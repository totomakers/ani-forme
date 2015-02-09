using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;

namespace DAL
{
    public class Races
    {
        /// <summary>
        /// Retourne toutes les races
        /// </summary>
        /// <returns></returns>
        public static List<String> GetAllRaces()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<String> results = cnx.Query<String>(@"SELECT DISTINCT Race FROM Races").ToList<String>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne toutes les races
        /// </summary>
        /// <returns></returns>
        public static List<String> GetAllEspeces()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<String> results = cnx.Query<String>(@"SELECT DISTINCT Espece FROM Races").ToList<String>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne toutes les especes par race
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        public static List<String> GetAllEspecesByRace(String race)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<String> results = cnx.Query<String>(@"SELECT DISTINCT Espece FROM Races WHERE Race = @race",
                                       new { race = race }).ToList<String>();

                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne toutes les especes par race
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>
        public static List<String> GetAllRacesByEspece(String espece)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<String> results = cnx.Query<String>(@"SELECT DISTINCT Race FROM Races WHERE Espece = @espece",
                                       new { espece = espece }).ToList<String>();

                SqlConnexion.CloseConnexion(cnx);
                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
