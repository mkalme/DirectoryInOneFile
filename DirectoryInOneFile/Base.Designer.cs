namespace DirectoryInOneFile
{
    partial class Base
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newFileButton = new System.Windows.Forms.Button();
            this.newFolderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.convertFileLink = new System.Windows.Forms.LinkLabel();
            this.openLabel = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(976, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // newFileButton
            // 
            this.newFileButton.Location = new System.Drawing.Point(12, 12);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(75, 25);
            this.newFileButton.TabIndex = 1;
            this.newFileButton.Text = "New File";
            this.newFileButton.UseVisualStyleBackColor = true;
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // newFolderButton
            // 
            this.newFolderButton.Location = new System.Drawing.Point(93, 12);
            this.newFolderButton.Name = "newFolderButton";
            this.newFolderButton.Size = new System.Drawing.Size(75, 25);
            this.newFolderButton.TabIndex = 2;
            this.newFolderButton.Text = "New Folder";
            this.newFolderButton.UseVisualStyleBackColor = true;
            this.newFolderButton.Click += new System.EventHandler(this.newFolderButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(205, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 25);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(315, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // convertFileLink
            // 
            this.convertFileLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.convertFileLink.AutoSize = true;
            this.convertFileLink.LinkColor = System.Drawing.Color.Black;
            this.convertFileLink.Location = new System.Drawing.Point(871, 10);
            this.convertFileLink.Name = "convertFileLink";
            this.convertFileLink.Size = new System.Drawing.Size(93, 13);
            this.convertFileLink.TabIndex = 5;
            this.convertFileLink.TabStop = true;
            this.convertFileLink.Text = "Convert to one file";
            this.convertFileLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.convertFileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.convertFileLink_LinkClicked);
            // 
            // openLabel
            // 
            this.openLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.openLabel.AutoSize = true;
            this.openLabel.LinkColor = System.Drawing.Color.Black;
            this.openLabel.Location = new System.Drawing.Point(915, 28);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(49, 13);
            this.openLabel.TabIndex = 6;
            this.openLabel.TabStop = true;
            this.openLabel.Text = "Open file";
            this.openLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.openLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openLabel_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 30;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "Last Modified";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FolderFile";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 586);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.convertFileLink);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newFolderButton);
            this.Controls.Add(this.newFileButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newFileButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newFolderButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.LinkLabel convertFileLink;
        private System.Windows.Forms.LinkLabel openLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

