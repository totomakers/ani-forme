using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FournisseurMgr
    {
        public static List<BO.Fournisseurs> GetAll()
        {
            return DAL.Fournisseurs.GetAll();
        }
    }
}
