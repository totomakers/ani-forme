using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LignesConsultations
    {
        #region Attribute
        private BO.Consultations consultation;
        private Guid numLigne;
        private BO.Baremes barem;
        private float prix;
        private Byte rappelEnvoye;
        private Byte archive;
        #endregion

        #region Constructor
        public LignesConsultations()
        {
        }
        #endregion

        #region Getter/Setter
        private BO.Consultations Consultation
        {
            get { return consultation; }
            set { consultation = value; }
        }
        private Guid NumLigne
        {
            get { return numLigne; }
            set { numLigne = value; }
        }
        private BO.Baremes Barem
        {
            get { return barem; }
            set { barem = value; }
        }
        private float Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        private Byte RappelEnvoye
        {
            get { return rappelEnvoye; }
            set { rappelEnvoye = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion

    }
}
