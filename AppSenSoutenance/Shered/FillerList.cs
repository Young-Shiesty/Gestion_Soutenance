using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace AppSenSoutenance.Shered
{
    public class FillerList
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();
        public List<ListItem>fillAnneeAcademique()
        {
            ///<summary>
            ///Remplir la liste des annees academiques
            ///</summary>
            ///returns></returns>

            List<ListItem> laliste = new List<ListItem>();
            var liste = db.anneesAcademiques.ToList();
            laliste.Add(new ListItem {
                Value = null,
                Text = "Selectionner"
            });   
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.IdAnneeAcademique.ToString(),
                    Text = t.LibelleAnneeAcademique.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }
    }
}
