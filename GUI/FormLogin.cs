using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// Doit être implanter dans toutes les forms
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.FORM_DEFAULT_TITLE + " : " + GUI.Lang.FORM_LOGIN_TITLE;
        }
    }
}
