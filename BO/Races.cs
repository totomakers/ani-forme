using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Races
    {
        #region Attribute
        private String race;
        private String espece;
        #endregion

        #region Constructor
        public Races()
        {
        }
        #endregion

        #region Getter/Setter
        public String Race
        {
            get { return race; }
            set { race = value; }
        }
        public String Espece
        {
            get { return espece; }
            set { espece = value; }
        }
        #endregion
    }
}
