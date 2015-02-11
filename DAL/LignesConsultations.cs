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
                                        INNER JOIN Baremes b ON b.CodeGroupement = lc.CodeGroupement AND b.DateVigueur = lc.DateVigueur
                                        INNER JOIN Consultations c ON c.CodeConsultation = lc.CodeConsultation
                                        WHERE lc.CodeConsultation = @codeConsultation 
                                        ORDER BY lc.NumLigne");

            SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
            List<BO.LignesConsultations> results = cnx.Query<BO.LignesConsultations, BO.Baremes, BO.Consultations, BO.LignesConsultations>(query,
                                                    (animaux, barem, consultations) => { animaux.Barem = barem; animaux.Consultation = consultations;  return animaux; },
                                                    new { codeConsultation = codeConsultation },
                                                    splitOn : "CodeGroupement,DateVigueur, codeConsultation").ToList<BO.LignesConsultations>();
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
            var query = @"DELETE FROM LignesConsultations
                        WHERE CodeConsultation = @codeConsultation 
                        AND NumLigne = @numLigne";

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


        public static List<BO.LignesConsultations> GetAllRappel()
        {
            try
            {
                var query = @"select *
                            from Animaux a, Consultations c, LignesConsultations l, Baremes b, Vaccins v, Clients cl
                            where c.CodeAnimal = a.CodeAnimal
                            and c.CodeConsultation = l.CodeConsultation
                            and b.CodeGroupement = l.CodeGroupement and b.DateVigueur = l.DateVigueur
                            and v.CodeVaccin = b.CodeVaccin
                            and l.RappelEnvoye = 0
                            and cl.Archive = 0
                            and DATEADD(MONTH, v.PeriodeValidite,c.DateConsultation) < DATEADD(DAY, -15, GETDATE())";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.LignesConsultations> results = cnx.Query<BO.Animaux, BO.Consultations, BO.LignesConsultations, BO.Baremes, BO.Vaccins, BO.Clients, BO.LignesConsultations>(query,
                    (animal, consultation, ligneconsultation, bareme, vaccin, client) =>
                    //{ animal.Client = client; consultation.Animal = animal; bareme.Vaccin = vaccin; ligneconsultation.Barem = bareme; ligneconsultation.Consultation = consultation; return ligneconsultation; },
                    { ligneconsultation.Consultation = consultation; ligneconsultation.Consultation.Animal = animal; ligneconsultation.Consultation.Animal.Client = client; ligneconsultation.Barem = bareme; ligneconsultation.Barem.Vaccin = vaccin; return ligneconsultation;},
                    splitOn: "CodeAnimal,CodeConsultation,CodeGroupement,DateVigueur,CodeVaccin").ToList<BO.LignesConsultations>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Relance()
        {
            throw new NotImplementedException();
        }

        public static bool Relance(BO.Animaux animal)
        {
            throw new NotImplementedException();
        }
    }
}
