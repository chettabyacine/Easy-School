using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UC_Classes : UserControl
    {
        public UC_Classes(bool isFormation)
        {
            InitializeComponent();
            if (isFormation) initialise_checklistbox_formation();
            else initialise_checklistbox();
        }
        private void initialise_checklistbox()
        {
            foreach (Classe classe in Classe.classesData)
            {
                checkedListBox1.Items.Add(classe.code);
            }
        }

        private void initialise_checklistbox_formation()
        {
            foreach (Formation formation in Formation.FormationData)
            {
                checkedListBox1.Items.Add(formation.code);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.ForeColor = Color.White;
            try
            {
                foreach (object checkedClasses in checkedListBox1.CheckedItems)
                {
                    Variables.classesArechercher.Add(checkedClasses.ToString());
                }
            }
            catch (Exception) { checkedListBox1.ForeColor = Color.FromArgb(255, 0, 0); MessageBox.Show("error"); }
            this.Hide();
            Mes_Eleves.Instance.BringToFront();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mes_Eleves.Instance.BringToFront();
        }
    }
}
