using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgendaMgr
    {
        /// <summary>
        /// Retourne tout les objets Agenda avec le veto passé en paramas
        /// </summary>
        /// <param name="veto"></param>
        /// <returns></returns>
        public static List<BO.Agenda>  GetAll(BO.Veterinaires veto = null)
        {
            return DAL.Agenda.GetAll(veto);
        }

        /// <summary>
        /// Retourne les objets Agenda ayant le veto et la date passé en params
        /// </summary>
        /// <param name="veto"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<BO.Agenda> GetAll(BO.Veterinaires veto, DateTime date)
        {
            return DAL.Agenda.GetAll(veto, date);
        }

        /// <summary>
        /// Ajoute l'objet Agenda passé en params
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public static bool Add(BO.Agenda agenda)
        {
            if (agenda.Animal == null || agenda.Veterinaires == null)
                throw new Exception(Lang.AGENDA_ANIMAL_AND_VETO_REQUIRED);

            if (DAL.Agenda.Verif(agenda))
                return DAL.Agenda.Create(agenda);
            else
                return false;
        }

        /// <summary>
        /// Supprime l'objet Agenda passé en params
        /// </summary>
        /// <param name="agenda"></param>
        /// <returns></returns>
        public static bool Delete(BO.Agenda agenda)
        {

            return DAL.Agenda.Delete(agenda);
        }

    }
}
