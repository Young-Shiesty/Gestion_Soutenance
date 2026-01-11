namespace AppSenSoutenance.View.Account
{
    partial class formUtilisateur
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.tabChefDepatrement = new System.Windows.Forms.TabPage();
            this.dgCandidat = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepatrement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.Controls.Add(this.txtMatricule);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtEmail);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtTel);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtPrename);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtName);
            this.tabCandidat.Controls.Add(this.label1);
            this.tabCandidat.Location = new System.Drawing.Point(4, 29);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(384, 437);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candidat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(25, 392);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(251, 26);
            this.txtMatricule.TabIndex = 46;
            this.txtMatricule.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "&Matricule";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(25, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 26);
            this.txtEmail.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "&Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(25, 223);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(251, 26);
            this.txtTel.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "&Tel";
            // 
            // txtPrename
            // 
            this.txtPrename.Location = new System.Drawing.Point(25, 138);
            this.txtPrename.Name = "txtPrename";
            this.txtPrename.Size = new System.Drawing.Size(251, 26);
            this.txtPrename.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "&Prenom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(25, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 26);
            this.txtName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "&Nom";
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.Location = new System.Drawing.Point(4, 29);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(384, 437);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            // 
            // tabChefDepatrement
            // 
            this.tabChefDepatrement.Location = new System.Drawing.Point(4, 29);
            this.tabChefDepatrement.Name = "tabChefDepatrement";
            this.tabChefDepatrement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDepatrement.Size = new System.Drawing.Size(384, 437);
            this.tabChefDepatrement.TabIndex = 2;
            this.tabChefDepatrement.Text = "Chef departement";
            this.tabChefDepatrement.UseVisualStyleBackColor = true;
            // 
            // dgCandidat
            // 
            this.dgCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCandidat.Location = new System.Drawing.Point(472, 41);
            this.dgCandidat.Name = "dgCandidat";
            this.dgCandidat.RowHeadersWidth = 62;
            this.dgCandidat.RowTemplate.Height = 28;
            this.dgCandidat.Size = new System.Drawing.Size(293, 437);
            this.dgCandidat.TabIndex = 27;
            // 
            // formUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 504);
            this.ControlBox = false;
            this.Controls.Add(this.dgCandidat);
            this.Controls.Add(this.tabControl1);
            this.Name = "formUtilisateur";
            this.Text = "Gestion Des Utilisateur";
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepatrement;
        private System.Windows.Forms.DataGridView dgCandidat;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}