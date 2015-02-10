using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Consultations
    {
        #region Attribute
        private Guid? codeConsultation;
        private DateTime dateConsultation;
        private BO.Veterinaires veterinaire;
        private BO.Animaux animal;
        private String commentaire;
        private Int16 etat;
        private BO.Factures facture;
        private Boolean archive;
        #endregion

        #region Constructor
        public Consultations()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid? CodeConsultation
        {
            get { return codeConsultation; }
            set { codeConsultation = value; }
        }

        public DateTime DateConsultation
        {
            get { return dateConsultation; }
            set { dateConsultation = value; }
        }

        public BO.Veterinaires Veterinaire
        {
            get { return veterinaire; }
            set { veterinaire = value; }
        }

        public BO.Animaux Animal
        {
            get { return animal; }
            set { animal = value; }
        }

        public String Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public Int16 Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public BO.Factures Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        public Boolean Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
