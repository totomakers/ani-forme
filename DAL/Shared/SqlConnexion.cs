using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnexion
    {
        public const String ConnexionString = "server={0};database={1};Integrated Security=false;user={2};password={3}";

        public static SqlConnection OpenConnexion()
        {
            try
            {
                String cnxStr = String.Format(ConnexionString,
                                              ConfigurationManager.AppSettings["Server"],
                                              ConfigurationManager.AppSettings["Database"],
                                              ConfigurationManager.AppSettings["Username"],
                                              ConfigurationManager.AppSettings["Password"]);

                var connexion = new SqlConnection(cnxStr);
                connexion.Open();
                return connexion;
            }
            catch(Exception e)
            {
                throw new Exception(String.Format(DAL.Lang.EXP_OPEN_CONN_FAIL, e.Message));
            }
        }

        public static Boolean CloseConnexion(SqlConnection cnx)
        {
            try
            {
                cnx.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(String.Format(DAL.Lang.EXP_CLOSE_CONN_FAIL, e.Message));
            }
        }
    }
}
