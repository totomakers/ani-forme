using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LignesConsultations
    {
        /// <summary>
        /// Retournes tout les lignes consultation avec le codeConsultation passé en params
        /// </summary>
        /// <param name="codeConsultation"></param>
        /// <returns></returns>
        public static List<BO.LignesConsultations> GetAll(Guid codeConsultation)
        {
            return new List<BO.LignesConsultations>(); //@TODO : methode getAll
        }


        /// <summary>
        /// Creer la ligne de consultation passé en params
        /// </summary>
        /// <param name="lignesConsultations"></param>
        /// <returns></returns>
        public static BO.LignesConsultations Create(BO.LignesConsultations lignesConsultations)
        {
            if (lignesConsultations.Consultation == null)
                throw new Exception("Une ligne de consultation ne peut pas être enregistrer si elle n'est pas liée a une consultation");

            if (lignesConsultations.Barem == null)
                throw new Exception("Une ligne de consultation ne peut pas être enregistrer si elle n'est pas liée a un barem");

            return null; //@TODO : methode create
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
                    throw new Exception("Impossible de supprimer une ligne de consultation sans consultation et/ou numéros de ligne");

                return false; //@TODO : methode dal
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
