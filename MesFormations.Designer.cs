namespace WindowsFormsApp4
{
    partial class MesFormations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matieres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mes Formations de langue";
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.AllowUserToResizeRows = false;
            this.dataview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.ColumnHeadersHeight = 35;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Classe,
            this.Matieres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataview.Location = new System.Drawing.Point(40, 105);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataview.RowHeadersVisible = false;
            this.dataview.RowTemplate.Height = 30;
            this.dataview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataview.Size = new System.Drawing.Size(754, 404);
            this.dataview.TabIndex = 16;
            // 
            // index
            // 
            this.index.HeaderText = "";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 30;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Niveaux";
            this.Classe.MaxInputLength = 5;
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // Matieres
            // 
            this.Matieres.HeaderText = "Formations";
            this.Matieres.MaxInputLength = 100;
            this.Matieres.Name = "Matieres";
            this.Matieres.ReadOnly = true;
            // 
            // MesFormations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.label1);
            this.Name = "MesFormations";
            this.Size = new System.Drawing.Size(834, 548);
            this.Load += new System.EventHandler(this.MesFormations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matieres;
    }
}
