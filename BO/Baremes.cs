using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private String typeActe;
        private String libelle;
        private Decimal tarifFixe;
        private Decimal tarifMini;
        private Decimal tarifMaxi;
        private BO.Vaccins vaccin;
        private Byte archive;
        #endregion

        #region Constructor
        public Baremes()
        {
        }
        #endregion

        #region Getter/Setter
        [DisplayName("Code Groupement")]
        public String CodeGroupement
        {
            get { return codeGroupement; }
            set { codeGroupement = value; }
        }

        [DisplayName("Date d'entrée en vigueure")]
        public String DateVigueur
        {
            get { return dateVigueur; }
            set { dateVigueur = value; }
        }

        [DisplayName("Code Acte")]
        public String TypeActe
        {
            get { return typeActe; }
            set { typeActe = value; }
        }

        [DisplayName("Nom")]
        public String Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        [DisplayName("Tarif Fixe")]
        public Decimal TarifFixe
        {
            get { return tarifFixe; }
            set { tarifFixe = value; }
        }

        [DisplayName("Tarif Mini")]
        public Decimal TarifMini
        {
            get { return tarifMini; }
            set { tarifMini = value; }
        }

        [DisplayName("Tarif Max")]
        public Decimal TarifMaxi
        {
            get { return tarifMaxi; }
            set { tarifMaxi = value; }
        }

        [DisplayName("Vaccin")]
        public BO.Vaccins Vaccin
        {
            get { return vaccin; }
            set { vaccin = value; }
        }

        [Browsable(false)]
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
