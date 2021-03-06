﻿namespace GUI
{
    partial class SubFormDossierClientAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormDossierClientAnimal));
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxAdresse2 = new System.Windows.Forms.TextBox();
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.buttonAddAni = new System.Windows.Forms.Button();
            this.buttonDeleteAni = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSearch = new System.Windows.Forms.CheckBox();
            this.buttonValidateAddCli = new System.Windows.Forms.Button();
            this.buttonCancelAddCli = new System.Windows.Forms.Button();
            this.buttonEditAni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(13, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 30);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "buttonFirst";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(93, 12);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 30);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "buttonPrev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(174, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 30);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(255, 12);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 31);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = "buttonLast";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(523, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 20);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(144, 357);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 40);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSearch.Location = new System.Drawing.Point(645, 40);
            this.textBoxSearch.MaxLength = 50;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(138, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelCode
            // 
            this.labelCode.AutoEllipsis = true;
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(12, 66);
            this.labelCode.Name = "labelCode";
            this.labelCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCode.Size = new System.Drawing.Size(54, 13);
            this.labelCode.TabIndex = 9;
            this.labelCode.Text = "labelCode";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Location = new System.Drawing.Point(17, 82);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(222, 20);
            this.textBoxCode.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(15, 126);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(224, 20);
            this.textBoxFirstName.TabIndex = 12;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 110);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFirstName.Size = new System.Drawing.Size(76, 13);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "labelFirstName";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(15, 170);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(224, 20);
            this.textBoxLastName.TabIndex = 14;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 154);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelLastName.Size = new System.Drawing.Size(77, 13);
            this.labelLastName.TabIndex = 13;
            this.labelLastName.Text = "labelLastName";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Enabled = false;
            this.textBoxAdresse.Location = new System.Drawing.Point(15, 222);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(224, 20);
            this.textBoxAdresse.TabIndex = 16;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(12, 206);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAdresse.Size = new System.Drawing.Size(67, 13);
            this.labelAdresse.TabIndex = 15;
            this.labelAdresse.Text = "labelAdresse";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Enabled = false;
            this.textBoxPostalCode.Location = new System.Drawing.Point(16, 290);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(223, 20);
            this.textBoxPostalCode.TabIndex = 18;
            this.textBoxPostalCode.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(12, 274);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPostalCode.Size = new System.Drawing.Size(83, 13);
            this.labelPostalCode.TabIndex = 17;
            this.labelPostalCode.Text = "labelPostalCode";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Location = new System.Drawing.Point(16, 331);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(223, 20);
            this.textBoxCity.TabIndex = 20;
            this.textBoxCity.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 315);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(46, 13);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "labelCity";
            // 
            // textBoxAdresse2
            // 
            this.textBoxAdresse2.Enabled = false;
            this.textBoxAdresse2.Location = new System.Drawing.Point(15, 244);
            this.textBoxAdresse2.Name = "textBoxAdresse2";
            this.textBoxAdresse2.Size = new System.Drawing.Size(224, 20);
            this.textBoxAdresse2.TabIndex = 21;
            this.textBoxAdresse2.TextChanged += new System.EventHandler(this.doCheck);
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.AllowUserToAddRows = false;
            this.dataGridViewAnimals.AllowUserToDeleteRows = false;
            this.dataGridViewAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Location = new System.Drawing.Point(245, 66);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.ReadOnly = true;
            this.dataGridViewAnimals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnimals.Size = new System.Drawing.Size(643, 354);
            this.dataGridViewAnimals.TabIndex = 22;
            this.dataGridViewAnimals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimals_CellDoubleClick);
            // 
            // buttonAddAni
            // 
            this.buttonAddAni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAni.Location = new System.Drawing.Point(580, 426);
            this.buttonAddAni.Name = "buttonAddAni";
            this.buttonAddAni.Size = new System.Drawing.Size(97, 23);
            this.buttonAddAni.TabIndex = 8;
            this.buttonAddAni.Text = "buttonAddAni";
            this.buttonAddAni.UseVisualStyleBackColor = true;
            this.buttonAddAni.Click += new System.EventHandler(this.buttonAddAni_Click);
            // 
            // buttonDeleteAni
            // 
            this.buttonDeleteAni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteAni.Location = new System.Drawing.Point(683, 426);
            this.buttonDeleteAni.Name = "buttonDeleteAni";
            this.buttonDeleteAni.Size = new System.Drawing.Size(100, 23);
            this.buttonDeleteAni.TabIndex = 23;
            this.buttonDeleteAni.Text = "buttonDeleteAni";
            this.buttonDeleteAni.UseVisualStyleBackColor = true;
            this.buttonDeleteAni.Click += new System.EventHandler(this.buttonDeleteAni_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // checkBoxSearch
            // 
            this.checkBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxSearch.Checked = true;
            this.checkBoxSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxSearch.Location = new System.Drawing.Point(789, 40);
            this.checkBoxSearch.Name = "checkBoxSearch";
            this.checkBoxSearch.Size = new System.Drawing.Size(99, 20);
            this.checkBoxSearch.TabIndex = 25;
            this.checkBoxSearch.Text = "checkBoxSearch";
            this.checkBoxSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSearch.UseVisualStyleBackColor = true;
            this.checkBoxSearch.CheckedChanged += new System.EventHandler(this.checkBoxSearch_CheckedChanged);
            // 
            // buttonValidateAddCli
            // 
            this.buttonValidateAddCli.Location = new System.Drawing.Point(139, 357);
            this.buttonValidateAddCli.Name = "buttonValidateAddCli";
            this.buttonValidateAddCli.Size = new System.Drawing.Size(100, 23);
            this.buttonValidateAddCli.TabIndex = 26;
            this.buttonValidateAddCli.Text = "buttonValidateAddCli";
            this.buttonValidateAddCli.UseVisualStyleBackColor = true;
            this.buttonValidateAddCli.Visible = false;
            this.buttonValidateAddCli.Click += new System.EventHandler(this.buttonValidateAddCli_Click);
            // 
            // buttonCancelAddCli
            // 
            this.buttonCancelAddCli.Location = new System.Drawing.Point(17, 357);
            this.buttonCancelAddCli.Name = "buttonCancelAddCli";
            this.buttonCancelAddCli.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelAddCli.TabIndex = 27;
            this.buttonCancelAddCli.Text = "buttonCancelAddCli";
            this.buttonCancelAddCli.UseVisualStyleBackColor = true;
            this.buttonCancelAddCli.Visible = false;
            this.buttonCancelAddCli.Click += new System.EventHandler(this.buttonCancelAddCli_Click);
            // 
            // buttonEditAni
            // 
            this.buttonEditAni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditAni.Location = new System.Drawing.Point(789, 426);
            this.buttonEditAni.Name = "buttonEditAni";
            this.buttonEditAni.Size = new System.Drawing.Size(97, 23);
            this.buttonEditAni.TabIndex = 28;
            this.buttonEditAni.Text = "buttonEditAni";
            this.buttonEditAni.UseVisualStyleBackColor = true;
            this.buttonEditAni.Click += new System.EventHandler(this.buttonEditAni_Click);
            // 
            // SubFormDossierClientAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 458);
            this.Controls.Add(this.buttonEditAni);
            this.Controls.Add(this.buttonCancelAddCli);
            this.Controls.Add(this.buttonValidateAddCli);
            this.Controls.Add(this.checkBoxSearch);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonDeleteAni);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAddAni);
            this.Controls.Add(this.dataGridViewAnimals);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAdresse2);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(804, 485);
            this.Name = "SubFormDossierClientAnimal";
            this.Text = "SubFormFolderCustomerAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxAdresse2;
        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.Button buttonAddAni;
        private System.Windows.Forms.Button buttonDeleteAni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxSearch;
        private System.Windows.Forms.Button buttonValidateAddCli;
        private System.Windows.Forms.Button buttonEditAni;
        public System.Windows.Forms.Button buttonCancelAddCli;

    }
}