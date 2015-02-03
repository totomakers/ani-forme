using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class VeterinairesMgr
    {
        public static List<BO.Veterinaires> GetAll()
        {
            return DAL.Veterinaires.GetAll();
        }

        public static List<BO.Veterinaires> GetAll(bool archived)
        {
            return DAL.Veterinaires.GetAll(false);
        }

        public static bool Delete(BO.Veterinaires veto)
        {
            return DAL.Veterinaires.Archive(veto, true);
        }
    }
}
