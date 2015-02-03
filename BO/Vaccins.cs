using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Vaccins
    {
        #region Atribute
        private Guid codeVaccin;
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
        private Guid CodeVaccin
        {
            get { return codeVaccin; }
            set { codeVaccin = value; }
        }
        private String NomVaccin
        {
            get { return nomVaccin; }
            set { nomVaccin = value; }
        }
        private Int32 QuantiteStock
        {
            get { return quantiteStock; }
            set { quantiteStock = value; }
        }
        private Int32 PeriodeValidite
        {
            get { return periodeValidite; }
            set { periodeValidite = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
