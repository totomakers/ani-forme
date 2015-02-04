using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VaccineMgr
    {
        /// <summary>
        /// Retourne l'ensemble des vaccins
        /// </summary>
        /// <returns></returns>
        public static List<BO.Vaccins> GetVaccins()
        {
            return DAL.Vaccins.GetVaccins();
        }
    }
}
