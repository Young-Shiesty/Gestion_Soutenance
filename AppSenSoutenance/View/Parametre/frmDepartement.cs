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
    public partial class frmDepartement : Form
    {
        public frmDepartement()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmDepartement_Load);

        }
        Bdsensoutenancecontext db = new Bdsensoutenancecontext();
        private void frmDepartement_Load(object sender, EventArgs e)
        {
            dgDepartement.DataSource = db.Departements.ToList();

        }
        public void effacer()
        {
            txtNomDepartement.Clear();
            txtCodeDepartement.Clear();
            dgDepartement.DataSource = db.Departements.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Departement Departements = new Departement()
            {
                NomDepartement = txtNomDepartement.Text,
                CodeDepartement=txtCodeDepartement.Text,


            };
            db.Departements.Add(Departements);
            db.SaveChanges();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ?id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement Departements = db.Departements.Find(id);
            Departements.NomDepartement = txtNomDepartement.Text;
            Departements.CodeDepartement = txtCodeDepartement.Text;
            db.SaveChanges();
            effacer();



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement Departements = db.Departements.Find(id);
            db.Departements.Remove(Departements);
            db.SaveChanges();
            effacer();

        }
    }
}

