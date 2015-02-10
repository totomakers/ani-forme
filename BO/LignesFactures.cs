using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LignesFactures
    {
        #region Attribute
        private BO.Factures facture;
        private Guid? numLigne;
        private BO.Baremes bareme;
        private float prix;
        private Byte archive;
        #endregion

        #region Constructor
        public LignesFactures()
        {
        }
        #endregion

        #region Getter/Setter
        public BO.Factures Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        public Guid? NumLigne
        {
            get { return numLigne; }
            set { numLigne = value; }
        }

        public BO.Baremes Bareme
        {
            get { return bareme; }
            set { bareme = value; }
        }

        public float Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion 
    }
}
