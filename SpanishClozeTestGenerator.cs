﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjercicioMago
{
    public class SpanishClozeTestGenerator
    {
        public enum EMood
        {
            Indicativo,
            Subjuntivo,
            Imperativo
        }

        public enum ETense
        {
            Presente,
            Futuro,
            Imperfecto,
            Preterito,
            Condicional,
            PresentePerfecto,
            FuturoPerfecto,
            Pluscuamperfecto,
            PreteritoAnterior
        }

        public enum EVerbField
        {
            infinitive,
            mood,
            tense,
            verb_english,
            form_1s,
            form_2s,
            form_3s,
            form_1p,
            form_2p,
            form_3p
        }

        public Dictionary<EMood, string> MoodStrings { get; private set; }
        public Dictionary<ETense, string> TenseStrings { get; private set; }

        private string DBFile { get; set; }

        public SpanishClozeTestGenerator(string dbFile)
        {
            DBFile = dbFile;

            MoodStrings = new Dictionary<EMood, string>();
            MoodStrings.Add(EMood.Indicativo, "Indicativo");
            MoodStrings.Add(EMood.Subjuntivo, "Subjuntivo");
            MoodStrings.Add(EMood.Imperativo, "Imperativo");

            TenseStrings = new Dictionary<ETense, string>();
            TenseStrings.Add(ETense.Presente, "Presente");
            TenseStrings.Add(ETense.Futuro, "Futuro");
            TenseStrings.Add(ETense.Imperfecto, "Imperfecto");
            TenseStrings.Add(ETense.Preterito, "Pretérito");
            TenseStrings.Add(ETense.Condicional, "Condicional");
            TenseStrings.Add(ETense.PresentePerfecto, "Presente perfecto");
            TenseStrings.Add(ETense.FuturoPerfecto, "Futuro perfecto");
            TenseStrings.Add(ETense.Pluscuamperfecto, "Pluscuamperfecto");
            TenseStrings.Add(ETense.PreteritoAnterior, "Pretérito anterior");
        }

        public static void CreateDBFromSQL(string sqlFile, string targetDBFile)
        {       
            SQLiteConnection dbConnection = new SQLiteConnection($"Data Source={targetDBFile};Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();
            cmd.CommandText = System.IO.File.ReadAllText(sqlFile);
            Console.WriteLine("Filling DB ...");
            cmd.ExecuteNonQuery();
            Console.WriteLine("DB created.");
        }

        public Dictionary<string, string> GetConjugatedToInfinitive(string mood, string tense, ref string report)
        {
            var result = new Dictionary<string, string>();

            SQLiteConnection dbConnection = new SQLiteConnection($"Data Source={DBFile};Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();

            cmd.CommandText = $"select * from verbs where mood = '{mood}' and tense = '{tense}'";

            Dictionary<string, string> ambigousVerbs = new Dictionary<string, string>();
            List<string> missingForms = new List<string>();

            StringBuilder sb = new StringBuilder();

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string infinitive = reader.GetString((int)EVerbField.infinitive).ToLower();
                    for (int i = (int)EVerbField.form_1s; i <= (int)EVerbField.form_3p; i++)
                    {
                        string form = reader.GetString(i).ToLower();
                        if (!form.Equals(""))
                        {
                            if (result.ContainsKey(form))
                            {
                                result[form] = $"{result[form]}:{infinitive}";
                                ambigousVerbs.Add(form, result[form]);
                            }
                            else
                            {
                                result.Add(form, infinitive);
                            }
                        }
                        else
                        {
                            missingForms.Add($"{infinitive}:{i}");
                        }
                    }
                }
            }

            if (report != null)
            {
                sb.AppendLine($"Found {result.Count} forms.");
                if (ambigousVerbs.Count > 0)
                {
                    sb.AppendLine($"Found {ambigousVerbs.Count} ambigous forms.");
                    foreach (var af in ambigousVerbs)
                    {
                        sb.AppendLine($"   {af.Key} | {af.Value}");
                    }
                }
                if (missingForms.Count > 0)
                {
                    sb.AppendLine($"Found {missingForms.Count} missing forms.");
                    foreach (var mf in missingForms)
                    {
                        sb.AppendLine($"   {mf}");
                    }
                }
                report = sb.ToString();
            }


            return result;
        }

        public string CreateClozeFromFile(string fileName, EMood mood, ETense tense)
        {
            string text = System.IO.File.ReadAllText(fileName, Encoding.Default);
            return CreateClozeFromText(text, mood, tense, true, 2.0);
        }

        public string CreateClozeFromText(string text, EMood mood, ETense tense, bool showInfinitive, double spaceSize)
        {
            return CreateClozeFromText(text, MoodStrings[mood], TenseStrings[tense], showInfinitive, spaceSize);
        }

        public string CreateClozeFromText(string text, string mood, string tense, bool showInfinitive, double spaceSize)
        {
            string report = null;
            var forms = GetConjugatedToInfinitive(mood, tense, ref report);

            char[] splitter = GetSplitter();
            string[] words = text.Split(splitter);
            HashSet<string> foundForms = new HashSet<string>();
            var pronouns = GetPronouns();
            string word = String.Empty;
            foreach (string w in words)
            {
                if (w != string.Empty)
                {
                    if (word.Equals(String.Empty))
                    {
                        if (pronouns.Contains(w))
                        {
                            word = w;
                            continue;
                        }
                    }
                    else
                    {
                        word = $"{word} {w}";
                    }
                    if (forms.ContainsKey(word.ToLower()))
                    {
                        foundForms.Add(word);
                    }
                    else if (forms.ContainsKey(w.ToLower()))
                    {
                        foundForms.Add(w);
                    }
                    word = String.Empty;
                }
            }

            foreach (var w in foundForms)
            {
                string pattern = String.Format(@"\b{0}\b", w);
                string infinitive = showInfinitive ? $"({forms[w.ToLower()]})" : "";
                string wordReplace = (spaceSize > 0.0) ? new String('_', (int)((double)w.Length * spaceSize)) : w;
                string replace = $"{infinitive} {wordReplace}";
                text = Regex.Replace(text, pattern, replace);
            }

            return text;
        }

        private List<string> GetPronouns()
        {
            var pronouns = new List<string>();
            pronouns.Add("me");
            pronouns.Add("te");
            pronouns.Add("se");
            pronouns.Add("nos");
            pronouns.Add("os");
            return pronouns;
        }

        private char[] GetSplitter()
        {
            return new Char[] { ' ', ',', '.', '!', '¡', '?', '¿', '\'', '(', ')', '[', ']' };
        }

        public string CreateRTFClozeFromText(string text, string mood, string tense, bool showInfinitive, double spaceSize)
        {
            string report = null;

            if (mood == null || tense == null)
                return report;

            var forms = GetConjugatedToInfinitive(mood, tense, ref report);

            char[] splitter = GetSplitter();          

            string[] words = text.Split(splitter);
            HashSet<string> foundForms = new HashSet<string>();

            var pronouns = GetPronouns();
            string word = String.Empty;
            foreach (string w in words)
            {
                if (w != string.Empty)
                {
                    if (word.Equals(String.Empty))
                    {
                        if (pronouns.Contains(w))
                        {
                            word = w;
                            continue;
                        }
                    }
                    else
                    {
                        word = $"{word} {w}";
                    }
                    if (forms.ContainsKey(word.ToLower()))
                    {
                        foundForms.Add(word);
                    }
                    else if (forms.ContainsKey(w.ToLower()))
                    {
                        foundForms.Add(w);
                    }
                    word = String.Empty;
                }
            }

            foreach (var w in foundForms)
            {
                string pattern = String.Format(@"\b{0}\b", w);
                string infinitive = showInfinitive ? $"({forms[w.ToLower()]}) " : "";

                //if (infinitive.Contains(":"))
                //{
                //    infinitive = String.Format(@"\b{0}\b0", infinitive);
                //}

                string wordReplace = (spaceSize > 0.0) ? new String('_', (int)((double)w.Length * spaceSize)) : w;
                string replace = $"{infinitive}{wordReplace}";
                var m = Regex.Matches(text, pattern);
                text = Regex.Replace(text, pattern, replace);
            }

            text = text.Replace(Environment.NewLine, @"\par ");

            return String.Format(@"{{\rtf1\ansi {0}}}", text);
        }
    }
}
