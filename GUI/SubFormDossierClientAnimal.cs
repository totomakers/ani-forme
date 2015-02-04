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
    public partial class SubFormDossierClientAnimal : Form
    {
        private String filtreName = "";
        private List<BO.Clients> clientsList = new List<Clients>();
        private Int32 index;
        private BO.Clients currentClient = null;

        public SubFormDossierClientAnimal()
        {
            InitializeComponent();
            I18N();
            InitializeClientsList();
            LoadClient();
        }


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


        }

        private void LoadClient()
        {
            if (index < clientsList.Count)
            {
                currentClient = clientsList[index];

                this.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_TITLE + " - " + currentClient.NomClient + " " + currentClient.PrenomClient;

                this.textBoxAdresse.Text = currentClient.Adresse1;
                this.textBoxAdresse2.Text = currentClient.Adresse2;
                this.textBoxCity.Text = currentClient.Ville;
                this.textBoxCode.Text = currentClient.CodeClient.ToString();
                this.textBoxFirstName.Text = currentClient.NomClient;
                this.textBoxLastName.Text = currentClient.PrenomClient;
                this.textBoxPostalCode.Text = currentClient.CodePostal;

                this.checkBoxSearch.Text = GUI.Lang.SUBFORM_FOLDERCUSTANI_SEARCH;
            }
        }

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
                StatutNavigation(true);
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
            //this.dataGridViewAnimals.DataSource = 

            if (clientsList.Count == 0)
                StatutNavigation(false);
            else
            {
                this.CurrentIndex = 0;
                StatutNavigation(true);
            }
            
        }

        /// <summary>
        /// Enable disable the navigation
        /// </summary>
        /// <param name="enable"></param>
        private void StatutNavigation(bool enable)
        {
            this.buttonAddAni.Enabled = enable;
            this.buttonDeleteAni.Enabled = enable;
            this.buttonFirst.Enabled = enable;
            this.buttonLast.Enabled = enable;
            this.buttonNext.Enabled = enable;
            this.buttonPrev.Enabled = enable;
            this.buttonDelete.Enabled = enable;

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

        private void SetNewPosition(int oldPosition)
        {
            //Récupration ancienne position
            if (oldPosition >= clientsList.Count - 1)   //on été au dernier on va donc au nouveau dernier
                this.CurrentIndex = clientsList.Count - 1;
            else if (oldPosition > 0 && oldPosition < clientsList.Count) //Au milieu de quelque chose
                this.CurrentIndex = oldPosition;
            else
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

        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32 prevIndex = index;

            //Archivage du client en cours
            if (BLL.ClientsMgr.Delete(currentClient))
            {
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_FOLDERCUSTANI_SUCCEFULL_ARCHIVE, currentClient.getFullName()), 
                                GUI.Lang.SUBFORM_FOLDERCUSTANI_TITLE_SUCCEFULL_ARCHIVE, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
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
    }
}
