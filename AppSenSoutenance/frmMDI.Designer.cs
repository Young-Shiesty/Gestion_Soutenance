namespace AppSenSoutenance
{
    partial class frmMDI
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSeDeconnecter = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
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
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
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
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 600);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnQuitter.Location = new System.Drawing.Point(0, 500);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(240, 50);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "✖  Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // btnSeDeconnecter
            // 
            this.btnSeDeconnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeDeconnecter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSeDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnSeDeconnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSeDeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeDeconnecter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeDeconnecter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnSeDeconnecter.Location = new System.Drawing.Point(0, 550);
            this.btnSeDeconnecter.Name = "btnSeDeconnecter";
            this.btnSeDeconnecter.Size = new System.Drawing.Size(240, 50);
            this.btnSeDeconnecter.TabIndex = 1;
            this.btnSeDeconnecter.Text = "⬅  Se déconnecter";
            this.btnSeDeconnecter.UseVisualStyleBackColor = false;
            this.btnSeDeconnecter.Click += new System.EventHandler(this.btnSeDeconnecter_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panelLogo.Controls.Add(this.lblTitle);
            this.panelLogo.Controls.Add(this.lblSousTitre);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 275);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 100);
            this.panelLogo.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SenSoutenance";
            // 
            // lblSousTitre
            // 
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblSousTitre.Location = new System.Drawing.Point(15, 55);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(210, 20);
            this.lblSousTitre.TabIndex = 1;
            this.lblSousTitre.Text = "Gestion des soutenances";
            // 
            // btnAnnee
            // 
            this.btnAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAnnee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnee.FlatAppearance.BorderSize = 0;
            this.btnAnnee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnAnnee.Location = new System.Drawing.Point(0, 220);
            this.btnAnnee.Name = "btnAnnee";
            this.btnAnnee.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAnnee.Size = new System.Drawing.Size(240, 55);
            this.btnAnnee.TabIndex = 3;
            this.btnAnnee.Text = "📅  Années Académiques";
            this.btnAnnee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnee.UseVisualStyleBackColor = false;
            this.btnAnnee.Click += new System.EventHandler(this.btnAnnee_Click_1);
            // 
            // btnSession
            // 
            this.btnSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnSession.Location = new System.Drawing.Point(0, 165);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(240, 55);
            this.btnSession.TabIndex = 4;
            this.btnSession.Text = "📋  Sessions";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = false;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click_1);
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnUtilisateur.Location = new System.Drawing.Point(0, 110);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUtilisateur.Size = new System.Drawing.Size(240, 55);
            this.btnUtilisateur.TabIndex = 5;
            this.btnUtilisateur.Text = "👤  Utilisateurs";
            this.btnUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateur.UseVisualStyleBackColor = false;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // btnSoutenance
            // 
            this.btnSoutenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSoutenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoutenance.FlatAppearance.BorderSize = 0;
            this.btnSoutenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSoutenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSoutenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnSoutenance.Location = new System.Drawing.Point(0, 55);
            this.btnSoutenance.Name = "btnSoutenance";
            this.btnSoutenance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSoutenance.Size = new System.Drawing.Size(240, 55);
            this.btnSoutenance.TabIndex = 6;
            this.btnSoutenance.Text = "🎓  Soutenances";
            this.btnSoutenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoutenance.UseVisualStyleBackColor = false;
            this.btnSoutenance.Click += new System.EventHandler(this.btnSoutenance_Click_1);
            // 
            // btnMemoire
            // 
            this.btnMemoire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnMemoire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemoire.FlatAppearance.BorderSize = 0;
            this.btnMemoire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemoire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMemoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMemoire.Location = new System.Drawing.Point(0, 0);
            this.btnMemoire.Name = "btnMemoire";
            this.btnMemoire.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMemoire.Size = new System.Drawing.Size(240, 55);
            this.btnMemoire.TabIndex = 7;
            this.btnMemoire.Text = "📝  Mémoires";
            this.btnMemoire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemoire.UseVisualStyleBackColor = false;
            this.btnMemoire.Click += new System.EventHandler(this.btnMemoire_Click_1);
            // 
            // frmMDI
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenSoutenance - Tableau de bord";
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Button btnAnnee;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnSoutenance;
        private System.Windows.Forms.Button btnMemoire;
        private System.Windows.Forms.Button btnSeDeconnecter;
        private System.Windows.Forms.Button btnQuitter;
    }
}