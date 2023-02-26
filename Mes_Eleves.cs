using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using ExcelDataReader;
using Microsoft.SqlServer;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Mes_Eleves : UserControl
    {
        int NB_ELEVES=0;
        public static Mes_Eleves _instance;
        public static Mes_Eleves Instance
        {
            get
            {
                if (_instance == null) _instance = new Mes_Eleves();
                return _instance;
            }
        }

        public Mes_Eleves()
        {
            InitializeComponent();
            afficherLesEleves(); 

        }

      

        public void afficherLesEleves_Matiere(bool Clear, String MATIERE)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, classe_code, matieres FROM mes_eleves where matieres LIKE \"%" + MATIERE + "%\"";
                command.CommandText = commandtext;
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (Clear)
                    {
                        DGV_header();
                        resizeDGV();
                    }
                    String nom = null;
                    String prenom = null;
                    int telephone = 0;
                    String telephone_s = "";
                    int telephone_2 = 0;
                    String telephone_s2 = "";
                    String classe = null;
                    String matieres = null;
                    int i = 1;
                    while (reader.Read())
                    {
                        nom = reader.GetString(0);
                        prenom = reader.GetString(1);
                        telephone = reader.GetInt32(2);
                        telephone_s = "0" + telephone.ToString();
                        telephone_2 = reader.GetInt32(3);
                        telephone_s2 = telephone_2.ToString();
                        classe = reader.GetString(4);
                        matieres = reader.GetString(5).Replace('_', ' ');
                        if (telephone_2 == 0) telephone_s2 = "-----------"; else telephone_s2 = "0" + telephone_s2;
                        DataView_MesEleves.Rows.Add(i, nom, prenom, telephone_s, telephone_s2, classe, matieres);
                        i++;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de connexion");
                }


                Variables.connection.Close();
            } catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }

        public void afficherLesEleves_Classe(bool Clear, String CLASSE)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, classe_code, matieres FROM mes_eleves where classe_code = \"" + CLASSE + "\"";
                command.CommandText = commandtext;
                try
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    if (Clear)
                    {
                        DGV_header();
                        resizeDGV();
                    }
                    String nom = null;
                    String prenom = null;
                    int telephone = 0;
                    int telephone_2 = 0;
                    String telephone_s = "";
                    String telephone_s2 = "";
                    String classe = null;
                    String matieres = null;
                    int i = 1;
                    while (reader.Read())
                    {
                        nom = reader.GetString(0);
                        prenom = reader.GetString(1);
                        telephone = reader.GetInt32(2);
                        telephone_s = "0" + telephone.ToString();
                        telephone_2 = reader.GetInt32(3);
                        telephone_s2 = telephone_2.ToString();
                        classe = reader.GetString(4);
                        matieres = reader.GetString(5).Replace('_', ' ');
                        if (telephone_2 == 0) telephone_s2 = "-----------"; else telephone_s2 = "0" + telephone_s2;
                        DataView_MesEleves.Rows.Add(i, nom, prenom, telephone_s, telephone_s2, classe, matieres);
                        i++;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de connexion");
                }


                Variables.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }

        public void afficherEleves_Classes_Matieres(bool Clear, String CLASSE, String MATIERE)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, classe_code, matieres FROM mes_eleves where classe_code = \"" + CLASSE + "\" AND matieres LIKE \"%" + MATIERE + "%\"";
                command.CommandText = commandtext;
                MySqlDataReader reader = command.ExecuteReader();
                if (Clear)
                {
                    DGV_header();
                    resizeDGV();
                }
                String nom = null;
                String prenom = null;
                int telephone = 0;
                int telephone_2 = 0;
                String telephone_s = "";
                String telephone_s2 = "";
                String classe = null;
                String matieres = null;
                int i = 1;
                while (reader.Read())
                {
                    nom = reader.GetString(0);
                    prenom = reader.GetString(1);
                    telephone = reader.GetInt32(2);
                    telephone_s = "0" + telephone.ToString();
                    telephone_2 = reader.GetInt32(3);
                    telephone_s2 = telephone_2.ToString();
                    classe = reader.GetString(4);
                    matieres = reader.GetString(5).Replace('_', ' ');
                    if (telephone_2 == 0) telephone_s2 = "-----------"; else telephone_s2 = "0" + telephone_s2;
                    DataView_MesEleves.Rows.Add(i,nom, prenom, telephone_s, telephone_s2, classe, matieres);
                    i++;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion");
            }


            Variables.connection.Close();
        }

        public void afficherLesEleves()
        {
            try 
            {
                MySqlCommand command = Variables.connectToDataBase();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, classe_code, matieres FROM mes_eleves";
                command.CommandText = commandtext;
                MySqlDataReader reader = command.ExecuteReader();
                DGV_header();
                resizeDGV();

                String nom = null;
                String prenom = null;
                int telephone = 0;
                String telephone_s = "";
                String telephone_s2 = "";
                int telephone_2 = 0;
                String classe = null;
                String matieres = null;
                int i = 1;
                while (reader.Read())
                {
                    nom = reader.GetString(0);
                    prenom = reader.GetString(1);
                    telephone = reader.GetInt32(2);
                    telephone_s = "0"+ telephone.ToString();
                    telephone_2 = reader.GetInt32(3);
                    telephone_s2 = telephone_2.ToString();
                    classe = reader.GetString(4);
                    matieres = reader.GetString(5).Replace('_', ' ');
                    if (telephone_2 == 0)
                    {
                        telephone_s2 = "-----------";
                    }
                    else
                    {
                        telephone_s2 = "0" + telephone_s2;
                    }
                    DataView_MesEleves.Rows.Add(i,nom, prenom, telephone_s,telephone_s2, classe, matieres);

                    i++;
                }
                NB_ELEVES = i-1;
                Variables.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur dans la connexion");
            }



            

        }

        public void DGV_header()
        {
            DataView_MesEleves.Rows.Clear();
        }

        public void resizeDGV()
        {
            
            DataView_MesEleves.Columns[0].Width= 40;
            DataView_MesEleves.Columns[1].Width = 100;
            DataView_MesEleves.Columns[2].Width = 100;
            DataView_MesEleves.Columns[3].Width = 90;
            DataView_MesEleves.Columns[4].Width = 90;
            DataView_MesEleves.Columns[5].Width = 50;
            DataView_MesEleves.Columns[7].Width = 26;
            DataView_MesEleves.Columns[8].Width = 26;
            DataView_MesEleves.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGV_header();
            if (Variables.matieresArechercher.Count() > 0)
            {
                if (Variables.classesArechercher.Count() > 0)
                {
                    foreach (String CLASSE in Variables.classesArechercher)
                    {

                        foreach (String MATIERE in Variables.matieresArechercher)
                        {
                            afficherEleves_Classes_Matieres(false, CLASSE, MATIERE);
                        }
                    }
                }
                else
                {
                    foreach (String MATIERE in Variables.matieresArechercher)
                    {
                        afficherLesEleves_Matiere(false, MATIERE);
                    }
                }
            }
            else
            {
                if (Variables.classesArechercher.Count() > 0)
                {
                    foreach (String CLASSE in Variables.classesArechercher)
                    {
                        afficherLesEleves_Classe(false, CLASSE);
                    }
                }
                else
                {
                    afficherLesEleves();
                }
            }
            
                Variables.matieresArechercher.Clear();
                Variables.classesArechercher.Clear();
        }

        private void button_select_matieres_Click(object sender, EventArgs e)
        {
            UC_selectMatieres uC_SelectMatieres = new UC_selectMatieres(false);
            Mes_Eleves.Instance.Controls.Add(uC_SelectMatieres);
            uC_SelectMatieres.BringToFront();
            uC_SelectMatieres.Focus();
        }

        private void button_select_classes_Click(object sender, EventArgs e)
        {
            UC_Classes uC_Classes = new UC_Classes(false);
            Mes_Eleves.Instance.Controls.Add(uC_Classes);
            uC_Classes.BringToFront();
            uC_Classes.Focus();
        }



        private void linkLabel_les_eleves_formations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            eleves_formations formation = new eleves_formations();
            Mes_Eleves.Instance.Controls.Add(formation);
            formation.BringToFront();
            formation.Dock = DockStyle.Fill;
            formation.Focus();
        }


        private void Mes_Eleves_Load(object sender, EventArgs e)
        {
            DataView_MesEleves.BorderStyle = BorderStyle.None;
            DataView_MesEleves.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215,255,249);
            DataView_MesEleves.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataView_MesEleves.EnableHeadersVisualStyles = false;
            DataView_MesEleves.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataView_MesEleves.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 94, 106);
            DataView_MesEleves.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromName("InactiveBorder");
        }

        private void DataView_MesEleves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                DataGridViewRow row = DataView_MesEleves.Rows[e.RowIndex];
                String nom = row.Cells[1].Value.ToString();
                String prenom = row.Cells[2].Value.ToString();
                String telephone = row.Cells[3].Value.ToString();
                String telephone_2 = row.Cells[4].Value.ToString();
                String classe = row.Cells[5].Value.ToString();
                String matiere = row.Cells[6].Value.ToString().Replace(' ','_');
                modifier_eleve a = new modifier_eleve(nom, prenom, telephone, telephone_2, classe, matiere);
                Instance.Controls.Add(a);
                a.BringToFront();
                a.Focus();

            }
            else
            {
                if(e.ColumnIndex == 8)
                {
                    try
                    {
                        MySqlCommand command = Variables.connectToDataBase();
                        int telephone = 0;
                        string commandtext = "DELETE FROM mes_eleves WHERE telephone = @tel ;";
                        command.CommandText = commandtext;
                        command.Parameters.AddWithValue("@tel", MySqlDbType.Int32);
                        DataGridViewRow row = DataView_MesEleves.Rows[e.RowIndex];
                        try
                        {
                            telephone = int.Parse(row.Cells[3].Value.ToString());
                            command.Parameters["@tel"].Value = telephone;
                            command.ExecuteNonQuery();
                            DataView_MesEleves.Rows.Remove(row);
                        }
                        catch (Exception) { MessageBox.Show("error in deleting"); }

                        Variables.connection.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (DataView_MesEleves.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    app.Application.Workbooks.Add(Type.Missing);
                    for (int i = 2; i < DataView_MesEleves.Columns.Count + 1; i++)
                    {
                        app.Cells[1, i - 1] = DataView_MesEleves.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < DataView_MesEleves.Rows.Count; i++)
                    {
                        for (int j = 1; j < DataView_MesEleves.Columns.Count - 2; j++)
                        {
                            if (j==3)
                            {
                                app.Cells[i + 2, j] = DataView_MesEleves.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                if (DataView_MesEleves.Rows[i].Cells[j].Value.ToString().Equals("-----------"))
                                    app.Cells[i + 2, j] = "0";
                                else
                                {
                                    app.Cells[i + 2, j] = DataView_MesEleves.Rows[i].Cells[j].Value.ToString();
                                }
                            }
                        }
                    }
                    app.Columns.AutoFit();
                    app.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur");
                }
            }
        }
    }
}
