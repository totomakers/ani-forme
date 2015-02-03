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
        public BO.Consultations Consultation
        {
            get { return consultation; }
            set { consultation = value; }
        }
        public Guid NumLigne
        {
            get { return numLigne; }
            set { numLigne = value; }
        }
        public BO.Baremes Barem
        {
            get { return barem; }
            set { barem = value; }
        }
        public float Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public Byte RappelEnvoye
        {
            get { return rappelEnvoye; }
            set { rappelEnvoye = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion

    }
}
