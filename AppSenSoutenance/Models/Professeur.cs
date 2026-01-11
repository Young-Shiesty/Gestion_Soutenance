using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance
{
    public class Professeur:Utilisateur
    {
        [Required, MaxLength(80)]
        public string SpecialiteProfesseur { get; set; }

        //Test pour voir si je peux push 
        public string Id { get; set; }
    }


}
