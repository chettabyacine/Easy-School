namespace WindowsFormsApp4
{
    partial class eleves_formations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eleves_formations));
            this.button_select_classes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_select_matieres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_mes_eleves = new System.Windows.Forms.LinkLabel();
            this.DataView_MesEleves = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matieres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView_MesEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // button_select_classes
            // 
            this.button_select_classes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button_select_classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_classes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_classes.ForeColor = System.Drawing.SystemColors.Control;
            this.button_select_classes.Location = new System.Drawing.Point(100, 115);
            this.button_select_classes.Name = "button_select_classes";
            this.button_select_classes.Size = new System.Drawing.Size(195, 28);
            this.button_select_classes.TabIndex = 17;
            this.button_select_classes.Text = "NIVEAU(X)";
            this.button_select_classes.UseVisualStyleBackColor = false;
            this.button_select_classes.Click += new System.EventHandler(this.button_select_classes_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.refresh_30px;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(40, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_select_matieres
            // 
            this.button_select_matieres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button_select_matieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_select_matieres.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select_matieres.ForeColor = System.Drawing.SystemColors.Control;
            this.button_select_matieres.Location = new System.Drawing.Point(301, 116);
            this.button_select_matieres.Name = "button_select_matieres";
            this.button_select_matieres.Size = new System.Drawing.Size(195, 28);
            this.button_select_matieres.TabIndex = 14;
            this.button_select_matieres.Text = "FORMATION(S)";
            this.button_select_matieres.UseVisualStyleBackColor = false;
            this.button_select_matieres.Click += new System.EventHandler(this.button_select_matieres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mes élèves: Formations de langues";
            // 
            // linkLabel_mes_eleves
            // 
            this.linkLabel_mes_eleves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_mes_eleves.AutoSize = true;
            this.linkLabel_mes_eleves.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_mes_eleves.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.linkLabel_mes_eleves.Location = new System.Drawing.Point(672, 123);
            this.linkLabel_mes_eleves.Name = "linkLabel_mes_eleves";
            this.linkLabel_mes_eleves.Size = new System.Drawing.Size(122, 15);
            this.linkLabel_mes_eleves.TabIndex = 19;
            this.linkLabel_mes_eleves.TabStop = true;
            this.linkLabel_mes_eleves.Text = "Les cours de soutien?";
            this.linkLabel_mes_eleves.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_mes_eleves_LinkClicked);
            // 
            // DataView_MesEleves
            // 
            this.DataView_MesEleves.AllowUserToAddRows = false;
            this.DataView_MesEleves.AllowUserToDeleteRows = false;
            this.DataView_MesEleves.AllowUserToResizeRows = false;
            this.DataView_MesEleves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView_MesEleves.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DataView_MesEleves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView_MesEleves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataView_MesEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView_MesEleves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.nom,
            this.prenom,
            this.telephone,
            this.telephone_2,
            this.Classe,
            this.Matieres,
            this.modifier,
            this.supprimer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView_MesEleves.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataView_MesEleves.Location = new System.Drawing.Point(40, 166);
            this.DataView_MesEleves.Name = "DataView_MesEleves";
            this.DataView_MesEleves.ReadOnly = true;
            this.DataView_MesEleves.RowHeadersVisible = false;
            this.DataView_MesEleves.RowTemplate.Height = 30;
            this.DataView_MesEleves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataView_MesEleves.Size = new System.Drawing.Size(754, 343);
            this.DataView_MesEleves.TabIndex = 20;
            this.DataView_MesEleves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_MesEleves_CellContentClick);
            this.DataView_MesEleves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_MesEleves_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 40;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MaxInputLength = 20;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Width = 90;
            // 
            // telephone_2
            // 
            this.telephone_2.HeaderText = "Telephone 2";
            this.telephone_2.Name = "telephone_2";
            this.telephone_2.ReadOnly = true;
            this.telephone_2.Width = 90;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Niveau";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            this.Classe.Width = 50;
            // 
            // Matieres
            // 
            this.Matieres.HeaderText = "Formation(s)";
            this.Matieres.Name = "Matieres";
            this.Matieres.ReadOnly = true;
            // 
            // modifier
            // 
            this.modifier.HeaderText = "";
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.Name = "modifier";
            this.modifier.ReadOnly = true;
            this.modifier.Width = 26;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "";
            this.supprimer.Image = ((System.Drawing.Image)(resources.GetObject("supprimer.Image")));
            this.supprimer.Name = "supprimer";
            this.supprimer.ReadOnly = true;
            this.supprimer.Width = 26;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(502, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "EXPORTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eleves_formations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataView_MesEleves);
            this.Controls.Add(this.linkLabel_mes_eleves);
            this.Controls.Add(this.button_select_classes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_select_matieres);
            this.Controls.Add(this.label1);
            this.Name = "eleves_formations";
            this.Size = new System.Drawing.Size(834, 548);
            this.Load += new System.EventHandler(this.eleves_formations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView_MesEleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_select_classes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_select_matieres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_mes_eleves;
        private System.Windows.Forms.DataGridView DataView_MesEleves;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matieres;
        private System.Windows.Forms.DataGridViewImageColumn modifier;
        private System.Windows.Forms.DataGridViewImageColumn supprimer;
        private System.Windows.Forms.Button button1;
    }
}
