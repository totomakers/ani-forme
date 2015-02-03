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

        /// <summary>
        /// Connecte un utilisateur
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwordNotHash"></param>
        /// <returns></returns>
        public static bool Login(String username, String passwordNotHash)
        {
            String hashPassword = BO.Account.getSHA1Password(username, passwordNotHash);
            loggedAccount = DAL.Account.Login(username, hashPassword);

            return (loggedAccount != null);
        }

        /// <summary>
        /// Permet de savoir si on est connecté
        /// </summary>
        public static bool isLogin
        {
            get { return (loggedAccount != null); }
        }

        /// <summary>
        /// Retourne le compte connecté a l'application
        /// </summary>
        public BO.Account CurrentAccount
        {
            get { return loggedAccount; }
        }

        /// <summary>
        /// Création d'un utilisateur de test
        /// </summary>
        public static void jeuxEssai()
        {
            BO.Account account = new BO.Account();
            account.Username = "test";
            account.PasswordSHA1 = BO.Account.getSHA1Password("test","test");
            DAL.Account.Create(account);
        }
    }
}
