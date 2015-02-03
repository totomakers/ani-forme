namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripDropDownButtonSecretariat = new System.Windows.Forms.ToolStripDropDownButton();
            this.takeRdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderCustomerAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remindersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockVaccinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonVeterinary = new System.Windows.Forms.ToolStripDropDownButton();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonParams = new System.Windows.Forms.ToolStripDropDownButton();
            this.veterinariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRight = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRdv = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCustomerAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReminders = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMedicalFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop.SuspendLayout();
            this.toolStripRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripDropDownButtonSecretariat
            // 
            this.toolStripDropDownButtonSecretariat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeRdvToolStripMenuItem,
            this.folderCustomerAnimalToolStripMenuItem,
            this.remindersToolStripMenuItem,
            this.updateStockVaccinToolStripMenuItem});
            this.toolStripDropDownButtonSecretariat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSecretariat.Image")));
            this.toolStripDropDownButtonSecretariat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSecretariat.Name = "toolStripDropDownButtonSecretariat";
            this.toolStripDropDownButtonSecretariat.Size = new System.Drawing.Size(227, 36);
            this.toolStripDropDownButtonSecretariat.Text = "toolStripDropDownButtonSecretariat";
            // 
            // takeRdvToolStripMenuItem
            // 
            this.takeRdvToolStripMenuItem.Name = "takeRdvToolStripMenuItem";
            this.takeRdvToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.takeRdvToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.takeRdvToolStripMenuItem.Text = "TakeAppointement";
            this.takeRdvToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // folderCustomerAnimalToolStripMenuItem
            // 
            this.folderCustomerAnimalToolStripMenuItem.Name = "folderCustomerAnimalToolStripMenuItem";
            this.folderCustomerAnimalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.folderCustomerAnimalToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.folderCustomerAnimalToolStripMenuItem.Text = "FolderCustomerAnimal";
            this.folderCustomerAnimalToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // remindersToolStripMenuItem
            // 
            this.remindersToolStripMenuItem.Name = "remindersToolStripMenuItem";
            this.remindersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.remindersToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.remindersToolStripMenuItem.Text = "Reminders";
            this.remindersToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // updateStockVaccinToolStripMenuItem
            // 
            this.updateStockVaccinToolStripMenuItem.Name = "updateStockVaccinToolStripMenuItem";
            this.updateStockVaccinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.updateStockVaccinToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.updateStockVaccinToolStripMenuItem.Text = "UpdateStockVaccin";
            this.updateStockVaccinToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripTop
            // 
            this.toolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonSecretariat,
            this.toolStripDropDownButtonVeterinary,
            this.toolStripDropDownButtonParams});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTop.Size = new System.Drawing.Size(838, 39);
            this.toolStripTop.TabIndex = 0;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonVeterinary
            // 
            this.toolStripDropDownButtonVeterinary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.medicalFolderToolStripMenuItem});
            this.toolStripDropDownButtonVeterinary.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonVeterinary.Image")));
            this.toolStripDropDownButtonVeterinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonVeterinary.Name = "toolStripDropDownButtonVeterinary";
            this.toolStripDropDownButtonVeterinary.Size = new System.Drawing.Size(224, 36);
            this.toolStripDropDownButtonVeterinary.Text = "toolStripDropDownButtonVeterinary";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // medicalFolderToolStripMenuItem
            // 
            this.medicalFolderToolStripMenuItem.Name = "medicalFolderToolStripMenuItem";
            this.medicalFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.medicalFolderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.medicalFolderToolStripMenuItem.Text = "MedicalFolder";
            this.medicalFolderToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripDropDownButtonParams
            // 
            this.toolStripDropDownButtonParams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veterinariToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.toolStripDropDownButtonParams.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonParams.Image")));
            this.toolStripDropDownButtonParams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonParams.Name = "toolStripDropDownButtonParams";
            this.toolStripDropDownButtonParams.Size = new System.Drawing.Size(209, 36);
            this.toolStripDropDownButtonParams.Text = "toolStripDropDownButtonParams";
            // 
            // veterinariToolStripMenuItem
            // 
            this.veterinariToolStripMenuItem.Name = "veterinariToolStripMenuItem";
            this.veterinariToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.veterinariToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.veterinariToolStripMenuItem.Text = "Veterinary";
            this.veterinariToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.updateToolStripMenuItem.Text = "UpdateCostBarem";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripRight
            // 
            this.toolStripRight.AllowItemReorder = true;
            this.toolStripRight.AllowMerge = false;
            this.toolStripRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRight.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRdv,
            this.toolStripButtonCustomerAnimal,
            this.toolStripButtonReminders,
            this.toolStripButtonAgenda,
            this.toolStripButtonMedicalFolder});
            this.toolStripRight.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripRight.Location = new System.Drawing.Point(677, 39);
            this.toolStripRight.Name = "toolStripRight";
            this.toolStripRight.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripRight.ShowItemToolTips = false;
            this.toolStripRight.Size = new System.Drawing.Size(161, 481);
            this.toolStripRight.Stretch = true;
            this.toolStripRight.TabIndex = 2;
            this.toolStripRight.Text = "toolStripRight";
            // 
            // toolStripButtonRdv
            // 
            this.toolStripButtonRdv.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRdv.Image")));
            this.toolStripButtonRdv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRdv.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.toolStripButtonRdv.Name = "toolStripButtonRdv";
            this.toolStripButtonRdv.Size = new System.Drawing.Size(158, 49);
            this.toolStripButtonRdv.Text = "toolStripButtonRdv";
            this.toolStripButtonRdv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRdv.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripButtonCustomerAnimal
            // 
            this.toolStripButtonCustomerAnimal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCustomerAnimal.Image")));
            this.toolStripButtonCustomerAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCustomerAnimal.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.toolStripButtonCustomerAnimal.Name = "toolStripButtonCustomerAnimal";
            this.toolStripButtonCustomerAnimal.Size = new System.Drawing.Size(158, 49);
            this.toolStripButtonCustomerAnimal.Text = "toolStripButtonCustomerAnimal";
            this.toolStripButtonCustomerAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCustomerAnimal.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripButtonReminders
            // 
            this.toolStripButtonReminders.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReminders.Image")));
            this.toolStripButtonReminders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReminders.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.toolStripButtonReminders.Name = "toolStripButtonReminders";
            this.toolStripButtonReminders.Size = new System.Drawing.Size(158, 49);
            this.toolStripButtonReminders.Text = "toolStripButtonReminders";
            this.toolStripButtonReminders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonReminders.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripButtonAgenda
            // 
            this.toolStripButtonAgenda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAgenda.Image")));
            this.toolStripButtonAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgenda.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.toolStripButtonAgenda.Name = "toolStripButtonAgenda";
            this.toolStripButtonAgenda.Size = new System.Drawing.Size(158, 49);
            this.toolStripButtonAgenda.Text = "toolStripButtonAgenda";
            this.toolStripButtonAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAgenda.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // toolStripButtonMedicalFolder
            // 
            this.toolStripButtonMedicalFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMedicalFolder.Image")));
            this.toolStripButtonMedicalFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMedicalFolder.Margin = new System.Windows.Forms.Padding(0, 1, 0, 15);
            this.toolStripButtonMedicalFolder.Name = "toolStripButtonMedicalFolder";
            this.toolStripButtonMedicalFolder.Size = new System.Drawing.Size(158, 49);
            this.toolStripButtonMedicalFolder.Text = "toolStripButtonMedicalFolder";
            this.toolStripButtonMedicalFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonMedicalFolder.ToolTipText = "toolStripButtonMedicalFolder";
            this.toolStripButtonMedicalFolder.Click += new System.EventHandler(this.ClickOpenSubForm);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 520);
            this.Controls.Add(this.toolStripRight);
            this.Controls.Add(this.toolStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.toolStripRight.ResumeLayout(false);
            this.toolStripRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSecretariat;
        private System.Windows.Forms.ToolStripMenuItem takeRdvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderCustomerAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remindersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockVaccinToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonVeterinary;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonParams;
        private System.Windows.Forms.ToolStripMenuItem veterinariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonRdv;
        private System.Windows.Forms.ToolStripButton toolStripButtonCustomerAnimal;
        private System.Windows.Forms.ToolStripButton toolStripButtonReminders;
        private System.Windows.Forms.ToolStripButton toolStripButtonAgenda;
        private System.Windows.Forms.ToolStripButton toolStripButtonMedicalFolder;

    }
}