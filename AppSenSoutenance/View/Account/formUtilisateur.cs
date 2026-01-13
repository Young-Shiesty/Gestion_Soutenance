using AppSenSoutenance.Migrations;
using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppSenSoutenance.View.Account
{
    public partial class formUtilisateur : Form
    {
        public formUtilisateur()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            db.candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }
        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.utilisateurs.Select(
                a => new { a.IdUtilisateur,a.NomUtilisateur,a.PrenomUtilisateur,
                a.TelUtilisateur,a.EmailUtilisateur}).ToList();
        }

        private void btnPadd_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur();

            professeur.NomUtilisateur = txtPnom.Text;
            professeur.PrenomUtilisateur = txtPprenom.Text;
            professeur.TelUtilisateur = txtPtel.Text;
            professeur.EmailUtilisateur = txtPemail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                professeur.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            db.professeurs.Add(professeur);
            db.SaveChanges();
            ResetForm();
        }

        private void btnPmod_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            professeur.NomUtilisateur = txtPnom.Text;
            professeur.PrenomUtilisateur = txtPprenom.Text;
            professeur.TelUtilisateur = txtPtel.Text;
            professeur.EmailUtilisateur = txtPemail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                professeur.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            db.SaveChanges();
            ResetForm() ;
        }

        private void btnPsup_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            db.professeurs.Remove(professeur);
            db.SaveChanges();
            ResetForm();
        }

        private void btnPSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);
            txtPnom.Text = professeur.NomUtilisateur;
            txtPprenom.Text = professeur.PrenomUtilisateur;
            txtPtel.Text = professeur.TelUtilisateur;
            txtPemail.Text = professeur.EmailUtilisateur;
            //txtMotDePasse.Text = professeur.MotDePasse;
            txtPSpecialite.Text = professeur.SpecialiteProfesseur;
        }

        private void formUtilisateur_Load(object sender, EventArgs e)
        {
            dgUtilisateur.DataSource = db.utilisateurs.Select(
                a => new {
                    a.IdUtilisateur,
                    a.NomUtilisateur,
                    a.PrenomUtilisateur,
                    a.TelUtilisateur,
                    a.EmailUtilisateur
                }).ToList(); 
        }
    }
}
