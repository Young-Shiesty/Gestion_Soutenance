using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance
{
    public class ChefDepartement: Utilisateur
    {
        public int? IdDepartement { get; set; }
        [ForeignKey("IdDepartement")]
        //Le virtual permet de recuperer le departement associe au chef de departement
        public virtual Departement Departement { get; set; }
    }
}
