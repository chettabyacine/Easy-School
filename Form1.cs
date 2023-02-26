using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{


    public partial class Form1 : Form
    {
        public static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null) _instance = new Form1();
                return _instance;
            }
        }
        public Form1()
        {
            InitializeComponent();
            panel4.Visible = false;
            if (!panel_form1.Controls.Contains(log.Instance))
            {
                panel_form1.Controls.Add(log.Instance);
            }
            //Variables.createTables();
            log.Instance.BringToFront();
            log.Instance.Dock = DockStyle.Fill;
            Classe.creerLesClasses();
            Formation.creerLesFormations();
           
        }

        



        private void button_accueil_1_Click(object sender, EventArgs e)
        {
            panelside.Height = button_accueil1.Height;
            panelside.Top = button_accueil1.Top;
            if (!panel_mini_form1.Controls.Contains(accueil.Instance))
            {
                panel_mini_form1.Controls.Add(accueil.Instance);

            }
            accueil.Instance.Visible = true;
            accueil.Instance.BringToFront();
            accueil.Instance.Dock = DockStyle.Fill;
            accueil.Instance.Size = panel_mini_form1.Size;
        }

        private void button_nv_eleve1_Click(object sender, EventArgs e)
        {
            panelside.Height = button_nv_eleve1.Height;
            panelside.Top = button_nv_eleve1.Top;
            if (!panel_mini_form1.Controls.Contains(Nouveau_Eleve.Instance))
            {
                panel_mini_form1.Controls.Add(Nouveau_Eleve.Instance);

            }
            Nouveau_Eleve.Instance.Visible = true;
            Nouveau_Eleve.Instance.BringToFront();

        }

        private void button_mes_classes_Click(object sender, EventArgs e)
        {
            panelside.Height = button_mes_classes.Height;
            panelside.Top = button_mes_classes.Top;
            if (!panel_mini_form1.Controls.Contains(MesClasses.Instance))
            {
                panel_mini_form1.Controls.Add(MesClasses.Instance);

            }
            MesClasses.Instance.Dock = DockStyle.Fill;
            MesClasses.Instance.Visible = true;
            MesClasses.Instance.BringToFront();


        }

        private void button_mes_eleves1_Click(object sender, EventArgs e)
        {
            panelside.Height = button_mes_eleves1.Height;
            panelside.Top = button_mes_eleves1.Top;

            if (!panel_mini_form1.Controls.Contains(Mes_Eleves.Instance))
            {
                panel_mini_form1.Controls.Add(Mes_Eleves.Instance);

            }
            Mes_Eleves.Instance.Visible = true;
            Mes_Eleves.Instance.BringToFront();

        }

        private void button_deconnexion_1_Click(object sender, EventArgs e)
        //button mes Formations
        {
            panelside.Height = button_mes_formations.Height;
            panelside.Top = button_mes_formations.Top;
            if (!panel_mini_form1.Controls.Contains(MesFormations.Instance))
            {
                panel_mini_form1.Controls.Add(MesFormations.Instance);

            }
            MesFormations.Instance.Dock = DockStyle.Fill;
            MesFormations.Instance.Visible = true;
            MesFormations.Instance.BringToFront();
        }

        private void panel_mini_form1_MouseMove(object sender, MouseEventArgs e)
        {
            openApp();

        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            openApp();
        }

        private void openApp()
        {
            if (!panel_mini_form1.Controls.Contains(accueil.Instance))
            {
                panel_mini_form1.Controls.Add(accueil.Instance);
                panelside.Height = button_accueil1.Height;
                panelside.Top = button_accueil1.Top;
                panel4.Visible = true;
                accueil.Instance.Visible = true;
                accueil.Instance.BringToFront();


            }



        }

        private void closeApp()
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            closeApp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            /*panelside.Height = button_vider.Height;
            panelside.Top = button_vider.Top;*/
            
            vider vider = new vider();
            panel_mini_form1.Controls.Add(vider);
            vider.BringToFront();
            vider.Focus();
        }

        private void panel_mini_form1_SizeChanged(object sender, EventArgs e)
        {
            accueil.Instance.Dock = DockStyle.Fill;
            Nouveau_Eleve.Instance.Dock = DockStyle.Fill;
            inscription_formation.Instance.Dock = DockStyle.Fill;
            Mes_Eleves.Instance.Dock = DockStyle.Fill;
            eleves_formations.Instance.Dock = DockStyle.Fill;
            MesClasses.Instance.Dock = DockStyle.Fill;
            MesFormations.Instance.Dock = DockStyle.Fill;
            
        }
    }
}


