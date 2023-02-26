namespace WindowsFormsApp4
{
    partial class accueil
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
            this.panel_accueil_grande = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.initialiser_bdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_accueil_grande.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_accueil_grande
            // 
            this.panel_accueil_grande.Controls.Add(this.panel2);
            this.panel_accueil_grande.Controls.Add(this.label1);
            this.panel_accueil_grande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_accueil_grande.Location = new System.Drawing.Point(0, 0);
            this.panel_accueil_grande.Name = "panel_accueil_grande";
            this.panel_accueil_grande.Size = new System.Drawing.Size(835, 547);
            this.panel_accueil_grande.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.initialiser_bdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 547);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.IMG_20201111_002652;
            this.pictureBox1.Location = new System.Drawing.Point(108, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.label4.Location = new System.Drawing.Point(521, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Les élèves de formations de langues";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.label3.Location = new System.Drawing.Point(85, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Les élèves de cours de soutien";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(575, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "IMPORTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Importer un fichier excel de la forme";
            // 
            // initialiser_bdd
            // 
            this.initialiser_bdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.initialiser_bdd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.initialiser_bdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.initialiser_bdd.FlatAppearance.BorderSize = 2;
            this.initialiser_bdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initialiser_bdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialiser_bdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.initialiser_bdd.Location = new System.Drawing.Point(108, 432);
            this.initialiser_bdd.Name = "initialiser_bdd";
            this.initialiser_bdd.Size = new System.Drawing.Size(152, 40);
            this.initialiser_bdd.TabIndex = 2;
            this.initialiser_bdd.Text = "IMPORTER";
            this.initialiser_bdd.UseVisualStyleBackColor = false;
            this.initialiser_bdd.Click += new System.EventHandler(this.initialiser_bdd_Click_1);
            this.initialiser_bdd.MouseEnter += new System.EventHandler(this.initialiser_bdd_MouseEnter);
            this.initialiser_bdd.MouseLeave += new System.EventHandler(this.initialiser_bdd_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Controls.Add(this.panel_accueil_grande);
            this.Name = "accueil";
            this.Size = new System.Drawing.Size(835, 547);
            this.Load += new System.EventHandler(this.accueil_Load);
            this.panel_accueil_grande.ResumeLayout(false);
            this.panel_accueil_grande.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_accueil_grande;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button initialiser_bdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
