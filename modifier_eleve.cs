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
    public partial class modifier_eleve : UserControl
    {
        int telephone_n = 0;
        public modifier_eleve(String nom, String prenom, String telephone, String telephone_2, String classe_code, String matieres)
        {
            InitializeComponent();
            textBox1.Text = nom;
            textBox7.Text = prenom;
            textBox3.Text = telephone;
            telephone_n = int.Parse(telephone);
            textBox2.Text = telephone_2;

            Classe eleve_classe = new Classe();
            comboBox1.Items.Clear();
            foreach(Classe classe in Classe.classesData)
            {
                if(classe!=null)
                {
                    comboBox1.Items.Add(classe.code);
                    if (classe.code.Equals(classe_code))
                    {
                        comboBox1.SelectedItem = classe_code;
                        eleve_classe = classe;
                    }
                }
            }
            List<String> matiere_eleve = Classe.decipherMateires(matieres, '_');
            checkedListBox_matieres.Items.Clear();
            int i = 0;
            foreach(String variable in eleve_classe.Matieres)
            {
                if (variable != null)
                {
                    checkedListBox_matieres.Items.Add(variable);
                    if (matiere_eleve.Contains(variable))
                    {
                        i = checkedListBox_matieres.Items.IndexOf(variable);
                        checkedListBox_matieres.SetItemCheckState(i, CheckState.Checked); 
                    }
                }

            }
                
        }
    


    
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mes_Eleves.Instance.BringToFront();
        }

 


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(Variables.connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                bool error = false;

                String nom = "";
                try
                {
                    nom = textBox1.Text.ToLower();
                    if (nom.Equals(""))
                    {
                        panel2.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }
                catch (Exception)
                {
                    panel2.BackColor = Color.FromArgb(255, 0, 0);
                    error = true;
                }


                String prenom = "";
                try
                {
                    prenom = textBox7.Text.ToLower();
                    if (prenom.Equals(""))
                    {
                        panel7.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }
                catch (Exception)
                {
                    panel7.BackColor = Color.FromArgb(255, 0, 0);
                    error = true;
                }


                int telephone = 0;
                try
                {
                    telephone = int.Parse(textBox3.Text);
                    if ((telephone < 500000000) || (telephone > 799999999)) { panel6.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                }
                catch (Exception)
                {
                    panel6.BackColor = Color.FromArgb(255, 0, 0);
                }

                int telephone_2 = 0;
                if (!textBox2.Text.Equals("-----------") && !textBox2.Text.Equals(""))
                {
                    try
                    {
                        telephone_2 = int.Parse(textBox2.Text);
                        if ((telephone_2 < 500000000) || (telephone_2 > 799999999) && (telephone_2 != 0)) { panel1.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                    }
                    catch (Exception)
                    {
                        textBox2.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }




                String classe = null;
                try
                {
                    classe = comboBox1.SelectedItem.ToString();
                    if (classe.Equals("")) { error = true; comboBox1.ForeColor = Color.FromArgb(255, 0, 0); }
                }
                catch (Exception) { comboBox1.ForeColor = Color.FromArgb(255, 0, 0); error = true; }



                String matieres = null;
                try
                {
                    foreach (object checkedMatiere in checkedListBox_matieres.CheckedItems)
                    {
                        matieres += checkedMatiere.ToString() + "_";
                    }

                    if (matieres.Equals("")) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }
                }
                catch (Exception) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }

                if (!error)
                {
                    command.Parameters.Add("@nom", MySqlDbType.VarChar);
                    command.Parameters["@nom"].Value = nom;
                    command.Parameters.Add("@prenom", MySqlDbType.VarChar);
                    command.Parameters["@prenom"].Value = prenom;
                    command.Parameters.Add("@telephone", MySqlDbType.Int32);
                    command.Parameters["@telephone"].Value = telephone;
                    command.Parameters.Add("@telephone_2", MySqlDbType.Int32);
                    command.Parameters["@telephone_2"].Value = telephone_2;
                    command.Parameters.Add("@classe_code", MySqlDbType.VarChar);
                    command.Parameters["@classe_code"].Value = classe;
                    command.Parameters.Add("@matieres", MySqlDbType.VarChar);
                    command.Parameters["@matieres"].Value = matieres;
                    command.Parameters.Add("@telephone_n", MySqlDbType.Int32);
                    command.Parameters["@telephone_n"].Value = telephone_n;
                    command.CommandText = "UPDATE mes_eleves SET nom = @nom, prenom = @prenom , telephone = @telephone, telephone_2 = @telephone_2, classe_code = @classe_code, matieres = @matieres WHERE telephone = @telephone_n ;";
                    try
                    {
                        command.ExecuteNonQuery();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("erreur");
                    }
                }
                connection.Close();
                this.Hide();
                Mes_Eleves.Instance.BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
            
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkedListBox_matieres.Items.Clear();
            String selectedcode = comboBox1.SelectedItem.ToString();
            foreach (Classe classe in Classe.classesData)
            {
                if (selectedcode.Equals(classe.code))
                {
                    for (int i = 0; i < classe.Matieres.Count(); i++)
                    {
                        if (classe.Matieres.ElementAt(i) != null)
                            checkedListBox_matieres.Items.Add(classe.Matieres.ElementAt(i));
                    }

                    break;
                }
            }
        }

        private void resetcolors()
        {
            panel7.ForeColor = Color.FromArgb(41,94,106);
            panel1.ForeColor = Color.FromArgb(41,94,106);
            panel2.ForeColor = Color.FromArgb(41,94,106);
            panel6.ForeColor = Color.FromArgb(41,94,106);
            comboBox1.ForeColor = Color.FromName("InactiveBorder");
            checkedListBox_matieres.ForeColor = Color.FromName("InactiveBorder");

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            resetcolors();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            resetcolors();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            resetcolors();

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            resetcolors();

        }
    }
}
