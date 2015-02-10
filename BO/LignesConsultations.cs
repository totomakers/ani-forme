using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class LignesConsultations
    {
        #region Attribute
        private BO.Consultations consultation;
        private Guid? numLigne;
        private BO.Baremes barem;
        private Decimal prix;
        private Boolean rappelEnvoye;
        private Boolean archive;
        #endregion

        #region Constructor
        public LignesConsultations()
        {
        }
        #endregion

        #region Getter/Setter
        [Browsable(false)]
        public BO.Consultations Consultation
        {
            get { return consultation; }
            set { consultation = value; }
        }

        public Guid? NumLigne
        {
            get { return numLigne; }
            set { numLigne = value; }
        }

        public BO.Baremes Barem
        {
            get { return barem; }
            set { barem = value; }
        }

        public Decimal Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        [Browsable(false)]
        public Boolean RappelEnvoye
        {
            get { return rappelEnvoye; }
            set { rappelEnvoye = value; }
        }

        [Browsable(false)]
        public Boolean Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion

    }
}
