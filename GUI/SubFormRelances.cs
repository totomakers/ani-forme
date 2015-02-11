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
            I18N();
        }

        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_RELANCE_TITLE;
            this.buttonRelanceAll.Text = GUI.Lang.SUBFORM_RELANCE_BUTTON_RELANCE_ALL;
            this.buttonRelanceOne.Text = GUI.Lang.SUBFORM_RELANCE_BUTTON_RELANCE_ONE;
        }

        private void Load_Content()
        {
            try
            {
                List<BO.LignesConsultations> lc = BLL.LignesConsultationsMgr.GetAllRappel();
                this.dataGridViewAnimauxARelancer.Columns.Clear();
                this.dataGridViewAnimauxARelancer.Rows.Clear();

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
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_RELANCE_ERROR_DATA_LOAD, e.Message));
            }
        }

        private void buttonRelanceAll_Click(object sender, EventArgs e)
        {
            int nbrow = BLL.LignesConsultationsMgr.Relance();
            if (nbrow>0)
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_RELANCE_RELANCE,nbrow) );
            else
                MessageBox.Show(GUI.Lang.SUBFORM_RELANCE_NORELANCE);

            Load_Content();
        }

        private void buttonRelanceOne_Click(object sender, EventArgs e)
        {
            BO.LignesConsultations ligne = new BO.LignesConsultations();
            ligne.Consultation = new BO.Consultations();
            if (this.dataGridViewAnimauxARelancer.SelectedRows.Count > 0)
            {
                ligne.Consultation.CodeConsultation = Guid.Parse(this.dataGridViewAnimauxARelancer.SelectedRows[0].Cells[0].FormattedValue.ToString());
                ligne.NumLigne = Guid.Parse(this.dataGridViewAnimauxARelancer.SelectedRows[0].Cells[1].FormattedValue.ToString());
            }
            String NomClient = this.dataGridViewAnimauxARelancer.SelectedRows[0].Cells[2].FormattedValue.ToString();
            String PrenomClient = this.dataGridViewAnimauxARelancer.SelectedRows[0].Cells[3].FormattedValue.ToString();
            String NomAnimal = this.dataGridViewAnimauxARelancer.SelectedRows[0].Cells[4].FormattedValue.ToString();

            if (ligne != null && (BLL.LignesConsultationsMgr.Relance(ligne)>0))
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_RELANCE_RELANCE_ONE,NomClient, NomAnimal));
            else
                MessageBox.Show(String.Format(GUI.Lang.SUBFORM_RELANCE_NORELANCE_ONE,NomClient + ' ' + PrenomClient));

            Load_Content();
        }
    }
}
