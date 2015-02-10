using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturesMgr
    {
        public static Int32 Impayees(BO.Clients client)
        {
            return DAL.Factures.CountFactureByClient(client) - DAL.Factures.CountFactureEtatByClient(client, DAL.FactureEtat.PAYEE);
        }
    }
}
