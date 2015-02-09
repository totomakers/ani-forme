namespace GUI.Dialog
{
    partial class DialogAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAnimal));
            this.buttonMedicalFolder = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelTatoo = new System.Windows.Forms.Label();
            this.labelEspece = new System.Windows.Forms.Label();
            this.comboBoxEspece = new System.Windows.Forms.ComboBox();
            this.labelRace = new System.Windows.Forms.Label();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxTatoo = new System.Windows.Forms.TextBox();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonMedicalFolder
            // 
            this.buttonMedicalFolder.Location = new System.Drawing.Point(1, 12);
            this.buttonMedicalFolder.Name = "buttonMedicalFolder";
            this.buttonMedicalFolder.Size = new System.Drawing.Size(136, 42);
            this.buttonMedicalFolder.TabIndex = 0;
            this.buttonMedicalFolder.Text = "buttonMedicalFolder";
            this.buttonMedicalFolder.UseVisualStyleBackColor = true;
            this.buttonMedicalFolder.Click += new System.EventHandler(this.buttonMedicalFolder_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidate.Location = new System.Drawing.Point(281, 12);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(86, 42);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "buttonValidate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(373, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 42);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(-2, 67);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(73, 13);
            this.labelCustomer.TabIndex = 3;
            this.labelCustomer.Text = "labelCustomer";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(1, 83);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(450, 21);
            this.comboBoxCustomer.TabIndex = 4;
            this.comboBoxCustomer.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(-2, 132);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(54, 13);
            this.labelCode.TabIndex = 5;
            this.labelCode.Text = "labelCode";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(-2, 157);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "labelName";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(-2, 184);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(53, 13);
            this.labelColor.TabIndex = 7;
            this.labelColor.Text = "labelColor";
            // 
            // labelTatoo
            // 
            this.labelTatoo.AutoSize = true;
            this.labelTatoo.Location = new System.Drawing.Point(-2, 236);
            this.labelTatoo.Name = "labelTatoo";
            this.labelTatoo.Size = new System.Drawing.Size(57, 13);
            this.labelTatoo.TabIndex = 8;
            this.labelTatoo.Text = "labelTatoo";
            // 
            // labelEspece
            // 
            this.labelEspece.AutoSize = true;
            this.labelEspece.Location = new System.Drawing.Point(-2, 207);
            this.labelEspece.Name = "labelEspece";
            this.labelEspece.Size = new System.Drawing.Size(65, 13);
            this.labelEspece.TabIndex = 9;
            this.labelEspece.Text = "labelEspece";
            // 
            // comboBoxEspece
            // 
            this.comboBoxEspece.FormattingEnabled = true;
            this.comboBoxEspece.Location = new System.Drawing.Point(67, 204);
            this.comboBoxEspece.Name = "comboBoxEspece";
            this.comboBoxEspece.Size = new System.Drawing.Size(135, 21);
            this.comboBoxEspece.TabIndex = 10;
            this.comboBoxEspece.SelectedIndexChanged += new System.EventHandler(this.comboBoxEspece_SelectedIndexChanged);
            this.comboBoxEspece.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // labelRace
            // 
            this.labelRace.Location = new System.Drawing.Point(208, 207);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(55, 13);
            this.labelRace.TabIndex = 11;
            this.labelRace.Text = "labelRace";
            this.labelRace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(269, 204);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(182, 21);
            this.comboBoxRace.TabIndex = 12;
            this.comboBoxRace.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Location = new System.Drawing.Point(67, 129);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(136, 20);
            this.textBoxCode.TabIndex = 13;
            this.textBoxCode.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 154);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(136, 20);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(67, 178);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(135, 20);
            this.textBoxColor.TabIndex = 15;
            this.textBoxColor.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // textBoxTatoo
            // 
            this.textBoxTatoo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTatoo.Location = new System.Drawing.Point(68, 236);
            this.textBoxTatoo.Name = "textBoxTatoo";
            this.textBoxTatoo.Size = new System.Drawing.Size(388, 20);
            this.textBoxTatoo.TabIndex = 16;
            this.textBoxTatoo.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(269, 153);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(183, 21);
            this.comboBoxSexe.TabIndex = 17;
            this.comboBoxSexe.TextChanged += new System.EventHandler(this.EventCheckBox);
            // 
            // DialogAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 265);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.textBoxTatoo);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.comboBoxEspece);
            this.Controls.Add(this.labelEspece);
            this.Controls.Add(this.labelTatoo);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonMedicalFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogAnimal";
            this.Text = "DialogAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMedicalFolder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelTatoo;
        private System.Windows.Forms.Label labelEspece;
        private System.Windows.Forms.ComboBox comboBoxEspece;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxTatoo;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        public System.Windows.Forms.Button buttonValidate;
    }
}