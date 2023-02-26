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
    public partial class inscription_formation : UserControl
    {
        public static bool Big = false;
        public static inscription_formation _instance;
        public static inscription_formation Instance
        {
            get
            {
                if (_instance == null) _instance = new inscription_formation();
                return _instance;
            }
        }
        
        public inscription_formation()
        {
            InitializeComponent();
            type_etudiant.Items.Add("Scolarisé");
            type_etudiant.Items.Add("Adulte");
            check_initialise_scolarise();
            comboBox_classe.Visible = false;
            input_nom.Focus();

        }

        private void check_initialise_scolarise()
        {
            comboBox_classe.Items.Clear();
            comboBox_classe.Items.Add("1AP");
            comboBox_classe.Items.Add("2AP");
            comboBox_classe.Items.Add("3AP");
            comboBox_classe.Items.Add("4AP");
            comboBox_classe.Items.Add("5AP");
            comboBox_classe.Items.Add("1AM");
            comboBox_classe.Items.Add("2AM");
            comboBox_classe.Items.Add("3AM");
            comboBox_classe.Items.Add("4AM");
        }

        private void check_initialise_adulte()
        {
            comboBox_classe.Visible = false;
            checkedListBox_matieres.Visible = true;
        }

        private void inscription_formation_Load(object sender, EventArgs e)
        {
            inscription_formation.Instance.Dock = DockStyle.Fill;
        }

        private void button_inscrire_Click(object sender, EventArgs e)
        {
            
        }

        private void resetColor()
        {
            label_error.Visible = false;
            panel1.BackColor = Color.FromArgb(41, 94, 106);
            panel2.BackColor = Color.FromArgb(41, 94, 106);
            panel3.BackColor = Color.FromArgb(41, 94, 106);
            panel_2eme_telephone.BackColor = Color.FromArgb(41, 94, 106);
            button_inscrire.BackColor = Color.FromArgb(41, 94, 106);
            comboBox_classe.ForeColor = Color.Black;
            type_etudiant.BackColor = Color.FromName("InactiveBorder");
            type_etudiant.ForeColor = Color.FromArgb(41, 94, 106);
            checkedListBox_matieres.ForeColor = Color.Black;
        }

        private void input_nom_Click(object sender, EventArgs e)
        {
            input_nom.Clear();
            resetColor();
        }

        private void input_prenom_Click(object sender, EventArgs e)
        {
            input_prenom.Clear();
            resetColor();

        }

        private void inpit_numero_Click(object sender, EventArgs e)
        {
            inpit_numero.Clear();
            resetColor();

        }

        private void comboBox_classe_Click(object sender, EventArgs e)
        {
            resetColor();
        }

        private void checkedListBox_matieres_Click(object sender, EventArgs e)
        {
            resetColor();
        }

        private void comboBox_classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetColor();
        }

        private void checkedListBox_matieres_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            resetColor();
        }

        private void Nouveau_Eleve_Click(object sender, EventArgs e)
        {
            resetColor();
        }

        private void type_etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                resetColor();
                comboBox_classe.Visible = true;
                if (!type_etudiant.SelectedItem.ToString().Equals("Adulte"))
                {
                    check_initialise_scolarise();

                }
                else
                {
                    comboBox_classe.Visible = false;
                    checkedListBox_matieres.Items.Clear();
                    String formation = "ADULTE";
                    foreach (Formation forma in Formation.FormationData)
                    {
                        if (forma.code.Equals(formation))
                        {
                            for (int i = 0; i < forma.Matieres.Count(); i++)
                            {
                                if (forma.Matieres.ElementAt(i) != null)
                                    checkedListBox_matieres.Items.Add(forma.Matieres.ElementAt(i));
                            }

                            break;
                        }
                    }
                }
            }
            catch(Exception) { int i = 0; }
        }

        private void comboBox_classe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                checkedListBox_matieres.Items.Clear();
                String formation = comboBox_classe.SelectedItem.ToString();
                foreach (Formation forma in Formation.FormationData)
                {
                    if (forma.code.Equals(formation))
                    {
                        for (int i = 0; i < forma.Matieres.Count(); i++)
                        {
                            if (forma.Matieres.ElementAt(i) != null)
                                checkedListBox_matieres.Items.Add(forma.Matieres.ElementAt(i));
                        }

                        break;
                    }
                }
            } catch (Exception)
            {
                int i = 0;
            }
           

        }

        private void input_2eme_telephone_Click(object sender, EventArgs e)
        {
            input_2eme_telephone.Clear();
            resetColor();
        }

        private void linkLabel_les_eleves_formations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Nouveau_Eleve.Instance.BringToFront();
        }

        private void inscription_formation_SizeChanged(object sender, EventArgs e)
        {
            Big = !Big;
            int lenght;
            int l_button;
            if (Big)
            {
                lenght = Variables.input_lengh_big;
                l_button = Variables.button_lengh_big;

            }
            else
            {
                lenght = Variables.input_lengh_small;
                l_button = Variables.button_lengh_small;
            }
            input_nom.Width = lenght;
            input_prenom.Width = lenght;
            inpit_numero.Width = lenght;
            input_2eme_telephone.Width = lenght;
            
            panel1.Width = lenght;
            panel2.Width = lenght;
            panel3.Width = lenght;
            panel_2eme_telephone.Width = lenght;
           
        }

        private void button_inscrire_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                button_inscrire.BackColor = Color.FromArgb(41, 94, 106);
                resetColor();
                bool error = false;

                String nom = null;
                try
                {
                    nom = input_nom.Text.ToLower();
                    if (nom.Equals(""))
                    {
                        panel1.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }
                catch (Exception)
                {
                    panel1.BackColor = Color.FromArgb(255, 0, 0);
                    error = true;
                }


                String prenom = null;
                try
                {
                    prenom = input_prenom.Text.ToLower();
                    if (prenom.Equals(""))
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


                int telephone = 0;
                try
                {
                    telephone = int.Parse(inpit_numero.Text);
                    if ((telephone > 799999999) || telephone == 0) { panel3.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                }
                catch (Exception)
                {
                    panel3.BackColor = Color.FromArgb(255, 0, 0);
                    error = true;
                }

                int telephone_2 = 0;
                try
                {
                    telephone_2 = int.Parse(input_2eme_telephone.Text);
                    if ((telephone_2 > 799999999)) { panel_2eme_telephone.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                }
                catch (Exception)
                {
                    panel_2eme_telephone.BackColor = Color.FromArgb(255, 0, 0);
                }
                panel_2eme_telephone.BackColor = Color.FromArgb(41, 94, 106);



                String classe = "";
                try
                {
                    if (type_etudiant.SelectedIndex != 0) classe = "ADULTE";
                    else
                    {
                        try
                        {
                            classe = comboBox_classe.SelectedItem.ToString();
                            if (classe.Equals("") || classe == null) { classe = "ADULTE"; }
                        }
                        catch (Exception) { comboBox_classe.ForeColor = Color.FromArgb(255, 0, 0); error = true; }
                    }
                }
                catch (Exception)
                {
                    if (classe.Equals("") || classe == null) { error = true; }
                }
               


                String matieres = null;
                try
                {
                    foreach (object checkedMatiere in checkedListBox_matieres.CheckedItems)
                    {
                        if (!Variables.matieres.Contains(checkedMatiere.ToString()))
                        {
                            Variables.matieres.Add(checkedMatiere.ToString());
                        }
                        matieres += checkedMatiere.ToString() + "_";
                    }

                    if (matieres.Equals("")) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }
                }
                catch (Exception) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }


                if (!error)
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@telephone", telephone);
                    command.Parameters.AddWithValue("@telephone_2", telephone_2);
                    command.Parameters.AddWithValue("@classe", classe);
                    command.Parameters.AddWithValue("@matieres", matieres);
                    command.CommandText = "INSERT  INTO mes_eleves_forma (nom, prenom, telephone, telephone_2, formation_code, matieres) VALUES (@nom,@prenom, @telephone,@telephone_2, @classe, @matieres)";
                    try
                    {
                        input_nom.Text = "Nom";
                        input_prenom.Text = "Prénom";
                        inpit_numero.Text = "Numéro du telephone";
                        input_2eme_telephone.Text = "Numéro du telephone (optionel)";
                        comboBox_classe.Text = "Classe";
                        
                        type_etudiant.ClearSelected();
                        for (int i = 0; i < checkedListBox_matieres.Items.Count; i++)
                        {
                            checkedListBox_matieres.SetItemCheckState(i, CheckState.Unchecked);
                        }
                        label_error.Text = "Inscription faite"; label_error.Visible = true;
                        label_error.ForeColor = Color.Green;
                        command.ExecuteNonQuery();
                        comboBox_classe.Hide();
                    }
                    catch (Exception)
                    {
                        

                        label_error.Text = "Erreur"; label_error.ForeColor = Color.Red;
                        label_error.Visible = true;
                        button_inscrire.BackColor = Color.FromArgb(255, 0, 0);
                    }
                }
                else
                {
                    label_error.Text = "Erreur"; label_error.ForeColor = Color.Red;
                    label_error.Visible = true;

                }
                Variables.connection.Close();
            }
            catch (Exception)
            {
                int i = 0; i++;
            }
        }

        private void input_nom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                input_prenom.Focus();
            }
        }

        private void input_prenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                inpit_numero.Focus();
            }
        }

        private void inpit_numero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                input_2eme_telephone.Focus();
            }
        }
    }
}
