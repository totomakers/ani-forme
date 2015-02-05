using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientsMgr
    {
        /// <summary>
        /// Retourne l'ensemble des clients
        /// </summary>
        /// <returns></returns>
        public static List<BO.Clients> GetAll()
        {
            return DAL.Clients.GetAll();
        }

        /// <summary>
        /// Retourne l'ensemble des clients archivé/non archivé
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Clients> GetAll(bool archived)
        {
            return DAL.Clients.GetAll(false);
        }


        public static List<BO.Clients> GetAll(bool archived, string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
                return DAL.Clients.GetAll(archived, name);
            else
                return DAL.Clients.GetAll(archived);
        }

        /// <summary>
        /// Archive le client passé en paramètre
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool Delete(BO.Clients client)
        {
            return DAL.Clients.Archive(client, true);
        }

        public static BO.Clients Create(BO.Clients client)
        {
            return DAL.Clients.Create(client);
        }
    }
}
