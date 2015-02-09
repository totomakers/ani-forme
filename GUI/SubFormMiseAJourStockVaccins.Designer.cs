namespace GUI
{
    partial class SubFormMiseAJourStockVaccins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormMiseAJourStockVaccins));
            this.dataGridViewVaccin = new System.Windows.Forms.DataGridView();
            this.labelNomVaccin = new System.Windows.Forms.Label();
            this.labelQte = new System.Windows.Forms.Label();
            this.textBoxNomVaccin = new System.Windows.Forms.TextBox();
            this.textBoxQte = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxFrounisseur = new System.Windows.Forms.ComboBox();
            this.labelFrounisseur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVaccin
            // 
            this.dataGridViewVaccin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVaccin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVaccin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccin.Location = new System.Drawing.Point(5, 12);
            this.dataGridViewVaccin.Name = "dataGridViewVaccin";
            this.dataGridViewVaccin.ReadOnly = true;
            this.dataGridViewVaccin.Size = new System.Drawing.Size(486, 196);
            this.dataGridViewVaccin.TabIndex = 0;
            this.dataGridViewVaccin.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVaccin_RowEnter);
            this.dataGridViewVaccin.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewVaccin_RowsAdded);
            // 
            // labelNomVaccin
            // 
            this.labelNomVaccin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNomVaccin.Location = new System.Drawing.Point(2, 218);
            this.labelNomVaccin.Name = "labelNomVaccin";
            this.labelNomVaccin.Size = new System.Drawing.Size(45, 12);
            this.labelNomVaccin.TabIndex = 1;
            this.labelNomVaccin.Text = "labelNomVaccin";
            this.labelNomVaccin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQte
            // 
            this.labelQte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQte.Location = new System.Drawing.Point(160, 218);
            this.labelQte.Name = "labelQte";
            this.labelQte.Size = new System.Drawing.Size(61, 12);
            this.labelQte.TabIndex = 2;
            this.labelQte.Text = "labelQte";
            this.labelQte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNomVaccin
            // 
            this.textBoxNomVaccin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNomVaccin.Location = new System.Drawing.Point(53, 215);
            this.textBoxNomVaccin.Name = "textBoxNomVaccin";
            this.textBoxNomVaccin.ReadOnly = true;
            this.textBoxNomVaccin.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomVaccin.TabIndex = 3;
            // 
            // textBoxQte
            // 
            this.textBoxQte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxQte.Location = new System.Drawing.Point(227, 215);
            this.textBoxQte.Name = "textBoxQte";
            this.textBoxQte.Size = new System.Drawing.Size(73, 20);
            this.textBoxQte.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(416, 241);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxFrounisseur
            // 
            this.comboBoxFrounisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFrounisseur.FormattingEnabled = true;
            this.comboBoxFrounisseur.Location = new System.Drawing.Point(390, 214);
            this.comboBoxFrounisseur.Name = "comboBoxFrounisseur";
            this.comboBoxFrounisseur.Size = new System.Drawing.Size(101, 21);
            this.comboBoxFrounisseur.TabIndex = 6;
            // 
            // labelFrounisseur
            // 
            this.labelFrounisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFrounisseur.Location = new System.Drawing.Point(306, 218);
            this.labelFrounisseur.Name = "labelFrounisseur";
            this.labelFrounisseur.Size = new System.Drawing.Size(78, 12);
            this.labelFrounisseur.TabIndex = 7;
            this.labelFrounisseur.Text = "labelFournisseur";
            this.labelFrounisseur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubFormMiseAJourStockVaccins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 273);
            this.Controls.Add(this.labelFrounisseur);
            this.Controls.Add(this.comboBoxFrounisseur);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxQte);
            this.Controls.Add(this.textBoxNomVaccin);
            this.Controls.Add(this.labelQte);
            this.Controls.Add(this.labelNomVaccin);
            this.Controls.Add(this.dataGridViewVaccin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormMiseAJourStockVaccins";
            this.Text = "SubFormUpdateStockVaccin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVaccin;
        private System.Windows.Forms.Label labelNomVaccin;
        private System.Windows.Forms.Label labelQte;
        private System.Windows.Forms.TextBox textBoxNomVaccin;
        private System.Windows.Forms.TextBox textBoxQte;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxFrounisseur;
        private System.Windows.Forms.Label labelFrounisseur;
    }
}