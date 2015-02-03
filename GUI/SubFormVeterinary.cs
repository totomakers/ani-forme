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
                    MessageBox.Show(String.Format("Le compte de {0} a été archivé !", veto.NomVeto), "Compte archivé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.dataGridViewVeterinary.DataSource = null;
            this.dataGridViewVeterinary.DataSource = BLL.VeterinairesMgr.GetAll(false);

        }
    }
}
