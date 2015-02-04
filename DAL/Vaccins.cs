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
                BO.Vaccins results = (BO.Vaccins)cnx.Query(@"SELECT * FROM Vaccins WHERE id=@id", new { id = idParam });
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
