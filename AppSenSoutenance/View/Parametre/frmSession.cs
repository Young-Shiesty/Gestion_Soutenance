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
            Effacer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            dgSession.DataSource = db.session.ToList();
            cbbAnneeAcademique.DataSource = filler.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            txtSession.Focus();
        } 

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);
            session.LibelleSession= txtSession.Text;
            session.IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue;
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int?id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.session.Find(id);
            db.session.Remove(session);
            db.SaveChanges();
            Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = db.session.ToList();

            if (!string.IsNullOrEmpty(txtRSession.Text)){
                liste = liste.Where(s => s.LibelleSession.Contains(txtRSession.Text)).ToList();
            }
            if(txtRAnneeAcademique.Text != "")
            {
                liste = liste.Where(s => s.AnneeAcademique.LibelleAnneeAcademique.Contains(txtRAnneeAcademique.Text)).ToList();
            }
            
            dgSession.DataSource = liste;

        }

      
    }
}
