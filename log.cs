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
    public partial class log : UserControl
    {
        public static log _instance;
        public static log Instance
        {
            get
            {
                if (log._instance == null) log._instance = new log();
                return log._instance;
            }
        }
        public log()
        {
            InitializeComponent();
            textBox1.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String id = textBox1.Text;
                String pass = textBox2.Text;

                if (id.Equals(Variables.identificateur))
                {
                    if (pass.Equals(Variables.motdepasse))
                    {
                        log.Instance.Hide();
                    }
                    else { panel_pass.BackColor = Color.FromArgb(255, 0, 0); }
                }
                else
                {
                    panel_id.BackColor = Color.FromArgb(255, 0, 0);
                    if (!pass.Equals(Variables.motdepasse)) { panel_pass.BackColor = Color.FromArgb(255, 0, 0); }
                }
            }
            catch (Exception)
            {
                int j = 0;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            panel_id.BackColor = Color.FromArgb(41, 94, 106);
            panel_pass.BackColor = Color.FromArgb(41, 94, 106);
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            panel_id.BackColor = Color.FromArgb(41, 94, 106);
            panel_pass.BackColor = Color.FromArgb(41, 94, 106);
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }

        private void log_MouseMove(object sender, MouseEventArgs e)
        {
            if (!label1.Focused) label1.Focus();
        }

        private void log_MouseEnter(object sender, EventArgs e)
        {
            if (!label1.Focused) label1.Focus();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!label1.Focused) label1.Focus();

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            button1.BackColor = Color.FromArgb(41, 94, 106);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 255, 255);
            button1.ForeColor = Color.FromArgb(41, 94, 106);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!label1.Focused) label1.Focus();
        }

        private void log_Click(object sender, EventArgs e)
        {
            panel_id.BackColor = Color.FromArgb(41, 94, 106);
            panel_pass.BackColor = Color.FromArgb(41, 94, 106);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void log_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //nothing
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
        }
    }
}
    