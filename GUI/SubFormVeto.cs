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
using GUI.Dialog;

namespace GUI
{
    public partial class SubFormVeto : Form
    {
        public SubFormVeto()
        {
            InitializeComponent();
            I18N();
            Reload();           
        }

        /// <summary>
        /// Traduction 
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_VETERINARY_TITLE;
            this.buttonAdd.Text = GUI.Lang.FORM_DEFAULT_ADD;
            this.buttonDelete.Text = GUI.Lang.FORM_DEFAULT_DELETE;
            this.buttonReset.Text = GUI.Lang.FORM_DEFAULT_RESET;

        }

        private void Reload()
        {
            this.dataGridViewVeterinary.DataSource = BLL.VeterinairesMgr.GetAll(false);
        }

        #region Events
        //===========================
        //EVENTS
        //===========================

        private void OnDialogClose(object sender, EventArgs e)
        {
            Reload();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVeterinary.CurrentRow == null)
                return;

            BO.Veterinaires veto = (BO.Veterinaires) this.dataGridViewVeterinary.CurrentRow.DataBoundItem;
            if(veto != null)
            {
                if (BLL.VeterinairesMgr.Delete(veto))
                {
                    MessageBox.Show(
                        String.Format(GUI.Lang.SUBFORM_VETERINARY_SUCCEFULL_ARCHIVE, veto.NomVeto), 
                        GUI.Lang.SUBFORM_VETERINARY_TITLE_SUCCEFULL_ARCHIVE, 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                        );
                }
            }

            this.dataGridViewVeterinary.DataSource = null;
            this.dataGridViewVeterinary.DataSource = BLL.VeterinairesMgr.GetAll(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogVetoAdd dialog = new DialogVetoAdd();
            dialog.FormClosed += OnDialogClose;
            dialog.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVeterinary.CurrentRow == null)
                return;

            BO.Veterinaires veto = (BO.Veterinaires)this.dataGridViewVeterinary.CurrentRow.DataBoundItem;
            DialogVetoReset dialog = new DialogVetoReset(veto.Account);
            dialog.FormClosed += OnDialogClose;
            dialog.ShowDialog();
        }

        #endregion
    }
}
