using AppSenSoutenance.View;
using AppSenSoutenance.View.Account;
using AppSenSoutenance.View.Parametre;
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


        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();    
            f.Show();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //pour que s'affiche a l'interieur du MDI
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSession f = new frmSession();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            securiteToolStripMenuItem.Visible = false;
            if (profil == "Admin")
            {
                securiteToolStripMenuItem.Visible = true;
            }
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
        
        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
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
//teste de pushh
        }

        private void memoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMemoire f = new frmMemoire();
            f.MdiParent = this;
            f.Show();
            //pour utiliser tout l'espace dispoible dans le conteneur
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
