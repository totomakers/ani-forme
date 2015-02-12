using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Fournisseurs
    {
        /// <summary>
        /// Retournes une liste de fournisseurs
        /// </summary>
        /// <returns></returns>
        public static List<BO.Fournisseurs> GetAll()
        {
            List<BO.Fournisseurs> result = new List<BO.Fournisseurs>();
            String line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ConfigurationManager.AppSettings["Chemin"]);
                while ((line = file.ReadLine()) != null)
                {
                    result.Add(new BO.Fournisseurs(line.ToString()));
                }
                file.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        /// <summary>
        /// Met a jour le fournisseur
        /// </summary>
        /// <returns></returns>
        public static bool Update()
        {
            return true;
        }
    }
}
