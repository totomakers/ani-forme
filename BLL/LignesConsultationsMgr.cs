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

            switch (lignesConsultations.Barem.TypeActe)
            {
                case "VACC":
                    BO.Vaccins vacc = lignesConsultations.Barem.Vaccin;
                    if (vacc != null)
                        VaccinsMgr.Update(vacc, vacc.QuantiteStock--);
                    break;

                case "TATO":
                    AnimauxMgr.Update(lignesConsultations.Consultation.Animal);
                    break;
            }

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

        /// <summary>
        /// Retourne toutes les lignes consultations qui ont besoin d'un rappel
        /// </summary>
        /// <returns></returns>
        public static List<BO.LignesConsultations> GetAllRappel()
        {
            //return DAL.LignesConsultations.GetAllRappel();
            return new List<BO.LignesConsultations>();
        }
 
        /// <summary>
        /// Archive tout les animaux du clients passé en params
        /// </summary>
        /// <param name="client"></param>
        public static void DeleteAllByClient(BO.Clients client)
        {
            if (client.CodeClient == null)
                throw new Exception(Lang.ANIMAUX_CANT_DELETE_ANI_CUST_WITHOUT_GUID);
 
            List<BO.Animaux> animaux = DAL.Animaux.GetAllByClient(client);
            foreach (BO.Animaux animal in animaux)
            {
                if (DAL.Consultations.GetNonPayed(animal) > 0)
                    throw new Exception(String.Format(Lang.ANIMAUX_CANT_ARCHIVE_CONSULT_NOT_PAID, client.getFullName()));
            }
            DAL.Animaux.ArchiveAllByClient(client);
        }
    }
}
