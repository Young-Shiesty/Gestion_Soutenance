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
        public void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
            dgAnneeAcademique.DataSource = db.anneesAcademiques.ToList();   
            txtLibelleAnneeAcademique.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());
            AnneeAcademique anneeAcademique = db.anneesAcademiques.Find(id);  
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);
            db.SaveChanges();
            Effacer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString());    
            AnneeAcademique anneeAcademique = db.anneesAcademiques.Find(id);
            db.anneesAcademiques.Remove(anneeAcademique);
            db.SaveChanges();
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtLibelleAnneeAcademique.Text = dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();
            txtAnneeAcademiqueVal.Text = dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();    

        }
    }
}
