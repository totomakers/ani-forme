using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;

namespace GUI
{
    public partial class SubFormDossierMedical : Form
    {
        #region Attributs
        private BO.Animaux currentAnimal = null;
        private List<BO.Animaux> animauxList = new List<Animaux>();
        private Int32 index;
        private static String defaultRtfText = @"{\rtf1\ainsi }"; //Pour nettoyer par de meilleur pour solution pour le moment

        /// <summary>
        /// Représente les index de la combobox de recherche
        /// </summary>
        private enum SearchFiltre
        {
            PAS_DE_FILTRE = 0,
            NOM = 1,
            NOM_CLIENT = 2,
            TATOO = 3,
        }
        #endregion

        #region Contrusteur
        /// <summary>
        /// Construction d'un dossier médical avec navigation
        /// </summary>
        public SubFormDossierMedical()
        {
            InitializeComponent();
            this.comboBoxSearchType.SelectedIndex = (int)SearchFiltre.PAS_DE_FILTRE;
            InitializeAnimauxList();
            I18N();
        }

        /// <summary>
        /// Construction d'un dossier médical avec un animal en param
        /// Déactive la recherche et la navigation
        /// </summary>
        /// <param name="animal"></param>
        public SubFormDossierMedical(BO.Animaux animal)
        {
            InitializeComponent();
            currentAnimal = animal;
            GenerateMedicalFolder();
            SetStatutNavigation(false);
            this.textBoxSearch.Enabled = false;
            this.comboBoxSearchType.Enabled = false;
            I18N();
        }
        #endregion

        #region Methodes

        /// <summary>
        /// Traduction de l'application
        /// </summary>
        private void I18N()
        {
            if (currentAnimal != null)
                this.Text = String.Format(GUI.Lang.SUBFORM_DOSSIER_MEDICAL_TITLE, currentAnimal.NomAnimal);
            else
                this.Text = GUI.Lang.SUBFORM_DOSSIER_MEDICAL_TITLE_2;

            this.buttonFirst.Text = GUI.Lang.FORM_DEFAULT_FIRST;
            this.buttonLast.Text = GUI.Lang.FORM_DEFAULT_LAST;
            this.buttonNext.Text = GUI.Lang.FORM_DEFAULT_NEXT;
            this.buttonPrev.Text = GUI.Lang.FORM_DEFAULT_PREV;
        }

        /// <summary>
        /// Charge l'animal a l'index spécifié
        /// </summary>
        private void LoadAnimal()
        { 
            // La liste est vide
            if (index == -1)
            {
                this.richTextBoxAnimal.Rtf = SubFormDossierMedical.defaultRtfText;
                this.richTextBoxAnimal.Enabled = false;
            }
            // La liste n'est pas vide
            else if (index < animauxList.Count)
            {
                currentAnimal = animauxList[index];
                GenerateMedicalFolder();
                this.Text = String.Format(GUI.Lang.SUBFORM_DOSSIER_MEDICAL_TITLE, currentAnimal.NomAnimal);
            }
        }

        /// <summary>
        /// Creer le dossier médical en RTF
        /// </summary>
        private void GenerateMedicalFolder()
        {
            this.richTextBoxAnimal.Enabled = true;
            this.richTextBoxAnimal.Rtf = SubFormDossierMedical.defaultRtfText;
            String finalStringRTF = @"";

            finalStringRTF += @"{\rtf1\ainsi ";
            finalStringRTF += @"\b Dossier médical de : #animalName\b0\par";
            finalStringRTF += @"\b\i Propriétaire : #proprioName \i0\b0\par";

            finalStringRTF = finalStringRTF.Replace("#animalName", currentAnimal.NomAnimal);
            finalStringRTF = finalStringRTF.Replace("#proprioName", currentAnimal.Client.getFullName());

            //Bouclie ici avec le remplacement des valeurs

            finalStringRTF += @"}";

            richTextBoxAnimal.Rtf = finalStringRTF;
           ;
        }
        #endregion

        #region Navigation
        //====================
        //NAVIGATION =========
        //====================

        /// <summary>
        /// Retourne la position actuel dans la liste
        /// </summary>
        private Int32 CurrentIndex
        {
            get { return index; }
            set
            {
                index = value;
                LoadAnimal();

                if (index >= 0)
                    SetStatutNavigation(true);
                else
                    SetStatutNavigation(false);
            }
        }

        /// <summary>
        /// Initialize la liste des animaux
        /// </summary>
        private void InitializeAnimauxList()
        {
            //Recherche
            if (!String.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                switch(comboBoxSearchType.SelectedIndex)
                {
                    case (int)SearchFiltre.PAS_DE_FILTRE :
                        this.animauxList = BLL.AnimauxMgr.GetAll(false);
                        break;

                    case (int)SearchFiltre.NOM:
                        this.animauxList = BLL.AnimauxMgr.GetAllByColumnLikeValue(AnimauxRechercheCritere.NOM, textBoxSearch.Text, false);
                        break;

                    case (int)SearchFiltre.NOM_CLIENT:
                        this.animauxList = BLL.AnimauxMgr.GetAllByColumnLikeValue(AnimauxRechercheCritere.NOM_CLIENT, textBoxSearch.Text, false);
                        break;

                    case (int)SearchFiltre.TATOO:
                        this.animauxList = BLL.AnimauxMgr.GetAllByColumnLikeValue(AnimauxRechercheCritere.TATOO, textBoxSearch.Text, false);
                        break;
                }
            }
            else
                this.animauxList = BLL.AnimauxMgr.GetAll(false);

            if (animauxList.Count == 0)
            {
                this.CurrentIndex = -1;
            }
            else
                this.CurrentIndex = 0;
        }

        /// <summary>
        /// Active/déactive la navigation
        /// </summary>
        /// <param name="enable"></param>
        private void SetStatutNavigation(bool enable)
        {
            this.buttonFirst.Enabled = enable;
            this.buttonLast.Enabled = enable;
            this.buttonNext.Enabled = enable;
            this.buttonPrev.Enabled = enable;

            //Il y a des clients dans la liste
            if (animauxList.Count != 0)
            {
                if (index + 1 >= animauxList.Count)
                {
                    this.buttonLast.Enabled = false;
                    this.buttonNext.Enabled = false;
                }

                if (index == 0)
                {
                    this.buttonPrev.Enabled = false;
                    this.buttonFirst.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Définis la nouvelle position a partir de l'ancienne
        /// </summary>
        /// <param name="oldPosition"></param>
        private void SetNewPosition(int oldPosition)
        {
            if (oldPosition == -1) //On avait rien on ne fais donc rien
                return;

            if (oldPosition >= animauxList.Count - 1)   //on était au dernier on va donc au nouveau dernier
                this.CurrentIndex = animauxList.Count - 1;
            else if (oldPosition > 0 && oldPosition < animauxList.Count) //Au milieu de quelque chose
                this.CurrentIndex = oldPosition;
            else //Sinon au premier
                this.CurrentIndex = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.CurrentIndex = 0;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.CurrentIndex -= 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.CurrentIndex += 1;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.CurrentIndex = animauxList.Count - 1;
        }
        #endregion

        #region Evenements
        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 oldIndex = CurrentIndex;
            InitializeAnimauxList();
            SetNewPosition(oldIndex);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Int32 oldIndex = CurrentIndex;
            InitializeAnimauxList();
            SetNewPosition(oldIndex);
        }
        #endregion 
    }
}
