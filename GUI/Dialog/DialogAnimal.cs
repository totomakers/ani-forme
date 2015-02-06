using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Dialog
{
    public enum DialogAnimalMode
    {
        ANIMAL,
        CLIENT,
        CREATE,
    }

    public partial class DialogAnimal : Form
    {
        private DialogAnimalMode mode = DialogAnimalMode.CREATE;
        private BO.Animaux animalEdited = null;
        private BO.Clients clientEdited = null;

        /// <summary>
        /// Mode ajout de la fenètre
        /// </summary>
        public DialogAnimal(BO.Clients client = null)
        {
            InitializeComponent();
            CreateMode(client);
            I18N(); //Appeler en dernier
        }

        /// <summary>
        /// Mode édition de la fenètre pour un animal
        /// </summary>
        /// <param name="animal"></param>
        public DialogAnimal(BO.Animaux animal)
        {
            InitializeComponent();
            EditMode(animal);
            I18N(); //Appeler en dernier
        }

        #region Methodes

        //================
        //METHODES =======
        //================

        private void I18N()
        {
            this.Text = GUI.Lang.DIALOG_ANIMAL_TITLE;
            this.Text += "-";

            switch (mode)
            {
                case DialogAnimalMode.ANIMAL:
                    this.Text += String.Format(GUI.Lang.DIALOG_ANIMAL_TITLE_EDIT_ANIMAL, animalEdited.NomAnimal);
                    break;

                case DialogAnimalMode.CLIENT:
                    this.Text += String.Format(GUI.Lang.DIALOG_ANIMAL_TITLE_ADD_CLIENT, clientEdited.getFullName());
                    break;

                case DialogAnimalMode.CREATE:
                    this.Text += String.Format(GUI.Lang.DIALOG_ANIMAL_TITLE_CREATE);
                    break;
            }

            this.buttonCancel.Text = GUI.Lang.FORM_DEFAULT_CANCEL;
            this.buttonValidate.Text = GUI.Lang.FORM_DEFAULT_VALIDATE;
            this.buttonMedicalFolder.Text = GUI.Lang.DIALOG_ANIMAL_MEDICAL_FOLDER;

            this.labelCode.Text = GUI.Lang.DIALOG_ANIMAL_LIB_CODE;
            this.labelColor.Text = GUI.Lang.DIALOG_ANIMAL_LIB_COLOR;
            this.labelCustomer.Text = GUI.Lang.DIALOG_ANIMAL_LIB_CUSTOMER;
            this.labelEspece.Text = GUI.Lang.DIALOG_ANIMAL_LIB_ESPECE;
            this.labelName.Text = GUI.Lang.DIALOG_ANIMAL_LIB_NAME;
            this.labelRace.Text = GUI.Lang.DIALOG_ANIMAL_LIB_RACE;
            this.labelTatoo.Text = GUI.Lang.DIALOG_ANIMAL_LIB_TATOO;   
        }

        /// <summary>
        /// Permet de passer en mode création
        /// </summary>
        private void CreateMode(BO.Clients client = null)
        {
            animalEdited = null;

            if (client != null)
            {
                mode = DialogAnimalMode.CLIENT;
                clientEdited = client;
                //@TODO précharger la textbox et la déactivé
                this.comboBoxCustomer.Enabled = false;
            }


            this.buttonMedicalFolder.Enabled = false; //dans le mode création le bouton create n'existe pas

        }

        /// <summary>
        /// Permet de passer en mode édition
        /// </summary>
        /// <param name="animal"></param>
        private void EditMode(BO.Animaux animal)
        {
            mode = DialogAnimalMode.ANIMAL;
            animalEdited = animal;
        }

        #endregion

        #region Evenements
        private void buttonMedicalFolder_Click(object sender, EventArgs e)
        {
            if (animalEdited != null)
            {
                SubFormDossierMedical formDossierMedical = new SubFormDossierMedical(animalEdited);
                formDossierMedical.ShowDialog();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        #endregion

    }
}
