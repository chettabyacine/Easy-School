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
    public partial class MesClasses : UserControl
    {
        public static Boolean openAccueil = false;
        public static MesClasses _instance;
        public static MesClasses Instance
        {
            get
            {
                if (MesClasses._instance == null) MesClasses._instance = new MesClasses();
                return MesClasses._instance;
            }
        }
        public MesClasses()
        {
            InitializeComponent();
            dataview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                command.CommandText = "SELECT * FROM mes_classes";
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



        private void MesClasses_Load(object sender, EventArgs e)
        {
            dataview.BorderStyle = BorderStyle.None;
            dataview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215, 255, 249);
            dataview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataview.EnableHeadersVisualStyles = false;
            dataview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 94, 106);
            dataview.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromName("InactiveBorder");
        }

        private void MesClasses_DoubleClick(object sender, EventArgs e)
        {
            afficher_les_classes();
        }
    }
}