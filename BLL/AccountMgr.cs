using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class AccountMgr
    {
        public static BO.Account loggedAccount;

        public static bool Login(String username, String passwordNotHash)
        {
            String hashPassword = BO.Account.getSHA1Password(username, passwordNotHash);
            loggedAccount = DAL.Account.Login(username, hashPassword);

            return (loggedAccount != null);
        }

        public static bool isLogin
        {
            get { return (loggedAccount != null); }
        }

        public static void jeuxEssai()
        {
            BO.Account account = new BO.Account();
            account.Username = "test";
            account.PasswordSHA1 = BO.Account.getSHA1Password("test","test");
            DAL.Account.CreateAccount(account);
        }
    }
}
