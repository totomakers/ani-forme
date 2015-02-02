using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;
using System.Data;

namespace DAL
{
    class Account
    {
        /// <summary>
        /// Retourne l'ensemble des comptes
        /// </summary>
        /// <returns>List de BO.Account</returns>
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

        public static bool CreateAccount(BO.Account account)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                int output = cnx.Execute("ajout_account", new { username = account.Username, password = account.PasswordSHA1 }, 
                                        commandType: CommandType.StoredProcedure);
                cnx.Close();
                return (output > 0);
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
