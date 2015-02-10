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
            var query = String.Format(@"SELECT * FROM  LignesConsultations lc
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
            var query = @"DELETE FROM LignesConsultations lc
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

        /// <summary>
        /// Retourne la liste des animaux a relancer
        /// </summary>
        /// <returns></returns>
        public static List<BO.LignesConsultations> GetAllRappel()
        {
            try
            {
                /*SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query = @"SELECT * 
                                FROM Animaux a
                                INNER JOIN Consultations c on c.CodeAnimal = a.CodeAnimal
                                INNER JOIN LignesConsultations lc on lc.CodeConsultation = c.CodeConsultation
                                INNER JOIN Baremes b on lc.CodeGroupement = b.CodeGroupement AND lc.DateVigueur = b.DateVigueur
                                INNER JOIN Vaccins v on b.CodeVaccin = v.CodeVaccin
                                WHERE (c.DateConsultation+v.PeriodeValidite) > (GETDATE()-14)
                                AND lc.RappelEnvoye = 0;";

                List<BO.LignesConsultations> results = cnx.Query<BO.Animaux, BO.Consultations, BO.LignesConsultations, BO.Baremes, BO.Vaccins ,BO.LignesConsultations>(query,
                                               (animal, consultation, lignesconsultations, baremes, vaccin) => { consultation.Animal = animal; lignesconsultations.Consultation = consultation; baremes.Vaccin = vaccin; lignesconsultations.Barem = baremes; return lignesconsultations; },
                                               splitOn: "CodeAnimal,CodeConsultation,CodeVaccin,CodeGroupement,DateVigueur")
                                               .ToList<BO.LignesConsultations>();

                return results;*/
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
