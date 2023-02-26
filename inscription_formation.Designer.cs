namespace WindowsFormsApp4
{
    partial class inscription_formation
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
            this.components = new System.ComponentModel.Container();
            this.label_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox_matieres = new System.Windows.Forms.CheckedListBox();
            this.inpit_numero = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.input_2eme_telephone = new System.Windows.Forms.TextBox();
            this.comboBox_classe = new System.Windows.Forms.ComboBox();
            this.type_etudiant = new System.Windows.Forms.ListBox();
            this.linkLabel_les_eleves_formations = new System.Windows.Forms.LinkLabel();
            this.panel_2eme_telephone = new System.Windows.Forms.Panel();
            this.button_inscrire = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(461, 502);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(105, 16);
            this.label_error.TabIndex = 34;
            this.label_error.Text = "Elève dupliqué";
            this.label_error.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Remplissez tout le champs, puis appuyer sur";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(70, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 1);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 1);
            this.panel4.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel2.Location = new System.Drawing.Point(70, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 1);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel1.Location = new System.Drawing.Point(70, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 1);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Inscription dans une(des) formation(s) de langue";
            // 
            // checkedListBox_matieres
            // 
            this.checkedListBox_matieres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkedListBox_matieres.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedListBox_matieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_matieres.CheckOnClick = true;
            this.checkedListBox_matieres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_matieres.FormattingEnabled = true;
            this.checkedListBox_matieres.Location = new System.Drawing.Point(464, 132);
            this.checkedListBox_matieres.Name = "checkedListBox_matieres";
            this.checkedListBox_matieres.Size = new System.Drawing.Size(334, 255);
            this.checkedListBox_matieres.Sorted = true;
            this.checkedListBox_matieres.TabIndex = 26;
            this.checkedListBox_matieres.Click += new System.EventHandler(this.checkedListBox_matieres_Click);
            // 
            // inpit_numero
            // 
            this.inpit_numero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.inpit_numero.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.inpit_numero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpit_numero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpit_numero.Location = new System.Drawing.Point(70, 246);
            this.inpit_numero.Name = "inpit_numero";
            this.inpit_numero.Size = new System.Drawing.Size(299, 14);
            this.inpit_numero.TabIndex = 24;
            this.inpit_numero.Text = "Numéro du telephone";
            this.inpit_numero.Click += new System.EventHandler(this.inpit_numero_Click);
            this.inpit_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inpit_numero_KeyDown);
            // 
            // input_prenom
            // 
            this.input_prenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.input_prenom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.input_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_prenom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_prenom.Location = new System.Drawing.Point(70, 189);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(299, 14);
            this.input_prenom.TabIndex = 23;
            this.input_prenom.Text = "Prenom";
            this.input_prenom.Click += new System.EventHandler(this.input_prenom_Click);
            this.input_prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_prenom_KeyDown);
            // 
            // input_nom
            // 
            this.input_nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.input_nom.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.input_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_nom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_nom.Location = new System.Drawing.Point(70, 132);
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(299, 14);
            this.input_nom.TabIndex = 22;
            this.input_nom.Text = "Nom";
            this.input_nom.Click += new System.EventHandler(this.input_nom_Click);
            this.input_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_nom_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // input_2eme_telephone
            // 
            this.input_2eme_telephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.input_2eme_telephone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.input_2eme_telephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_2eme_telephone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_2eme_telephone.Location = new System.Drawing.Point(70, 303);
            this.input_2eme_telephone.Name = "input_2eme_telephone";
            this.input_2eme_telephone.Size = new System.Drawing.Size(299, 14);
            this.input_2eme_telephone.TabIndex = 35;
            this.input_2eme_telephone.Text = "Numéro du telephone (optionel)";
            this.input_2eme_telephone.Click += new System.EventHandler(this.input_2eme_telephone_Click);
            // 
            // comboBox_classe
            // 
            this.comboBox_classe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_classe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_classe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_classe.FormattingEnabled = true;
            this.comboBox_classe.Location = new System.Drawing.Point(208, 348);
            this.comboBox_classe.Name = "comboBox_classe";
            this.comboBox_classe.Size = new System.Drawing.Size(161, 23);
            this.comboBox_classe.TabIndex = 25;
            this.comboBox_classe.Text = "Classe";
            this.comboBox_classe.SelectionChangeCommitted += new System.EventHandler(this.comboBox_classe_SelectionChangeCommitted);
            this.comboBox_classe.Click += new System.EventHandler(this.comboBox_classe_Click);
            // 
            // type_etudiant
            // 
            this.type_etudiant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.type_etudiant.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.type_etudiant.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_etudiant.FormattingEnabled = true;
            this.type_etudiant.ItemHeight = 15;
            this.type_etudiant.Location = new System.Drawing.Point(70, 342);
            this.type_etudiant.Name = "type_etudiant";
            this.type_etudiant.Size = new System.Drawing.Size(121, 34);
            this.type_etudiant.TabIndex = 37;
            this.type_etudiant.Click += new System.EventHandler(this.type_etudiant_SelectedIndexChanged);
            this.type_etudiant.SelectedIndexChanged += new System.EventHandler(this.type_etudiant_SelectedIndexChanged);
            // 
            // linkLabel_les_eleves_formations
            // 
            this.linkLabel_les_eleves_formations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_les_eleves_formations.AutoSize = true;
            this.linkLabel_les_eleves_formations.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_les_eleves_formations.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.linkLabel_les_eleves_formations.Location = new System.Drawing.Point(676, 60);
            this.linkLabel_les_eleves_formations.Name = "linkLabel_les_eleves_formations";
            this.linkLabel_les_eleves_formations.Size = new System.Drawing.Size(122, 15);
            this.linkLabel_les_eleves_formations.TabIndex = 38;
            this.linkLabel_les_eleves_formations.TabStop = true;
            this.linkLabel_les_eleves_formations.Text = "Les cours de soutien?";
            this.linkLabel_les_eleves_formations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_les_eleves_formations_LinkClicked);
            // 
            // panel_2eme_telephone
            // 
            this.panel_2eme_telephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_2eme_telephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel_2eme_telephone.Location = new System.Drawing.Point(70, 321);
            this.panel_2eme_telephone.Name = "panel_2eme_telephone";
            this.panel_2eme_telephone.Size = new System.Drawing.Size(299, 1);
            this.panel_2eme_telephone.TabIndex = 39;
            // 
            // button_inscrire
            // 
            this.button_inscrire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button_inscrire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_inscrire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inscrire.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inscrire.ForeColor = System.Drawing.Color.White;
            this.button_inscrire.Location = new System.Drawing.Point(464, 412);
            this.button_inscrire.Name = "button_inscrire";
            this.button_inscrire.Size = new System.Drawing.Size(330, 49);
            this.button_inscrire.TabIndex = 40;
            this.button_inscrire.Text = "INSCRIRE";
            this.button_inscrire.UseVisualStyleBackColor = false;
            this.button_inscrire.Click += new System.EventHandler(this.button_inscrire_Click_1);
            // 
            // inscription_formation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.button_inscrire);
            this.Controls.Add(this.panel_2eme_telephone);
            this.Controls.Add(this.linkLabel_les_eleves_formations);
            this.Controls.Add(this.type_etudiant);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox_matieres);
            this.Controls.Add(this.comboBox_classe);
            this.Controls.Add(this.inpit_numero);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.input_2eme_telephone);
            this.Name = "inscription_formation";
            this.Size = new System.Drawing.Size(834, 548);
            this.Load += new System.EventHandler(this.inscription_formation_Load);
            this.SizeChanged += new System.EventHandler(this.inscription_formation_SizeChanged);
            this.Click += new System.EventHandler(this.Nouveau_Eleve_Click);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox_matieres;
        private System.Windows.Forms.TextBox inpit_numero;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.TextBox input_2eme_telephone;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.ListBox type_etudiant;
        private System.Windows.Forms.ComboBox comboBox_classe;
        private System.Windows.Forms.LinkLabel linkLabel_les_eleves_formations;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_2eme_telephone;
        private System.Windows.Forms.Button button_inscrire;
    }
}
