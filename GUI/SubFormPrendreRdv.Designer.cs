namespace GUI
{
    partial class SubFormPrendreRdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormPrendreRdv));
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.dataGridViewAgenda = new System.Windows.Forms.DataGridView();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.comboBoxVeterianire = new System.Windows.Forms.ComboBox();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeure = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.groupBoxVeto = new System.Windows.Forms.GroupBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonUrgence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeure)).BeginInit();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxVeto.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(6, 19);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(111, 21);
            this.comboBoxClient.TabIndex = 0;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(6, 46);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(111, 21);
            this.comboBoxAnimal.TabIndex = 1;
            // 
            // dataGridViewAgenda
            // 
            this.dataGridViewAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgenda.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewAgenda.Name = "dataGridViewAgenda";
            this.dataGridViewAgenda.ReadOnly = true;
            this.dataGridViewAgenda.RowHeadersWidth = 25;
            this.dataGridViewAgenda.Size = new System.Drawing.Size(483, 327);
            this.dataGridViewAgenda.TabIndex = 4;
            this.dataGridViewAgenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewAgenda_RowsAdded);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(123, 44);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(19, 23);
            this.buttonAddAnimal.TabIndex = 3;
            this.buttonAddAnimal.Text = "+";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(123, 19);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(19, 23);
            this.buttonAddClient.TabIndex = 2;
            this.buttonAddClient.Text = "+";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // comboBoxVeterianire
            // 
            this.comboBoxVeterianire.FormattingEnabled = true;
            this.comboBoxVeterianire.Location = new System.Drawing.Point(6, 19);
            this.comboBoxVeterianire.Name = "comboBoxVeterianire";
            this.comboBoxVeterianire.Size = new System.Drawing.Size(111, 21);
            this.comboBoxVeterianire.TabIndex = 0;
            this.comboBoxVeterianire.SelectedIndexChanged += new System.EventHandler(this.comboBoxVeterianire_SelectedIndexChanged);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownMin.Location = new System.Drawing.Point(79, 64);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownMin.TabIndex = 12;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.UpAndDownCircle);
            // 
            // numericUpDownHeure
            // 
            this.numericUpDownHeure.Location = new System.Drawing.Point(6, 64);
            this.numericUpDownHeure.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHeure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownHeure.Name = "numericUpDownHeure";
            this.numericUpDownHeure.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownHeure.TabIndex = 11;
            this.numericUpDownHeure.ValueChanged += new System.EventHandler(this.UpAndDownCircle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Heure :";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Location = new System.Drawing.Point(57, 66);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(13, 13);
            this.labelHeure.TabIndex = 9;
            this.labelHeure.Text = "h";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(419, 453);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(257, 453);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(338, 453);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.buttonAddAnimal);
            this.groupBoxClient.Controls.Add(this.comboBoxClient);
            this.groupBoxClient.Controls.Add(this.buttonAddClient);
            this.groupBoxClient.Controls.Add(this.comboBoxAnimal);
            this.groupBoxClient.Location = new System.Drawing.Point(12, 10);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(157, 95);
            this.groupBoxClient.TabIndex = 10;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // groupBoxVeto
            // 
            this.groupBoxVeto.Controls.Add(this.comboBoxVeterianire);
            this.groupBoxVeto.Location = new System.Drawing.Point(175, 10);
            this.groupBoxVeto.Name = "groupBoxVeto";
            this.groupBoxVeto.Size = new System.Drawing.Size(157, 95);
            this.groupBoxVeto.TabIndex = 11;
            this.groupBoxVeto.TabStop = false;
            this.groupBoxVeto.Text = "Vétérinaire";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.buttonUrgence);
            this.groupBoxDate.Controls.Add(this.numericUpDownMin);
            this.groupBoxDate.Controls.Add(this.dateTimePicker1);
            this.groupBoxDate.Controls.Add(this.numericUpDownHeure);
            this.groupBoxDate.Controls.Add(this.labelHeure);
            this.groupBoxDate.Controls.Add(this.label1);
            this.groupBoxDate.Location = new System.Drawing.Point(338, 10);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(157, 95);
            this.groupBoxDate.TabIndex = 12;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Date";
            // 
            // buttonUrgence
            // 
            this.buttonUrgence.Image = ((System.Drawing.Image)(resources.GetObject("buttonUrgence.Image")));
            this.buttonUrgence.Location = new System.Drawing.Point(109, 10);
            this.buttonUrgence.Name = "buttonUrgence";
            this.buttonUrgence.Size = new System.Drawing.Size(40, 40);
            this.buttonUrgence.TabIndex = 13;
            this.buttonUrgence.UseVisualStyleBackColor = true;
            this.buttonUrgence.Click += new System.EventHandler(this.buttonUrgence_Click);
            // 
            // SubFormPrendreRdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 478);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxVeto);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormPrendreRdv";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SubFormPrendreRdv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeure)).EndInit();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxVeto.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.DataGridView dataGridViewAgenda;
        private System.Windows.Forms.ComboBox comboBoxVeterianire;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownHeure;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.GroupBox groupBoxVeto;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Button buttonUrgence;
    }
}