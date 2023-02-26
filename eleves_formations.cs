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
    public partial class eleves_formations : UserControl
    {
        public static eleves_formations _instance;
        public static eleves_formations Instance
        {
            get
            {
                if (_instance == null) _instance = new eleves_formations();
                return _instance;
            }
        }
        public eleves_formations()
        {
            InitializeComponent();
            afficherLesEleves();
        }
    
        public void afficherLesEleves_Matiere(bool Clear, String MATIERE)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, formation_code, matieres FROM mes_eleves_forma where matieres LIKE \"%" + MATIERE + "%\"";
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
                    Variables.connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion");
            }

        }

        public void afficherLesEleves_Classe(bool Clear, String CLASSE)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, formation_code, matieres FROM mes_eleves_forma where formation_code = \"" + CLASSE + "\"";
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
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, formation_code, matieres FROM mes_eleves_forma where formation_code = \"" + CLASSE + "\" AND matieres LIKE \"%" + MATIERE + "%\"";
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
                Variables.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }
       
        public void afficherLesEleves()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                string commandtext = "SELECT nom, prenom, telephone, telephone_2, formation_code, matieres FROM mes_eleves_forma";
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
                    telephone_s = "0" + telephone.ToString();
                    telephone_2 = reader.GetInt32(3);
                    telephone_s2 = telephone_2.ToString();
                    classe = reader.GetString(4);
                    matieres = reader.GetString(5).Replace('_', ' ');
                    if (telephone_2 == 0) telephone_s2 = "-----------"; else telephone_s2 = "0" + telephone_s2;
                    DataView_MesEleves.Rows.Add(i,nom, prenom, telephone_s, telephone_s2, classe, matieres);
                    i++;

                }
                Variables.connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur");
            }
        }

        public void DGV_header()
        {
            DataView_MesEleves.Rows.Clear();
        }

        public void resizeDGV()
        {
            DataView_MesEleves.Columns[DataView_MesEleves.Columns.Count - 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            UC_selectMatieres uC_SelectMatieres = new UC_selectMatieres(true);
            Mes_Eleves.Instance.Controls.Add(uC_SelectMatieres);
            uC_SelectMatieres.BringToFront();
            uC_SelectMatieres.Focus();
        }

        private void button_select_classes_Click(object sender, EventArgs e)
        {
            UC_Classes uC_Classes = new UC_Classes(true);
            Mes_Eleves.Instance.Controls.Add(uC_Classes);
            uC_Classes.BringToFront();
            uC_Classes.Focus();
        }

    

        private void button_suprrimer_eleve_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                int telephone = 0;
                string commandtext = "DELETE FROM mes_eleves_forma WHERE telephone = @tel ;";
                command.CommandText = commandtext;
                command.Parameters.AddWithValue("@tel", MySqlDbType.Int32);
                foreach (DataGridViewRow row in DataView_MesEleves.SelectedRows)
                {
                    telephone = int.Parse(row.Cells[2].Value.ToString());
                    try
                    {
                        command.Parameters["@tel"].Value = telephone;
                        command.ExecuteNonQuery();
                        DataView_MesEleves.Rows.Remove(row);
                    }
                    catch (Exception) { MessageBox.Show("error in deleting"); }
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }

        private void linkLabel_mes_eleves_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Mes_Eleves.Instance.BringToFront();
        }

        private void eleves_formations_Load(object sender, EventArgs e)
        {
            DataView_MesEleves.BorderStyle = BorderStyle.None;
            DataView_MesEleves.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(215, 255, 249);
            DataView_MesEleves.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataView_MesEleves.EnableHeadersVisualStyles = false;
            DataView_MesEleves.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataView_MesEleves.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 94, 106);
            DataView_MesEleves.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromName("InactiveBorder");
        }

        private void DataView_MesEleves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {

                DataGridViewRow row = DataView_MesEleves.Rows[e.RowIndex];
                String nom = row.Cells[1].Value.ToString();
                String prenom = row.Cells[2].Value.ToString();
                String telephone = row.Cells[3].Value.ToString();
                String telephone_2 = row.Cells[4].Value.ToString();
                String classe = row.Cells[5].Value.ToString();
                String matieres = row.Cells[6].Value.ToString().Replace(' ', '_');
                Modifier_eleve_formation edit = new Modifier_eleve_formation(nom, prenom, telephone, telephone_2, classe, matieres);
                Mes_Eleves.Instance.Controls.Add(edit);
                edit.BringToFront();
                edit.Focus();
            }
            else
            {
                if (e.ColumnIndex == 8)
                {
                    try
                    {
                        MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        int telephone = 0;
                        string commandtext = "DELETE FROM mes_eleves_forma WHERE telephone = @tel ;";
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

                        connection.Close();
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
                            if (j == 3)
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