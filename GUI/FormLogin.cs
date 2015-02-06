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

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            I18N();
        }

        /// <summary>
        /// Méthodes pour traduire l'application
        /// Doit être implenté dans toutes les forms
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.FORM_DEFAULT_TITLE + " : " + GUI.Lang.FORM_LOGIN_TITLE;
            this.labelUsername.Text = GUI.Lang.FORM_LOGIN_LIB_USERNAME;
            this.labelPassword.Text = GUI.Lang.FORM_LOGIN_LIB_PASSWORD;
            this.buttonLogin.Text = GUI.Lang.FORM_DEFAULT_VALIDATE;
        }

        #region Methodes
        //===========================
        //METHODES
        //===========================

        private void TryLogin()
        {
            String username = this.textBoxUsername.Text;
            String password = this.textBoxPassword.Text;

            //Succefull login
            if (BLL.AccountMgr.Login(username, password))
            {
                this.Hide();
                FormMain mainForm = new FormMain();
                mainForm.Show();
                mainForm.Disposed += MainFormClosed;
            }
            else
            {
                MessageBox.Show(GUI.Lang.FORM_LOGIN_LOGIN_FAIL_TEXT, 
                                GUI.Lang.FORM_DEFAULT_ERROR_TITLE,   
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void MainFormClosed(object sender, EventArgs arg)
        {
            this.Close();
        }
        #endregion

        #region Events
        //===========================
        //EVENTS 
        //===========================

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                TryLogin();
        }
        #endregion


        private void FormLogin_Load(object sender, EventArgs e)
        {
#if DEBUG
            this.textBoxPassword.Text = "test";
            this.textBoxUsername.Text = "test";
#endif       
        }

    }
}
