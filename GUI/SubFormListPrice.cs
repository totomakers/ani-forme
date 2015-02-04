using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class SubFormListPrice : Form
    {
        public SubFormListPrice()
        {
            InitializeComponent();
            I18N();
        }

        /// <summary>
        /// Traduction de la fenetre
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.SUB_FORM_LIST_PRICE_TITLE;
            this.labelLibelle.Text = GUI.Lang.SUB_FORM_LIST_PRICE_LABEL_LIBELLE;
            this.labelTarifFixe.Text = GUI.Lang.SUB_FORM_LIST_PRICE_LABEL_TARIF_FIXE;
            this.buttonModify.Text = GUI.Lang.SUB_FORM_LIST_PRICE_BTN_MODIFY;
            this.buttonImportXml.Text = GUI.Lang.SUB_FORM_LIST_PRICE_BTN_IMPORT;

        }

        private void SubFormListPrice_Load(object sender, EventArgs e)
        {
            this.Update_Data();
            this.dataGridViewListPrice.AutoResizeRows();
        }

        private void Update_Data()
        {
            this.dataGridViewListPrice.DataSource = BLL.ListPriceMgr.GetBaremes();
        }

        private void dataGridViewListPrice_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxLibelle.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            this.textBoxTarifFixe.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            BLL.ListPriceMgr.CreateBareme(dataGridViewListPrice.SelectedCells[0].OwningRow.Cells[0].FormattedValue.ToString(),
                                          dataGridViewListPrice.SelectedCells[0].OwningRow.Cells[1].FormattedValue.ToString(),
                                          this.textBoxTarifFixe.Text);
            this.Update_Data();
        }

        private void buttonImportXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BLL.ListPriceMgr.ImportXml(openFileDialog1.FileName);
            }
            this.Update_Data();
        }
        
    }
}
