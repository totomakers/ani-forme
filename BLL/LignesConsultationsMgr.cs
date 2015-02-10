using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LignesConsultationsMgr
    {
        /// <summary>
        /// Retournes tout les lignes consultation avec le codeConsultation passé en params
        /// </summary>
        /// <param name="codeConsultation"></param>
        /// <returns></returns>
        public static List<BO.LignesConsultations> GetAll(Guid codeConsultation)
        {
            return DAL.LignesConsultations.GetAll(codeConsultation);
        }


        /// <summary>
        /// Creer la ligne de consultation passé en params
        /// </summary>
        /// <param name="lignesConsultations"></param>
        /// <returns></returns>
        public static BO.LignesConsultations Create(BO.LignesConsultations lignesConsultations)
        {
            if (lignesConsultations.Consultation == null)
                throw new Exception(Lang.LIGNESCONSULTATION_CANT_CREATE_WITHOUT_CONSULTATION);

            if (lignesConsultations.Barem == null)
                throw new Exception(Lang.LIGNESCONSULTATION_CANT_CREATE_WITHOUT_BAREM);

            return DAL.LignesConsultations.Create(lignesConsultations);
        }


        /// <summary>
        /// Supprime la ligne consultation passé en param
        /// </summary>
        /// <param name="lignesConsultation"></param>
        /// <returns></returns>
        public static bool Delete(BO.LignesConsultations ligneConsultation)
        {
            try
            {
                if (ligneConsultation.Consultation == null || ligneConsultation.NumLigne == null)
                    throw new Exception(Lang.LIGNESCONSULTATION_CANT_DELETE_PK);

                return DAL.LignesConsultations.Delete(ligneConsultation);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
