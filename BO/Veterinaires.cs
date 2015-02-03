using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Veterinaires
    {
        #region Attribute
        private Guid codeVeto;
        private String nomVeto;
        private Byte archive;
        private BO.Account compte;
        #endregion

        #region Constructor
        public Veterinaires()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid CodeVeto
        {
            get { return codeVeto; }
            set { codeVeto = value; }
        }
        public String NomVeto
        {
            get { return nomVeto; }
            set { nomVeto = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        public BO.Account Compte
        {
            get { return compte; }
            set { compte = value; }
        }
        #endregion
    }
}
