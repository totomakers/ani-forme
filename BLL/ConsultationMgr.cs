using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum ConsultationsEtat
    {
        EN_COURS_DE_SAISIE = 0,
        SAISI_VETO_TERMINER_ET_FACTURE_POSSIBLE = 1,
        FACTURE_GENEREE = 2
    }

    public class ConsultationMgr
    {
        /// <summary>
        /// Retourne la consultation par guid
        /// </summary>
        /// <param name="codeConsultation"></param>
        /// <returns></returns>
        public static BO.Consultations Get(Guid codeConsultation)
        {
            return DAL.Consultations.Get(codeConsultation);
        }

        /// <summary>
        /// Retourne la consultation pour l'animal à la date
        /// </summary>
        /// <param name="dateConsultation"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        public static BO.Consultations Get(DateTime dateConsultation, BO.Animaux animal)
        {
            return DAL.Consultations.Get(dateConsultation, animal);
        }

        /// <summary>
        /// Sauvegarde/Met à jour la consultation en base de donnée
        /// </summary>
        /// <param name="consultation"></param>
        /// <returns></returns>
        public static BO.Consultations Save(BO.Consultations consultation)
        {
            if (consultation.CodeConsultation == null)
                return BLL.ConsultationMgr.Create(consultation);
            else
            {
                BLL.ConsultationMgr.Update(consultation);
                return consultation;
            }
        }

        /// <summary>
        /// Creer la consultation et retourne l'objet nouvelle crée (Guid définis)
        /// </summary>
        /// <param name="consultation"></param>
        /// <returns></returns>
        public static BO.Consultations Create(BO.Consultations consultation)
        {
            return DAL.Consultations.Create(consultation);
        }

        /// <summary>
        /// Met a jour la consultation
        /// </summary>
        /// <param name="consultation"></param>
        /// <returns></returns>
        public static bool Update(BO.Consultations consultation)
        {
            if (consultation.CodeConsultation == null)
                throw new Exception("La consultation doit posséder un Guid pour être mis a jour");

            if(consultation.Etat >= (short)BLL.ConsultationsEtat.SAISI_VETO_TERMINER_ET_FACTURE_POSSIBLE)
                throw new Exception("La consultation est non modifiable !");

            return DAL.Consultations.Update(consultation);
        }

        /// <summary>
        /// Valide la consultation
        /// La met a jour au préalable
        /// </summary>
        /// <param name="consultation"></param>
        /// <returns></returns>
        public static bool Validate(BO.Consultations consultation)
        {
            try
            {
                if (!BLL.ConsultationMgr.Update(consultation)) //On met a jour
                    return false;


                return DAL.Consultations.Validate(consultation);
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Impossible de valider la consultation : {0}", ex.Message));
            }
        }

        /// <summary>
        /// Supprime la consultation passé en params
        /// </summary>
        /// <param name="consultation"></param>
        /// <returns></returns>
        public static bool Delete(BO.Consultations consultation)
        {
            return DAL.Consultations.Delete(consultation);
        }

    }
}
