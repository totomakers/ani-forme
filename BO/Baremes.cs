using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Baremes
    {
        #region Attribute
        private String codeGroupement;
        private String dateVigueur;
        private String typeAchat;
        private String libelle;
        private float tarifFixe;
        private float tarifMini;
        private float tarifMaxi;
        private BO.Vaccins vaccin;
        private Byte archive;
        #endregion

        #region Constructor
        public Baremes()
        {
        }
        #endregion

        #region Getter/Setter
        public String CodeGroupement
        {
            get { return codeGroupement; }
            set { codeGroupement = value; }
        }
        public String DateVigueur
        {
            get { return dateVigueur; }
            set { dateVigueur = value; }
        }
        public String TypeAchat
        {
            get { return typeAchat; }
            set { typeAchat = value; }
        }
        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        public float TarifFixe
        {
            get { return tarifFixe; }
            set { tarifFixe = value; }
        }
        public float TarifMini
        {
            get { return tarifMini; }
            set { tarifMini = value; }
        }
        public float TarifMaxi
        {
            get { return tarifMaxi; }
            set { tarifMaxi = value; }
        }
        public BO.Vaccins Vaccin
        {
            get { return vaccin; }
            set { vaccin = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
