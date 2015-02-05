using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgendaMgr
    {
        public static List<BO.Agenda>  GetAll(BO.Veterinaires veto = null)
        {
            return DAL.Agenda.GetAll(veto);
        }

        public static bool Add(BO.Agenda agenda)
        {
            if (DAL.Agenda.Verif(agenda))
                return DAL.Agenda.Create(agenda);
            else
                return false;
        }

        public static bool Delete(BO.Agenda agenda)
        {
            return DAL.Agenda.Delete(agenda);
        }

    }
}
