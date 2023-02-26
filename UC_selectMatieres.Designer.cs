namespace WindowsFormsApp4
{
    partial class UC_selectMatieres
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seléctionez les matiéres à afficher";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(103, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "C\'est bon";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.Location = new System.Drawing.Point(100, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(337, 187);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button_cancel
            // 
            this.button_cancel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.cancel_24px;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(513, 0);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(24, 24);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // UC_selectMatieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(70, 95);
            this.Name = "UC_selectMatieres";
            this.Size = new System.Drawing.Size(537, 358);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button_cancel;
    }
}
