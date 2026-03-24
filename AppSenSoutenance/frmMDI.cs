using AppSenSoutenance.View;
using AppSenSoutenance.View.Account;
using AppSenSoutenance.View.Parametre;
using AppSenSoutenance.views.parametre;
using AppSenSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmMDI : Form
    {

        public string profil;
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Methode pour fermer tous les formulaires enfants ouverts dans le parentMDI
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;
            //For each child form set the window state to Maximized

            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }
        private void OuvrirFormulaire(Form formulaire)
        {
            try
            {
                fermer();
                formulaire.MdiParent = this;
                formulaire.Show();
                formulaire.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir le formulaire : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            btnUtilisateur.Visible = true;
            /*
            btnUtilisateur.Visible = false;
            
            if (profil == "Admin")
            {
                btnUtilisateur.Visible = true;
            }*/

            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new formUtilisateur());
        }

        private void btnSoutenance_Click_1(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmSoutenance());
        }

        private void btnMemoire_Click_1(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmMemoire());
        }

        private void btnSession_Click_1(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmSession());
        }

        private void btnAnnee_Click_1(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmAnneeAcademique());

        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment quitter l'application ?",
            "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            Application.Exit();
        }

        private void btnSeDeconnecter_Click_1(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?",
           "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }
    }
}
