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
    public partial class SubFormMiseAJourStockVaccins : Form
    {
        public SubFormMiseAJourStockVaccins()
        {
            InitializeComponent();
            LoadContent();
            I18N();
        }

        public void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_MAJVACCIN_TITLE;
            this.labelFrounisseur.Text = GUI.Lang.SUBFORM_MAJVACCIN_LABEL_FOURNISSEUR;
            this.labelNomVaccin.Text = GUI.Lang.SUBFORM_MAJVACCIN_LABEL_NOM;
            this.labelQte.Text = GUI.Lang.SUBFORM_MAJVACCIN_LABEL_QTE;
            this.buttonUpdate.Text = GUI.Lang.SUBFORM_MAJVACCIN_BUTTON_MODIFY;
        }

        public void LoadContent()
        {
            this.dataGridViewVaccin.DataSource = BLL.VaccinsMgr.GetAll();
            this.dataGridViewVaccin.Columns[0].Visible = false;
            
            this.comboBoxFrounisseur.DataSource = BLL.FournisseurMgr.GetAll();

        }


        #region Evenements
        private void dataGridViewVaccin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxNomVaccin.Text = this.dataGridViewVaccin.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            this.textBoxQte.Text = this.dataGridViewVaccin.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            BLL.VaccinsMgr.Update(  this.dataGridViewVaccin.SelectedCells[0].OwningRow.Cells[0].FormattedValue.ToString(),
                                    this.textBoxQte.Text);
            UpdateContent();
        }
        
        public void UpdateContent()
        {
            this.dataGridViewVaccin.DataSource = BLL.VaccinsMgr.GetAll();
        }
        #endregion
    }
}
