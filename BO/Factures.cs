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
        private Guid numFacture;
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
        private Guid NumFacture
        {
            get { return numFacture; }
            set { numFacture = value; }
        }
        private DateTime DateFacture
        {
            get { return dateFacture; }
            set { dateFacture = value; }
        }
        private BO.Clients Client
        {
            get { return client; }
            set { client = value; }
        }
        private float TotalFacture
        {
            get { return totalFacture; }
            set { totalFacture = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        private Int16 Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        private DateTime RappelEnvoye
        {
            get { return rappelEnvoye; }
            set { rappelEnvoye = value; }
        }
        #endregion
    }
}
