namespace GUI
{
    partial class SubFormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormAgenda));
            this.groupBoxVeto = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxVeto = new System.Windows.Forms.ComboBox();
            this.labelVeto = new System.Windows.Forms.Label();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.buttonDossierMedical = new System.Windows.Forms.Button();
            this.groupBoxVeto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVeto
            // 
            this.groupBoxVeto.Controls.Add(this.dateTimePickerDate);
            this.groupBoxVeto.Controls.Add(this.labelDate);
            this.groupBoxVeto.Controls.Add(this.comboBoxVeto);
            this.groupBoxVeto.Controls.Add(this.labelVeto);
            this.groupBoxVeto.Location = new System.Drawing.Point(9, 10);
            this.groupBoxVeto.Name = "groupBoxVeto";
            this.groupBoxVeto.Size = new System.Drawing.Size(345, 52);
            this.groupBoxVeto.TabIndex = 0;
            this.groupBoxVeto.TabStop = false;
            this.groupBoxVeto.Text = "De :";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(248, 19);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(88, 20);
            this.dateTimePickerDate.TabIndex = 3;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(190, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "labelDate";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxVeto
            // 
            this.comboBoxVeto.FormattingEnabled = true;
            this.comboBoxVeto.Location = new System.Drawing.Point(63, 19);
            this.comboBoxVeto.Name = "comboBoxVeto";
            this.comboBoxVeto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVeto.TabIndex = 1;
            this.comboBoxVeto.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeto_SelectedIndexChanged);
            // 
            // labelVeto
            // 
            this.labelVeto.AutoSize = true;
            this.labelVeto.Location = new System.Drawing.Point(6, 22);
            this.labelVeto.Name = "labelVeto";
            this.labelVeto.Size = new System.Drawing.Size(51, 13);
            this.labelVeto.TabIndex = 0;
            this.labelVeto.Text = "labelVeto";
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Location = new System.Drawing.Point(11, 68);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.ReadOnly = true;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(343, 200);
            this.dataGridViewAgenda.TabIndex = 1;
            this.dataGridViewAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgenda_CellDoubleClick);
            this.dataGridViewAgenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewAgenda_RowsAdded);
            // 
            // buttonDossierMedical
            // 
            this.buttonDossierMedical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDossierMedical.Location = new System.Drawing.Point(279, 274);
            this.buttonDossierMedical.Name = "buttonDossierMedical";
            this.buttonDossierMedical.Size = new System.Drawing.Size(75, 38);
            this.buttonDossierMedical.TabIndex = 2;
            this.buttonDossierMedical.Text = "buttonDossierMedical";
            this.buttonDossierMedical.UseVisualStyleBackColor = true;
            this.buttonDossierMedical.Click += new System.EventHandler(this.buttonDossierMedical_Click);
            // 
            // SubFormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 316);
            this.Controls.Add(this.buttonDossierMedical);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Controls.Add(this.groupBoxVeto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormAgenda";
            this.Text = "Agenda";
            this.groupBoxVeto.ResumeLayout(false);
            this.groupBoxVeto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVeto;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxVeto;
        private System.Windows.Forms.Label labelVeto;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.Button buttonDossierMedical;
    }
}