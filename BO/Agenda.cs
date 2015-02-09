using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Agenda
    {
        #region Attribute
        private BO.Veterinaires veterinaire;
        private DateTime dateRdv;
        private Guid codeAnimal;
        private BO.Animaux animal;
        #endregion

        #region Constructor
        public Agenda()
        {
        }
        #endregion

        #region Getter/Setter

        public BO.Veterinaires Veterinaires
        {
            get { return veterinaire; }
            set { veterinaire = value; }
        }


        public DateTime DateRdv
        {
            get { return dateRdv; }
            set { dateRdv = value; }
        }

        public Guid CodeAnimal
        {
            get { return codeAnimal; }
            set { codeAnimal = value; }
        }

        public Animaux Animal
        {
            get { return animal; }
            set { animal = value; } 
        }
        #endregion

    }
}
