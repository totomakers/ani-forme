using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public enum FactureEtat
    {
        A_IMPRIMER,
        IMPRIMEE,
        PAYEE,
    }

    public class Factures
    {
        /// <summary>
        /// Retourne le nombre de facture d'un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static Int32 CountFactureByClient(BO.Clients client)
        {
            return 0;
        }

        /// <summary>
        /// Retourne le nombre de facture d'un client avec cet etat
        /// </summary>
        /// <param name="client"></param>
        /// <param name="etat"></param>
        /// <returns></returns>
        public static Int32 CountFactureEtatByClient(BO.Clients client, FactureEtat etat)
        {
            return 0;
        }

        /// <summary>
        /// Retourne la liste des factures avec l'état passé en params
        /// </summary>
        /// <param name="client"></param>
        /// <param name="etat"></param>
        /// <returns></returns>
        public static List<BO.Factures> GetFactureEtatByClient(BO.Clients client, FactureEtat etat)
        {
            return new List<BO.Factures>();
        }

        /// <summary>
        /// Retourne l'ensemble des factures d'un client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<BO.Factures> GetFactureByClient(BO.Clients client)
        {
            return new List<BO.Factures>();
        }
    }
}
