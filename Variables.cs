using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Variables
    {
        public const String database_name = "base_cs";
        public const String server = "127.0.0.1";
        public const String user_name = "root";
        public const String password = "Yacine_chettab22";
        public static String connectionString = "server="+server+";user id="+user_name+";password="+password+";persistsecurityinfo=True;database="+database_name;
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static  String identificateur = "easyschool";
        public static  String motdepasse = "0549909303";
        public static String mdps_vider = "racim2020";
        public static HashSet<String> matieres = new HashSet<string>();
        public static HashSet<String> matieres_formation = new HashSet<string>();
        public static List<String> matieresArechercher = new List<string>();
        public static List<String> classesArechercher = new List<String>();
        public static int input_lengh_small = 299;
        public static int input_lengh_big = 400;
        public static int button_lengh_small = 330;
        public static int button_lengh_big = 330;


        public static MySqlCommand connectToDataBase()
        {
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                return command;
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show("Erreur dans la connexion à la base de données");
                return null;
            }
            
        }
        

        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control content)
        {
            try
            {
                if (!content.Contains(control)) content.Controls.Add(control);
                control.BringToFront();
                control.Focus();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Erreur");
            }
        }

        

    }
}
