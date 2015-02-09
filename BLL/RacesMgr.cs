using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RacesMgr
    {
        /// <summary>
        /// Retourne toutes les races
        /// </summary>
        /// <returns></returns>
        public static List<String> GetAllRaces()
        {
            return DAL.Races.GetAllRaces();
        }

        /// <summary>
        /// Retourne toutes les especes
        /// </summary>
        /// <returns></returns>
        public static List<String> GetAllEspeces()
        {
            return DAL.Races.GetAllEspeces();
        }

        /// <summary>
        /// Retourne toutes les especes par race
        /// </summary>
        /// <param name="Race"></param>
        /// <returns></returns>
        public static List<String> GetAllEspecesByRace(String race)
        {
            return DAL.Races.GetAllEspecesByRace(race);
        }

        /// <summary>
        /// Retourne toutes les especes par race
        /// </summary>
        /// <param name="Race"></param>
        /// <returns></returns>
        public static List<String> GetAllRacesByEspece(String espece)
        {
            return DAL.Races.GetAllRacesByEspece(espece);
        }
    }
}
