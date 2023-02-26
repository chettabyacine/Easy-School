using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class vider : UserControl
    {
        public vider()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // var : 
                  String database_name = "base_cs";
                  String server = "127.0.0.1";
                  String user_name = "root";
                  String password = "Yacine_chettab22";
                  String connectionString = "server=" + server + ";user id=" + user_name + ";password=" + password + ";persistsecurityinfo=True;database=" + database_name;
                  MySqlConnection connection = new MySqlConnection(connectionString);
                  connection.Open();


                label1.ForeColor = Color.FromName("InactiveBorder");
                panel1.BackColor = Color.FromName("InactiveBorder");
                if (textBox1.Text.Equals(Variables.mdps_vider))
                {
                    MySqlCommand command = connection.CreateCommand();
                    if (listBox1.SelectedIndex == 0)
                    {
                        command.CommandText = "DELETE FROM mes_eleves WHERE id>0;";
                    }
                    else
                    {
                        command.CommandText = "DELETE FROM  mes_eleves_forma WHERE id>0;";
                    }
                    command.ExecuteNonQuery();

                } 
                else
                {
                    panel1.BackColor = Color.Red;
                }
                connection.Close();
            }
            catch (Exception)
            {
                label1.ForeColor = Color.Red;
            }
            Hide();
            Form1.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.Instance.BringToFront();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.PasswordChar = '*';

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromName("InactiveBorder");
            button1.ForeColor = Color.FromArgb(41, 94, 106);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromName("InactiveBorder");
            button2.ForeColor = Color.FromArgb(41, 94, 106);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromName("InactiveBorder");
            button1.BackColor = Color.FromArgb(41, 94, 106);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromName("InactiveBorder");
            button2.BackColor = Color.FromArgb(41, 94, 106);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.Instance.BringToFront();
            
        }
    }
}
