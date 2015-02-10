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
        /// Creer toutes les lignes consultations
        /// </summary>
        /// <param name="lignesConsultations"></param>
        /// <param name="codeConsultation"></param>
        /// <returns></returns>
        public static List<BO.LignesConsultations> CreateAll(List<BO.LignesConsultations> lignesConsultations, Guid codeConsultation)
        {
            for (Int32 i = 0; i < lignesConsultations.Count; i++)
            {
                BO.LignesConsultations ligne = lignesConsultations[i];

                if (ligne.NumLigne == null)
                {
                    if (ligne.Consultation == null || ligne.Consultation.CodeConsultation != codeConsultation)
                        ligne.Consultation = ConsultationMgr.Get(codeConsultation);

                    lignesConsultations[i] = BLL.LignesConsultationsMgr.Create(ligne);
                }
            }

            return lignesConsultations;
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
