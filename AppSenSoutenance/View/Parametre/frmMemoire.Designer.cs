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
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMemoire
            // 
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemoire.Location = new System.Drawing.Point(473, 51);
            this.dgMemoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.RowHeadersWidth = 51;
            this.dgMemoire.RowTemplate.Height = 24;
            this.dgMemoire.Size = new System.Drawing.Size(472, 387);
            this.dgMemoire.TabIndex = 1;
            this.dgMemoire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemoire_CellClick);
            // 
            // txtSujetMemoire
            // 
            this.txtSujetMemoire.Location = new System.Drawing.Point(41, 113);
            this.txtSujetMemoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(325, 26);
            this.txtSujetMemoire.TabIndex = 13;
            // 
            // sujet
            // 
            this.sujet.AutoSize = true;
            this.sujet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.sujet.Location = new System.Drawing.Point(41, 62);
            this.sujet.Name = "sujet";
            this.sujet.Size = new System.Drawing.Size(111, 20);
            this.sujet.TabIndex = 14;
            this.sujet.Text = "Sujet Memoire";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(41, 221);
            this.cbbAnneeAcademique.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(321, 28);
            this.cbbAnneeAcademique.TabIndex = 17;
            // 
            // anneeacademique
            // 
            this.anneeacademique.AutoSize = true;
            this.anneeacademique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.anneeacademique.Location = new System.Drawing.Point(37, 170);
            this.anneeacademique.Name = "anneeacademique";
            this.anneeacademique.Size = new System.Drawing.Size(149, 20);
            this.anneeacademique.TabIndex = 16;
            this.anneeacademique.Text = "Annee Academique";
            // 
            // cbbSession
            // 
            this.cbbSession.FormattingEnabled = true;
            this.cbbSession.Location = new System.Drawing.Point(41, 331);
            this.cbbSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbSession.Name = "cbbSession";
            this.cbbSession.Size = new System.Drawing.Size(321, 28);
            this.cbbSession.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label3.Location = new System.Drawing.Point(37, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Session";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(303, 390);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 48);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(41, 390);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 48);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(172, 390);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 48);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmMemoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(979, 481);
            this.ControlBox = false;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.anneeacademique);
            this.Controls.Add(this.txtSujetMemoire);
            this.Controls.Add(this.sujet);
            this.Controls.Add(this.dgMemoire);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btnEdit;
    }
}