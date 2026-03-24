using AppSenSoutenance.Shered;
using System;
using static System.Net.Mime.MediaTypeNames;

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

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.panelCarte = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panelCarte.SuspendLayout();
            this.SuspendLayout();

            // panelCarte
            this.panelCarte.BackColor = System.Drawing.Color.White;
            this.panelCarte.Controls.Add(this.lblTitre);
            this.panelCarte.Controls.Add(this.label1);
            this.panelCarte.Controls.Add(this.txtIdentifiant);
            this.panelCarte.Controls.Add(this.label2);
            this.panelCarte.Controls.Add(this.txtMotDePasse);
            this.panelCarte.Controls.Add(this.btnSeConnecter);
            this.panelCarte.Controls.Add(this.btnQuitter);
            this.panelCarte.Location = new System.Drawing.Point(42, 47);
            this.panelCarte.Name = "panelCarte";
            this.panelCarte.Size = new System.Drawing.Size(482, 533);

            // lblTitre
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblTitre.Location = new System.Drawing.Point(56, 38);
            this.lblTitre.Size = new System.Drawing.Size(315, 50);
            this.lblTitre.Text = "SenSoutenance";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label1
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label1.Location = new System.Drawing.Point(45, 144);
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.Text = "Identifiant";

            // txtIdentifiant
            this.txtIdentifiant.BackColor = System.Drawing.Color.White;
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdentifiant.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtIdentifiant.Location = new System.Drawing.Point(45, 172);
            this.txtIdentifiant.Size = new System.Drawing.Size(337, 34);

            // label2
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.label2.Location = new System.Drawing.Point(45, 244);
            this.label2.Size = new System.Drawing.Size(338, 25);
            this.label2.Text = "Mot de passe";

            // txtMotDePasse
            this.txtMotDePasse.BackColor = System.Drawing.Color.White;
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotDePasse.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtMotDePasse.Location = new System.Drawing.Point(45, 272);
            this.txtMotDePasse.Size = new System.Drawing.Size(337, 34);
            this.txtMotDePasse.UseSystemPasswordChar = true;

            // btnSeConnecter
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(113, 360);
            this.btnSeConnecter.Size = new System.Drawing.Size(235, 52);
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);

            // btnQuitter
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderSize = 1;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnQuitter.Location = new System.Drawing.Point(113, 440);
            this.btnQuitter.Size = new System.Drawing.Size(235, 44);
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);

            // frmConnexion
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.ClientSize = new System.Drawing.Size(578, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panelCarte);
            this.Name = "frmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenSoutenance :: Connexion";
            this.Load += new System.EventHandler(this.frmConnexion_Load);

            this.panelCarte.ResumeLayout(false);
            this.panelCarte.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCarte;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Button btnQuitter;
    }
}