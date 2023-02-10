namespace OutputExcelDocument
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.grpCompanyInfo = new System.Windows.Forms.GroupBox();
            this.textCompanyName = new System.Windows.Forms.TextBox();
            this.textCompanyAddress3 = new System.Windows.Forms.TextBox();
            this.textCompanyAddress1 = new System.Windows.Forms.TextBox();
            this.textCompanyAddress2 = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress1 = new System.Windows.Forms.Label();
            this.lblCompanyAddress2 = new System.Windows.Forms.Label();
            this.lblCompanyAddress3 = new System.Windows.Forms.Label();
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.grpCompanyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(34, 25);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(215, 26);
            this.cmbDocumentType.TabIndex = 1;
            // 
            // grpCompanyInfo
            // 
            this.grpCompanyInfo.Controls.Add(this.lblCompanyAddress3);
            this.grpCompanyInfo.Controls.Add(this.lblCompanyAddress2);
            this.grpCompanyInfo.Controls.Add(this.lblCompanyAddress1);
            this.grpCompanyInfo.Controls.Add(this.lblCompanyName);
            this.grpCompanyInfo.Controls.Add(this.textCompanyAddress2);
            this.grpCompanyInfo.Controls.Add(this.textCompanyAddress1);
            this.grpCompanyInfo.Controls.Add(this.textCompanyAddress3);
            this.grpCompanyInfo.Controls.Add(this.textCompanyName);
            this.grpCompanyInfo.Location = new System.Drawing.Point(34, 168);
            this.grpCompanyInfo.Name = "grpCompanyInfo";
            this.grpCompanyInfo.Size = new System.Drawing.Size(511, 223);
            this.grpCompanyInfo.TabIndex = 2;
            this.grpCompanyInfo.TabStop = false;
            this.grpCompanyInfo.Text = "CompanyInfo";
            // 
            // textCompanyName
            // 
            this.textCompanyName.Location = new System.Drawing.Point(129, 41);
            this.textCompanyName.Name = "textCompanyName";
            this.textCompanyName.Size = new System.Drawing.Size(286, 25);
            this.textCompanyName.TabIndex = 0;
            // 
            // textCompanyAddress3
            // 
            this.textCompanyAddress3.Location = new System.Drawing.Point(129, 164);
            this.textCompanyAddress3.Name = "textCompanyAddress3";
            this.textCompanyAddress3.Size = new System.Drawing.Size(286, 25);
            this.textCompanyAddress3.TabIndex = 1;
            // 
            // textCompanyAddress1
            // 
            this.textCompanyAddress1.Location = new System.Drawing.Point(129, 85);
            this.textCompanyAddress1.Name = "textCompanyAddress1";
            this.textCompanyAddress1.Size = new System.Drawing.Size(286, 25);
            this.textCompanyAddress1.TabIndex = 2;
            // 
            // textCompanyAddress2
            // 
            this.textCompanyAddress2.Location = new System.Drawing.Point(129, 124);
            this.textCompanyAddress2.Name = "textCompanyAddress2";
            this.textCompanyAddress2.Size = new System.Drawing.Size(286, 25);
            this.textCompanyAddress2.TabIndex = 3;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(18, 44);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(51, 18);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Name";
            // 
            // lblCompanyAddress1
            // 
            this.lblCompanyAddress1.AutoSize = true;
            this.lblCompanyAddress1.Location = new System.Drawing.Point(18, 88);
            this.lblCompanyAddress1.Name = "lblCompanyAddress1";
            this.lblCompanyAddress1.Size = new System.Drawing.Size(77, 18);
            this.lblCompanyAddress1.TabIndex = 5;
            this.lblCompanyAddress1.Text = "Address1";
            // 
            // lblCompanyAddress2
            // 
            this.lblCompanyAddress2.AutoSize = true;
            this.lblCompanyAddress2.Location = new System.Drawing.Point(18, 127);
            this.lblCompanyAddress2.Name = "lblCompanyAddress2";
            this.lblCompanyAddress2.Size = new System.Drawing.Size(77, 18);
            this.lblCompanyAddress2.TabIndex = 6;
            this.lblCompanyAddress2.Text = "Address2";
            // 
            // lblCompanyAddress3
            // 
            this.lblCompanyAddress3.AutoSize = true;
            this.lblCompanyAddress3.Location = new System.Drawing.Point(18, 164);
            this.lblCompanyAddress3.Name = "lblCompanyAddress3";
            this.lblCompanyAddress3.Size = new System.Drawing.Size(77, 18);
            this.lblCompanyAddress3.TabIndex = 7;
            this.lblCompanyAddress3.Text = "Address3";
            // 
            // btnCreateExcel
            // 
            this.btnCreateExcel.Location = new System.Drawing.Point(578, 332);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(140, 58);
            this.btnCreateExcel.TabIndex = 3;
            this.btnCreateExcel.Text = "Create";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.grpCompanyInfo);
            this.Controls.Add(this.cmbDocumentType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCompanyInfo.ResumeLayout(false);
            this.grpCompanyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.GroupBox grpCompanyInfo;
        private System.Windows.Forms.Label lblCompanyAddress3;
        private System.Windows.Forms.Label lblCompanyAddress2;
        private System.Windows.Forms.Label lblCompanyAddress1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox textCompanyAddress2;
        private System.Windows.Forms.TextBox textCompanyAddress1;
        private System.Windows.Forms.TextBox textCompanyAddress3;
        private System.Windows.Forms.TextBox textCompanyName;
        private System.Windows.Forms.Button btnCreateExcel;
    }
}

