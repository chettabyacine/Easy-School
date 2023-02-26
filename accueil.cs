using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class accueil : UserControl
    {
        public static accueil _instance;
        public static accueil Instance
        {
            get
            {
                if (accueil._instance == null) accueil._instance = new accueil();
                return accueil._instance;
            }
        }

        public accueil()
        {
            InitializeComponent();
            
        }







        private void initialiser_bdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                command.Parameters.Add("nom", MySqlDbType.String);
                command.Parameters.Add("prenom", MySqlDbType.String);
                command.Parameters.Add("telephone", MySqlDbType.Int32);
                command.Parameters.Add("telephone_2", MySqlDbType.Int32);
                command.Parameters.Add("classe", MySqlDbType.String);
                command.Parameters.Add("matieres", MySqlDbType.String);

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel Files|*.xls;*.xlsx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = File.Open(open.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }
                            });
                            DataTableCollection tablecollection = result.Tables;

                            foreach (DataRow row in tablecollection[0].Rows)
                            {
                                command.Parameters["nom"].Value = row[0].ToString();
                                command.Parameters["prenom"].Value = row[1].ToString();
                                if (!row[2].ToString().Equals("") && row[2].ToString() != null)
                                    command.Parameters["telephone"].Value = int.Parse(row[2].ToString());
                                if (!row[3].ToString().Equals("") && row[3].ToString() != null)
                                    command.Parameters["telephone_2"].Value = int.Parse(row[3].ToString());
                                command.Parameters["classe"].Value = row[4].ToString();
                                command.Parameters["matieres"].Value = row[5].ToString().Replace(' ','_');
                                command.CommandText = "INSERT INTO mes_eleves (nom, prenom, telephone, telephone_2, classe_code, matieres) VALUES (@nom, @prenom, @telephone, @telephone_2, @classe, @matieres)";
                                command.ExecuteNonQuery();
                            }
                            reader.Close();
                            Variables.connection.Close();
                        }

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }

        private void initialiser_bdd_MouseEnter(object sender, EventArgs e)
        {
            initialiser_bdd.BackColor = Color.FromArgb(41, 94,106);
            initialiser_bdd.ForeColor = Color.FromName("InactiveBorder");
        }

        private void initialiser_bdd_MouseLeave(object sender, EventArgs e)
        {
            initialiser_bdd.ForeColor = Color.FromArgb(41, 94, 106);
            initialiser_bdd.BackColor = Color.FromName("InactiveBorder");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                command.Parameters.Add("nom", MySqlDbType.String);
                command.Parameters.Add("prenom", MySqlDbType.String);
                command.Parameters.Add("telephone", MySqlDbType.Int32);
                command.Parameters.Add("telephone_2", MySqlDbType.Int32);
                command.Parameters.Add("classe", MySqlDbType.String);
                command.Parameters.Add("matieres", MySqlDbType.String);

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Excel Files|*.xls;*.xlsx";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = File.Open(open.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }
                            });
                            DataTableCollection tablecollection = result.Tables;

                            foreach (DataRow row in tablecollection[0].Rows)
                            {
                                command.Parameters["nom"].Value = row[0].ToString();
                                command.Parameters["prenom"].Value = row[1].ToString();
                                if (!row[2].ToString().Equals("") && row[2].ToString() != null)
                                    command.Parameters["telephone"].Value = int.Parse(row[2].ToString());
                                if (!row[3].ToString().Equals("") && row[3].ToString() != null)
                                    command.Parameters["telephone_2"].Value = int.Parse(row[3].ToString());
                                command.Parameters["classe"].Value = row[4].ToString();
                                command.Parameters["matieres"].Value = row[5].ToString().Replace(' ','_');
                                command.CommandText = "INSERT INTO mes_eleves_forma (nom, prenom, telephone, telephone_2, formation_code, matieres) VALUES (@nom, @prenom, @telephone, @telephone_2, @classe, @matieres)";
                                command.ExecuteNonQuery();
                            }
                            reader.Close();
                            Variables.connection.Close();
                        }

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(41, 94, 106);
            button1.ForeColor = Color.FromName("InactiveBorder");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(41, 94, 106);
            button1.BackColor = Color.FromName("InactiveBorder");
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            //

        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            //useless
        }
    }
}
