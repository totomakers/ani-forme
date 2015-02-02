using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;

namespace DAL
{
    public class Account
    {
        /// <summary>
        /// Retourne l'ensemble des comptes
        /// </summary>
        /// <returns></returns>
        public static List<BO.Account> GetAccounts()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Account> results = cnx.Query<BO.Account>(@"SELECT * FROM Account").ToList<BO.Account>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le compte représenté par l'id
        /// Retourne un objet null sinon
        /// </summary>
        /// <param name="idParam"></param>
        /// <returns></returns>
        public static BO.Account GetAccount(int idParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"SELECT * FROM Account WHERE id = @id";
                List<BO.Account> results = cnx.Query<BO.Account>(query, new { id = idParam }).ToList<BO.Account>();

                if (results.Count > 0)
                    return results.First();

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static BO.Account Login(String usernameParam, String passwordParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"SELECT * FROM Account WHERE username = @user AND password = @password";
                List<BO.Account> results = cnx.Query<BO.Account>(query, new { user = usernameParam, password = passwordParam }).ToList<BO.Account>();

                if (results.Count > 0)
                    return results.First();

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
