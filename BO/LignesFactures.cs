using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class LignesFactures
    {
        #region Attribute
        private BO.Factures facture;
        private Guid numLigne;
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
        private BO.Factures Facture
        {
            get { return facture; }
            set { facture = value; }
        }
        private Guid NumLigne
        {
            get { return numLigne; }
            set { numLigne = value; }
        }
        private BO.Baremes Bareme
        {
            get { return bareme; }
            set { bareme = value; }
        }
        private float Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion 
    }
}
