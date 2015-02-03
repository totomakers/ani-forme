using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Animaux
    {
        #region Attribute
        private Guid codeAnimal;
        private String nomAnimal;
        private Char sexe;
        private String couleur;
        private BO.Races race;
        private BO.Clients client;
        private String tatouage;
        private String antecedent;
        private Byte archive;
        #endregion

        #region constructor
        public Animaux()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid CodeAnimal
        {
            get { return codeAnimal; }
            set { codeAnimal=value; }
        }
        public String NomAnimal
        {
            get { return nomAnimal; }
            set { nomAnimal = value; }
        }
        public Char Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public String Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        public BO.Races Race
        {
            get { return race; }
            set { race = value; }
        }
        public BO.Clients Client
        {
            get { return client; }
            set { client = value; }
        }
        public String Tatouage
        {
            get { return tatouage; }
            set { tatouage = value; }
        }
        public String Antecedent
        {
            get { return antecedent; }
            set { antecedent = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
