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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.lstContacts);
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
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(19, 29);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(777, 290);
            this.lstContacts.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGetGoogleContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ListBox lstContacts;
    }
}

