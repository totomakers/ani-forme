using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Agenda
    {
        #region Attribute
        private BO.Vaterinaires veterinaire;
        private DateTime dateRdv;
        private BO.Animaux animal;
        #endregion

        #region Constructor
        public Agenda()
        {
        }
        #endregion

        #region Getter/Setter

        /// <summary>
        /// Identifiant du compte
        /// </summary>
        public Guid Veterinaire
        {
            get { return veterinaire; }
            set { veterinaire = value; }
        }

        /// <summary>
        /// Getter/setter du nom d'utilisateur
        /// </summary>
        public DateTime DateRdv
        {
            get { return dateRdv; }
            set { dateRdv = value; }
        }

        /// <summary>
        /// Getter/Setter du mot de passe encode en SHA1
        /// avec la salt suivant : USERNAME:PASSWORD
        /// </summary>
        public Animaux Animal
        {
            get { return animal; }
            set { animal = value; } 
        }
        #endregion


    }
}
