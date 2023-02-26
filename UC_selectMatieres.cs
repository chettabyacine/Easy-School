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
    public partial class UC_selectMatieres : UserControl
    {
        public UC_selectMatieres(bool isFormation)
        {
            InitializeComponent();
            if (!isFormation) { initialise_checklistbox(); }
            else initialise_checklistbox_formations();
        }

        private void initialise_checklistbox()
        {
            foreach (String matiere in Variables.matieres)
            {
                checkedListBox1.Items.Add(matiere);
            }
        }
        private void initialise_checklistbox_formations()
        {
            foreach (String matiere in Variables.matieres_formation)
            {
                checkedListBox1.Items.Add(matiere);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.ForeColor = Color.White;
            try
            {
                foreach (object checkedMatiere in checkedListBox1.CheckedItems)
                {
                    Variables.matieresArechercher.Add(checkedMatiere.ToString());
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
