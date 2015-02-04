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
    }
}
