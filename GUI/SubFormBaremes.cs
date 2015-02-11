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
            Load_Data();
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
            this.labelFiltre.Text = GUI.Lang.SUBFORM_LIST_PRICE_LABEL_FILTRE;
        }

        private void SubFormListPrice_Load(object sender, EventArgs e)
        {
            this.Update_Data();
            this.dataGridViewListPrice.AutoResizeRows();
        }

        private void Update_Data(String Type = "")
        {
            this.dataGridViewListPrice.DataSource = BLL.BaremesMgr.GetAll(Type);
        }

        private void Load_Data()
        {
            this.dataGridViewListPrice.DataSource = BLL.BaremesMgr.GetAll("");
            List<String> list = new List<string>();
            list.Add(GUI.Lang.SUBFORM_LIST_PRICE_EMPTY_FILTRE);
            foreach (String item in BLL.BaremesMgr.GetTypeActe())
            {
                list.Add(item);
            }
            this.comboBoxFiltre.DataSource = list;
        }

        

        private void dataGridViewListPrice_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxLibelle.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            this.textBoxTarifFixe.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            this.textBoxTarifMini.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            this.textBoxTarifMaxi.Text = dataGridViewListPrice.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewListPrice.CurrentCell != null)
            {
                BO.Baremes bareme = new BO.Baremes();
                bareme.CodeGroupement = dataGridViewListPrice.CurrentCell.OwningRow.Cells[0].FormattedValue.ToString();
                bareme.DateVigueur = dataGridViewListPrice.CurrentCell.OwningRow.Cells[1].FormattedValue.ToString();
                BLL.BaremesMgr.CreateBareme(bareme, this.textBoxTarifFixe.Text, this.textBoxTarifMini.Text, this.textBoxTarifMaxi.Text);
                this.Update_Data();
            }
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

        private void comboBoxFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Update_Data(this.comboBoxFiltre.SelectedItem.ToString());
        }
        
    }
}


