using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormMain : Form
    {
        private Dictionary<int, String> mdiSubForm;
        private List<int> uniqueInstanceSubForm;

        public FormMain()
        {
            InitializeComponent();
            I18N();
            InitializeSubForm();
        }

        /// <summary>
        /// Traduction de la fenetre
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.FORM_DEFAULT_TITLE + " : " + GUI.Lang.FORM_MAIN_TITLE;

            if (BLL.AccountMgr.isLogin)
            {
                this.Text += " (connecté en tant que " + BLL.AccountMgr.loggedAccount.Username + ")";
            }

            //RIGHT TOOLSTRIP
            this.toolStripButtonAgenda.Text = GUI.Lang.FORM_MAIN_MENUITEM_AGENDA;
            this.toolStripButtonCustomerAnimal.Text = GUI.Lang.FORM_MAIN_MENUITEM_FOLDER_CUSTOMER_ANIMAL;
            this.toolStripButtonMedicalFolder.Text = GUI.Lang.FORM_MAIN_MENUITEM_MEDICAL_FOLDER;
            this.toolStripButtonReminders.Text = GUI.Lang.FORM_MAIN_MENUITEM_REMINDERS;
            this.toolStripButtonRdv.Text = GUI.Lang.FORM_MAIN_MENUITEM_TAKE_APPOINTEMENT;

            //SECRETARIAT
            this.toolStripDropDownButtonSecretariat.Text = GUI.Lang.FORM_MAIN_TOOLSTRIP_SECRETARIAT;
            this.takeRdvToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_TAKE_APPOINTEMENT;
            this.folderCustomerAnimalToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_FOLDER_CUSTOMER_ANIMAL;
            this.remindersToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_REMINDERS;
            this.updateStockVaccinToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_UPDATE_STOCK_VACCIN;

            //VETERINARY
            this.toolStripDropDownButtonVeterinary.Text = GUI.Lang.FORM_MAIN_TOOLSTRIP_VETERINARY;
            this.agendaToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_AGENDA;
            this.medicalFolderToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_MEDICAL_FOLDER;

            //PARAMS
            this.toolStripDropDownButtonParams.Text = GUI.Lang.FORM_MAIN_TOOLSTRIP_PARAMS;
            this.veterinariToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_VETERINARY;
            this.updateStockVaccinToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_UPDATECOST;
            this.listPriceToolStripMenuItem.Text = GUI.Lang.FORM_MAIN_MENUITEM_UPDATECOST;
        }

        //===========================
        //METHODES ==================
        //===========================

        /// <summary>
        /// Charge l'ensemble des sous formulaires de celui-ci
        /// </summary>
        private void InitializeSubForm()
        {
            //Ajoute ici toutes les sous fenetres
            mdiSubForm = new Dictionary<int, String>();

            //Secrétariat
            mdiSubForm[this.takeRdvToolStripMenuItem.GetHashCode()] = "GUI.SubFormTakeRdv";
            mdiSubForm[this.toolStripButtonRdv.GetHashCode()] = "GUI.SubFormTakeRdv";
            
            mdiSubForm[this.folderCustomerAnimalToolStripMenuItem.GetHashCode()] = "GUI.SubFormFolderCustomerAnimal";
            mdiSubForm[this.toolStripButtonCustomerAnimal.GetHashCode()] = "GUI.SubFormFolderCustomerAnimal";

            mdiSubForm[this.remindersToolStripMenuItem.GetHashCode()] = "GUI.SubFormReminders";
            mdiSubForm[this.toolStripButtonReminders.GetHashCode()] = "GUI.SubFormReminders";

            mdiSubForm[this.updateStockVaccinToolStripMenuItem.GetHashCode()] = "GUI.SubFormUpdateStockVaccin";

            //Vétérinaires
            mdiSubForm[this.agendaToolStripMenuItem.GetHashCode()] = "GUI.SubFormAgenda";
            mdiSubForm[this.toolStripButtonAgenda.GetHashCode()] = "GUI.SubFormAgenda";

            mdiSubForm[this.medicalFolderToolStripMenuItem.GetHashCode()] = "GUI.SubFormMedicalFolder";
            mdiSubForm[this.toolStripButtonMedicalFolder.GetHashCode()] = "GUI.SubFormMedicalFolder";
            
            //Paramètres
            mdiSubForm[this.veterinariToolStripMenuItem.GetHashCode()] = "GUI.SubFormVeterinary";
            mdiSubForm[this.listPriceToolStripMenuItem.GetHashCode()] = "GUI.SubFormListPrice";
            
            
            //Limite a une seule instance de la fenètre liée
            uniqueInstanceSubForm = new List<int>();

            //Secrétariat
            uniqueInstanceSubForm.Add(this.takeRdvToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.toolStripButtonRdv.GetHashCode());

            uniqueInstanceSubForm.Add(this.folderCustomerAnimalToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.toolStripButtonCustomerAnimal.GetHashCode());

            uniqueInstanceSubForm.Add(this.remindersToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.toolStripButtonReminders.GetHashCode());

            uniqueInstanceSubForm.Add(this.updateStockVaccinToolStripMenuItem.GetHashCode());

            //Vétérinaires
            uniqueInstanceSubForm.Add(this.agendaToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.toolStripButtonAgenda.GetHashCode());

            uniqueInstanceSubForm.Add(this.medicalFolderToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.toolStripButtonMedicalFolder.GetHashCode());
            
            //Paramètres
            uniqueInstanceSubForm.Add(this.veterinariToolStripMenuItem.GetHashCode());
            uniqueInstanceSubForm.Add(this.listPriceToolStripMenuItem.GetHashCode());
        }

       
        /// <summary>
        /// Ouvre une sous fenètre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOpenSubForm(object sender, EventArgs e)
        {
            try
            {
                // récupere la forme du bouton
                KeyValuePair<int, String> subFormItr = mdiSubForm.First(x => x.Key == sender.GetHashCode());

                bool createInstance = true;
                Form myForm = null;
                Type FormType = Type.GetType(subFormItr.Value);

                if (uniqueInstanceSubForm.Exists(x => x == sender.GetHashCode()))
                {
                    if (this.MdiChildren.Count(x => x.GetType() == FormType) > 0) //déjà un
                    {
                        myForm = this.MdiChildren.First(x => x.GetType() == FormType);
                        createInstance = false;
                    } 
                }
                
                if(createInstance) // doit en creer un nouveau
                {
                    myForm = (Form)Activator.CreateInstance(FormType);
                    myForm.MdiParent = this;
                }

                myForm.Show(); //afficher
            }
            catch (Exception ex)
            {
                String msg = "L'objet {0} est liée a l'événement ClickOpenSubForm mais n'a pas de Form dans InitializeSubForm!";
                MessageBox.Show(String.Format(msg, sender.ToString())); 
            }
        }
    }
}
