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
        private Guid codeConsultation;
        private DateTime dateConsultation;
        private BO.Veterinaires veterinaire;
        private BO.Animaux animal;
        private String commentaire;
        private Int16 etat;
        private BO.Factures facture;
        private Byte archive;
        #endregion

        #region Constructor
        public Consultations()
        {
        }
        #endregion

        #region Getter/Setter
        private Guid CodeConsultation
        {
            get { return codeConsultation; }
            set { codeConsultation = value; }
        }
        private DateTime DateConsultation
        {
            get { return dateConsultation; }
            set { dateConsultation = value; }
        }
        private BO.Veterinaires Veterinaire
        {
            get { return veterinaire; }
            set { veterinaire = value; }
        }
        private BO.Animaux Animal
        {
            get { return animal; }
            set { animal = value; }
        }
        private String Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }
        private Int16 Etat
        {
            get { return etat; }
            set { etat = value; }
        }
        private BO.Factures Facture
        {
            get { return facture; }
            set { facture = value; }
        }
        private Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
