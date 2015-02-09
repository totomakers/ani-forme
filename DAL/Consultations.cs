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
    enum ConsultationEtat
    {
        EN_COURS_DE_SAISIE,
        SAISI_VETO_TERMINER,
        FACTURATION_POSSIBLE,
        FACTURE_GENEREE
    }

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
    }
}
