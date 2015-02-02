using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Dapper;

namespace DAL
{
    class Account
    {
        private static SqlConnection cnx = DAL.SqlConnexion.OpenConnection();


        public static List<BO.Account> GetAccounts()
        {
            try
            {
                return cnx.Query<BO.Account>("SELECT * FROM Account;").ToList<BO.Account>();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static BO.Account GetAccount(int idParam)
        {
            try
            {
                var sql = @"SELECT * FROM Account WHERE id = @id";
                return cnx.Query<BO.Account>(sql, new { id = idParam }).First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CreateAccount(int idParam)
        {
            try
            {
                var sql = @"SELECT * FROM Account WHERE id = @id";

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        

    }
}
