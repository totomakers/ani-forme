using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Fournisseurs
    {
        #region Attribute
        private String nom;
        #endregion

        #region Constructor
        public Fournisseurs(String _nom)
        {
            Nom = _nom;
        }
        #endregion

        #region Getter/Setter
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Surcharge de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Nom;
        }
        #endregion
    }
}
