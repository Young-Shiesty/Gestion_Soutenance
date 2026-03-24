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
        BdSenSoutenanceContext db;

        public formUtilisateur()
        {
            InitializeComponent();
        }

        private void formUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                db = new BdSenSoutenanceContext();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion: " + ex.Message);
                this.Close();
            }
        }
        private bool ChampVide(params TextBox[] champs)
        {
            foreach (TextBox champ in champs)
            {
                if (string.IsNullOrWhiteSpace(champ.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    champ.Focus(); 
                    return true;
                }
            }
            return false;
        }

        private string GenererMatricule()
        {
            string annee = DateTime.Now.Year.ToString();
            int nombre = db.candidats.Count();
            int prochainNumero = nombre + 1;
            string matricule = "MAT" + annee + prochainNumero.ToString("D5");
            return matricule;
        }
            
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ChampVide(txtNom, txtPrenom, txtTel, txtEmail)) return;
            Candidat candidat = new Candidat();

            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MatriculeCandidat = GenererMatricule();
                
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }

            db.candidats.Add(candidat);
            db.SaveChanges();
            txtMatricule.ReadOnly = true;
            txtMatricule.Text = candidat.MatriculeCandidat;
            ResetForm();

        }



        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgUtilisateur.CurrentRow == null) return;

            if (ChampVide(txtNom, txtPrenom, txtTel, txtEmail)) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);

            if (candidat == null) return;

            candidat.NomUtilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
            }
            txtMatricule.ReadOnly = true;
            txtMatricule.Text = candidat.MatriculeCandidat;
            db.SaveChanges();
            ResetForm();

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

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
            if (ChampVide(txtPnom, txtPprenom, txtPtel, txtPemail, txtPSpecialite)) return;
            Professeur professeur = new Professeur
            {
                NomUtilisateur = txtPnom.Text,
                PrenomUtilisateur = txtPprenom.Text,
                TelUtilisateur = txtPtel.Text,
                EmailUtilisateur = txtPemail.Text,
                SpecialiteProfesseur = txtPSpecialite.Text
            };

           
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
            if (ChampVide(txtPnom, txtPprenom, txtPtel, txtPemail, txtPSpecialite)) return;
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
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = db.professeurs.Find(id);

            if (professeur == null) return;

            db.professeurs.Remove(professeur);
            db.SaveChanges();
            ResetForm();
        }



        private void btnCadd_Click(object sender, EventArgs e)
        {

            if (ChampVide(txtCnom, txtCprenom, txtCtel, txtCemail, txtDepartement)) return;

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

            if (ChampVide(txtCnom, txtCprenom, txtCtel, txtCemail, txtDepartement)) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement  chef = db.chefsDepartements.Find(id);

            if (chef == null) return;

            chef.NomUtilisateur = txtCnom.Text;
            chef.PrenomUtilisateur = txtCprenom.Text;
            chef.TelUtilisateur = txtCtel.Text;
            chef.EmailUtilisateur = txtCemail.Text;
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
            if (db == null) return;
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement: " + ex.Message);
            }
        }

        private void btnCsup_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cet élément ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;
            if (dgUtilisateur.CurrentRow == null) return;

            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            ChefDepartement chef = db.chefsDepartements.Find(id);

            if (chef == null) return;

            db.chefsDepartements.Remove(chef);
            db.SaveChanges();
            ResetForm();
        }

        private void dgUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUtilisateur.CurrentRow == null) return;
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            Candidat candidat = db.candidats.Find(id);
            if (candidat != null)
            {
                txtNom.Text = candidat.NomUtilisateur;
                txtPrenom.Text = candidat.PrenomUtilisateur;
                txtTel.Text = candidat.TelUtilisateur;
                txtEmail.Text = candidat.EmailUtilisateur;
                txtMatricule.Text = candidat.MatriculeCandidat;
                txtMatricule.ReadOnly = true; 
                return;
            }

            Professeur professeur = db.professeurs.Find(id);
            if (professeur != null)
            {
                txtPnom.Text = professeur.NomUtilisateur;
                txtPprenom.Text = professeur.PrenomUtilisateur;
                txtPtel.Text = professeur.TelUtilisateur;
                txtPemail.Text = professeur.EmailUtilisateur;
                txtPSpecialite.Text = professeur.SpecialiteProfesseur;
                return;
            }

            ChefDepartement chef = db.chefsDepartements.Find(id);
            if (chef != null)
            {
                txtCnom.Text = chef.NomUtilisateur;
                txtCprenom.Text = chef.PrenomUtilisateur;
                txtCtel.Text = chef.TelUtilisateur;
                txtCemail.Text = chef.EmailUtilisateur;
                txtDepartement.Text = chef.IdDepartement.ToString();
            }

        }
    }
}
