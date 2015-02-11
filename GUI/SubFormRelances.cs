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
    public partial class SubFormRelances : Form
    {
        public SubFormRelances()
        {
            InitializeComponent();
            Load_Content();
        }

        private void Load_Content()
        {
            //this.dataGridViewAnimauxARelancer.DataSource = BLL.LignesConsultationsMgr.GetAllRappel();
        }

        private void buttonRelanceAll_Click(object sender, EventArgs e)
        {
            if(BLL.AnimauxMgr.Relance())
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_RELANCE);
            else
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_NORELANCE);

        }

        private void buttonRelanceOne_Click(object sender, EventArgs e)
        {
            BO.Animaux animal = null;
            if(this.dataGridViewAnimauxARelancer.SelectedRows.Count > 0)
                animal = (BO.Animaux)this.dataGridViewAnimauxARelancer.SelectedRows[0].DataBoundItem;
            if (animal != null && BLL.AnimauxMgr.Relance(animal))
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_RELANCE);
            else
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_NORELANCE);
        }
    }
}
