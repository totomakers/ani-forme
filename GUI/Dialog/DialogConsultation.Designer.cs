﻿namespace GUI.Dialog
{
    partial class DialogConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogConsultation));
            this.buttonMedicalFolder = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.textBoxAniSexe = new System.Windows.Forms.TextBox();
            this.textBoxAniColor = new System.Windows.Forms.TextBox();
            this.textBoxAniTatoo = new System.Windows.Forms.TextBox();
            this.textBoxAniRace = new System.Windows.Forms.TextBox();
            this.textBoxAniEspec = new System.Windows.Forms.TextBox();
            this.textBoxAniName = new System.Windows.Forms.TextBox();
            this.textBoxAniCode = new System.Windows.Forms.TextBox();
            this.labelAniTatoo = new System.Windows.Forms.Label();
            this.labelAniColor = new System.Windows.Forms.Label();
            this.labelAniSexe = new System.Windows.Forms.Label();
            this.labelAniRace = new System.Windows.Forms.Label();
            this.labelAniEspece = new System.Windows.Forms.Label();
            this.labelAniName = new System.Windows.Forms.Label();
            this.labelAniCode = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.groupBoxActe = new System.Windows.Forms.GroupBox();
            this.buttonActeDelete = new System.Windows.Forms.Button();
            this.buttonActeAdd = new System.Windows.Forms.Button();
            this.textBoxActeTotal = new System.Windows.Forms.TextBox();
            this.comboBoxActeLibelle = new System.Windows.Forms.ComboBox();
            this.labelActeLibelle = new System.Windows.Forms.Label();
            this.comboBoxActeType = new System.Windows.Forms.ComboBox();
            this.textBoxActeVeto = new System.Windows.Forms.TextBox();
            this.dateTimePickerActe = new System.Windows.Forms.DateTimePicker();
            this.labelActeTotal = new System.Windows.Forms.Label();
            this.dataGridViewActe = new System.Windows.Forms.DataGridView();
            this.groupBoxTarif = new System.Windows.Forms.GroupBox();
            this.numericUpDownActePrix = new System.Windows.Forms.NumericUpDown();
            this.textBoxActeMax = new System.Windows.Forms.TextBox();
            this.textBoxActeMin = new System.Windows.Forms.TextBox();
            this.labelActePrix = new System.Windows.Forms.Label();
            this.labelActeMax = new System.Windows.Forms.Label();
            this.labelActeMin = new System.Windows.Forms.Label();
            this.labelActeVeto = new System.Windows.Forms.Label();
            this.labelActeType = new System.Windows.Forms.Label();
            this.labelActeDate = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxAnimal.SuspendLayout();
            this.groupBoxActe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActe)).BeginInit();
            this.groupBoxTarif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActePrix)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMedicalFolder
            // 
            this.buttonMedicalFolder.Location = new System.Drawing.Point(4, 7);
            this.buttonMedicalFolder.Name = "buttonMedicalFolder";
            this.buttonMedicalFolder.Size = new System.Drawing.Size(111, 35);
            this.buttonMedicalFolder.TabIndex = 0;
            this.buttonMedicalFolder.Text = "buttonMedicalFolder";
            this.buttonMedicalFolder.UseVisualStyleBackColor = true;
            this.buttonMedicalFolder.Click += new System.EventHandler(this.buttonMedicalFolder_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidate.Location = new System.Drawing.Point(355, 7);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(111, 35);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "buttonValidate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(472, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(111, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAnimal.Controls.Add(this.textBoxAniSexe);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniColor);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniTatoo);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniRace);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniEspec);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniName);
            this.groupBoxAnimal.Controls.Add(this.textBoxAniCode);
            this.groupBoxAnimal.Controls.Add(this.labelAniTatoo);
            this.groupBoxAnimal.Controls.Add(this.labelAniColor);
            this.groupBoxAnimal.Controls.Add(this.labelAniSexe);
            this.groupBoxAnimal.Controls.Add(this.labelAniRace);
            this.groupBoxAnimal.Controls.Add(this.labelAniEspece);
            this.groupBoxAnimal.Controls.Add(this.labelAniName);
            this.groupBoxAnimal.Controls.Add(this.labelAniCode);
            this.groupBoxAnimal.Location = new System.Drawing.Point(1, 48);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(582, 159);
            this.groupBoxAnimal.TabIndex = 3;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "groupBoxAnimal";
            // 
            // textBoxAniSexe
            // 
            this.textBoxAniSexe.Location = new System.Drawing.Point(294, 42);
            this.textBoxAniSexe.Name = "textBoxAniSexe";
            this.textBoxAniSexe.ReadOnly = true;
            this.textBoxAniSexe.Size = new System.Drawing.Size(31, 20);
            this.textBoxAniSexe.TabIndex = 13;
            // 
            // textBoxAniColor
            // 
            this.textBoxAniColor.Location = new System.Drawing.Point(371, 42);
            this.textBoxAniColor.Name = "textBoxAniColor";
            this.textBoxAniColor.ReadOnly = true;
            this.textBoxAniColor.Size = new System.Drawing.Size(133, 20);
            this.textBoxAniColor.TabIndex = 12;
            // 
            // textBoxAniTatoo
            // 
            this.textBoxAniTatoo.Location = new System.Drawing.Point(11, 130);
            this.textBoxAniTatoo.Name = "textBoxAniTatoo";
            this.textBoxAniTatoo.ReadOnly = true;
            this.textBoxAniTatoo.Size = new System.Drawing.Size(220, 20);
            this.textBoxAniTatoo.TabIndex = 11;
            // 
            // textBoxAniRace
            // 
            this.textBoxAniRace.Location = new System.Drawing.Point(156, 80);
            this.textBoxAniRace.Name = "textBoxAniRace";
            this.textBoxAniRace.ReadOnly = true;
            this.textBoxAniRace.Size = new System.Drawing.Size(137, 20);
            this.textBoxAniRace.TabIndex = 10;
            // 
            // textBoxAniEspec
            // 
            this.textBoxAniEspec.Location = new System.Drawing.Point(11, 80);
            this.textBoxAniEspec.Name = "textBoxAniEspec";
            this.textBoxAniEspec.ReadOnly = true;
            this.textBoxAniEspec.Size = new System.Drawing.Size(133, 20);
            this.textBoxAniEspec.TabIndex = 9;
            // 
            // textBoxAniName
            // 
            this.textBoxAniName.Location = new System.Drawing.Point(156, 42);
            this.textBoxAniName.Name = "textBoxAniName";
            this.textBoxAniName.ReadOnly = true;
            this.textBoxAniName.Size = new System.Drawing.Size(133, 20);
            this.textBoxAniName.TabIndex = 8;
            // 
            // textBoxAniCode
            // 
            this.textBoxAniCode.Location = new System.Drawing.Point(11, 42);
            this.textBoxAniCode.Name = "textBoxAniCode";
            this.textBoxAniCode.ReadOnly = true;
            this.textBoxAniCode.Size = new System.Drawing.Size(133, 20);
            this.textBoxAniCode.TabIndex = 7;
            // 
            // labelAniTatoo
            // 
            this.labelAniTatoo.Location = new System.Drawing.Point(9, 115);
            this.labelAniTatoo.Name = "labelAniTatoo";
            this.labelAniTatoo.Size = new System.Drawing.Size(79, 12);
            this.labelAniTatoo.TabIndex = 6;
            this.labelAniTatoo.Text = "labelAniTatoo";
            // 
            // labelAniColor
            // 
            this.labelAniColor.Location = new System.Drawing.Point(368, 27);
            this.labelAniColor.Name = "labelAniColor";
            this.labelAniColor.Size = new System.Drawing.Size(100, 12);
            this.labelAniColor.TabIndex = 5;
            this.labelAniColor.Text = "labelAniColor";
            // 
            // labelAniSexe
            // 
            this.labelAniSexe.Location = new System.Drawing.Point(291, 27);
            this.labelAniSexe.Name = "labelAniSexe";
            this.labelAniSexe.Size = new System.Drawing.Size(100, 12);
            this.labelAniSexe.TabIndex = 4;
            this.labelAniSexe.Text = "labelAniSexe";
            // 
            // labelAniRace
            // 
            this.labelAniRace.Location = new System.Drawing.Point(153, 65);
            this.labelAniRace.Name = "labelAniRace";
            this.labelAniRace.Size = new System.Drawing.Size(100, 12);
            this.labelAniRace.TabIndex = 3;
            this.labelAniRace.Text = "labelAniRace";
            // 
            // labelAniEspece
            // 
            this.labelAniEspece.Location = new System.Drawing.Point(9, 65);
            this.labelAniEspece.Name = "labelAniEspece";
            this.labelAniEspece.Size = new System.Drawing.Size(79, 12);
            this.labelAniEspece.TabIndex = 2;
            this.labelAniEspece.Text = "labelAniEspece";
            // 
            // labelAniName
            // 
            this.labelAniName.Location = new System.Drawing.Point(155, 27);
            this.labelAniName.Name = "labelAniName";
            this.labelAniName.Size = new System.Drawing.Size(79, 12);
            this.labelAniName.TabIndex = 1;
            this.labelAniName.Text = "labelAniName";
            // 
            // labelAniCode
            // 
            this.labelAniCode.Location = new System.Drawing.Point(11, 27);
            this.labelAniCode.Name = "labelAniCode";
            this.labelAniCode.Size = new System.Drawing.Size(79, 12);
            this.labelAniCode.TabIndex = 0;
            this.labelAniCode.Text = "labelAniCode";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(3, 237);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(580, 124);
            this.textBoxComment.TabIndex = 4;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // labelComment
            // 
            this.labelComment.Location = new System.Drawing.Point(4, 220);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(150, 14);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "labelComment";
            // 
            // groupBoxActe
            // 
            this.groupBoxActe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxActe.Controls.Add(this.buttonActeDelete);
            this.groupBoxActe.Controls.Add(this.buttonActeAdd);
            this.groupBoxActe.Controls.Add(this.textBoxActeTotal);
            this.groupBoxActe.Controls.Add(this.comboBoxActeLibelle);
            this.groupBoxActe.Controls.Add(this.labelActeLibelle);
            this.groupBoxActe.Controls.Add(this.comboBoxActeType);
            this.groupBoxActe.Controls.Add(this.textBoxActeVeto);
            this.groupBoxActe.Controls.Add(this.dateTimePickerActe);
            this.groupBoxActe.Controls.Add(this.labelActeTotal);
            this.groupBoxActe.Controls.Add(this.dataGridViewActe);
            this.groupBoxActe.Controls.Add(this.groupBoxTarif);
            this.groupBoxActe.Controls.Add(this.labelActeVeto);
            this.groupBoxActe.Controls.Add(this.labelActeType);
            this.groupBoxActe.Controls.Add(this.labelActeDate);
            this.groupBoxActe.Location = new System.Drawing.Point(3, 376);
            this.groupBoxActe.Name = "groupBoxActe";
            this.groupBoxActe.Size = new System.Drawing.Size(580, 319);
            this.groupBoxActe.TabIndex = 6;
            this.groupBoxActe.TabStop = false;
            this.groupBoxActe.Text = "groupBoxActe";
            // 
            // buttonActeDelete
            // 
            this.buttonActeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActeDelete.Location = new System.Drawing.Point(116, 266);
            this.buttonActeDelete.Name = "buttonActeDelete";
            this.buttonActeDelete.Size = new System.Drawing.Size(102, 29);
            this.buttonActeDelete.TabIndex = 15;
            this.buttonActeDelete.Text = "buttonActeDelete";
            this.buttonActeDelete.UseVisualStyleBackColor = true;
            this.buttonActeDelete.Click += new System.EventHandler(this.buttonActeDelete_Click);
            // 
            // buttonActeAdd
            // 
            this.buttonActeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActeAdd.Location = new System.Drawing.Point(8, 266);
            this.buttonActeAdd.Name = "buttonActeAdd";
            this.buttonActeAdd.Size = new System.Drawing.Size(102, 29);
            this.buttonActeAdd.TabIndex = 7;
            this.buttonActeAdd.Text = "buttonActeAdd";
            this.buttonActeAdd.UseVisualStyleBackColor = true;
            this.buttonActeAdd.Click += new System.EventHandler(this.buttonActeAdd_Click);
            // 
            // textBoxActeTotal
            // 
            this.textBoxActeTotal.Location = new System.Drawing.Point(486, 266);
            this.textBoxActeTotal.Name = "textBoxActeTotal";
            this.textBoxActeTotal.ReadOnly = true;
            this.textBoxActeTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxActeTotal.Size = new System.Drawing.Size(84, 20);
            this.textBoxActeTotal.TabIndex = 14;
            // 
            // comboBoxActeLibelle
            // 
            this.comboBoxActeLibelle.FormattingEnabled = true;
            this.comboBoxActeLibelle.Location = new System.Drawing.Point(125, 89);
            this.comboBoxActeLibelle.Name = "comboBoxActeLibelle";
            this.comboBoxActeLibelle.Size = new System.Drawing.Size(224, 21);
            this.comboBoxActeLibelle.TabIndex = 13;
            this.comboBoxActeLibelle.SelectedIndexChanged += new System.EventHandler(this.comboBoxActeLibelle_SelectedIndexChanged);
            // 
            // labelActeLibelle
            // 
            this.labelActeLibelle.Location = new System.Drawing.Point(122, 71);
            this.labelActeLibelle.Name = "labelActeLibelle";
            this.labelActeLibelle.Size = new System.Drawing.Size(90, 17);
            this.labelActeLibelle.TabIndex = 12;
            this.labelActeLibelle.Text = "labelActeLibelle";
            // 
            // comboBoxActeType
            // 
            this.comboBoxActeType.FormattingEnabled = true;
            this.comboBoxActeType.Location = new System.Drawing.Point(9, 89);
            this.comboBoxActeType.Name = "comboBoxActeType";
            this.comboBoxActeType.Size = new System.Drawing.Size(99, 21);
            this.comboBoxActeType.TabIndex = 11;
            this.comboBoxActeType.SelectedIndexChanged += new System.EventHandler(this.comboBoxActeType_SelectedIndexChanged);
            // 
            // textBoxActeVeto
            // 
            this.textBoxActeVeto.Location = new System.Drawing.Point(125, 38);
            this.textBoxActeVeto.Name = "textBoxActeVeto";
            this.textBoxActeVeto.ReadOnly = true;
            this.textBoxActeVeto.Size = new System.Drawing.Size(221, 20);
            this.textBoxActeVeto.TabIndex = 10;
            // 
            // dateTimePickerActe
            // 
            this.dateTimePickerActe.Checked = false;
            this.dateTimePickerActe.Enabled = false;
            this.dateTimePickerActe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerActe.Location = new System.Drawing.Point(12, 38);
            this.dateTimePickerActe.Name = "dateTimePickerActe";
            this.dateTimePickerActe.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerActe.TabIndex = 9;
            // 
            // labelActeTotal
            // 
            this.labelActeTotal.Location = new System.Drawing.Point(390, 269);
            this.labelActeTotal.Name = "labelActeTotal";
            this.labelActeTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelActeTotal.Size = new System.Drawing.Size(90, 13);
            this.labelActeTotal.TabIndex = 8;
            this.labelActeTotal.Text = "labelActeTotal";
            // 
            // dataGridViewActe
            // 
            this.dataGridViewActe.AllowUserToAddRows = false;
            this.dataGridViewActe.AllowUserToDeleteRows = false;
            this.dataGridViewActe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActe.Location = new System.Drawing.Point(8, 137);
            this.dataGridViewActe.MultiSelect = false;
            this.dataGridViewActe.Name = "dataGridViewActe";
            this.dataGridViewActe.ReadOnly = true;
            this.dataGridViewActe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewActe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActe.Size = new System.Drawing.Size(560, 123);
            this.dataGridViewActe.TabIndex = 7;
            this.dataGridViewActe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewActe_RowsAdded);
            this.dataGridViewActe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewActe_RowsRemoved);
            // 
            // groupBoxTarif
            // 
            this.groupBoxTarif.Controls.Add(this.numericUpDownActePrix);
            this.groupBoxTarif.Controls.Add(this.textBoxActeMax);
            this.groupBoxTarif.Controls.Add(this.textBoxActeMin);
            this.groupBoxTarif.Controls.Add(this.labelActePrix);
            this.groupBoxTarif.Controls.Add(this.labelActeMax);
            this.groupBoxTarif.Controls.Add(this.labelActeMin);
            this.groupBoxTarif.Location = new System.Drawing.Point(363, 19);
            this.groupBoxTarif.Name = "groupBoxTarif";
            this.groupBoxTarif.Size = new System.Drawing.Size(207, 112);
            this.groupBoxTarif.TabIndex = 6;
            this.groupBoxTarif.TabStop = false;
            this.groupBoxTarif.Text = "groupBoxTarif";
            // 
            // numericUpDownActePrix
            // 
            this.numericUpDownActePrix.DecimalPlaces = 2;
            this.numericUpDownActePrix.Enabled = false;
            this.numericUpDownActePrix.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownActePrix.Location = new System.Drawing.Point(9, 87);
            this.numericUpDownActePrix.Name = "numericUpDownActePrix";
            this.numericUpDownActePrix.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownActePrix.TabIndex = 17;
            // 
            // textBoxActeMax
            // 
            this.textBoxActeMax.Location = new System.Drawing.Point(104, 39);
            this.textBoxActeMax.Name = "textBoxActeMax";
            this.textBoxActeMax.ReadOnly = true;
            this.textBoxActeMax.Size = new System.Drawing.Size(88, 20);
            this.textBoxActeMax.TabIndex = 16;
            // 
            // textBoxActeMin
            // 
            this.textBoxActeMin.Location = new System.Drawing.Point(10, 39);
            this.textBoxActeMin.Name = "textBoxActeMin";
            this.textBoxActeMin.ReadOnly = true;
            this.textBoxActeMin.Size = new System.Drawing.Size(88, 20);
            this.textBoxActeMin.TabIndex = 15;
            // 
            // labelActePrix
            // 
            this.labelActePrix.Location = new System.Drawing.Point(7, 70);
            this.labelActePrix.Name = "labelActePrix";
            this.labelActePrix.Size = new System.Drawing.Size(71, 14);
            this.labelActePrix.TabIndex = 8;
            this.labelActePrix.Text = "labelActePrix";
            // 
            // labelActeMax
            // 
            this.labelActeMax.Location = new System.Drawing.Point(101, 22);
            this.labelActeMax.Name = "labelActeMax";
            this.labelActeMax.Size = new System.Drawing.Size(55, 11);
            this.labelActeMax.TabIndex = 7;
            this.labelActeMax.Text = "labelActeMax";
            // 
            // labelActeMin
            // 
            this.labelActeMin.Location = new System.Drawing.Point(7, 21);
            this.labelActeMin.Name = "labelActeMin";
            this.labelActeMin.Size = new System.Drawing.Size(55, 15);
            this.labelActeMin.TabIndex = 6;
            this.labelActeMin.Text = "labelActeMin";
            // 
            // labelActeVeto
            // 
            this.labelActeVeto.Location = new System.Drawing.Point(122, 20);
            this.labelActeVeto.Name = "labelActeVeto";
            this.labelActeVeto.Size = new System.Drawing.Size(78, 15);
            this.labelActeVeto.TabIndex = 5;
            this.labelActeVeto.Text = "labelActeVeto";
            // 
            // labelActeType
            // 
            this.labelActeType.Location = new System.Drawing.Point(9, 72);
            this.labelActeType.Name = "labelActeType";
            this.labelActeType.Size = new System.Drawing.Size(79, 14);
            this.labelActeType.TabIndex = 1;
            this.labelActeType.Text = "labelActeType";
            // 
            // labelActeDate
            // 
            this.labelActeDate.Location = new System.Drawing.Point(9, 23);
            this.labelActeDate.Name = "labelActeDate";
            this.labelActeDate.Size = new System.Drawing.Size(79, 15);
            this.labelActeDate.TabIndex = 0;
            this.labelActeDate.Text = "labelActeDate";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(238, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 35);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // DialogConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(583, 720);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxActe);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.groupBoxAnimal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonMedicalFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogConsultation";
            this.Text = " ";
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.groupBoxActe.ResumeLayout(false);
            this.groupBoxActe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActe)).EndInit();
            this.groupBoxTarif.ResumeLayout(false);
            this.groupBoxTarif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActePrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMedicalFolder;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.Label labelAniCode;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.GroupBox groupBoxActe;
        private System.Windows.Forms.Label labelActeVeto;
        private System.Windows.Forms.Label labelActeType;
        private System.Windows.Forms.Label labelActeDate;
        private System.Windows.Forms.GroupBox groupBoxTarif;
        private System.Windows.Forms.Label labelActePrix;
        private System.Windows.Forms.Label labelActeMax;
        private System.Windows.Forms.Label labelActeMin;
        private System.Windows.Forms.DataGridView dataGridViewActe;
        private System.Windows.Forms.Label labelActeTotal;
        private System.Windows.Forms.Label labelAniName;
        private System.Windows.Forms.Label labelAniEspece;
        private System.Windows.Forms.Label labelAniRace;
        private System.Windows.Forms.Label labelAniSexe;
        private System.Windows.Forms.Label labelAniColor;
        private System.Windows.Forms.Label labelAniTatoo;
        private System.Windows.Forms.TextBox textBoxAniCode;
        private System.Windows.Forms.TextBox textBoxAniRace;
        private System.Windows.Forms.TextBox textBoxAniEspec;
        private System.Windows.Forms.TextBox textBoxAniName;
        private System.Windows.Forms.TextBox textBoxAniSexe;
        private System.Windows.Forms.TextBox textBoxAniColor;
        private System.Windows.Forms.TextBox textBoxAniTatoo;
        private System.Windows.Forms.DateTimePicker dateTimePickerActe;
        private System.Windows.Forms.TextBox textBoxActeVeto;
        private System.Windows.Forms.ComboBox comboBoxActeType;
        private System.Windows.Forms.ComboBox comboBoxActeLibelle;
        private System.Windows.Forms.Label labelActeLibelle;
        private System.Windows.Forms.TextBox textBoxActeTotal;
        private System.Windows.Forms.TextBox textBoxActeMin;
        private System.Windows.Forms.TextBox textBoxActeMax;
        private System.Windows.Forms.NumericUpDown numericUpDownActePrix;
        private System.Windows.Forms.Button buttonActeAdd;
        private System.Windows.Forms.Button buttonActeDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}