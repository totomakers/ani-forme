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
            this.dataGridViewListPrice.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewListPrice.Name = "dataGridViewListPrice";
            this.dataGridViewListPrice.ReadOnly = true;
            this.dataGridViewListPrice.RowHeadersWidth = 25;
            this.dataGridViewListPrice.Size = new System.Drawing.Size(672, 273);
            this.dataGridViewListPrice.TabIndex = 0;
            this.dataGridViewListPrice.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPrice_RowEnter);
            // 
            // labelLibelle
            // 
            this.labelLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLibelle.Location = new System.Drawing.Point(12, 309);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(75, 20);
            this.labelLibelle.TabIndex = 4;
            this.labelLibelle.Text = "labelLibelle";
            this.labelLibelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLibelle.Location = new System.Drawing.Point(93, 309);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.ReadOnly = true;
            this.textBoxLibelle.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibelle.TabIndex = 3;
            // 
            // labelTarifFixe
            // 
            this.labelTarifFixe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTarifFixe.Location = new System.Drawing.Point(12, 335);
            this.labelTarifFixe.Name = "labelTarifFixe";
            this.labelTarifFixe.Size = new System.Drawing.Size(75, 20);
            this.labelTarifFixe.TabIndex = 6;
            this.labelTarifFixe.Text = "labelTarifFixe";
            this.labelTarifFixe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTarifFixe
            // 
            this.textBoxTarifFixe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTarifFixe.Location = new System.Drawing.Point(93, 335);
            this.textBoxTarifFixe.Name = "textBoxTarifFixe";
            this.textBoxTarifFixe.Size = new System.Drawing.Size(100, 20);
            this.textBoxTarifFixe.TabIndex = 5;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModify.Location = new System.Drawing.Point(199, 335);
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
            this.buttonImportXml.Location = new System.Drawing.Point(609, 335);
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
            this.comboBoxFiltre.Location = new System.Drawing.Point(93, 3);
            this.comboBoxFiltre.Name = "comboBoxFiltre";
            this.comboBoxFiltre.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFiltre.TabIndex = 9;
            this.comboBoxFiltre.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltre_SelectedIndexChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.Location = new System.Drawing.Point(12, 3);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(75, 21);
            this.labelFiltre.TabIndex = 10;
            this.labelFiltre.Text = "labelfiltre";
            this.labelFiltre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubFormBaremes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 360);
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
    }
}