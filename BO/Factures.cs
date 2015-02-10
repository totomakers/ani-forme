using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Factures
    {
        #region Attribute
        private Guid? numFacture;
        private DateTime dateFacture;
        private BO.Clients client;
        private float totalFacture;
        private Byte archive;
        private Int16 etat;
        private DateTime rappelEnvoye;
        #endregion

        #region Constructor
        public Factures()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid? NumFacture
        {
            get { return numFacture; }
            set { numFacture = value; }
        }
        public DateTime DateFacture
        {
            get { return dateFacture; }
            set { dateFacture = value; }
        }
        public BO.Clients Client
        {
            get { return client; }
            set { client = value; }
        }
        public float TotalFacture
        {
            get { return totalFacture; }
            set { totalFacture = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        public Int16 Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        public DateTime RappelEnvoye
        {
            get { return rappelEnvoye; }
            set { rappelEnvoye = value; }
        }
        #endregion
    }
}
