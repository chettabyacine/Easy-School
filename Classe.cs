using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Classe
    {
      
        private static int id = 0;
        public String code { get; set; }
        public List<String> Matieres = new List<string>();
        public static int nb_matieres { get; set; }
        public Classe(String i1, List<String> i2)
        {
            this.code = i1;
            this.Matieres = i2;
            id++;
        }

        public Classe()
        {
            id++;
        }
        public Classe(string code)
        {
            id++;
            this.code = code;
        }


        public static List<Classe> classesData = new List<Classe>();
        public static List<String> decipherMateires(String data, char seperator)
        {
            List<String> tableau = new List<string>();
            String mot = null;
            int i = 0;
            foreach (char c in data)
            {
                if (c != '\0')
                {
                    if (c != seperator)
                    {
                        mot += c;
                    }
                    else
                    {
                        tableau.Add(mot);
                        if (!Variables.matieres.Contains(mot)) Variables.matieres.Add(mot);
                        mot = null;
                    }
                }
                else break;
            }
            tableau.Add(mot);
            return tableau;
        }

        public static void creerLesClasses()
        {
            nb_matieres = 0;
            Classe.classesData.Clear();
            MySqlCommand command =  Variables.connectToDataBase();

            try
            {
                command.CommandText = "USE `base_cs`";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * FROM mes_classes";
                MySqlDataReader reader = command.ExecuteReader();
                Classe uneclasse = null;
                while (reader.Read())
                {

                    uneclasse = new Classe(reader.GetString(0), decipherMateires(reader.GetString(1), '_'));
                    classesData.Add(uneclasse);

                }


                Variables.connection.Close();
            }
            catch (Exception)
            {
                int i = 0;
                i++;
            }

        }
        public static Classe getClasse(String classe_code)
        {
            foreach(Classe classe in classesData)
            {
                if (classe_code.Equals(classe.code))
                {
                    return classe;
                }
               
            }
            return null;
        }


      
    }
}
        




