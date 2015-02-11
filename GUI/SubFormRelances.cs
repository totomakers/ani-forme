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
            try
            {
                List<BO.LignesConsultations> lc = BLL.LignesConsultationsMgr.GetAllRappel();
                this.dataGridViewAnimauxARelancer.Columns.Add("CodeConsult", "Code Consultation");
                this.dataGridViewAnimauxARelancer.Columns.Add("NumLigne", "Numero Ligne");
                this.dataGridViewAnimauxARelancer.Columns.Add("NomClient", "Nom");
                this.dataGridViewAnimauxARelancer.Columns.Add("PrenomClient", "Prenom");
                this.dataGridViewAnimauxARelancer.Columns.Add("Animal", "Animal");
                foreach (BO.LignesConsultations item in lc)
                {
                    this.dataGridViewAnimauxARelancer.Rows.Add(item.Consultation.CodeConsultation, item.NumLigne, item.Consultation.Animal.Client.NomClient, item.Consultation.Animal.Client.PrenomClient, item.Consultation.Animal.NomAnimal);
                }
            }
            catch (Exception e)
            {

            }
        }

        private void buttonRelanceAll_Click(object sender, EventArgs e)
        {
            if (BLL.LignesConsultationsMgr.Relance())
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_RELANCE);
            else
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_NORELANCE);

        }

        private void buttonRelanceOne_Click(object sender, EventArgs e)
        {
            BO.Animaux animal = null;
            if(this.dataGridViewAnimauxARelancer.SelectedRows.Count > 0)
                animal = (BO.Animaux)this.dataGridViewAnimauxARelancer.SelectedRows[0].DataBoundItem;
            if (animal != null && BLL.LignesConsultationsMgr.Relance(animal))
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_RELANCE);
            else
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_NORELANCE);
        }
    }
}
