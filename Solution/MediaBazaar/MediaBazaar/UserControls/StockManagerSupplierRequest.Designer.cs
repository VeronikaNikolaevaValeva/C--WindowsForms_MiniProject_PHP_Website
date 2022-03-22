namespace MediaBazaar
{
    partial class StockManagerSupplierRequest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnProceedRequest = new System.Windows.Forms.Button();
            this.gbxSupplierRequestProductInfo = new System.Windows.Forms.GroupBox();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.pnlMinimumStock = new System.Windows.Forms.Panel();
            this.lblSupplierRequestAmount = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.pnlViewSupplierRequests = new System.Windows.Forms.Panel();
            this.lbxSupplierRequests = new System.Windows.Forms.ListBox();
            this.lblViewSupplierRequests = new System.Windows.Forms.Label();
            this.gbxSupplierContact = new System.Windows.Forms.GroupBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.rtxbEmailContent = new System.Windows.Forms.RichTextBox();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txbEmailSubject = new System.Windows.Forms.TextBox();
            this.gbxSupplierRequestProductInfo.SuspendLayout();
            this.pnlMinimumStock.SuspendLayout();
            this.pnlViewSupplierRequests.SuspendLayout();
            this.gbxSupplierContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyRequest.Location = new System.Drawing.Point(851, 334);
            this.btnDenyRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(227, 49);
            this.btnDenyRequest.TabIndex = 14;
            this.btnDenyRequest.Text = "Deny request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnProceedRequest
            // 
            this.btnProceedRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProceedRequest.Location = new System.Drawing.Point(575, 334);
            this.btnProceedRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProceedRequest.Name = "btnProceedRequest";
            this.btnProceedRequest.Size = new System.Drawing.Size(227, 49);
            this.btnProceedRequest.TabIndex = 13;
            this.btnProceedRequest.Text = "Proceed request";
            this.btnProceedRequest.UseVisualStyleBackColor = true;
            this.btnProceedRequest.Click += new System.EventHandler(this.btnProceedRequest_Click);
            // 
            // gbxSupplierRequestProductInfo
            // 
            this.gbxSupplierRequestProductInfo.BackColor = System.Drawing.Color.White;
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblRequestedAmount);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.pnlMinimumStock);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblProductBrand);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblProductTypeAndModel);
            this.gbxSupplierRequestProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSupplierRequestProductInfo.Location = new System.Drawing.Point(575, 86);
            this.gbxSupplierRequestProductInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSupplierRequestProductInfo.Name = "gbxSupplierRequestProductInfo";
            this.gbxSupplierRequestProductInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSupplierRequestProductInfo.Size = new System.Drawing.Size(503, 229);
            this.gbxSupplierRequestProductInfo.TabIndex = 12;
            this.gbxSupplierRequestProductInfo.TabStop = false;
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Location = new System.Drawing.Point(29, 146);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(228, 29);
            this.lblRequestedAmount.TabIndex = 7;
            this.lblRequestedAmount.Text = "Requested amount: ";
            // 
            // pnlMinimumStock
            // 
            this.pnlMinimumStock.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlMinimumStock.Controls.Add(this.lblSupplierRequestAmount);
            this.pnlMinimumStock.Location = new System.Drawing.Point(294, 146);
            this.pnlMinimumStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMinimumStock.Name = "pnlMinimumStock";
            this.pnlMinimumStock.Size = new System.Drawing.Size(178, 63);
            this.pnlMinimumStock.TabIndex = 6;
            // 
            // lblSupplierRequestAmount
            // 
            this.lblSupplierRequestAmount.AutoSize = true;
            this.lblSupplierRequestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierRequestAmount.Location = new System.Drawing.Point(71, 16);
            this.lblSupplierRequestAmount.Name = "lblSupplierRequestAmount";
            this.lblSupplierRequestAmount.Size = new System.Drawing.Size(39, 29);
            this.lblSupplierRequestAmount.TabIndex = 5;
            this.lblSupplierRequestAmount.Text = "00";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(29, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(29, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // pnlViewSupplierRequests
            // 
            this.pnlViewSupplierRequests.BackColor = System.Drawing.Color.White;
            this.pnlViewSupplierRequests.Controls.Add(this.lbxSupplierRequests);
            this.pnlViewSupplierRequests.Location = new System.Drawing.Point(37, 86);
            this.pnlViewSupplierRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlViewSupplierRequests.Name = "pnlViewSupplierRequests";
            this.pnlViewSupplierRequests.Size = new System.Drawing.Size(505, 297);
            this.pnlViewSupplierRequests.TabIndex = 11;
            // 
            // lbxSupplierRequests
            // 
            this.lbxSupplierRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxSupplierRequests.FormattingEnabled = true;
            this.lbxSupplierRequests.ItemHeight = 29;
            this.lbxSupplierRequests.Location = new System.Drawing.Point(13, 20);
            this.lbxSupplierRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxSupplierRequests.Name = "lbxSupplierRequests";
            this.lbxSupplierRequests.Size = new System.Drawing.Size(478, 265);
            this.lbxSupplierRequests.TabIndex = 0;
            this.lbxSupplierRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxSupplierRequests_DrawItem);
            this.lbxSupplierRequests.DoubleClick += new System.EventHandler(this.lbxSupplierRequests_DoubleClick);
            this.lbxSupplierRequests.MouseLeave += new System.EventHandler(this.lbxSupplierRequests_MouseLeave);
            this.lbxSupplierRequests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxSupplierRequests_MouseMove);
            // 
            // lblViewSupplierRequests
            // 
            this.lblViewSupplierRequests.AutoSize = true;
            this.lblViewSupplierRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblViewSupplierRequests.Location = new System.Drawing.Point(32, 37);
            this.lblViewSupplierRequests.Name = "lblViewSupplierRequests";
            this.lblViewSupplierRequests.Size = new System.Drawing.Size(374, 32);
            this.lblViewSupplierRequests.TabIndex = 10;
            this.lblViewSupplierRequests.Text = "View supplier stock requests";
            // 
            // gbxSupplierContact
            // 
            this.gbxSupplierContact.BackColor = System.Drawing.Color.White;
            this.gbxSupplierContact.Controls.Add(this.txbEmailSubject);
            this.gbxSupplierContact.Controls.Add(this.btnSendEmail);
            this.gbxSupplierContact.Controls.Add(this.rtxbEmailContent);
            this.gbxSupplierContact.Controls.Add(this.lblSupplierEmail);
            this.gbxSupplierContact.Controls.Add(this.lblSupplierPhone);
            this.gbxSupplierContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSupplierContact.Location = new System.Drawing.Point(37, 390);
            this.gbxSupplierContact.Name = "gbxSupplierContact";
            this.gbxSupplierContact.Size = new System.Drawing.Size(1041, 361);
            this.gbxSupplierContact.TabIndex = 15;
            this.gbxSupplierContact.TabStop = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendEmail.Location = new System.Drawing.Point(783, 284);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(227, 49);
            this.btnSendEmail.TabIndex = 14;
            this.btnSendEmail.Text = "Send email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // rtxbEmailContent
            // 
            this.rtxbEmailContent.Location = new System.Drawing.Point(22, 128);
            this.rtxbEmailContent.Name = "rtxbEmailContent";
            this.rtxbEmailContent.Size = new System.Drawing.Size(988, 149);
            this.rtxbEmailContent.TabIndex = 2;
            this.rtxbEmailContent.Text = "";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Location = new System.Drawing.Point(17, 30);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(169, 29);
            this.lblSupplierEmail.TabIndex = 1;
            this.lblSupplierEmail.Text = "Supplier email";
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Location = new System.Drawing.Point(383, 30);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(178, 29);
            this.lblSupplierPhone.TabIndex = 0;
            this.lblSupplierPhone.Text = "Supplier phone";
            // 
            // txbEmailSubject
            // 
            this.txbEmailSubject.Location = new System.Drawing.Point(22, 88);
            this.txbEmailSubject.Name = "txbEmailSubject";
            this.txbEmailSubject.Size = new System.Drawing.Size(539, 34);
            this.txbEmailSubject.TabIndex = 15;
            // 
            // StockManagerSupplierRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxSupplierContact);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnProceedRequest);
            this.Controls.Add(this.gbxSupplierRequestProductInfo);
            this.Controls.Add(this.pnlViewSupplierRequests);
            this.Controls.Add(this.lblViewSupplierRequests);
            this.Name = "StockManagerSupplierRequest";
            this.Size = new System.Drawing.Size(1129, 785);
            this.gbxSupplierRequestProductInfo.ResumeLayout(false);
            this.gbxSupplierRequestProductInfo.PerformLayout();
            this.pnlMinimumStock.ResumeLayout(false);
            this.pnlMinimumStock.PerformLayout();
            this.pnlViewSupplierRequests.ResumeLayout(false);
            this.gbxSupplierContact.ResumeLayout(false);
            this.gbxSupplierContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.Button btnProceedRequest;
        private System.Windows.Forms.GroupBox gbxSupplierRequestProductInfo;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.Panel pnlMinimumStock;
        private System.Windows.Forms.Label lblSupplierRequestAmount;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Panel pnlViewSupplierRequests;
        private System.Windows.Forms.ListBox lbxSupplierRequests;
        private System.Windows.Forms.Label lblViewSupplierRequests;
        private System.Windows.Forms.GroupBox gbxSupplierContact;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.RichTextBox rtxbEmailContent;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txbEmailSubject;
    }
}
