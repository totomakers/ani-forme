using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Guid? codeAnimal;
        private BO.Animaux animal;
        private Boolean urgence;
        #endregion

        #region Constructor
        public Agenda()
        {
        }
        #endregion

        #region Getter/Setter
        [DisplayName("Vétérinaire")]
        public BO.Veterinaires Veterinaires
        {
            get { return veterinaire; }
            set { veterinaire = value; }
        }

        [DisplayName("Date")]
        public DateTime DateRdv
        {
            get { return dateRdv; }
            set { dateRdv = value; }
        }

        public Guid? CodeAnimal
        {
            get { return codeAnimal; }
            set { codeAnimal = value; }
        }

        [DisplayName("Animal")]
        public Animaux Animal
        {
            get { return animal; }
            set { animal = value; } 
        }

        public Boolean Urgence
        {
            get { return urgence; }
            set { urgence = value; }
        }
        #endregion

    }
}
