using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.views.parametre
{
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        private void label2_Click(object sender, EventArgs e)
        {
            dgSoutenance.DataSource = db.soutenances.ToList();
        }

        private bool ChampsValides()
        {
            if (string.IsNullOrWhiteSpace(txtDateSoutenance.Text))
            {
                MessageBox.Show("Veuillez saisir la date de soutenance.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDateSoutenance.Focus();
                return false;
            }
            if (!DateTime.TryParse(txtDateSoutenance.Text, out _))
            {
                MessageBox.Show("La date saisie n'est pas valide. Format attendu : jj/mm/aaaa", "Date invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateSoutenance.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLieuSoutenance.Text))
            {
                MessageBox.Show("Veuillez saisir le lieu de soutenance.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLieuSoutenance.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtResultatSoutenance.Text))
            {
                MessageBox.Show("Veuillez saisir le résultat.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResultatSoutenance.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMentionSoutenance.Text))
            {
                MessageBox.Show("Veuillez saisir la mention.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMentionSoutenance.Focus();
                return false;
            }
            return true;
        }

        //la fonction effacer
        public void effacer()
        {
            txtDateSoutenance.Clear();
            txtLieuSoutenance.Clear();
            txtResultatSoutenance.Clear();
            txtMentionSoutenance.Clear();
            txtObservationSoutenance.Clear();
            dgSoutenance.DataSource = db.soutenances.ToList();
            txtDateSoutenance.Focus();

        }
        //fonction ajouter soutenance  en convertissant la fonction date time
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            DateTime dateSoutenance;

            if (!DateTime.TryParse(txtDateSoutenance.Text, out dateSoutenance))
            {
                return;
            }
            if (!ChampsValides()) return;
            Soutenance soutenance = new Soutenance()
            {
                DateSoutenance = dateSoutenance,
                LieuSoutenance = txtLieuSoutenance.Text,
                ResultatSoutenance = txtResultatSoutenance.Text,
                MentionSoutenance = txtMentionSoutenance.Text,
                ObservationsSoutenance = txtObservationSoutenance.Text
            };

            db.soutenances.Add(soutenance);
            db.SaveChanges();
            effacer();

        }
        //pour modifier  une soutenance

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une soutenance à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ChampsValides()) return;
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            //La méthode Find() permet de chercher un objet spécifique dans la collection
            //ou la table (ici db.Soutenances) en fonction de son identifiant (id).
            //En d'autres termes, elle permet de retrouver l'enregistrement dont l'identifiant
            //correspond à la valeur de id passé en paramètre.
           
            Soutenance soutenance = db.soutenances.Find(id);
            soutenance.LieuSoutenance = txtLieuSoutenance.Text;
            soutenance.ResultatSoutenance = txtResultatSoutenance.Text;
            soutenance.MentionSoutenance = txtMentionSoutenance.Text;
            soutenance.ObservationsSoutenance = txtObservationSoutenance.Text;
            db.SaveChanges();
            effacer();
        }
        //supprimer une soutenance 
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une soutenance à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cette soutenance ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = db.soutenances.Find(id);
            db.soutenances.Remove(soutenance);
            db.SaveChanges();
            effacer();
        }
        //pour selectionner une soutenance

        private void dgSoutenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            int id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = db.soutenances.Find(id);

            if (soutenance == null) return;

            txtDateSoutenance.Text = soutenance.DateSoutenance.ToString("dd/MM/yyyy");
            txtLieuSoutenance.Text = soutenance.LieuSoutenance;
            txtResultatSoutenance.Text = soutenance.ResultatSoutenance;
            txtMentionSoutenance.Text = soutenance.MentionSoutenance;
            txtObservationSoutenance.Text = soutenance.ObservationsSoutenance;
        }

        
    }
}
