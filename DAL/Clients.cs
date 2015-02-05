using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;
using DAL.Shared;

namespace DAL
{
    public class Clients
    {
        /// <summary>
        /// Récupère tout les clients
        /// </summary>
        /// <returns></returns>
        public static List<BO.Clients> GetAll()
        {
            try
            {
                var query = @"SELECT * FROM  Clients c ORDER BY c.CodeClient";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Clients> results = cnx.Query<BO.Clients>(query).ToList<BO.Clients>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Surcharge de la méthode getAll pour obtenir les archivés ou non
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Clients> GetAll(bool archived)
        {
            try
            {
                var query = @"SELECT * FROM  Clients c WHERE c.Archive=@archive ORDER BY c.CodeClient";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Clients> results = cnx.Query<BO.Clients>(query, new { archive = archived }).ToList<BO.Clients>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne tout les clients dont le nom est %name% archivé ou non
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<BO.Clients> GetAll(bool archived, string name = "")
        {
            var query = String.Format(@"SELECT * FROM  Clients c WHERE c.Archive = @archive and NomClient LIKE (@name) ORDER BY c.CodeClient");
            SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
            List<BO.Clients> results = cnx.Query<BO.Clients>(query, new { archive = archived, name = '%'+name+'%' }).ToList<BO.Clients>();
            SqlConnexion.CloseConnexion(cnx);

            return results;
        }

        /// <summary>
        /// Déactive/Active un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool Archive(BO.Clients client, bool archived)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Clients SET Archive=@archive WHERE CodeClient = @codeClient";
                int rowNb = cnx.Execute(query, new { codeClient = client.CodeClient, archive = (archived) ? 1 : 0 });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Clients Get(Guid id)
        {
            try
            {
                var query = @"SELECT * FROM  Clients c WHERE CodeClient = @code";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                BO.Clients results = cnx.Query<BO.Clients>(query, new { code = id }).ToList<BO.Clients>()[0];
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Clients Create(BO.Clients client)
        {
            return null;
        }
    }
}
