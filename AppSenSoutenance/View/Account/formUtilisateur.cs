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
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public formUtilisateur()
        {
            InitializeComponent();
            ResetForm();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat
            {
                NomUtilisateur = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                TelUtilisateur = txtTel.Text,
                EmailUtilisateur = txtEmail.Text,
                MatriculeCandidat = txtMatricule.Text
            };

            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.candidats.Add(candidat);
            db.SaveChanges();
            ResetForm();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);

            if (candidat == null) return;

            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;

            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.SaveChanges();
            ResetForm();

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat= db.candidats.Find(id);

            if (candidat == null) return;

            db.candidats.Remove(candidat);
            db.SaveChanges();
            ResetForm();



        }


        private void btnPadd_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur
            {
                NomUtilisateur = txtPnom.Text,
                PrenomUtilisateur = txtPprenom.Text,
                TelUtilisateur = txtPtel.Text,
                EmailUtilisateur = txtPemail.Text,
                SpecialiteProfesseur = txtPSpecialite.Text
            };

            professeur.NomUtilisateur = txtPnom.Text;
            professeur.PrenomUtilisateur = txtPprenom.Text;
            professeur.TelUtilisateur = txtPtel.Text;
            professeur.EmailUtilisateur = txtPemail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                professeur.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.professeurs.Add(professeur);
            db.SaveChanges();
            ResetForm();
        }

        private void btnPmod_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);

            if (professeur == null) return;

            professeur.NomUtilisateur = txtPnom.Text;
            professeur.PrenomUtilisateur = txtPprenom.Text;
            professeur.TelUtilisateur = txtPtel.Text;
            professeur.EmailUtilisateur = txtPemail.Text;
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;

            using (MD5 md5Hash = MD5.Create())
            {
                professeur.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.SaveChanges();
            ResetForm();
        }

        private void btnPsup_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);

            if (professeur == null) return;

            db.professeurs.Remove(professeur);
            db.SaveChanges();
            ResetForm();
        }

        private void btnPSelect_Click(object sender, EventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);

            if (professeur == null) return;

            txtPnom.Text = professeur.NomUtilisateur;
            txtPprenom.Text = professeur.PrenomUtilisateur;
            txtPtel.Text = professeur.TelUtilisateur;
            txtPemail.Text = professeur.EmailUtilisateur;
            //txtMotDePasse.Text = professeur.MotDePasse;
            txtPSpecialite.Text = professeur.SpecialiteProfesseur;
        }



        private void btnCadd_Click(object sender, EventArgs e)
        {
            int idDep = int.Parse(txtDepartement.Text);
            ChefDepartement chef = new ChefDepartement

            {
                NomUtilisateur = txtCnom.Text,
                PrenomUtilisateur = txtCprenom.Text,
                TelUtilisateur = txtCtel.Text,
                EmailUtilisateur = txtCemail.Text,
                //Je recupere l'id car on a une clee etrangere
                IdDepartement = idDep
                
            };

            using (MD5 md5Hash = MD5.Create())
            {
                chef.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.chefsDepartements.Add(chef);
            db.SaveChanges();
            ResetForm();
        }

        private void btnCmod_Click(object sender, EventArgs e)
        {
            int idDep = int.Parse(txtDepartement.Text);

            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement  chef = db.chefsDepartements.Find(id);

            if (chef == null) return;

            chef.NomUtilisateur = txtPnom.Text;
            chef.PrenomUtilisateur = txtPprenom.Text;
            chef.TelUtilisateur = txtPtel.Text;
            chef.EmailUtilisateur = txtPemail.Text;
            chef.IdDepartement = idDep;

            using (MD5 md5Hash = MD5.Create())
            {
                chef.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.SaveChanges();
            ResetForm();
        }



        private void ResetForm()
        {
            dgUtilisateur.DataSource = db.utilisateurs
                .Select(u => new
                {
                    u.IdUtilisateur,
                    u.NomUtilisateur,
                    u.PrenomUtilisateur,
                    u.TelUtilisateur,
                    u.EmailUtilisateur
                })
                .ToList();
        }

        private void btnCsup_Click(object sender, EventArgs e)
        {
         
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            ChefDepartement chef = db.chefsDepartements.Find(id);

            if (chef == null) return;

            db.chefsDepartements.Remove(chef);
            db.SaveChanges();
            ResetForm();
        }

    
}
}
