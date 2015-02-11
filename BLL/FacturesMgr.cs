using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum FacturesEtat
    {
        A_IMPRIMER,
        IMPRIMEE,
        PAYEE,
    }

    public class FacturesMgr
    {
        /// <summary>
        /// Retourne le nombre de facture non payée du client
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static Int32 Impayees(BO.Clients client)
        {
            return DAL.Factures.CountFactureByClient(client) - DAL.Factures.CountFactureEtatByClient(client, (short)BLL.FacturesEtat.PAYEE);
        }
    }
}
