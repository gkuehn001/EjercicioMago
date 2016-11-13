using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMago
{
    public class VerbUser
    {
        public enum EMood
        {
            Indicativo,
            Subjuntivo,
            ImperativoAfirmado,
            ImperativoNegativo,

            Todo
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
            PreteritoAnterior,
            CondictionalPerfecto,

            Todo
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

        protected string DBFile { get; set; }

        public virtual Dictionary<EMood, string> MoodStrings { get; set; }
        public virtual Dictionary<ETense, string> TenseStrings { get; set; }

        public static List<string> ReflexivePronouns = new List<string>();
        public static List<string> PersonalPronouns = new List<string>();

        public VerbUser(string dbFile)
        {
            DBFile = dbFile;

            MoodStrings = new Dictionary<EMood, string>();
            MoodStrings.Add(EMood.Todo, "Todo");
            MoodStrings.Add(EMood.Indicativo, "Indicativo");
            MoodStrings.Add(EMood.Subjuntivo, "Subjuntivo");
            MoodStrings.Add(EMood.ImperativoAfirmado, "Imperativo Afirmativo");
            MoodStrings.Add(EMood.ImperativoNegativo, "Imperativo Negativo");

            TenseStrings = new Dictionary<ETense, string>();
            TenseStrings.Add(ETense.Todo, "Todo");
            TenseStrings.Add(ETense.Presente, "Presente");
            TenseStrings.Add(ETense.Futuro, "Futuro");
            TenseStrings.Add(ETense.Imperfecto, "Imperfecto");
            TenseStrings.Add(ETense.Preterito, "Pretérito");
            TenseStrings.Add(ETense.Condicional, "Condicional");
            TenseStrings.Add(ETense.PresentePerfecto, "Presente perfecto");
            TenseStrings.Add(ETense.FuturoPerfecto, "Futuro perfecto");
            TenseStrings.Add(ETense.Pluscuamperfecto, "Pluscuamperfecto");
            TenseStrings.Add(ETense.PreteritoAnterior, "Pretérito anterior");
            TenseStrings.Add(ETense.CondictionalPerfecto, "Condicional perfecto");

            ReflexivePronouns.Add("me");
            ReflexivePronouns.Add("te");
            ReflexivePronouns.Add("se");
            ReflexivePronouns.Add("nos");
            ReflexivePronouns.Add("os");
                
            PersonalPronouns.Add("yo");
            PersonalPronouns.Add("tú");
            PersonalPronouns.Add("èl");
            PersonalPronouns.Add("ns");
            PersonalPronouns.Add("vs");
            PersonalPronouns.Add("ellos");


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
    }
}
