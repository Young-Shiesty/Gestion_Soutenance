namespace AppSenSoutenance
{
    partial class frmMDI
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAnnee = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.btnSoutenance = new System.Windows.Forms.Button();
            this.btnMemoire = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.panelSidebar.Controls.Add(this.btnQuitter);
            this.panelSidebar.Controls.Add(this.btnSeDeconnecter);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Controls.Add(this.btnAnnee);
            this.panelSidebar.Controls.Add(this.btnSession);
            this.panelSidebar.Controls.Add(this.btnUtilisateur);
            this.panelSidebar.Controls.Add(this.btnSoutenance);
            this.panelSidebar.Controls.Add(this.btnMemoire);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(281, 600);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(0, 500);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(281, 50);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeDeconnecter.Location = new System.Drawing.Point(0, 550);
            this.btnSeDeconnecter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(281, 50);
            this.btnSeDeconnecter.TabIndex = 6;
            this.btnSeDeconnecter.Text = "Se déconnecter";
            this.btnSeDeconnecter.UseVisualStyleBackColor = true;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(120)))));
            this.panelLogo.Controls.Add(this.lblTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 375);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(281, 125);
            this.panelLogo.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SenSoutenance";
            // 
            // btnAnnee
            // 
            this.btnAnnee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnee.FlatAppearance.BorderSize = 0;
            this.btnAnnee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnee.ForeColor = System.Drawing.Color.White;
            this.btnAnnee.Location = new System.Drawing.Point(0, 300);
            this.btnAnnee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnee.Name = "btnAnnee";
            this.btnAnnee.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAnnee.Size = new System.Drawing.Size(281, 75);
            this.btnAnnee.TabIndex = 1;
            this.btnAnnee.Text = "Années Académiques";
            this.btnAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnee.UseVisualStyleBackColor = true;
            this.btnAnnee.Click += new System.EventHandler(this.btnAnnee_Click);
            // 
            // btnSession
            // 
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSession.ForeColor = System.Drawing.Color.White;
            this.btnSession.Location = new System.Drawing.Point(0, 225);
            this.btnSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(281, 75);
            this.btnSession.TabIndex = 2;
            this.btnSession.Text = "Sessions";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnUtilisateur.Location = new System.Drawing.Point(0, 150);
            this.btnUtilisateur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnUtilisateur.Size = new System.Drawing.Size(281, 75);
            this.btnUtilisateur.TabIndex = 3;
            this.btnUtilisateur.Text = "Utilisateurs";
            this.btnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateur.UseVisualStyleBackColor = true;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click_1);
            // 
            // btnSoutenance
            // 
            this.btnSoutenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoutenance.FlatAppearance.BorderSize = 0;
            this.btnSoutenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoutenance.ForeColor = System.Drawing.Color.White;
            this.btnSoutenance.Location = new System.Drawing.Point(0, 75);
            this.btnSoutenance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSoutenance.Name = "btnSoutenance";
            this.btnSoutenance.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSoutenance.Size = new System.Drawing.Size(281, 75);
            this.btnSoutenance.TabIndex = 4;
            this.btnSoutenance.Text = "Soutenances";
            this.btnSoutenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoutenance.UseVisualStyleBackColor = true;
            this.btnSoutenance.Click += new System.EventHandler(this.btnSoutenance_Click);
            // 
            // btnMemoire
            // 
            this.btnMemoire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoire.FlatAppearance.BorderSize = 0;
            this.btnMemoire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoire.ForeColor = System.Drawing.Color.White;
            this.btnMemoire.Location = new System.Drawing.Point(0, 0);
            this.btnMemoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnMemoire.Size = new System.Drawing.Size(281, 75);
            this.btnMemoire.TabIndex = 4;
            this.btnMemoire.Text = "Mémoire";
            this.btnMemoire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoire.UseVisualStyleBackColor = true;
            this.btnMemoire.Click += new System.EventHandler(this.btnMemoire_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenSoutenance - Tableau de bord";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnAnnee;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMemoire;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnSoutenance;
        private System.Windows.Forms.Button btnSeDeconnecter;
        private System.Windows.Forms.Button btnQuitter;
    }
}