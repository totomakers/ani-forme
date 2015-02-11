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
        /// Met a jour le vaccin passé en params a condition que la qte > a la quantite en stock
        /// </summary>
        /// <param name="code"></param>
        /// <param name="Qte"></param>
        /// <returns></returns>
        public static bool AddQte(BO.Vaccins vacc, Int32 Qte)
        {
            if (vacc.QuantiteStock < Qte)
            {
                vacc.QuantiteStock = Qte;
                return DAL.Vaccins.Update(vacc);
            }
            else
                throw new Exception(Lang.VACCINS_QUANTITY_NEED_BE_SUPP);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="Qte"></param>
        /// <returns></returns>
        public static bool Update(BO.Vaccins vacc, Int32 Qte)
        {
            vacc.QuantiteStock = Qte;
            return DAL.Vaccins.Update(vacc);
        }
    }
}
