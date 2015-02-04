using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Veterinaires
    {
        #region Attributes
        private Guid codeVeto;
        private String nomVeto;
        private Boolean archive;

        private Int32 accountId;
        private BO.Account account;
        #endregion

        #region Constructor
        public Veterinaires()
        {
        }
        #endregion

        #region Getter/Setter
        [Browsable(false)]
        public Guid CodeVeto
        {
            get { return codeVeto; }
            set { codeVeto = value; }
        }

        [DisplayName("Nom")]
        public String NomVeto
        {
            get { return nomVeto; }
            set { nomVeto = value; }
        }

        [Browsable(false)]
        public Boolean Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        [Browsable(false)]
        public Int32 AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        [DisplayName("Compte")]
        public BO.Account Account
        {
            get { return account; }
            set { account = value; }
        }
        #endregion
    }
}
