using AppSenSoutenance.Models;
using AppSenSoutenance.Shered;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                BdSenSoutenanceContext db = new BdSenSoutenanceContext();
                var leUser = db.utilisateurs.Where(a => a.EmailUtilisateur.ToLower() == txtIdentifiant.Text.ToLower()).FirstOrDefault();
                if (leUser != null)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        if (Shered.Crypted.VerifyMd5Hash(md5Hash, txtMotDePasse.Text,leUser.MotDePasse))
                        {
                            frmMDI f = new frmMDI();
                            f.profil = db.utilisateurs.GetType().Name;
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou Mot de passe incorrect");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot de passe incorrect");
                }
            }
            catch (Exception ex)
            {

                Logger.WriteDataError("frmConnexion- btnSeConnecter_Click", ex.ToString());

            }
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Logger.WriteLogSystem("Deconnexion", "btnQuitter_Click");
            Application.Exit();
        }
    }
}
