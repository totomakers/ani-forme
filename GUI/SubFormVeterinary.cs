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
    public partial class SubFormVeterinary : Form
    {
        public SubFormVeterinary()
        {
            InitializeComponent();
            I18N();

            // lien de la dataGridView
            this.dataGridViewVeterinary.DataSource = BLL.VeterinairesMgr.GetAll(false);
        }

        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_VETERINARY_TITLE;
            this.buttonAdd.Text = GUI.Lang.FORM_DEFAULT_ADD;
            this.buttonDelete.Text = GUI.Lang.FORM_DEFAULT_DELETE;
            this.buttonReset.Text = GUI.Lang.FORM_DEFAULT_RESET;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
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
            DialogAddVeterinary dialog = new DialogAddVeterinary();
            dialog.ShowDialog();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResetVeterinary dialog = new DialogResetVeterinary();
            dialog.ShowDialog();
        }
    }
}
