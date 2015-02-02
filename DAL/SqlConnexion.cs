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
        private static String server = "localhost";
        private static String port = "5432";
        private static String db = "GestionLogin";
        private static String user = "sa";
        private static String pwd = "Pa$$w0rd";

        public const string ConnectionString = "server=" + server + ";port=" + port + ";database=" + db + ";Integrated Security=false;user=" + user + ";password=" + pwd;

        public static SqlConnection OpenConnection()
        {
            try
            {
                var connection = new SqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch(Exception e)
            {
                throw new Exception(String.Format(DAL.Lang.EXP_OPEN_CONN_FAIL, e.Message));
            }
        }

        public static Boolean CloseConnection(SqlConnection cnx)
        {
            try
            {
                cnx.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Impossible de fermer la connexion : " + e.Message);
            }
        }
    }
}
