namespace AppSenSoutenance.Views.Parametre
{
    partial class frmMemoire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgMemoire = new System.Windows.Forms.DataGridView();
            this.txtSujetMemoire = new System.Windows.Forms.TextBox();
            this.sujet = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.anneeacademique = new System.Windows.Forms.Label();
            this.cbbSession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMemoire
            // 
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoire.Location = new System.Drawing.Point(520, 115);
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.RowHeadersWidth = 51;
            this.dgMemoire.RowTemplate.Height = 24;
            this.dgMemoire.Size = new System.Drawing.Size(525, 424);
            this.dgMemoire.TabIndex = 1;
            // 
            // txtSujetMemoire
            // 
            this.txtSujetMemoire.Location = new System.Drawing.Point(12, 144);
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(289, 22);
            this.txtSujetMemoire.TabIndex = 13;
            // 
            // sujet
            // 
            this.sujet.AutoSize = true;
            this.sujet.Location = new System.Drawing.Point(12, 115);
            this.sujet.Name = "sujet";
            this.sujet.Size = new System.Drawing.Size(93, 16);
            this.sujet.TabIndex = 14;
            this.sujet.Text = "Sujet Memoire";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(12, 247);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(286, 24);
            this.cbbAnneeAcademique.TabIndex = 17;
            // 
            // anneeacademique
            // 
            this.anneeacademique.AutoSize = true;
            this.anneeacademique.Location = new System.Drawing.Point(9, 215);
            this.anneeacademique.Name = "anneeacademique";
            this.anneeacademique.Size = new System.Drawing.Size(126, 16);
            this.anneeacademique.TabIndex = 16;
            this.anneeacademique.Text = "Annee Academique";
            // 
            // cbbSession
            // 
            this.cbbSession.FormattingEnabled = true;
            this.cbbSession.Location = new System.Drawing.Point(12, 346);
            this.cbbSession.Name = "cbbSession";
            this.cbbSession.Size = new System.Drawing.Size(286, 24);
            this.cbbSession.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Session";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(257, 444);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 38);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 38);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(300, 48);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(221, 38);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmMemoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.anneeacademique);
            this.Controls.Add(this.txtSujetMemoire);
            this.Controls.Add(this.sujet);
            this.Controls.Add(this.dgMemoire);
            this.Name = "frmMemoire";
            this.Text = "frmMemoire";
            this.Load += new System.EventHandler(this.frmMemoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMemoire;
        private System.Windows.Forms.TextBox txtSujetMemoire;
        private System.Windows.Forms.Label sujet;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Label anneeacademique;
        private System.Windows.Forms.ComboBox cbbSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
    }
}