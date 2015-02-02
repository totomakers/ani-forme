using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnexion
    {
        public const String ConnexionString = "server={0};port={1};database={2};Integrated Security=false;user={3};password={4}";

        public static SqlConnection OpenConnexion()
        {
            try
            {    
                var connexion = new SqlConnection(String.Format(ConnexionString, 
                                                  Properties.Connexion.Default.Server,
                                                  Properties.Connexion.Default.Port,
                                                  Properties.Connexion.Default.Database,
                                                  Properties.Connexion.Default.Username,
                                                  Properties.Connexion.Default.Password));
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
