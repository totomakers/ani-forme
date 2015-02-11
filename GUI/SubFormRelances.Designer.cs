namespace GUI
{
    partial class SubFormRelances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormRelances));
            this.buttonRelanceAll = new System.Windows.Forms.Button();
            this.buttonRelanceOne = new System.Windows.Forms.Button();
            this.dataGridViewAnimauxARelancer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimauxARelancer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRelanceAll
            // 
            this.buttonRelanceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRelanceAll.Location = new System.Drawing.Point(12, 156);
            this.buttonRelanceAll.Name = "buttonRelanceAll";
            this.buttonRelanceAll.Size = new System.Drawing.Size(75, 23);
            this.buttonRelanceAll.TabIndex = 1;
            this.buttonRelanceAll.Text = "buttonRelanceALL";
            this.buttonRelanceAll.UseVisualStyleBackColor = true;
            this.buttonRelanceAll.Click += new System.EventHandler(this.buttonRelanceAll_Click);
            // 
            // buttonRelanceOne
            // 
            this.buttonRelanceOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRelanceOne.Location = new System.Drawing.Point(93, 156);
            this.buttonRelanceOne.Name = "buttonRelanceOne";
            this.buttonRelanceOne.Size = new System.Drawing.Size(75, 23);
            this.buttonRelanceOne.TabIndex = 2;
            this.buttonRelanceOne.Text = "buttonRelanceOne";
            this.buttonRelanceOne.UseVisualStyleBackColor = true;
            this.buttonRelanceOne.Click += new System.EventHandler(this.buttonRelanceOne_Click);
            // 
            // dataGridViewAnimauxARelancer
            // 
            this.dataGridViewAnimauxARelancer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAnimauxARelancer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnimauxARelancer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimauxARelancer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAnimauxARelancer.Name = "dataGridViewAnimauxARelancer";
            this.dataGridViewAnimauxARelancer.Size = new System.Drawing.Size(268, 138);
            this.dataGridViewAnimauxARelancer.TabIndex = 3;
            // 
            // SubFormRelances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 184);
            this.Controls.Add(this.dataGridViewAnimauxARelancer);
            this.Controls.Add(this.buttonRelanceOne);
            this.Controls.Add(this.buttonRelanceAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormRelances";
            this.Text = "SubFormReminders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimauxARelancer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRelanceAll;
        private System.Windows.Forms.Button buttonRelanceOne;
        private System.Windows.Forms.DataGridView dataGridViewAnimauxARelancer;
    }
}