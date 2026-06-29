namespace ExportToExcel
{
    partial class frmExportExcel
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.cmbDBList = new System.Windows.Forms.ComboBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadDBList = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTable);
            this.groupBox2.Controls.Add(this.lblTable);
            this.groupBox2.Controls.Add(this.cmbDBList);
            this.groupBox2.Controls.Add(this.txtServerName);
            this.groupBox2.Controls.Add(this.lblServerName);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 203);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Server Info";
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(106, 148);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(384, 24);
            this.cmbTable.TabIndex = 14;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTable.Location = new System.Drawing.Point(14, 146);
            this.lblTable.Name = "lblTable";
            this.lblTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTable.Size = new System.Drawing.Size(86, 16);
            this.lblTable.TabIndex = 13;
            this.lblTable.Text = "Table Name:";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cmbDBList
            // 
            this.cmbDBList.FormattingEnabled = true;
            this.cmbDBList.Location = new System.Drawing.Point(106, 118);
            this.cmbDBList.Name = "cmbDBList";
            this.cmbDBList.Size = new System.Drawing.Size(384, 24);
            this.cmbDBList.TabIndex = 12;
            this.cmbDBList.SelectedIndexChanged += new System.EventHandler(this.cmbDBList_SelectedIndexChanged);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(106, 33);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(384, 22);
            this.txtServerName.TabIndex = 2;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblServerName.Location = new System.Drawing.Point(7, 33);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblServerName.Size = new System.Drawing.Size(90, 16);
            this.lblServerName.TabIndex = 11;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(384, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPassword.Location = new System.Drawing.Point(30, 88);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 61);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(384, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblUserName.Location = new System.Drawing.Point(20, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserName.Size = new System.Drawing.Size(79, 16);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DB Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnLoadDBList
            // 
            this.btnLoadDBList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoadDBList.Location = new System.Drawing.Point(169, 232);
            this.btnLoadDBList.Name = "btnLoadDBList";
            this.btnLoadDBList.Size = new System.Drawing.Size(212, 34);
            this.btnLoadDBList.TabIndex = 20;
            this.btnLoadDBList.Text = "Connect SQL Server";
            this.btnLoadDBList.UseVisualStyleBackColor = true;
            this.btnLoadDBList.Click += new System.EventHandler(this.btnLoadDBList_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportExcel.Location = new System.Drawing.Point(169, 285);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(212, 34);
            this.btnExportExcel.TabIndex = 21;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // frmExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 337);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnLoadDBList);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "frmExportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export SQL Data to Excel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadDBList;
        private System.Windows.Forms.ComboBox cmbDBList;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnExportExcel;
    }
}