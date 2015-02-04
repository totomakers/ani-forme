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
    public class Account
    {
        /// <summary>
        /// Retourne l'ensemble des comptes
        /// </summary>
        /// <returns>List de BO.Account</returns>
        public static List<BO.Account> GetAll()
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
        public static BO.Account Get(int idParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"SELECT * FROM Account WHERE id = @id";
                List<BO.Account> results = cnx.Query<BO.Account>(query, new { id = idParam }).ToList<BO.Account>();

                SqlConnexion.CloseConnexion(cnx);

                if (results.Count > 0)
                    return results.First();

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le compte représenté par l'username
        /// Retourne un objet null sinon
        /// </summary>
        /// <param name="usernameParam"></param>
        /// <returns></returns>
        public static BO.Account Get(string usernameParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"SELECT * FROM Account WHERE username = @username";
                List<BO.Account> results = cnx.Query<BO.Account>(query, new { username = usernameParam.ToUpper() }).ToList<BO.Account>();

                SqlConnexion.CloseConnexion(cnx);

                if (results.Count > 0)
                    return results.First();

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Creer en base le compte passer en parametre
        /// </summary>
        /// <param name="account"></param>
        /// <returns>Vrai si l'insertion a reussi, faux sinon</returns>
        public static bool Create(BO.Account account)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                int output = cnx.Execute("ajout_account", new { username = account.Username, password = account.PasswordSHA1 }, 
                                        commandType: CommandType.StoredProcedure);
                SqlConnexion.CloseConnexion(cnx);
                return (output > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Supprime le compte passé en paramètre
        /// </summary>
        /// <param name="account"></param>
        /// <returns>vrai si reussite, faux sinon</returns>
        public static bool Delete(BO.Account account)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"DELETE FROM Account WHERE id = @id";
                int rowNb = cnx.Execute(query, new { id = account.Id });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Modifie le compte passé en paramètre
        /// </summary>
        /// <returns></returns>
        public static bool Update(BO.Account account)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Account SET username=@user, password=@pwd WHERE id=@id";
                int rowNb = cnx.Execute(query, new { id = account.Id, user=account.Username, pwd=account.PasswordSHA1 });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Selectionne les données en base correspondant au username et au password passés en paramètre.
        /// </summary>
        /// <param name="usernameParam"></param>
        /// <param name="passwordParam"></param>
        /// <returns>Un BO.Account si reussite, null sinon</returns>
        public static BO.Account Login(String usernameParam, String passwordParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"SELECT * FROM Account WHERE username = @user AND password = @password";
                List<BO.Account> results = cnx.Query<BO.Account>(query, new { user = usernameParam.ToUpper(), password = passwordParam }).ToList<BO.Account>();

                if (results.Count > 0)
                {
                    query = @"UPDATE Account SET is_online=1 WHERE id = @id";
                    cnx.Query(query, new { id = results.First().Id });
                    SqlConnexion.CloseConnexion(cnx);
                    return results.First();
                }

                SqlConnexion.CloseConnexion(cnx);
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Selectionne les données en base correspondant au compte passé en paramètre.
        /// </summary>
        /// <param name="account"></param>
        /// <returns>Vrai si reussite, faux sinon</returns>
        public static bool Logout(BO.Account account)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Account SET is_onlie=0 WHERE id = @id";
                int rowNb = cnx.Execute(query, new { id = account.Id });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
