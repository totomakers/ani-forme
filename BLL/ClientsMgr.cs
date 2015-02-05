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

        /// <summary>
        /// Retourne l'ensemble des clients archivé ou non avec le params name dans leur nom
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="name"></param>
        /// <returns></returns>
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
        public static void Delete(BO.Clients client)
        {
            //Vérification client
            //Toutes les factures doivent être payé pour archiver le client
            //@TODO faire un mgr de facture...
            Int32 factureImpayee = DAL.Factures.CountFactureByClient(client) - DAL.Factures.CountFactureEtatByClient(client, DAL.FactureEtat.PAYEE);
            if (factureImpayee > 0)
            {
                throw new Exception(String.Format("Ce client a {0} facture impayée ! Il ne peut pas être supprimé", factureImpayee));
            }

            BLL.AnimauxMgr.DeleteAllByClient(client);
            DAL.Clients.Archive(client, true);
        }

        /// <summary>
        /// Creer le client passé en paramètre
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static BO.Clients Create(BO.Clients client)
        {
            return DAL.Clients.Create(client);
        }
    }
}
