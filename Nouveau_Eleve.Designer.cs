namespace WindowsFormsApp4
{
    partial class Nouveau_Eleve
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
            this.input_nom = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.inpit_numero = new System.Windows.Forms.TextBox();
            this.comboBox_classe = new System.Windows.Forms.ComboBox();
            this.checkedListBox_matieres = new System.Windows.Forms.CheckedListBox();
            this.button_inscrire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.input_2eme_telephone = new System.Windows.Forms.TextBox();
            this.panel_2eme_telephone = new System.Windows.Forms.Panel();
            this.linkLabel_les_eleves_formations = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.input_nom.TabIndex = 0;
            this.input_nom.Text = "Nom";
            this.input_nom.Click += new System.EventHandler(this.input_nom_Click);
            this.input_nom.TextChanged += new System.EventHandler(this.input_nom_TextChanged);
            this.input_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_nom_KeyDown);
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
            this.input_prenom.TabIndex = 1;
            this.input_prenom.Text = "Prénom";
            this.input_prenom.Click += new System.EventHandler(this.input_prenom_Click);
            this.input_prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_prenom_KeyDown);
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
            this.inpit_numero.TabIndex = 2;
            this.inpit_numero.Text = "Numéro du telephone";
            this.inpit_numero.Click += new System.EventHandler(this.inpit_numero_Click);
            this.inpit_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inpit_numero_KeyDown);
            // 
            // comboBox_classe
            // 
            this.comboBox_classe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_classe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_classe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_classe.FormattingEnabled = true;
            this.comboBox_classe.Location = new System.Drawing.Point(70, 364);
            this.comboBox_classe.Name = "comboBox_classe";
            this.comboBox_classe.Size = new System.Drawing.Size(299, 23);
            this.comboBox_classe.TabIndex = 4;
            this.comboBox_classe.Text = "Classe";
            this.comboBox_classe.SelectedIndexChanged += new System.EventHandler(this.comboBox_classe_SelectedIndexChanged);
            this.comboBox_classe.SelectionChangeCommitted += new System.EventHandler(this.comboBox_classe_SelectionChangeCommitted);
            this.comboBox_classe.Click += new System.EventHandler(this.comboBox_classe_Click);
            // 
            // checkedListBox_matieres
            // 
            this.checkedListBox_matieres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_matieres.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkedListBox_matieres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_matieres.CheckOnClick = true;
            this.checkedListBox_matieres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_matieres.FormattingEnabled = true;
            this.checkedListBox_matieres.Location = new System.Drawing.Point(464, 132);
            this.checkedListBox_matieres.Name = "checkedListBox_matieres";
            this.checkedListBox_matieres.Size = new System.Drawing.Size(330, 255);
            this.checkedListBox_matieres.Sorted = true;
            this.checkedListBox_matieres.TabIndex = 5;
            this.checkedListBox_matieres.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_matieres_ItemCheck);
            this.checkedListBox_matieres.Click += new System.EventHandler(this.checkedListBox_matieres_Click);
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
            this.button_inscrire.TabIndex = 6;
            this.button_inscrire.Text = "INSCRIRE";
            this.button_inscrire.UseVisualStyleBackColor = false;
            this.button_inscrire.Click += new System.EventHandler(this.button_inscrire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inscription dans un(des) cours de soutien";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel1.Location = new System.Drawing.Point(70, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel2.Location = new System.Drawing.Point(70, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel3.Location = new System.Drawing.Point(70, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 1);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remplissez tout le champs, puis appuyer sur";
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
            this.label_error.TabIndex = 18;
            this.label_error.Text = "Elève dupliqué";
            this.label_error.Visible = false;
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
            this.input_2eme_telephone.TabIndex = 3;
            this.input_2eme_telephone.Text = "Numéro du telephone (optionel)";
            this.input_2eme_telephone.Click += new System.EventHandler(this.input_2eme_telephone_Click);
            this.input_2eme_telephone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_2eme_telephone_KeyDown);
            // 
            // panel_2eme_telephone
            // 
            this.panel_2eme_telephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_2eme_telephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.panel_2eme_telephone.Location = new System.Drawing.Point(70, 323);
            this.panel_2eme_telephone.Name = "panel_2eme_telephone";
            this.panel_2eme_telephone.Size = new System.Drawing.Size(299, 1);
            this.panel_2eme_telephone.TabIndex = 17;
            // 
            // linkLabel_les_eleves_formations
            // 
            this.linkLabel_les_eleves_formations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_les_eleves_formations.AutoSize = true;
            this.linkLabel_les_eleves_formations.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_les_eleves_formations.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.linkLabel_les_eleves_formations.Location = new System.Drawing.Point(643, 58);
            this.linkLabel_les_eleves_formations.Name = "linkLabel_les_eleves_formations";
            this.linkLabel_les_eleves_formations.Size = new System.Drawing.Size(151, 15);
            this.linkLabel_les_eleves_formations.TabIndex = 7;
            this.linkLabel_les_eleves_formations.TabStop = true;
            this.linkLabel_les_eleves_formations.Text = "Les formations de langues?";
            this.linkLabel_les_eleves_formations.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_les_eleves_formations_LinkClicked);
            // 
            // Nouveau_Eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.linkLabel_les_eleves_formations);
            this.Controls.Add(this.panel_2eme_telephone);
            this.Controls.Add(this.input_2eme_telephone);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_inscrire);
            this.Controls.Add(this.checkedListBox_matieres);
            this.Controls.Add(this.comboBox_classe);
            this.Controls.Add(this.inpit_numero);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Name = "Nouveau_Eleve";
            this.Size = new System.Drawing.Size(834, 548);
            this.Load += new System.EventHandler(this.Nouveau_Eleve_Load);
            this.SizeChanged += new System.EventHandler(this.Nouveau_Eleve_SizeChanged);
            this.Click += new System.EventHandler(this.Nouveau_Eleve_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Nouveau_Eleve_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox inpit_numero;
        private System.Windows.Forms.ComboBox comboBox_classe;
        private System.Windows.Forms.CheckedListBox checkedListBox_matieres;
        private System.Windows.Forms.Button button_inscrire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_2eme_telephone;
        private System.Windows.Forms.TextBox input_2eme_telephone;
        private System.Windows.Forms.LinkLabel linkLabel_les_eleves_formations;
    }
}
