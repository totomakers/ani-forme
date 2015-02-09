using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Dialog;

namespace GUI
{
    public partial class SubFormAgenda : Form
    {
        public SubFormAgenda()
        {
            InitializeComponent();
            I18N();

            this.comboBoxVeto.DataSource = BLL.VeterinairesMgr.GetAll(false);
            this.comboBoxVeto.SelectedItem = ((List<BO.Veterinaires>)this.comboBoxVeto.DataSource).First(x => x.AccountId == BLL.AccountMgr.loggedAccount.Id);

            UpdateContent();
        }

        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_AGENDA_TITLE;
            this.labelDate.Text = GUI.Lang.SUBFORM_AGENDA_LABEL_DATE;
            this.labelVeto.Text = GUI.Lang.SUBFORM_AGENDA_LABEL_VETO;
            this.buttonDossierMedical.Text = GUI.Lang.SUBFORM_AGENDA_BTN_DOSSIER;
            this.groupBoxVeto.Text = GUI.Lang.SUBFORM_AGENDA_GB_VETO;
            
        }

        private void UpdateContent()
        {
            BO.Veterinaires veto = (BO.Veterinaires)this.comboBoxVeto.SelectedItem;
            DateTime date = this.dateTimePickerDate.Value;
            this.dataGridViewAgenda.DataSource = BLL.AgendaMgr.GetAll(veto, date);

            this.dataGridViewAgenda.Columns["CodeAnimal"].Visible = false;
            this.dataGridViewAgenda.Columns["Urgence"].Visible = false;
        }

        private void comboBoxVeto_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void buttonDossierMedical_Click(object sender, EventArgs e)
        {
            BO.Animaux animal = null;
            
            if(this.dataGridViewAgenda.SelectedCells.Count > 0)
                animal = ((BO.Agenda)this.dataGridViewAgenda.SelectedCells[0].OwningRow.DataBoundItem).Animal;
            
            SubFormDossierMedical frm;
            
            if (animal != null)
                frm = new SubFormDossierMedical(animal);
            else
                frm = new SubFormDossierMedical();

            frm.Show();
        }

        private void dataGridViewAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewAgenda.SelectedCells.Count > 0)
            {
               BO.Agenda agenda = (BO.Agenda)this.dataGridViewAgenda.SelectedCells[0].OwningRow.DataBoundItem;
               DialogConsultation consultation = new DialogConsultation(agenda);
               consultation.Show();
            }
		}
		
        private void dataGridViewAgenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = 0;
            for (i = e.RowIndex; i < (e.RowCount + e.RowIndex); i++)
            {
                Boolean test = ((BO.Agenda)(this.dataGridViewAgenda.Rows[i].DataBoundItem)).Urgence;
                if (test)
                    this.dataGridViewAgenda.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                else
                    this.dataGridViewAgenda.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
