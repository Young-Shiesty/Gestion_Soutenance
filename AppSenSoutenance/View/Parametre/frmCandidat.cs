using AppSenSoutenance.Migrations;
using AppSenSoutenance.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Parametre
{
    public partial class frmCandidat : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public frmCandidat()
        {
            InitializeComponent();
        }
        public void Effacer()
        {
            txtPrename.Clear();
            txtName.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            dgCandidat.DataSource = db.utilisateurs.ToList();
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Candidat candidat = new Candidat();
            candidat.NomUtilisateur = txtName.Text;
            candidat.PrenomUtilisateur = txtPrename.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MotDePasse = txtPassword.Text;
            db.candidats.Add(candidat);
            db.SaveChanges();
            Effacer();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCandidat.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);
            candidat.NomUtilisateur = txtName.Text;
            candidat.PrenomUtilisateur = txtPrename.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.EmailUtilisateur = txtEmail.Text;
            candidat.MotDePasse = txtPassword.Text;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCandidat.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = db.candidats.Find(id);
            db.candidats.Remove(candidat);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtName.Text = dgCandidat.CurrentRow.Cells[1].Value.ToString();
            txtPrename.Text = dgCandidat.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgCandidat.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgCandidat.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dgCandidat.CurrentRow.Cells[5].Value.ToString();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
