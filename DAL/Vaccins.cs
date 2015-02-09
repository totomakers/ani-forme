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
    public class Vaccins
    {

        public static List<BO.Vaccins> GetAll()
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Vaccins> results = cnx.Query<BO.Vaccins>(@"SELECT * FROM Vaccins").ToList<BO.Vaccins>();
                SqlConnexion.CloseConnexion(cnx);

                return results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static BO.Vaccins Get(Guid idParam)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                List<BO.Vaccins> results = cnx.Query<BO.Vaccins>(@"SELECT * FROM Vaccins WHERE CodeVaccin=@code", new { code = idParam }).ToList<BO.Vaccins>();
                SqlConnexion.CloseConnexion(cnx);

                if (results.Count > 0)
                    return results.First();
                else
                    return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool Update(BO.Vaccins vac)
        {
            try
            {
                SqlConnection cnx = DAL.SqlConnexion.OpenConnexion();
                var query = @"UPDATE Vaccins SET QuantiteStock=@qte WHERE CodeVaccin=@code";
                int rowNb = cnx.Execute(query, new { code = vac.CodeVaccin, qte = vac.QuantiteStock });
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
