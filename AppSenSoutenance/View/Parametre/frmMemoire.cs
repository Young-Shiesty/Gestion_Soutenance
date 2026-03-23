using AppSenSoutenance.Models;
using AppSenSoutenance.Shered;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Parametre
{
    public partial class frmMemoire : Form
    {
        public frmMemoire()
        {
            InitializeComponent();
        }
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        FillerList filler = new FillerList();
        private void frmMemoire_Load(object sender, EventArgs e)
        {
            
            Effacer(); 
        }
        private bool ChampsValides()
        {
            if (string.IsNullOrWhiteSpace(txtSujetMemoire.Text))
            {
                MessageBox.Show("Veuillez saisir le sujet du mémoire.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSujetMemoire.Focus();
                return false;
            }

            if (cbbAnneeAcademique.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbAnneeAcademique.Focus();
                return false;
            }

            if (cbbSession.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une session.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbSession.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ChampsValides()) return;
            Memoire memoire = new Memoire();
            memoire.SujetMemoire = txtSujetMemoire.Text; 
            memoire.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);
            memoire.IdSession = Convert.ToInt32(cbbSession.SelectedValue); 

            db.memoires.Add(memoire);
            db.SaveChanges();

            Effacer();
        }


        private void Effacer()
        {
            txtSujetMemoire.Clear();
            // Met à jour le DataGrid
            //String libelle = db.session.Find(a.IdSession).LibelleSession;
            //dgMemoire.DataSource = db.memoires.Select(
            //     a => new {
            //         a.IdMemoire,
            //         a.SujetMemoire,
            //         //db.session.Find(a.IdSession).LibelleSession, 

            //     }).ToList(); 
            dgMemoire.DataSource = (from m in db.memoires 
                                    join s in db.session on m.IdSession equals s.IdSession
                                    select new
                                    {
                                        m.IdMemoire,
                                        m.SujetMemoire,
                                        LibelleSession = s.LibelleSession
                                    }).ToList(); 


            cbbAnneeAcademique.DataSource = filler.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            
            cbbSession.DataSource = filler.FillSession();
            cbbSession.DisplayMember = "Text";
            cbbSession.ValueMember = "Value";
        }
        private void dgMemoire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            int id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire memoire = db.memoires.Find(id);
            if (memoire == null) return;
            txtSujetMemoire.Text = memoire.SujetMemoire;
            cbbAnneeAcademique.SelectedValue = memoire.IdAnneeAcademique;
            cbbSession.SelectedValue = memoire.IdSession;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un mémoire à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer ce mémoire ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            int? id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire memoire = db.memoires.Find(id);
            db.memoires.Remove(memoire);
            db.SaveChanges();
            Effacer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un mémoire à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ChampsValides()) return;

            int id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire memoire = db.memoires.Find(id);

            if (memoire == null) return;

            memoire.SujetMemoire = txtSujetMemoire.Text;
            memoire.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);
            memoire.IdSession = Convert.ToInt32(cbbSession.SelectedValue);

            db.SaveChanges();
            Effacer();
        }
    }
}
