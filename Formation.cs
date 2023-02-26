using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Formation
    {
        private static int id = 0;
        public String code { get; set; }
        public List<String> Matieres = new List<string>();
        public static int nb_matieres { get; set; }
        public Formation(String i1, List<String> i2)
        {
            this.code = i1;
            this.Matieres = i2;
            id++;
        }

        public Formation()
        {
            id++;
        }
        public Formation(string code)
        {
            id++;
            this.code = code;
        }


        public static List<Formation> FormationData = new List<Formation>();
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
                        if (!Variables.matieres_formation.Contains(mot)) Variables.matieres_formation.Add(mot);
                        mot = null;
                    }
                }
                else break;
            }
            tableau.Add(mot);
            return tableau;
        }

        public static void creerLesFormations()
        {
            nb_matieres = 0;
            Formation.FormationData.Clear();
            MySqlCommand command = Variables.connectToDataBase();

            try
            {
                command.CommandText = "USE `base_cs`";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * FROM mes_formations";
                MySqlDataReader reader = command.ExecuteReader();
                Formation uneformation = null;
                while (reader.Read())
                {

                    uneformation = new Formation(reader.GetString(0), decipherMateires(reader.GetString(1), '_'));
                    FormationData.Add(uneformation);

                }


                Variables.connection.Close();
            }
            catch (Exception)
            {
                int i = 0;
                i++;
            }

        }
        public static Formation getFormation(String formation_code)
        {
            foreach (Formation formation in FormationData)
            {
                if (formation_code.Equals(formation.code))
                {
                    return formation;
                }

            }
            return null;
        }
    }
}
