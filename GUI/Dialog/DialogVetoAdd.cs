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
using BO;

namespace GUI.Dialog
{
    public partial class DialogVetoAdd : Form
    {
        public DialogVetoAdd()
        {
            InitializeComponent();
            I18N();
            CheckTextBox();
        }

        //==================
        //METHODES =========
        //==================

        private void I18N()
        {
            this.Text = GUI.Lang.DIALOG_VETERINARY_ADD_TITLE;
            this.labelName.Text = GUI.Lang.DIALOG_VETERINARY_ADD_LIB_NAME;
            this.labelPassword.Text = GUI.Lang.DIALOG_VETERINARY_ADD_LIB_PASSWORD;
            this.labelUsername.Text = GUI.Lang.DIALOG_VETERINARY_ADD_LIB_USERNAME;
            this.buttonAdd.Text = GUI.Lang.FORM_DEFAULT_ADD;
        }

        private void CheckTextBox()
        {
            bool canValidate = true;

            //===========================
            //Vérification nom
            //Longueur > 0
            //Requis
            if (textBoxName.TextLength > 0)
            {
                textBoxName.BackColor = Color.LimeGreen;
            }
            else
            {
                textBoxName.BackColor = Color.Red;
                canValidate = false;
            }
            //==============================

            //===========================
            //Vérification Username
            if (textBoxUsername.TextLength > 0 && !AccountMgr.isLogin(textBoxUsername.Text))
            {
                textBoxUsername.BackColor = Color.LimeGreen;
            }
            else
            {
                textBoxUsername.BackColor = Color.Red;
                canValidate = false;
            }
            //==============================

            //===========================
            //Vérification Password
            if (textBoxPassword.TextLength >= 4)
            {
                textBoxPassword.BackColor = Color.LimeGreen;
            }
            else
            {
                textBoxPassword.BackColor = Color.Red;
                canValidate = false;
            }
            //==============================

            this.buttonAdd.Enabled = canValidate;
        }

        //==================
        //EVENTS ===========
        //==================

        private void doCheck(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String username = this.textBoxUsername.Text;
            String password = this.textBoxPassword.Text;

            Account newAccount = AccountMgr.Create(new Account() { Username = username, PasswordSHA1 = Account.getSHA1Password(username, password) });
            VeterinairesMgr.Create(new Veterinaires() { AccountId = newAccount.Id, Archive = false, NomVeto = this.textBoxName.Text });
            this.Close();
        }
    }
}
