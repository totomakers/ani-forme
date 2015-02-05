using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnimauxMgr
    {
        /// <summary>
        /// Retourne tout les animaux
        /// </summary>
        /// <returns></returns>
        public static List<BO.Animaux> GetAll()
        {
            return DAL.Animaux.GetAll();
        }

        /// <summary>
        /// Retourne tout les animaux, archivé ou non
        /// </summary>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAll(bool archived)
        {
            return DAL.Animaux.GetAll(archived);
        }

        /// <summary>
        /// Retourne tout les animaux par clients
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAllByClient(BO.Clients client)
        {
            return DAL.Animaux.GetAllByClient(client);
        }

        /// <summary>
        /// Retourne tout les animaux par client, archivé ou non
        /// </summary>
        /// <param name="client"></param>
        /// <param name="archived"></param>
        /// <returns></returns>
        public static List<BO.Animaux> GetAllByClient(BO.Clients client, bool archived)
        {
            return DAL.Animaux.GetAllByClient(client, archived);
        }
    }
}
