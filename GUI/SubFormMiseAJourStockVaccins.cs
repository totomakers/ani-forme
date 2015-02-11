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
            this.comboBoxFrounisseur.DataSource = BLL.FournisseurMgr.GetAll();
        }


        #region Evenements
        private void dataGridViewVaccin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxNomVaccin.Text = this.dataGridViewVaccin.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
           
            this.numericUpDownQte.Minimum = (decimal)((Int32)this.dataGridViewVaccin.Rows[e.RowIndex].Cells[1].Value);
            this.numericUpDownQte.Value = (decimal)((Int32)this.dataGridViewVaccin.Rows[e.RowIndex].Cells[1].Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewVaccin.CurrentCell != null)
                {
                    int RowOldIndex = this.dataGridViewVaccin.CurrentCell.OwningRow.Index; //Sauvegarde de l'ancien index de ligne
                    int CellOldIndex = this.dataGridViewVaccin.CurrentCell.ColumnIndex;

                    BO.Vaccins vaccin = (BO.Vaccins)this.dataGridViewVaccin.CurrentCell.OwningRow.DataBoundItem;
                    BLL.VaccinsMgr.Update(vaccin, (int)this.numericUpDownQte.Value);
                    UpdateContent();

                    //Permet de retourner a la ligne selectionner
                    if (this.dataGridViewVaccin.RowCount > RowOldIndex && this.dataGridViewVaccin.ColumnCount > CellOldIndex)
                        this.dataGridViewVaccin.CurrentCell = this.dataGridViewVaccin.Rows[RowOldIndex].Cells[CellOldIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                GUI.Lang.FORM_DEFAULT_ERROR_TITLE,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        
        public void UpdateContent()
        {
            this.dataGridViewVaccin.DataSource = BLL.VaccinsMgr.GetAll();
        }

        private void dataGridViewVaccin_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = 0;
            for (i = e.RowIndex; i < (e.RowCount + e.RowIndex); i++)
            {
                Int32 temp = ((BO.Vaccins)(this.dataGridViewVaccin.Rows[i].DataBoundItem)).QuantiteStock;
                if (temp == 0)
                    this.dataGridViewVaccin.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                else
                    this.dataGridViewVaccin.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        #endregion
    }
}
