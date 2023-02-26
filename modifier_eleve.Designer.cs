namespace WindowsFormsApp4
{
    partial class modifier_eleve
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox_matieres = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modifiez les informations de l\'élève";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(155, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "C\'est bon";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.cancel_24px;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(670, 0);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(24, 24);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(162, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 15);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = " ";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Location = new System.Drawing.Point(162, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 1);
            this.panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // checkedListBox_matieres
            // 
            this.checkedListBox_matieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.checkedListBox_matieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_matieres.CheckOnClick = true;
            this.checkedListBox_matieres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_matieres.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedListBox_matieres.FormattingEnabled = true;
            this.checkedListBox_matieres.Location = new System.Drawing.Point(382, 125);
            this.checkedListBox_matieres.Name = "checkedListBox_matieres";
            this.checkedListBox_matieres.Size = new System.Drawing.Size(177, 221);
            this.checkedListBox_matieres.Sorted = true;
            this.checkedListBox_matieres.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(162, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 1);
            this.panel1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(162, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 15);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = " ";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel6.Location = new System.Drawing.Point(162, 221);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 1);
            this.panel6.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(162, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 15);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = " ";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel7.Location = new System.Drawing.Point(162, 173);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 1);
            this.panel7.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox7.Location = new System.Drawing.Point(162, 152);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(173, 15);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = " ";
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            // 
            // modifier_eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkedListBox_matieres);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(70, 95);
            this.Name = "modifier_eleve";
            this.Size = new System.Drawing.Size(694, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_matieres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox7;
    }
}
