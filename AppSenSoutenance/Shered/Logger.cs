using AppSenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace AppSenSoutenance.Shered
{
    public static class Logger
    {
        /// <summary>
        /// Logger dans la BD
        /// </summary>
        /// <param name="TitreErreur"></param>
        /// <param name="erreur"></param>

        public static void WriteDataError(string TitreErreur, string erreur)
        {
            BdSenSoutenanceContext db = new BdSenSoutenanceContext();
            try
            {
                Td_Erreur log = new Td_Erreur();
                log.DateErreur = DateTime.Now;
                log.DescriptionErreur = erreur.Length > 1000 ? erreur.Substring(0, 2000) : erreur;
                log.TitreErreur = TitreErreur;
                db.Td_Erreur.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// Logger au niveau des fichiers
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool CreateFile(string message)
        {
            bool rep = false;
            string fileName = string.Format("{0}{1}{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                string path = "~/Error/" + fileName + ".txt";
                    //System.Web.HttpContext.Current.Server.MapPath("~/Error/" + fileName + ".txt");
                if (!File.Exists(path))
                {
                    File.Create(path);
                    //   File.Delete(path);
                }
                File.Create(path);
                bool fileUse = true;
                while (fileUse)
                {
                    try
                    {
                        System.IO.TextWriter writeFile = new StreamWriter(path, true);
                        writeFile.WriteLine("" + DateTime.Now);
                        writeFile.WriteLine(message);
                        writeFile.WriteLine("-------------------------------------------");
                        writeFile.Flush();
                        writeFile.Close();
                        writeFile = null;
                        fileUse = false;
                    }
                    catch (Exception e)
                    {
                        WriteLogSystem(e.ToString(), "CreateFile");
                    }
                }
                rep = true;
            }
            catch (IOException e)
            {
                WriteLogSystem(e.ToString(), "WriteFileError");
            }
            return rep;
        }


        /// <summary>
        /// Enregistrer les logs dans le systeme d'exploitation
        /// </summary>
        /// <param name="erreur"></param>
        /// <param name="libelle"></param>
        public static void WriteLogSystem(string erreur, string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "SenSoutenance";
                eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description {2}", DateTime.Now, libelle, erreur), EventLogEntryType.Information,101,1);
            }
        }
    }
}