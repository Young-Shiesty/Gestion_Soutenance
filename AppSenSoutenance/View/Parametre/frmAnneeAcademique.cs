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

namespace AppSenSoutenance.View.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
         }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            //il permet de prendre toutes les annees academiques de la base de donnee et de les afficher dans le datagridview
            dgAnneeAcademique.DataSource = db.anneesAcademiques.ToList();

        }

        private bool ChampsValides()
        {
            if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLibelleAnneeAcademique.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAnneeAcademiqueVal.Text))
            {
                MessageBox.Show("Veuillez saisir l'année.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnneeAcademiqueVal.Focus();
                return false;
            }
            if (!int.TryParse(txtAnneeAcademiqueVal.Text, out _))
            {
                MessageBox.Show("L'année doit être un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnneeAcademiqueVal.Focus();
                return false;
            }
            return true;
        }
        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = db.anneesAcademiques.ToList();   
            txtLibelleAnneeAcademique.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ChampsValides()) return;
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };
            db.anneesAcademiques.Add(anneeAcademique);
            db.SaveChanges();
            Effacer();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une année à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ChampsValides()) return;

            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneesAcademiques.Find(id);  
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une année à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cette année ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());    
            AnneeAcademique anneeAcademique = db.anneesAcademiques.Find(id);
            db.anneesAcademiques.Remove(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void dgAnneeAcademique_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }

    }
}
