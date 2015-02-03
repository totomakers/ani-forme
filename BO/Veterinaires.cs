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
        private String motPasse;
        private Byte archive;
        #endregion

        #region Constructor
        public Veterinaires()
        {
        }
        #endregion

        #region Getter/Setter
        private Guid CodeVeto
        {
            get { return codeVeto; }
            set { codeVeto = value; }
        }
        private String NomVeto
        {
            get { return nomVeto; }
            set { nomVeto = value; }
        }
        private String MotPasse
        {
            get { return motPasse; }
            set { motPasse = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
