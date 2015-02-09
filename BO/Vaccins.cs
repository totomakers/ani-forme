using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccins
    {
        #region Atribute
        private Guid? codeVaccin;
        private String nomVaccin;
        private Int32 quantiteStock;
        private Int32 periodeValidite;
        private Byte archive;
        #endregion

        #region Constructor
        public Vaccins()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid? CodeVaccin
        {
            get { return codeVaccin; }
            set { codeVaccin = value; }
        }
        
        [DisplayName("Nom")]
        public String NomVaccin
        {
            get { return nomVaccin; }
            set { nomVaccin = value; }
        }
        
        [DisplayName("Quantité")]
        public Int32 QuantiteStock
        {
            get { return quantiteStock; }
            set { quantiteStock = value; }
        }
        
        [DisplayName("Validité")]
        public Int32 PeriodeValidite
        {
            get { return periodeValidite; }
            set { periodeValidite = value; }
        }

        [Browsable(false)]
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion

        #region Methode
        public override string ToString()
        {
            return NomVaccin;
        }
        #endregion
    }
}
