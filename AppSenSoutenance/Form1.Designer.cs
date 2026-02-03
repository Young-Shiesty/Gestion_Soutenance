namespace AppSenSoutenance
{
    partial class frmConnexion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnexion));
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.labelTitle.Location = new System.Drawing.Point(242, 170);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(398, 45);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "ConnectionSenSoutenace";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.Black;
            this.txtIdentifiant.Location = new System.Drawing.Point(211, 287);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(425, 39);
            this.txtIdentifiant.TabIndex = 2;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.txtIdentifiant_TextChanged);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMotDePasse.ForeColor = System.Drawing.Color.Black;
            this.txtMotDePasse.Location = new System.Drawing.Point(211, 378);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(425, 39);
            this.txtMotDePasse.TabIndex = 1;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.txtMotDePasse_TextChanged);
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(457, 451);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(183, 45);
            this.btnSeConnecter.TabIndex = 0;
            this.btnSeConnecter.Text = "Se Connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(352, 53);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(120, 75);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 4;
            this.pictureLogo.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Blue;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(215, 451);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(183, 45);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(211, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identifiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(211, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mot De Passe";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(795, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenSoutenance::Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

}

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
