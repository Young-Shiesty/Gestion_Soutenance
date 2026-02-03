using AppSenSoutenance.Migrations;
using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }
        public static void StartApp()
        {
            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            var adminUser = db.admins.Count();
            if (adminUser == 0)
            {
                Admin candidat = new Admin();
                candidat.NomUtilisateur = "Thiam";
                candidat.PrenomUtilisateur = "Moussa";
                candidat.TelUtilisateur = "774536423";
                candidat.EmailUtilisateur = "admin@yopmail.com";
                using (MD5 md5Hash = MD5.Create())
                {
                    candidat.MotDePasse = Shered.Crypted.GetMd5Hash(md5Hash, "passer123");
                }
                db.admins.Add(candidat);
                db.SaveChanges();
            }
        }
    }
}
