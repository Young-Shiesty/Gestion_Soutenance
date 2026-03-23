using AppSenSoutenance.Models;
using AppSenSoutenance.Shered;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSenSoutenance.View.Parametre
{
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
            //Test le projet
        }

        BdSenSoutenanceContext db = new BdSenSoutenanceContext();   
        FillerList filler = new FillerList();  
        private void frmSession_Load(object sender, EventArgs e)
        {
            //dgSession.DataSource = (from m in db.session
            //                        join s in db.anneesAcademiques on m.IdAnneeAcademique equals s.IdAnneeAcademique
            //                        select new
            //                        {
            //                            m.IdSession,
            //                            m.LibelleSession,
            //                            AnneeAcademique = m.AnneeAcademique
            //                        }).ToList();
            //                        
            dgSession.DataSource = db.session.Select(
                 a => new
                 {
                     a.IdSession,
                     a.LibelleSession,
                     a.AnneeAcademique.LibelleAnneeAcademique
                     //db.session.Find(a.IdSession).LibelleSession, 

                 }).ToList();
            Effacer();
        }

        private bool ChampsValides()
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé de la session.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSession.Focus();
                return false;
            }

            if (cbbAnneeAcademique.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbAnneeAcademique.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ChampsValides()) return;
            Session session = new Session();
            session.LibelleSession = txtSession.Text;
            session.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.session.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedValue = "";
           // dgSession.DataSource = db.session.ToList();
            cbbAnneeAcademique.DataSource = filler.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        }

        private void dgSession_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);

            if (session == null) return;

            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une session à modifier.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ChampsValides()) return;

            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);
            session.LibelleSession= txtSession.Text;
            session.IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une session à supprimer.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment supprimer cette session ?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;
            int?id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);
            db.session.Remove(session); 
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRSession.Text) &&
       string.IsNullOrWhiteSpace(txtRAnneeAcademique.Text))
            {
                MessageBox.Show("Veuillez saisir au moins un critère de recherche.", "Recherche vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRSession.Focus();
                return;
            }
            var liste = db.session.ToList();
            if (!string.IsNullOrWhiteSpace(txtRSession.Text))
            {
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }
            if (!string.IsNullOrWhiteSpace(txtRAnneeAcademique.Text))
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRAnneeAcademique.Text)).ToList();
            }
            if (liste.Count == 0)
            {
                MessageBox.Show("Aucun résultat trouvé.", "Recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgSession.DataSource = liste;
        }

      
    }
}
