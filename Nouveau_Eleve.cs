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
    public partial class Nouveau_Eleve : UserControl
    {
        int nb_student = -1;
        public static bool Big = false;
        public static Nouveau_Eleve _instance;
        public static Nouveau_Eleve Instance
        {
            get
            {
                if (Nouveau_Eleve._instance == null) Nouveau_Eleve._instance = new Nouveau_Eleve();
                return Nouveau_Eleve._instance;
            }
        }
        
        public Nouveau_Eleve()
        {
            InitializeComponent();
            initialise_combobox();
            input_nom.Focus();
        }
        

        private void initialise_combobox()
        {
            foreach(Classe classe in Classe.classesData)
            {
                comboBox_classe.Items.Add(classe.code);
            }
        }



        private void button_inscrire_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = Variables.connectToDataBase();
                button_inscrire.BackColor = Color.FromArgb(41, 94, 106);
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
                    if ((telephone > 799999999)) { panel3.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                }
                catch (Exception)
                {
                    panel3.BackColor = Color.FromArgb(255, 0, 0);
                    error = true;
                }

                int telephone_2 = 0;
                if (!input_2eme_telephone.Text.Equals("Numéro du telephone (optionel)") && !input_2eme_telephone.Text.Equals(""))
                {
                    try
                    {
                        telephone_2 = int.Parse(input_2eme_telephone.Text);
                        if ((telephone_2 > 799999999)) { panel_2eme_telephone.BackColor = Color.FromArgb(255, 0, 0); error = true; }
                    }
                    catch (Exception)
                    {
                        panel_2eme_telephone.BackColor = Color.FromArgb(255, 0, 0);
                        error = true;
                    }
                }




                String classe = "";
                try
                {
                    classe = comboBox_classe.SelectedItem.ToString();
                    if (classe.Equals("")) { error = true; comboBox_classe.ForeColor = Color.FromArgb(255, 0, 0); }
                }
                catch (Exception) { comboBox_classe.ForeColor = Color.FromArgb(255, 0, 0); error = true; }



                String matieres = "";
                try
                {
                    foreach (object checkedMatiere in checkedListBox_matieres.CheckedItems)
                    {
                        if (!Variables.matieres.Contains(checkedMatiere.ToString()))
                        {
                            Variables.matieres.Add(checkedMatiere.ToString());
                        }
                        
                            else matieres += checkedMatiere.ToString() + "_";
                        
                       
                    }

                    if (matieres.Equals("")) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }
                }
                catch (Exception) { error = true; checkedListBox_matieres.ForeColor = Color.FromArgb(255, 0, 0); }


                if (!error)
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@telephone", telephone);
                    command.Parameters.AddWithValue("@telephone2", telephone_2);
                    command.Parameters.AddWithValue("@classe", classe);
                    command.Parameters.AddWithValue("@matieres", matieres);
                    nb_student++;
                    command.CommandText = "INSERT  INTO mes_eleves (nom, prenom, telephone, telephone_2, classe_code, matieres) VALUES (@nom,@prenom, @telephone, @telephone2, @classe, @matieres)";
                    try
                    {
                        input_nom.Text = "Nom";
                        input_prenom.Text = "Prénom";
                        inpit_numero.Text = "Numéro du telephone";
                        input_2eme_telephone.Text = "Numéro du telephone (optionel)";
                        comboBox_classe.Text = "Classe";
                        for (int i = 0; i < checkedListBox_matieres.Items.Count; i++)
                        {
                            checkedListBox_matieres.SetItemCheckState(i, CheckState.Unchecked);
                        }
                        
                        label_error.Text = "Inscription faite";
                        label_error.ForeColor = Color.Green;
                        command.ExecuteNonQuery();
                        label_error.ForeColor = Color.Green; label_error.Visible = true;
                        input_nom.Focus();
                    }
                    catch (Exception)
                    {
                        button_inscrire.BackColor = Color.FromArgb(255, 0, 0);
                        label_error.ForeColor = Color.Red;
                        label_error.Text = "Erreur";
                        label_error.Visible = true;
                    }
                }
                else
                {
                    label_error.ForeColor = Color.Red;
                    label_error.Text = "Erreur";
                    label_error.Visible = true;
                }
                Variables.connection.Close();
            }
            catch (Exception)
            {
                label_error.ForeColor = Color.Red;
                label_error.Text = "Erreur";
                label_error.Visible = true;
            }

        }

        

        private void comboBox_classe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            checkedListBox_matieres.Items.Clear();
            String selectedcode = comboBox_classe.SelectedItem.ToString();
            foreach (Classe classe in Classe.classesData)
            {
                if (selectedcode.Equals(classe.code))
                {
                    for (int i = 0; i<classe.Matieres.Count(); i++ )
                    {
                        if (classe.Matieres.ElementAt(i)!=null)
                        {
                            checkedListBox_matieres.Items.Add(classe.Matieres.ElementAt(i));
                        }
                        
                    }
                    
                    break;
                }
            }
        }

        private void resetColor()
        {
            label_error.Visible = false;
            panel1.BackColor = Color.FromArgb(41, 94, 106);
            panel2.BackColor = Color.FromArgb(41, 94, 106);
            panel3.BackColor = Color.FromArgb(41, 94, 106);
            button_inscrire.BackColor = Color.FromArgb(41, 94, 106);
            comboBox_classe.ForeColor = Color.Black;
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



        private void input_2eme_telephone_Click(object sender, EventArgs e)
        {
            input_2eme_telephone.Clear();
            resetColor();
        }

        private void linkLabel_les_eleves_formations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inscription_formation ins = new inscription_formation();
            Nouveau_Eleve.Instance.Controls.Add(ins);
            ins.Dock = DockStyle.Fill;
            ins.BringToFront();
            ins.Focus();
        }

        private void input_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nouveau_Eleve_SizeChanged(object sender, EventArgs e)
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
            comboBox_classe.Width = lenght;
            panel1.Width = lenght;
            panel2.Width = lenght;
            panel3.Width = lenght;
            panel_2eme_telephone.Width = lenght;
            button_inscrire.Width = l_button;
            checkedListBox_matieres.Width = l_button;
        }

        private void Nouveau_Eleve_Load(object sender, EventArgs e)
        {

        }

        private void Nouveau_Eleve_KeyDown(object sender, KeyEventArgs e)
        {
           
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

        private void input_2eme_telephone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                button_inscrire.Focus();
            }
        }
    }
}
