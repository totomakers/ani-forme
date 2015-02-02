using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO.Utils;

namespace BO
{
    public class Account
    {
        #region Attribute
        private String username;
        private String passwordSHA1;
        #endregion

        #region Getter/Setter

        /// <summary>
        /// Getter/setter du nom d'utilisateur
        /// </summary>
        public String Username
        {
            get;
            set;
        }

        /// <summary>
        /// Getter/Setter du mot de passe encode en SHA1
        /// avec la salt suivant : USERNAME:PASSWORD
        /// </summary>
        public String PasswordSHA1
        {
            get;
            set; //@warning ne pas appeler uniquement pour l'orm
        }

        #endregion

        #region Methodes

        /// <summary>
        /// Permet de définir le nouveau mot de passe pour l'utilisateur
        /// </summary>
        /// <param name="password">le nouveau mot de passe</param>
        public void setPassword(String password)
        {
            String finalString = Username.ToUpper() + ':' + password.ToUpper();
            PasswordSHA1 = Utils.HelperSHA1.GetSHA1HashData(finalString);
        }

        #endregion
    }
}
