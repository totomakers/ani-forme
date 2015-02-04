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
    public partial class SubFormBaremes : Form
    {
        public SubFormBaremes()
        {
            InitializeComponent();
            I18N();
        }

        /// <summary>
        /// Traduction de la fenetre
        /// </summary>
        private void I18N()
        {
            this.Text = GUI.Lang.SUBFORM_LIST_PRICE_TITLE;
            this.labelLibelle.Text = GUI.Lang.SUBFORM_LIST_PRICE_LIB_LIBELLE;
            this.labelTarifFixe.Text = GUI.Lang.SUBFORM_LIST_PRICE_LIB_TARIF_FIXE;
            this.buttonModify.Text = GUI.Lang.SUBFORM_LIST_PRICE_BTN_MODIFY;
            this.buttonImportXml.Text = GUI.Lang.SUBFORM_LIST_PRICE_BTN_IMPORT;

        }

        private void SubFormListPrice_Load(object sender, EventArgs e)
        {
            this.Update_Data();
            this.dataGridViewListPrice.AutoResizeRows();
        }

        private void Update_Data()
        {
            this.dataGridViewListPrice.DataSource = BLL.BaremesMgr.GetAll();
        }

        private void dataGridViewListPrice_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxLibelle.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            this.textBoxTarifFixe.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            BLL.BaremesMgr.CreateBareme(dataGridViewListPrice.SelectedCells[0].OwningRow.Cells[0].FormattedValue.ToString(),
                                          dataGridViewListPrice.SelectedCells[0].OwningRow.Cells[1].FormattedValue.ToString(),
                                          this.textBoxTarifFixe.Text);
            this.Update_Data();
        }

        private void buttonImportXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BLL.BaremesMgr.ImportXml(openFileDialog1.FileName);
            }
            this.Update_Data();
        }
        
    }
}
