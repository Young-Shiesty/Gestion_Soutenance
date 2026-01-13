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
        Bdsensoutenancecontext db = new Bdsensoutenancecontext();

        private void label2_Click(object sender, EventArgs e)
        {
            dgSoutenance.DataSource = db.Soutenances.ToList();

        }
        //la fonction effacer
        public void effacer()
        {
            txtDateSoutenance.Clear();
            txtLieuSoutenance.Clear();
            txtResultatSoutenance.Clear();
            txtMentionSoutenance.Clear();
            txtObservationSoutenance.Clear();
            dgSoutenance.DataSource = db.Soutenances.ToList();
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

            Soutenance soutenance = new Soutenance()
            {
                DateSoutenance = dateSoutenance,
                LieuSoutenance = txtLieuSoutenance.Text,
                ResultatSoutenance = txtResultatSoutenance.Text,
                MentionSoutenance = txtMentionSoutenance.Text,
                ObservationSoutenance = txtObservationSoutenance.Text
            };

            db.Soutenances.Add(soutenance);
            db.SaveChanges();
            effacer();

        }
        //pour modifier  une soutenance

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            //La méthode Find() permet de chercher un objet spécifique dans la collection
            //ou la table (ici db.Soutenances) en fonction de son identifiant (id).
            //En d'autres termes, elle permet de retrouver l'enregistrement dont l'identifiant
            //correspond à la valeur de id passé en paramètre.
           
            Soutenance soutenance = db.Soutenances.Find(id);
            soutenance.LieuSoutenance = txtLieuSoutenance.Text;
            soutenance.ResultatSoutenance = txtResultatSoutenance.Text;
            soutenance.MentionSoutenance = txtMentionSoutenance.Text;
            soutenance.ObservationSoutenance = txtObservationSoutenance.Text;
            db.SaveChanges();
            effacer();



        }
        //supprimer une soutenance 
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = db.Soutenances.Find(id);
            db.Soutenances.Remove(soutenance);
            db.SaveChanges();
            effacer();


        }
        //pour selectionner une soutenance

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            //Le Value fait référence à la valeur contenue dans la cellule de la ligne
            //sélectionnée du DataGridView (dgSoutenance).
            //dgSoutenance.CurrentRow :
            //dgSoutenance.CurrentRow :
            txtDateSoutenance.Text = dgSoutenance.CurrentRow.Cells[1].Value.ToString();
            txtLieuSoutenance.Text = dgSoutenance.CurrentRow.Cells[2].Value.ToString();
            txtMentionSoutenance.Text = dgSoutenance.CurrentRow.Cells[3].Value.ToString();
            txtObservationSoutenance.Text = dgSoutenance.CurrentRow.Cells[4].Value.ToString();
            txtResultatSoutenance.Text = dgSoutenance.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
