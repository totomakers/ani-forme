using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;
using System.Data;

namespace DAL
{
    public class Consultations
    {
        public static List<BO.Consultations> GetAllByAnimal(BO.Animaux currentAnimal)
        {
            try
            {
                var query = @"SELECT * FROM Consultations c, Veterinaires v, Animaux a, Factures f
                            WHERE c.CodeAnimal = @code
                            AND (f.NumFacture=c.NumFacture OR c.NumFacture is null)
                            AND v.CodeVeto=c.CodeVeto
                            AND a.CodeAnimal=c.CodeAnimal";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Consultations> results = cnx.Query<BO.Consultations, BO.Veterinaires, BO.Animaux, BO.Factures, BO.Consultations>(query,
                    (consultation, veto, animal, facture) => { consultation.Veterinaire = veto; consultation.Animal = animal; consultation.Facture = facture; return consultation; },
                    new { code = currentAnimal.CodeAnimal },
                    splitOn: "CodeVeto,CodeAnimal,NumFacture").ToList<BO.Consultations>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int GetNonPayed(BO.Animaux animal)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                String query =  @"SELECT COUNT(*) 
                                FROM Consultations c
                                INNER JOIN Factures f on c.NumFacture = f.NumFacture
                                WHERE f.Etat<2
                                AND c.CodeAnimal = @code";
                int result = cnx.Query<int>(query, new { code = animal.CodeAnimal }).ToList<int>()[0];
                
                SqlConnexion.CloseConnexion(cnx);

                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static BO.Consultations Get(Guid id)
        {
            try
            {
                var query = @"SELECT * FROM Consultations c, Veterinaires v, Animaux a, Factures f
                            WHERE c.CodeConsultation = @code
                            AND (f.NumFacture=c.NumFacture OR c.NumFacture is null)
                            AND v.CodeVeto=c.CodeVeto
                            AND a.CodeAnimal=c.CodeAnimal";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                BO.Consultations results = cnx.Query<BO.Consultations, BO.Veterinaires, BO.Animaux, BO.Factures, BO.Consultations>(query,
                    (consultation, veto, animal, facture) => { consultation.Veterinaire = veto; consultation.Animal = animal; consultation.Facture = facture; return consultation; },
                    new { code = id },
                    splitOn: "CodeVeto,CodeAnimal,NumFacture").First();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Consultations Get(DateTime dateConsultation, BO.Animaux animalParam)
        {
            try
            {
                var query = @"SELECT * FROM Consultations c, Veterinaires v, Animaux a, Factures f
                            WHERE c.CodeAnimal = @animal 
                            AND c.DateConsultation = @date
                            AND (f.NumFacture=c.NumFacture OR c.NumFacture is null)
                            AND v.CodeVeto=c.CodeVeto
                            AND a.CodeAnimal=c.CodeAnimal";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                BO.Consultations results = cnx.Query<BO.Consultations, BO.Veterinaires, BO.Animaux, BO.Factures, BO.Consultations>(query,
                    (consultation, veto, animal, facture) => {consultation.Veterinaire = veto; consultation.Animal = animal; consultation.Facture = facture; return consultation; },
                    new { animal = animalParam.CodeAnimal, date = dateConsultation },
                    splitOn: "CodeVeto,CodeAnimal,NumFacture").First();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Consultations Create(BO.Consultations consult)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                Guid temp = cnx.ExecuteScalar<Guid>("EXEC ajout_consultation @dateconsultation, @codeveto, @cadeanimal, @commentaire, @etat",
                                        new
                                        {
                                            dateconsultation = consult.DateConsultation,
	                                        codeveto = consult.Veterinaire.CodeVeto,
	                                        cadeanimal = consult.Animal.CodeAnimal,
	                                        commentaire = consult.Commentaire,
	                                        etat = consult.Etat
                                        });
                consult.CodeConsultation = temp;
                SqlConnexion.CloseConnexion(cnx);

                return consult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Update(BO.Consultations consultation)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Consultations 
                            SET 
                            DateConsultation = @date,
                            CodeVeto = @codeVeto,
                            CodeAnimal = @codeAnimal,
                            Commentaire = @comm,
                            Etat = @etat,
                            NumFacture = @facture,
                            Archive = @archive
                            WHERE CodeConsultation=@consult";

                int rowNb = cnx.Execute(query, new
                {
                    consult = consultation.CodeConsultation,
                    date = consultation.DateConsultation,
                    codeVeto = consultation.Veterinaire.CodeVeto,
                    codeAnimal = consultation.Animal.CodeAnimal,
                    comm = consultation.Commentaire,
                    etat = consultation.Etat,
                    facture = (consultation.Facture != null) ? consultation.Facture.NumFacture : null,
                    archive = consultation.Archive
                });

                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Validate(BO.Consultations consultation)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Consultations 
                            SET Etat = 1
                            WHERE CodeConsultation=@consult";

                int rowNb = cnx.Execute(query, new
                {
                    consult = consultation.CodeConsultation
                });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Delete(BO.Consultations consultation)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"DELETE FROM Consultations WHERE CodeConsultation=@consult";

                int rowNb = cnx.Execute(query, new
                {
                    consult = consultation.CodeConsultation
                });
                SqlConnexion.CloseConnexion(cnx);
                return (rowNb > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
