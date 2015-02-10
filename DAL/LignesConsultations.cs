using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;

namespace DAL
{
    public class LignesConsultations
    {
        /// <summary>
        /// Retourne toutes les lignes d'une consultation
        /// </summary>
        /// <param name="codeConsultation"></param>
        /// <returns></returns>
        public static List<BO.LignesConsultations> GetAll(Guid codeConsultation)
        {
            var query = String.Format(@"SELECT * FROM  LignesConsultation lc
                                        WHERE lc.CodeConsultation = @codeConsultation 
                                        ORDER BY lc.NumLigne");

            SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
            List<BO.LignesConsultations> results = cnx.Query<BO.LignesConsultations>(query, new { codeConsultation = codeConsultation }).ToList<BO.LignesConsultations>();
            SqlConnexion.CloseConnexion(cnx);

            return results;
        }

        /// <summary>
        /// Supprime la ligne consultation passé en params
        /// </summary>
        /// <param name="ligneConsultation"></param>
        /// <returns></returns>
        public static bool Delete(BO.LignesConsultations ligneConsultation)
        {
            var query = @"DELETE FROM ignesConsultation lc
                        WHERE lc.CodeConsultation = @codeConsultation 
                        AND lc.NumLigne = @numLigne";

            SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
            
            int deletedLine = cnx.Execute(query, new { codeConsultation = ligneConsultation.Consultation.CodeConsultation, ligneConsultation.NumLigne });
            SqlConnexion.CloseConnexion(cnx);

            return (deletedLine > 0);
        }

        /// <summary>
        /// Creer la ligne consultation passé en params
        /// </summary>
        /// <param name="ligneConsultation"></param>
        /// <returns></returns>
        public static BO.LignesConsultations Create(BO.LignesConsultations ligneConsultation)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                Guid temp = cnx.ExecuteScalar<Guid>("EXEC ajout_ligne_consultation @codeconsult, @codegroupenet, @datevigueur, @prix",
                                        new
                                        {
                                            codeconsult = ligneConsultation.Consultation.CodeConsultation,
                                            codegroupenet = ligneConsultation.Barem.CodeGroupement,
                                            datevigueur = ligneConsultation.Barem.DateVigueur,
                                            prix = ligneConsultation.Prix,
                                        });
                ligneConsultation.NumLigne = temp;
                SqlConnexion.CloseConnexion(cnx);

                return ligneConsultation;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
