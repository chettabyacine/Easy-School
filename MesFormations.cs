using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MesFormations : UserControl
    {
        public static Boolean openAccueil = false;
        public static MesFormations _instance;
        public static MesFormations Instance
        {
            get
            {
                if (_instance == null) _instance = new MesFormations();
                return _instance;
            }
        }
        public MesFormations()
        {
            InitializeComponent();
            dataview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41,94,106);
            setDGV();
            afficher_les_classes();
        }

        public void setDGV()
        {
            dataview.Rows.Clear();
        }

        public void afficher_les_classes()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM mes_formations";
                MySqlDataReader reader = null;
                try
                {
                    reader = command.ExecuteReader();
                    setDGV();
                    int i = 1;
                    while (reader.Read())
                    {
                        dataview.Rows.Add(i, reader.GetString(0), reader.GetString(1).Replace('_', ' '));
                        i++;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de connexion");
                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }

        }



        

        private void MesClasses_DoubleClick(object sender, EventArgs e)
        {
            afficher_les_classes();
        }

        private void MesFormations_Load(object sender, EventArgs e)
        {
            dataview.BorderStyle = BorderStyle.None;
            dataview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215, 255, 249);
            dataview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataview.EnableHeadersVisualStyles = false;
            dataview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 94, 106);
            dataview.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromName("InactiveBorder");
        }
    }
}
