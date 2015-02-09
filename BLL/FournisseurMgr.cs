using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FournisseurMgr
    {
        /// <summary>
        /// Retourne tout les fournisseurs
        /// </summary>
        /// <returns></returns>
        public static List<BO.Fournisseurs> GetAll()
        {
            return DAL.Fournisseurs.GetAll();
        }
    }
}
