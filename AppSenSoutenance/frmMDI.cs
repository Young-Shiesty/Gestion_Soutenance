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


        private void btnSeDeconnecter_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();    
            f.Show();
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnnee_Click(object sender, EventArgs e)
        {
            fermer();
            //pour que s'affiche a l'interieur du MDI
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            fermer();
            frmSession f = new frmSession();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnProfesseur_Click(object sender, EventArgs e)
        {
            fermer();
            formUtilisateur f = new formUtilisateur();    
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
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
            fermer();
            try
            {
                formUtilisateur f = new formUtilisateur();
                f.MdiParent = this;
                f.Show();
                f.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir le formulaire : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMemoire_Click(object sender, EventArgs e)
        {
            fermer();
            frmMemoire f = new frmMemoire();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnSoutenance_Click(object sender, EventArgs e)
        {
            fermer();
            frmSoutenance f = new frmSoutenance();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
