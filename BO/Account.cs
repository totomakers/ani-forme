using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO.Utils;

namespace BO
{
    public class Account : Object
    {
        #region Attribute
        private Int32 id;
        private String username;
        private String passwordSHA1;
        #endregion

        #region Constructor
        public Account()
        {
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            return Username;
        }
        #endregion

        #region Getter/Setter

        /// <summary>
        /// Identifiant du compte
        /// </summary>
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Getter/setter du nom d'utilisateur
        /// </summary>
        public String Username
        {
            get { return username.ToUpper(); }
            set { username = value; }
        }

        /// <summary>
        /// Getter/Setter du mot de passe encode en SHA1
        /// avec la salt suivant : USERNAME:PASSWORD
        /// </summary>
        public String PasswordSHA1
        {
            get { return passwordSHA1; }
            set { passwordSHA1 = value; } //@WARNING ne pas appeler uniquement pour l'orm
        }
        #endregion

        #region Methodes

        /// <summary>
        /// Permet de définir le nouveau mot de passe pour l'utilisateur
        /// </summary>
        /// <param name="password">le nouveau mot de passe</param>
        public void setPassword(String password)
        {
            PasswordSHA1 = Account.getSHA1Password(this.Username, password);
        }

        /// <summary>
        /// Retourne le mot de passe en SHA1
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static String getSHA1Password(String username, String password)
        {
            String finalString = username.ToUpper() + ':' + password;
            return BO.Utils.HelperSHA1.GetSHA1HashData(finalString);
        }
        #endregion
    }
}
