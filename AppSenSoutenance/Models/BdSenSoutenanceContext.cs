
using AppSenSoutenance.Migrations;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenSoutenanceContext : DbContext
    {
        public BdSenSoutenanceContext(): base("name=BdSenSoutenanceContext"){}
        public DbSet<AnneeAcademique> anneesAcademiques { get; set; }

        public DbSet<Session> session { get; set; }
        public DbSet<Memoire> memoires { get; set; }
        public DbSet<Soutenance> soutenances { get; set; }
         public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<ChefDepartement> chefsDepartements { get; set; }
        public DbSet<Candidat> candidats { get; set; }
        public DbSet<Professeur> professeurs { get; set; }
        public DbSet<Td_Erreur> Td_Erreur { get; set; }
    }
}
