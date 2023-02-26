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
    public partial class Modifier_eleve_formation : UserControl
    {
        int telephone_n = 0;
        public Modifier_eleve_formation(String nom, String prenom, String telephone, String telephone_2, String classe_code, String matieres)
        {
            InitializeComponent();
            try
            {
                this.Visible = true;
                textBox1.Text = nom;
                textBox7.Text = prenom;
                textBox3.Text = telephone;
                telephone_n = int.Parse(telephone);
                textBox2.Text = telephone_2;
            } catch (Exception) { int khra = 0; }

            Formation eleve_formation = new Formation();
            comboBox1.Items.Clear();
            foreach (Formation formation in Formation.FormationData)
            {
                if (formation != null)
                {
                    comboBox1.Items.Add(formation.code);
                    if (formation.code.Equals(classe_code))
                    {
                        comboBox1.SelectedItem = classe_code;
                        eleve_formation = formation;
                    }
                }
            }
            List<String> matiere_eleve = Classe.decipherMateires(matieres, '_');
            int i = 0;
            checkedListBox_matieres.Items.Clear();
            foreach (String variable in eleve_formation.Matieres)
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

            //button1.PerformClick();
        }




        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            eleves_formations.Instance.BringToFront();
        }

        private void button_click ()
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
                        if ((telephone_2 > 799999999)) { panel1.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                    }
                    catch (Exception)
                    {
                        textBox2.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }




                String formation = null;
                try
                {
                    formation = comboBox1.SelectedItem.ToString();
                    //MessageBox.Show(formation);
                    if (formation.Equals("")) { error = true; comboBox1.ForeColor = Color.FromArgb(255, 0, 0); }
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
                    command.Parameters.Add("@formation_code", MySqlDbType.VarChar);
                    command.Parameters["@formation_code"].Value = formation;
                    command.Parameters.Add("@matieres", MySqlDbType.VarChar);
                    command.Parameters["@matieres"].Value = matieres;
                    command.Parameters.Add("@telephone_n", MySqlDbType.Int32);
                    command.Parameters["@telephone_n"].Value = telephone_n;
                    command.CommandText = "UPDATE mes_eleves_forma SET nom = @nom, prenom = @prenom , telephone = @telephone, telephone_2 = @telephone_2, formation_code = @formation_code, matieres = @matieres WHERE telephone = @telephone_n ;";
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
                eleves_formations.Instance.BringToFront();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button_click();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                checkedListBox_matieres.Items.Clear();
                String selectedcode = comboBox1.SelectedItem.ToString();
                foreach (Formation formation in Formation.FormationData)
                {
                    if (selectedcode.Equals(formation.code))
                    {
                        for (int i = 0; i < formation.Matieres.Count(); i++)
                        {
                            if (formation.Matieres.ElementAt(i) != null)
                                checkedListBox_matieres.Items.Add(formation.Matieres.ElementAt(i));
                        }

                        break;
                    }
                }
            } catch (Exception)
            {
                int khra = 0;
            }
        }

        private void resetcolors()
        {
            panel7.ForeColor = Color.FromArgb(41, 94, 106);
            panel1.ForeColor = Color.FromArgb(41, 94, 106);
            panel2.ForeColor = Color.FromArgb(41, 94, 106);
            panel6.ForeColor = Color.FromArgb(41, 94, 106);
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
