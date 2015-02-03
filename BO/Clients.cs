using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Clients
    {
        #region Attribute
        private Guid codeClient;
        private String nomClient;
        private String prenomClient;
        private String adresse1;
        private String adresse2;
        private String codePostal;
        private String ville;
        private String numTel;
        private String assurance;
        private String email;
        private String remarque;
        private Byte archive;
        #endregion

        #region Constructor
        public Clients()
        {
        }
        #endregion

        #region Getter/Setter
        public Guid CodeClient
        {
            get { return codeClient; }
            set { codeClient = value; }
        }
        public String NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }
        public String PrenomClient
        {
            get { return prenomClient; }
            set { prenomClient = value; }
        }
        public String Adresse1
        {
            get { return adresse1; }
            set { adresse1 = value; }
        }
        public String Adresse2
        {
            get { return adresse2; }
            set { adresse2 = value; }
        }
        public String CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
        public String Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public String NumTel
        {
            get { return numTel; }
            set { numTel = value; }
        }
        public String Assurance
        {
            get { return assurance; }
            set { assurance = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Remarque
        {
            get { return remarque; }
            set { remarque = value; }
        }
        public Byte Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion
    }
}
