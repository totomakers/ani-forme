﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Animaux
    {
        #region Attribute
        private Guid? codeAnimal;
        private String nomAnimal;
        private Char sexe;
        private String couleur;
        private String race;
        private String espece;
        private Guid? codeClient;
        private BO.Clients client;
        private String tatouage;
        private String antecedents;
        private Boolean archive;
        #endregion

        #region constructor
        public Animaux()
        {
        }
        #endregion

        #region Getter/Setter
        [DisplayName("Code")]
        public Guid? CodeAnimal
        {
            get { return codeAnimal; }
            set { codeAnimal=value; }
        }

        [DisplayName("Nom")]
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

        public Guid? CodeClient
        {
            get { return codeClient; }
            set { codeClient = value; }
        }

        public BO.Clients Client
        {
            get { return client; }
            set { client = value; codeClient = value.CodeClient; }
        }

        public String Tatouage
        {
            get { return tatouage; }
            set { tatouage = value; }
        }

        public String Antecedents
        {
            get { return antecedents; }
            set { antecedents = value; }
        }

        [Browsable(false)]
        public Boolean Archive
        {
            get { return archive; }
            set { archive = value; }
        }
        #endregion

        #region Methodes
        public override string ToString()
        {
            return NomAnimal;
        }
        #endregion
    }
}
