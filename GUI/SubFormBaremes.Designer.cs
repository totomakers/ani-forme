namespace GUI
{
    partial class SubFormBaremes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormBaremes));
            this.dataGridViewListPrice = new System.Windows.Forms.DataGridView();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.labelTarifFixe = new System.Windows.Forms.Label();
            this.textBoxTarifFixe = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonImportXml = new System.Windows.Forms.Button();
            this.comboBoxFiltre = new System.Windows.Forms.ComboBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.labelTarifMaxi = new System.Windows.Forms.Label();
            this.textBoxTarifMaxi = new System.Windows.Forms.TextBox();
            this.labelTarifMini = new System.Windows.Forms.Label();
            this.textBoxTarifMini = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListPrice
            // 
            this.dataGridViewListPrice.AllowUserToAddRows = false;
            this.dataGridViewListPrice.AllowUserToDeleteRows = false;
            this.dataGridViewListPrice.AllowUserToResizeRows = false;
            this.dataGridViewListPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPrice.Location = new System.Drawing.Point(12, 34);
            this.dataGridViewListPrice.Name = "dataGridViewListPrice";
            this.dataGridViewListPrice.ReadOnly = true;
            this.dataGridViewListPrice.RowHeadersWidth = 25;
            this.dataGridViewListPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListPrice.Size = new System.Drawing.Size(672, 336);
            this.dataGridViewListPrice.TabIndex = 0;
            this.dataGridViewListPrice.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPrice_RowEnter);
            // 
            // labelLibelle
            // 
            this.labelLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLibelle.Location = new System.Drawing.Point(12, 379);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(75, 20);
            this.labelLibelle.TabIndex = 4;
            this.labelLibelle.Text = "labelLibelle";
            this.labelLibelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLibelle.Location = new System.Drawing.Point(93, 379);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.ReadOnly = true;
            this.textBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibelle.TabIndex = 3;
            // 
            // labelTarifFixe
            // 
            this.labelTarifFixe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTarifFixe.Location = new System.Drawing.Point(12, 405);
            this.labelTarifFixe.Name = "labelTarifFixe";
            this.labelTarifFixe.Size = new System.Drawing.Size(75, 20);
            this.labelTarifFixe.TabIndex = 6;
            this.labelTarifFixe.Text = "labelTarifFixe";
            this.labelTarifFixe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTarifFixe
            // 
            this.textBoxTarifFixe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTarifFixe.Location = new System.Drawing.Point(93, 405);
            this.textBoxTarifFixe.Name = "textBoxTarifFixe";
            this.textBoxTarifFixe.Size = new System.Drawing.Size(100, 20);
            this.textBoxTarifFixe.TabIndex = 5;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModify.Location = new System.Drawing.Point(386, 404);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 20);
            this.buttonModify.TabIndex = 7;
            this.buttonModify.Text = "buttonModify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonImportXml
            // 
            this.buttonImportXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImportXml.Location = new System.Drawing.Point(609, 405);
            this.buttonImportXml.Name = "buttonImportXml";
            this.buttonImportXml.Size = new System.Drawing.Size(75, 20);
            this.buttonImportXml.TabIndex = 8;
            this.buttonImportXml.Text = "buttonImport";
            this.buttonImportXml.UseVisualStyleBackColor = true;
            this.buttonImportXml.Click += new System.EventHandler(this.buttonImportXml_Click);
            // 
            // comboBoxFiltre
            // 
            this.comboBoxFiltre.FormattingEnabled = true;
            this.comboBoxFiltre.Location = new System.Drawing.Point(93, 7);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFiltre.TabIndex = 9;
            this.comboBoxFiltre.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltre_SelectedIndexChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.Location = new System.Drawing.Point(12, 9);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(75, 15);
            this.labelFiltre.TabIndex = 10;
            this.labelFiltre.Text = "labelfiltre";
            this.labelFiltre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTarifMaxi
            // 
            this.labelTarifMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTarifMaxi.Location = new System.Drawing.Point(199, 405);
            this.labelTarifMaxi.Name = "labelTarifMaxi";
            this.labelTarifMaxi.Size = new System.Drawing.Size(75, 20);
            this.labelTarifMaxi.TabIndex = 14;
            this.labelTarifMaxi.Text = "labelTarifMaxi";
            this.labelTarifMaxi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTarifMaxi
            // 
            this.textBoxTarifMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTarifMaxi.Location = new System.Drawing.Point(280, 405);
            this.textBoxTarifMaxi.Name = "textBoxTarifMaxi";
            this.textBoxTarifMaxi.Size = new System.Drawing.Size(100, 20);
            this.textBoxTarifMaxi.TabIndex = 13;
            // 
            // labelTarifMini
            // 
            this.labelTarifMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTarifMini.Location = new System.Drawing.Point(199, 379);
            this.labelTarifMini.Name = "labelTarifMini";
            this.labelTarifMini.Size = new System.Drawing.Size(75, 20);
            this.labelTarifMini.TabIndex = 12;
            this.labelTarifMini.Text = "labelTarifMini";
            this.labelTarifMini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTarifMini
            // 
            this.textBoxTarifMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTarifMini.Location = new System.Drawing.Point(280, 379);
            this.textBoxTarifMini.Name = "textBoxTarifMini";
            this.textBoxTarifMini.Size = new System.Drawing.Size(100, 20);
            this.textBoxTarifMini.TabIndex = 11;
            // 
            // SubFormBaremes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 430);
            this.Controls.Add(this.labelTarifMaxi);
            this.Controls.Add(this.textBoxTarifMaxi);
            this.Controls.Add(this.labelTarifMini);
            this.Controls.Add(this.textBoxTarifMini);
            this.Controls.Add(this.labelFiltre);
            this.Controls.Add(this.comboBoxFiltre);
            this.Controls.Add(this.buttonImportXml);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.labelTarifFixe);
            this.Controls.Add(this.textBoxTarifFixe);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.dataGridViewListPrice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormBaremes";
            this.Text = "SubFormListPrice";
            this.Load += new System.EventHandler(this.SubFormListPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label labelTarifFixe;
        private System.Windows.Forms.TextBox textBoxTarifFixe;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonImportXml;
        private System.Windows.Forms.DataGridView dataGridViewListPrice;
        private System.Windows.Forms.ComboBox comboBoxFiltre;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.Label labelTarifMaxi;
        private System.Windows.Forms.TextBox textBoxTarifMaxi;
        private System.Windows.Forms.Label labelTarifMini;
        private System.Windows.Forms.TextBox textBoxTarifMini;
    }
}