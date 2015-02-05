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
        /// Vérifie l'existance d'un compte par son username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool isLogin(String username)
        {
            return (DAL.Account.Get(username) != null);
        }

        /// <summary>
        /// Vérifie l'existance d'un compte par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool isLogin(Int32 id)
        {
            return (DAL.Account.Get(id) != null);
        }

        /// <summary>
        /// Permet de savoir si on est connecté
        /// </summary>
        public static bool isLogged
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
        /// Création d'un compte
        /// Retourne le même compte avec son id en base de donnée
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static BO.Account Create(BO.Account account)
        {
            DAL.Account.Create(account);
            return DAL.Account.Get(account.Username);
        }

        /// <summary>
        /// Met a jour le compte passé en paramètre
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool Update(BO.Account account)
        {
            if (!isLogin(account.Id))
            {
                throw new Exception("Ce compte n'existe pas !");
            }

            return DAL.Account.Update(account);
        }
    }
}
