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

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            dgMemoire.DataSource = db.memoires.Select(
                 a => new {
                     a.IdMemoire,
                     a.SujetMemoire,
                     a.IdSession, 
                 }).ToList(); 

            // Année académique
            cbbAnneeAcademique.DataSource = filler.fillAnneeAcademique();
            cbbAnneeAcademique.DisplayMember = "Text";
            cbbAnneeAcademique.ValueMember = "Value";
            

            // Session
            cbbSession.DataSource = filler.FillSession();
            cbbSession.DisplayMember = "Text";
            cbbSession.ValueMember = "Value";
            
        }




        private void btnSelect_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire memoire = db.memoires.Find(id);
            txtSujetMemoire.Text = memoire.SujetMemoire;

            cbbAnneeAcademique.SelectedValue = memoire.IdAnneeAcademique;
           
            cbbSession.SelectedValue = memoire.IdSession;
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire memoire = db.memoires.Find(id);
            db.memoires.Remove(memoire);
            db.SaveChanges();
            Effacer();
        }
    }
}
