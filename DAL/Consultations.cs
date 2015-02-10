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
                var query = @"SELECT * FROM Consultation c WHERE CodeConsultation = @code";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                BO.Consultations results = cnx.Query<BO.Consultations>(query, new { code = id }).ToList<BO.Consultations>().First();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Consultations Get(DateTime dateConsultation, BO.Animaux animal)
        {
            try
            {
                var query = @"SELECT * FROM Consultation c WHERE CodeAnimal = @animal AND DateConsultation = @date";
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                BO.Consultations results = cnx.Query<BO.Consultations>(query, new { animal = animal.CodeAnimal, date = dateConsultation }).ToList<BO.Consultations>().First();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
    
    }
}
