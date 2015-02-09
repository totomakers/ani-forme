using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VaccinsMgr
    {
        /// <summary>
        /// Retourne l'ensemble des vaccins
        /// </summary>
        /// <returns></returns>
        public static List<BO.Vaccins> GetAll()
        {
            return DAL.Vaccins.GetAll();
        }

        /// <summary>
        /// Met a jour le vaccin passé en params
        /// </summary>
        /// <param name="code"></param>
        /// <param name="Qte"></param>
        /// <returns></returns>
        public static bool Update(String code, String Qte)
        {
            BO.Vaccins vacc = DAL.Vaccins.Get(Guid.Parse(code));
            if (vacc.QuantiteStock < int.Parse(Qte))
            {
                vacc.QuantiteStock = int.Parse(Qte);
                return DAL.Vaccins.Update(vacc);
            }
            else
                return false;
        }
    }
}
