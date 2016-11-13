using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMago
{
    public class Conjugador : VerbUser
    {
        private List<string> infinitives = null;

        Font verbHeaderFont = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Font moodFont       = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Font tenseFont      = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Font pronounFont    = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
        Font verbFont       = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

        public Conjugador(string dbFile) : base(dbFile)
        {
        }

        public List<string> GetVerbList(string content)
        {
            if (infinitives == null)
            {
                SQLiteConnection dbConnection = new SQLiteConnection($"Data Source={DBFile};Version=3;");
                dbConnection.Open();
                SQLiteCommand cmd = dbConnection.CreateCommand();

                cmd.CommandText = $"select infinitive from infinitive";

                infinitives = new List<string>();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        infinitives.Add(reader.GetString(0));
                    }
                }
            }

            if (content.Equals(String.Empty))
            {
                return infinitives;
            }

            List<string> result = new List<string>();

            foreach (var inf in infinitives)
            {
                if (inf.Contains(content))
                {
                    result.Add(inf);
                }
            }

            return result;
        }

        public void GetConjugatedRTF(RichTextBox tb, string verb, string mood, string tense)
        {
            SQLiteConnection dbConnection = new SQLiteConnection($"Data Source={DBFile};Version=3;");
            dbConnection.Open();
            SQLiteCommand cmd = dbConnection.CreateCommand();         

            tb.SelectionFont = verbHeaderFont;
            tb.AppendText(verb.ToUpper() + Environment.NewLine);             

            foreach (var m in MoodStrings)
            {
                if (!m.Value.Equals("Todo") && (m.Value.StartsWith(mood) || mood.Equals("Todo")))
                {
                    tb.SelectionFont = moodFont;
                    tb.SelectionBackColor = System.Drawing.Color.LightGray;
                    tb.AppendText(m.Value + @"                                                       " + Environment.NewLine);
                    foreach (var t in TenseStrings)
                    {
                        if (!t.Value.Equals("Todo") && (t.Value.Equals(tense) || tense.Equals("Todo")))
                        {                           
                            cmd.CommandText = $"select * from verbs where infinitive = '{verb}' and mood like '{m.Value}%' and tense = '{t.Value}'";

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    tb.SelectionFont = tenseFont;
                                    tb.AppendText(t.Value + Environment.NewLine);
                                    AppendConjugatedVerb(tb, EVerbField.form_1s, reader);
                                    AppendConjugatedVerb(tb, EVerbField.form_2s, reader);
                                    AppendConjugatedVerb(tb, EVerbField.form_3s, reader);
                                    AppendConjugatedVerb(tb, EVerbField.form_1p, reader);
                                    AppendConjugatedVerb(tb, EVerbField.form_2p, reader);
                                    AppendConjugatedVerb(tb, EVerbField.form_3p, reader);
                                }
                            }

                        }
                    }
                    
                }
            }
            // past participle
            cmd.CommandText = $"select pastparticiple from pastparticiple where infinitive = '{verb}'";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tb.SelectionFont = moodFont;
                    tb.SelectionBackColor = System.Drawing.Color.LightGray;
                    tb.AppendText("Participio                                                       " + Environment.NewLine);

                    tb.SelectionFont = verbFont;
                    tb.SelectionColor = Color.CadetBlue;
                    tb.AppendText(reader.GetString(0) + Environment.NewLine);
                }
            }

            // gerund
            cmd.CommandText = $"select gerund from gerund where infinitive = '{verb}'";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tb.SelectionFont = moodFont;
                    tb.SelectionBackColor = System.Drawing.Color.LightGray;
                    tb.AppendText("Gerundio                                                       " + Environment.NewLine);

                    tb.SelectionFont = verbFont;
                    tb.SelectionColor = Color.CadetBlue;
                    tb.AppendText(reader.GetString(0) + Environment.NewLine);
                }
            }
        }

        void AppendConjugatedVerb(RichTextBox rtb, EVerbField verbField, SQLiteDataReader reader)
        {
            rtb.SelectionFont = pronounFont;
            rtb.SelectionColor = Color.Black;
            rtb.AppendText($"({GetPronoun(verbField)}) ");
            rtb.SelectionFont = verbFont;
            rtb.SelectionColor = Color.CadetBlue;
            rtb.AppendText(reader.GetString((int)verbField) + Environment.NewLine);
        }

        string GetPronoun(EVerbField field)
        {
            switch (field)
            {
                case EVerbField.form_1s: return "yo";
                case EVerbField.form_2s: return "tú";
                case EVerbField.form_3s: return "él";
                case EVerbField.form_1p: return "ns";
                case EVerbField.form_2p: return "vs";
                case EVerbField.form_3p: return "ellos";
                default: return "";
            }
        }
    }
}
