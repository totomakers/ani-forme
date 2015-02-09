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
        public static List<BO.Fournisseurs> GetAll()
        {
            List<BO.Fournisseurs> result = new List<BO.Fournisseurs>();
            String line;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(Properties.Fournisseurs.Default.Chemin);
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
            finally
            {
            }
            return result;
        }

        public static bool Update()
        {
            return true;
        }
    }
}
