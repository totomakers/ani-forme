﻿using System;
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
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class SubFormDossierClientAnimal : Form
    {
        private String filtreName = "";
        private List<BO.Clients> clientsList = new List<Clients>();
        private Int32 index;
        private BO.Clients currentClient = null;
        private bool createMode = false;


        public SubFormDossierClientAnimal()
        {
            InitializeComponent();
            I18N();
            InitializeClientsList();
            LoadClient();
        }

        #region Methodes

        /// <summary>
        /// Traduction de la fenetre
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_TITLE;
            this.labelAdresse.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_ADRESSE;
            this.labelCity.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_CITY;
            this.labelCode.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_CODE;
            this.labelFirstName.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_FIRSTNAME;
            this.labelLastName.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_LASTNAME;
            this.labelPostalCode.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_LIB_POSTALCODE;

            this.buttonAdd.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_ADD_CUST;
            this.buttonDelete.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_DEL_CUST;

            this.buttonAddAni.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_ADD_ANI;
            this.buttonDeleteAni.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_DELETE_ANI;

            this.buttonFirst.Text = GUI.Lang.FORM_DEFAULT_FIRST;
            this.buttonLast.Text = GUI.Lang.FORM_DEFAULT_LAST;
            this.buttonNext.Text = GUI.Lang.FORM_DEFAULT_NEXT;
            this.buttonPrev.Text = GUI.Lang.FORM_DEFAULT_PREV;

            this.buttonCancelAddCli.Text = GUI.Lang.FORM_DEFAULT_CANCEL;
            this.buttonValidateAddCli.Text = GUI.Lang.FORM_DEFAULT_VALIDATE;
        }

        /// <summary>
        /// Vérifie les checkbox, uniquement en mode création sinon, ne fais rien
        /// </summary>
        private void CheckTextBox()
        {
            if (this.CreateMode)
            {
                bool canAdd = true;
                //====================
                //Adresse1
                if (String.IsNullOrWhiteSpace(this.textBoxAdresse.Text))
                {
                    this.textBoxAdresse.BackColor = Color.Red;
                    canAdd = false;
                }
                else this.textBoxAdresse.BackColor = Color.LightGreen;
                //====================
                //Adresse2
                this.textBoxAdresse2.BackColor = Color.LightGreen;
                //====================
                 //Ville
                this.textBoxCity.BackColor = Color.LightGreen;
                //====================
                //Nom
                if (String.IsNullOrWhiteSpace(this.textBoxLastName.Text))
                {
                    this.textBoxLastName.BackColor = Color.Red;
                    canAdd = false;
                }
                else this.textBoxLastName.BackColor = Color.LightGreen;
                //====================
                //Prénom
                if (String.IsNullOrWhiteSpace(this.textBoxFirstName.Text))
                {
                    this.textBoxFirstName.BackColor = Color.Red;
                    canAdd = false;
                }
                else this.textBoxFirstName.BackColor = Color.LightGreen;
                //====================
                //Code postal
                Match match = Regex.Match(this.textBoxPostalCode.Text, @"\d{5}-?(\d{4})?$");
                if (!match.Success)
                {
                    this.textBoxPostalCode.BackColor = Color.Red;
                    canAdd = false;
                }
                else this.textBoxPostalCode.BackColor = Color.LightGreen;
                //======================  
                //Activation du bouton d'ajout
                this.buttonValidateAddCli.Enabled = canAdd;
            }
            else
            {
                this.textBoxAdresse.BackColor = default(Color);
                this.textBoxAdresse2.BackColor = default(Color);
                this.textBoxCity.BackColor = default(Color);
                this.textBoxFirstName.BackColor = default(Color);
                this.textBoxLastName.BackColor = default(Color);
                this.textBoxPostalCode.BackColor = default(Color);
            }
        }

        /// <summary>
        /// Active/Déactive le mode création
        /// </summary>
        public bool CreateMode
        {
            get { return createMode; }
            set
            {
                createMode = value;

                //Activation/Déactivation tableau
                this.dataGridViewAnimals.Enabled = !createMode;

                //Déactivation de la recherche
                this.checkBoxSearch.Enabled = !createMode;
                this.textBoxSearch.Enabled = !createMode;

                //Déactive les boutons pour animaux
                this.buttonAddAni.Enabled = !createMode;
                this.buttonDeleteAni.Enabled = !createMode;

                //Déactive la navigation
                this.StatutNavigation(!createMode);
                this.buttonAdd.Enabled = !createMode;

                this.buttonCancelAddCli.Visible = createMode;
                this.buttonValidateAddCli.Visible = createMode;
                this.buttonDelete.Visible = !createMode;

                if (createMode)
                {
                    //Active les textesbox
                    this.textBoxAdresse.Enabled = true;
                    this.textBoxAdresse2.Enabled = true;
                    this.textBoxCity.Enabled = true;
                    this.textBoxCode.Enabled = true;
                    this.textBoxFirstName.Enabled = true;
                    this.textBoxLastName.Enabled = true;
                    this.textBoxPostalCode.Enabled = true;

                    //Vide les textesbox
                    this.textBoxAdresse.Text = "";
                    this.textBoxAdresse2.Text = "";
                    this.textBoxCity.Text = "";
                    this.textBoxCode.Text = "";
                    this.textBoxFirstName.Text = "";
                    this.textBoxLastName.Text = "";
                    this.textBoxPostalCode.Text = "";

                    //Vide le tableau
                    this.dataGridViewAnimals.DataSource = null;
                }
                else
                {
                    //Recharge les clients
                    InitializeClientsList();
                    LoadClient();
                }

                CheckTextBox(); //Redraw textbox
            }
        }

        //Chargement d'un client
        private void LoadClient()
        {
            //Pas de client
            if (index == -1)
            {
                //Vide le tableau des animaux
                this.dataGridViewAnimals.DataSource = null;
                this.dataGridViewAnimals.Enabled = false;

                //Vide les textbox
                this.textBoxAdresse.Text = "";
                this.textBoxAdresse2.Text = "";
                this.textBoxCity.Text = "";
                this.textBoxCode.Text = "";
                this.textBoxFirstName.Text = "";
                this.textBoxLastName.Text = "";
                this.textBoxPostalCode.Text = "";

                //Déactive les texbox
                this.textBoxAdresse.Enabled = false;
                this.textBoxAdresse2.Enabled = false;
                this.textBoxCity.Enabled = false;
                this.textBoxCode.Enabled = false;
                this.textBoxFirstName.Enabled = false;
                this.textBoxLastName.Enabled = false;
                this.textBoxPostalCode.Enabled = false;

                this.buttonAddAni.Enabled = false;
                this.buttonDeleteAni.Enabled = false;
            }
            //Un client
            else if (index < clientsList.Count)
            {
                currentClient = clientsList[index];

                this.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_TITLE + " - " + currentClient.NomClient + " " + currentClient.PrenomClient;

                //Remplis les textbox
                this.textBoxAdresse.Text = currentClient.Adresse1;
                this.textBoxAdresse2.Text = currentClient.Adresse2;
                this.textBoxCity.Text = currentClient.Ville;
                this.textBoxCode.Text = currentClient.CodeClient.ToString();
                this.textBoxFirstName.Text = currentClient.NomClient;
                this.textBoxLastName.Text = currentClient.PrenomClient;
                this.textBoxPostalCode.Text = currentClient.CodePostal;

                //Active les texbox
                this.textBoxAdresse.Enabled = true;
                this.textBoxAdresse2.Enabled = true;
                this.textBoxCity.Enabled = true;
                this.textBoxFirstName.Enabled = true;
                this.textBoxLastName.Enabled = true;
                this.textBoxPostalCode.Enabled = true;

                this.checkBoxSearch.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_SEARCH;

                //==============
                //Animaux =======
                this.dataGridViewAnimals.DataSource = BLL.AnimauxMgr.GetAllByClient(currentClient); //load animals list
                this.buttonAddAni.Enabled = true;
                this.buttonDeleteAni.Enabled = true;
                //===============
            }
        }
        #endregion

        #region Navigation
        //====================
        //Navigation =========
        //====================

        private Int32 CurrentIndex
        {
            get { return index; }
            set 
            {
                index = value;
                LoadClient();

                if (index >= 0)
                    StatutNavigation(true);
                else
                    StatutNavigation(false);
            }
        }

        /// <summary>
        /// Initialize the client list
        /// </summary>
        private void InitializeClientsList()
        {
            if (checkBoxSearch.Checked)
                clientsList = ClientsMgr.GetAll(false, textBoxSearch.Text);
            else
                clientsList = ClientsMgr.GetAll(false);
            
            if (clientsList.Count == 0)
                this.CurrentIndex = -1;
            else
                this.CurrentIndex = 0;
        }

        /// <summary>
        /// Active/déactive la navigation
        /// </summary>
        /// <param name="enable"></param>
        private void StatutNavigation(bool enable)
        {
            this.buttonFirst.Enabled = enable;
            this.buttonLast.Enabled = enable;
            this.buttonNext.Enabled = enable;
            this.buttonPrev.Enabled = enable;
            this.buttonDelete.Enabled = enable;

            //Il y a des clients dans la liste
            if (clientsList.Count != 0)
            {
                if (index + 1 >= clientsList.Count)
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

        private void SetNewPosition(int oldPosition)
        {
            if (oldPosition == -1) //On avait rien on ne fais donc rien
                return;

            if (oldPosition >= clientsList.Count - 1)   //on été au dernier on va donc au nouveau dernier
                this.CurrentIndex = clientsList.Count - 1;
            else if (oldPosition > 0 && oldPosition < clientsList.Count) //Au milieu de quelque chose
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
            this.CurrentIndex = clientsList.Count - 1;
        }

        //======================================
        #endregion

        #region Events
        //====================
        //EVENTS
        //====================

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 prevIndex = index;

            //Archivage du client en cours
            try
            {
                BLL.ClientsMgr.Delete(currentClient);  
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_FOLDERCUSTANI_SUCCEFULL_ARCHIVE, currentClient.getFullName()), 
                                GUI.Lang.SUBFORM_FOLDERCUSTANI_TITLE_SUCCEFULL_ARCHIVE, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                                GUI.Lang.FORM_DEFAULT_ERROR_TITLE,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            InitializeClientsList();
            SetNewPosition(prevIndex);
        }

        private void checkBoxSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSearch.Checked)
            {
                filtreName = this.textBoxSearch.Text;
            }

            Int32 prevIndex = index;
            InitializeClientsList();
            SetNewPosition(prevIndex);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Int32 prevIndex = index;
            InitializeClientsList();
            SetNewPosition(prevIndex); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.CreateMode = true;
        }

        private void buttonCancelAddCli_Click(object sender, EventArgs e)
        {
            this.CreateMode = false;
        }

        private void buttonValidateAddCli_Click(object sender, EventArgs e)
        {
            //Creation de l'objet client
            Clients cli = new Clients { Adresse1 = this.textBoxAdresse.Text, 
                                        Adresse2 = this.textBoxAdresse2.Text,
                                        Archive = false,
                                        CodePostal = this.textBoxPostalCode.Text,
                                        NomClient = this.textBoxFirstName.Text,
                                        PrenomClient = this.textBoxLastName.Text,
                                        Ville = this.textBoxCity.Text };

            Clients finalCli = BLL.ClientsMgr.Create(cli); //Contient le client avec l'id


            this.CreateMode = false;
            //Change l'index a la position du nouveau client
            if (finalCli != null && (finalCli = this.clientsList.First(x => x.CodeClient == finalCli.CodeClient)) != null)
                this.CurrentIndex = this.clientsList.IndexOf(finalCli);
        }

        private void buttonDeleteAni_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewAnimals.CurrentRow != null)
            {
                Animaux animal = (Animaux)this.dataGridViewAnimals.CurrentRow.DataBoundItem;
                try
                {
                    AnimauxMgr.Delete(animal);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                GUI.Lang.FORM_DEFAULT_ERROR_TITLE,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }

        private void doCheck(object sender, EventArgs e)
        {
            CheckTextBox();
        }
        #endregion


    }
}