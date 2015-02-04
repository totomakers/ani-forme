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

namespace GUI.Dialog
{
    public partial class DialogVetoReset : Form
    {
        private BO.Account account;

        public DialogVetoReset(BO.Account account)
        {
            InitializeComponent();
            I18N();
            CheckTextBox();
            this.account = account;
        }

        private void I18N()
        {
            this.Text = GUI.Lang.DIALOG_VETERINARY_RESET_TITLE;
            this.labelPassword.Text = GUI.Lang.DIALOG_VETERINARY_RESET_PASSWORD;
            this.labelConfirmPassword.Text = GUI.Lang.DIALOG_VETERINARY_RESET_CONFIRM_PASSWORD;
            this.buttonValidate.Text = GUI.Lang.FORM_DEFAULT_VALIDATE;
        }

        private void CheckTextBox()
        {
            bool canValidate = true;

            //=================
            //password
            if (!String.IsNullOrWhiteSpace(this.textBoxPassword.Text)
                && this.textBoxPassword.TextLength >= 4
                && this.textBoxPassword.Text == this.textBoxConfirmPassword.Text)
            {
                textBoxPassword.BackColor = Color.LimeGreen;
            }
            else
            {
                textBoxPassword.BackColor = Color.Red;
                canValidate = false;
            }
            
            //================
            //confirm
            if (!String.IsNullOrWhiteSpace(this.textBoxConfirmPassword.Text) 
                && this.textBoxConfirmPassword.TextLength >= 4
                && this.textBoxPassword.Text == this.textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.BackColor = Color.LimeGreen;
            }
            else
            {
                textBoxConfirmPassword.BackColor = Color.Red;
                canValidate = false;
            }

            //===============
            this.buttonValidate.Enabled = canValidate;
        }


        #region Events

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            account.setPassword(this.textBoxPassword.Text);
            BLL.AccountMgr.Update(account);

            this.Close();
        }
        #endregion
    }
}
