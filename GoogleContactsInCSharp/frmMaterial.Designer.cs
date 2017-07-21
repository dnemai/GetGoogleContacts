namespace GoogleContactsInCSharp
{
    partial class frmMaterial
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
            this.cmdGetGoogleContacts = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.dataGridContacts = new System.Windows.Forms.DataGridView();
            this.NameAndEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGetGoogleContacts
            // 
            this.cmdGetGoogleContacts.Location = new System.Drawing.Point(12, 12);
            this.cmdGetGoogleContacts.Name = "cmdGetGoogleContacts";
            this.cmdGetGoogleContacts.Size = new System.Drawing.Size(219, 23);
            this.cmdGetGoogleContacts.TabIndex = 0;
            this.cmdGetGoogleContacts.Text = "Get google contacts";
            this.cmdGetGoogleContacts.UseVisualStyleBackColor = true;
            this.cmdGetGoogleContacts.Click += new System.EventHandler(this.cmdGetGoogleContacts_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridContacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Google contacts";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(608, 394);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(219, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Exit";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.AllowUserToAddRows = false;
            this.dataGridContacts.AllowUserToDeleteRows = false;
            this.dataGridContacts.AllowUserToOrderColumns = true;
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameAndEmail,
            this.chkBox});
            this.dataGridContacts.Location = new System.Drawing.Point(21, 19);
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.ReadOnly = true;
            this.dataGridContacts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridContacts.RowTemplate.Height = 60;
            this.dataGridContacts.Size = new System.Drawing.Size(772, 302);
            this.dataGridContacts.TabIndex = 0;
            // 
            // NameAndEmail
            // 
            this.NameAndEmail.HeaderText = "Name & Email";
            this.NameAndEmail.MinimumWidth = 100;
            this.NameAndEmail.Name = "NameAndEmail";
            this.NameAndEmail.ReadOnly = true;
            this.NameAndEmail.Width = 200;
            // 
            // chkBox
            // 
            this.chkBox.HeaderText = "Select";
            this.chkBox.Name = "chkBox";
            this.chkBox.ReadOnly = true;
            this.chkBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chkBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 426);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdGetGoogleContacts);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaterial";
            this.Text = "Material";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGetGoogleContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.DataGridView dataGridContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAndEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBox;
    }
}

