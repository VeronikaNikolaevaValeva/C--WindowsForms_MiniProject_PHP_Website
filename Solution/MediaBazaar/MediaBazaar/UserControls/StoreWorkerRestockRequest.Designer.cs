namespace MediaBazaar
{
    partial class StoreWorkerRestockRequest
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
            this.lblCreateRestockRequest = new System.Windows.Forms.Label();
            this.lbxProductsBelowMinimum = new System.Windows.Forms.ListBox();
            this.gbxRestocRProductInformation = new System.Windows.Forms.GroupBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.pnlMinimumStock = new System.Windows.Forms.Panel();
            this.lblMinimumAmount = new System.Windows.Forms.Label();
            this.lblAmoutnOfStockInStore = new System.Windows.Forms.Label();
            this.pnlAmountInStore = new System.Windows.Forms.Panel();
            this.lblAmountInStore = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.lblMinimumStock = new System.Windows.Forms.Label();
            this.gbxMinimumStockInStore = new System.Windows.Forms.GroupBox();
            this.btnAdjustMinStock = new System.Windows.Forms.Button();
            this.txbMinimumAmountInStore = new System.Windows.Forms.TextBox();
            this.gbxSendRestockRequest = new System.Windows.Forms.GroupBox();
            this.txbRestockRequesrtAmount = new System.Windows.Forms.TextBox();
            this.btnStoreSend = new System.Windows.Forms.Button();
            this.lblSendToStore = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbpBelowMinimum = new System.Windows.Forms.TabPage();
            this.tbpAboveMinimum = new System.Windows.Forms.TabPage();
            this.lbxProductsAboveMinimum = new System.Windows.Forms.ListBox();
            this.gbxRestocRProductInformation.SuspendLayout();
            this.pnlMinimumStock.SuspendLayout();
            this.pnlAmountInStore.SuspendLayout();
            this.gbxMinimumStockInStore.SuspendLayout();
            this.gbxSendRestockRequest.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbpBelowMinimum.SuspendLayout();
            this.tbpAboveMinimum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateRestockRequest
            // 
            this.lblCreateRestockRequest.AutoSize = true;
            this.lblCreateRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreateRestockRequest.Location = new System.Drawing.Point(23, 31);
            this.lblCreateRestockRequest.Name = "lblCreateRestockRequest";
            this.lblCreateRestockRequest.Size = new System.Drawing.Size(314, 32);
            this.lblCreateRestockRequest.TabIndex = 1;
            this.lblCreateRestockRequest.Text = "Create restock requests";
            // 
            // lbxProductsBelowMinimum
            // 
            this.lbxProductsBelowMinimum.BackColor = System.Drawing.Color.White;
            this.lbxProductsBelowMinimum.CausesValidation = false;
            this.lbxProductsBelowMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxProductsBelowMinimum.FormattingEnabled = true;
            this.lbxProductsBelowMinimum.ItemHeight = 29;
            this.lbxProductsBelowMinimum.Location = new System.Drawing.Point(6, 4);
            this.lbxProductsBelowMinimum.Name = "lbxProductsBelowMinimum";
            this.lbxProductsBelowMinimum.Size = new System.Drawing.Size(489, 236);
            this.lbxProductsBelowMinimum.TabIndex = 0;
            this.lbxProductsBelowMinimum.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxCreateRestockRequests_DrawItem);
            this.lbxProductsBelowMinimum.DoubleClick += new System.EventHandler(this.lbxCreateRestockRequests_DoubleClick);
            this.lbxProductsBelowMinimum.MouseLeave += new System.EventHandler(this.lbxCreateRestockRequests_MouseLeave);
            this.lbxProductsBelowMinimum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxCreateRestockRequests_MouseMove);
            // 
            // gbxRestocRProductInformation
            // 
            this.gbxRestocRProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxRestocRProductInformation.Controls.Add(this.lblMinimum);
            this.gbxRestocRProductInformation.Controls.Add(this.pnlMinimumStock);
            this.gbxRestocRProductInformation.Controls.Add(this.lblAmoutnOfStockInStore);
            this.gbxRestocRProductInformation.Controls.Add(this.pnlAmountInStore);
            this.gbxRestocRProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxRestocRProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxRestocRProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxRestocRProductInformation.Location = new System.Drawing.Point(574, 85);
            this.gbxRestocRProductInformation.Name = "gbxRestocRProductInformation";
            this.gbxRestocRProductInformation.Size = new System.Drawing.Size(517, 270);
            this.gbxRestocRProductInformation.TabIndex = 6;
            this.gbxRestocRProductInformation.TabStop = false;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(299, 152);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(117, 29);
            this.lblMinimum.TabIndex = 7;
            this.lblMinimum.Text = "Minimum:";
            // 
            // pnlMinimumStock
            // 
            this.pnlMinimumStock.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlMinimumStock.Controls.Add(this.lblMinimumAmount);
            this.pnlMinimumStock.Location = new System.Drawing.Point(304, 184);
            this.pnlMinimumStock.Name = "pnlMinimumStock";
            this.pnlMinimumStock.Size = new System.Drawing.Size(178, 63);
            this.pnlMinimumStock.TabIndex = 6;
            // 
            // lblMinimumAmount
            // 
            this.lblMinimumAmount.AutoSize = true;
            this.lblMinimumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimumAmount.Location = new System.Drawing.Point(71, 16);
            this.lblMinimumAmount.Name = "lblMinimumAmount";
            this.lblMinimumAmount.Size = new System.Drawing.Size(39, 29);
            this.lblMinimumAmount.TabIndex = 5;
            this.lblMinimumAmount.Text = "50";
            // 
            // lblAmoutnOfStockInStore
            // 
            this.lblAmoutnOfStockInStore.AutoSize = true;
            this.lblAmoutnOfStockInStore.Location = new System.Drawing.Point(30, 152);
            this.lblAmoutnOfStockInStore.Name = "lblAmoutnOfStockInStore";
            this.lblAmoutnOfStockInStore.Size = new System.Drawing.Size(164, 29);
            this.lblAmoutnOfStockInStore.TabIndex = 5;
            this.lblAmoutnOfStockInStore.Text = "Stock in store:";
            // 
            // pnlAmountInStore
            // 
            this.pnlAmountInStore.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlAmountInStore.Controls.Add(this.lblAmountInStore);
            this.pnlAmountInStore.Location = new System.Drawing.Point(35, 184);
            this.pnlAmountInStore.Name = "pnlAmountInStore";
            this.pnlAmountInStore.Size = new System.Drawing.Size(184, 63);
            this.pnlAmountInStore.TabIndex = 2;
            // 
            // lblAmountInStore
            // 
            this.lblAmountInStore.AutoSize = true;
            this.lblAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInStore.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInStore.Name = "lblAmountInStore";
            this.lblAmountInStore.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInStore.TabIndex = 5;
            this.lblAmountInStore.Text = "00";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(30, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(30, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // lblMinimumStock
            // 
            this.lblMinimumStock.AutoSize = true;
            this.lblMinimumStock.Location = new System.Drawing.Point(30, 39);
            this.lblMinimumStock.Name = "lblMinimumStock";
            this.lblMinimumStock.Size = new System.Drawing.Size(147, 50);
            this.lblMinimumStock.TabIndex = 7;
            this.lblMinimumStock.Text = "Minimum stock \r\nin store:";
            // 
            // gbxMinimumStockInStore
            // 
            this.gbxMinimumStockInStore.BackColor = System.Drawing.Color.White;
            this.gbxMinimumStockInStore.Controls.Add(this.lblMinimumStock);
            this.gbxMinimumStockInStore.Controls.Add(this.btnAdjustMinStock);
            this.gbxMinimumStockInStore.Controls.Add(this.txbMinimumAmountInStore);
            this.gbxMinimumStockInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxMinimumStockInStore.Location = new System.Drawing.Point(574, 387);
            this.gbxMinimumStockInStore.Name = "gbxMinimumStockInStore";
            this.gbxMinimumStockInStore.Size = new System.Drawing.Size(516, 134);
            this.gbxMinimumStockInStore.TabIndex = 9;
            this.gbxMinimumStockInStore.TabStop = false;
            // 
            // btnAdjustMinStock
            // 
            this.btnAdjustMinStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdjustMinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdjustMinStock.Location = new System.Drawing.Point(379, 70);
            this.btnAdjustMinStock.Name = "btnAdjustMinStock";
            this.btnAdjustMinStock.Size = new System.Drawing.Size(103, 43);
            this.btnAdjustMinStock.TabIndex = 8;
            this.btnAdjustMinStock.Text = "Adjust";
            this.btnAdjustMinStock.UseVisualStyleBackColor = false;
            this.btnAdjustMinStock.Click += new System.EventHandler(this.btnAdjustMinStock_Click);
            // 
            // txbMinimumAmountInStore
            // 
            this.txbMinimumAmountInStore.Location = new System.Drawing.Point(230, 36);
            this.txbMinimumAmountInStore.Name = "txbMinimumAmountInStore";
            this.txbMinimumAmountInStore.Size = new System.Drawing.Size(108, 30);
            this.txbMinimumAmountInStore.TabIndex = 0;
            this.txbMinimumAmountInStore.Text = "50";
            // 
            // gbxSendRestockRequest
            // 
            this.gbxSendRestockRequest.BackColor = System.Drawing.Color.White;
            this.gbxSendRestockRequest.Controls.Add(this.txbRestockRequesrtAmount);
            this.gbxSendRestockRequest.Controls.Add(this.btnStoreSend);
            this.gbxSendRestockRequest.Controls.Add(this.lblSendToStore);
            this.gbxSendRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSendRestockRequest.Location = new System.Drawing.Point(575, 541);
            this.gbxSendRestockRequest.Name = "gbxSendRestockRequest";
            this.gbxSendRestockRequest.Size = new System.Drawing.Size(516, 134);
            this.gbxSendRestockRequest.TabIndex = 10;
            this.gbxSendRestockRequest.TabStop = false;
            // 
            // txbRestockRequesrtAmount
            // 
            this.txbRestockRequesrtAmount.Location = new System.Drawing.Point(224, 36);
            this.txbRestockRequesrtAmount.Name = "txbRestockRequesrtAmount";
            this.txbRestockRequesrtAmount.Size = new System.Drawing.Size(108, 30);
            this.txbRestockRequesrtAmount.TabIndex = 8;
            // 
            // btnStoreSend
            // 
            this.btnStoreSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnStoreSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStoreSend.Location = new System.Drawing.Point(376, 70);
            this.btnStoreSend.Name = "btnStoreSend";
            this.btnStoreSend.Size = new System.Drawing.Size(103, 43);
            this.btnStoreSend.TabIndex = 7;
            this.btnStoreSend.Text = "Send";
            this.btnStoreSend.UseVisualStyleBackColor = false;
            this.btnStoreSend.Click += new System.EventHandler(this.btnStoreSend_Click);
            // 
            // lblSendToStore
            // 
            this.lblSendToStore.AutoSize = true;
            this.lblSendToStore.Location = new System.Drawing.Point(27, 39);
            this.lblSendToStore.Name = "lblSendToStore";
            this.lblSendToStore.Size = new System.Drawing.Size(132, 50);
            this.lblSendToStore.TabIndex = 6;
            this.lblSendToStore.Text = "Send restock \r\nrequest:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(165, 550);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbpBelowMinimum);
            this.tabControl2.Controls.Add(this.tbpAboveMinimum);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(29, 85);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(516, 287);
            this.tabControl2.TabIndex = 12;
            // 
            // tbpBelowMinimum
            // 
            this.tbpBelowMinimum.Controls.Add(this.lbxProductsBelowMinimum);
            this.tbpBelowMinimum.Location = new System.Drawing.Point(4, 38);
            this.tbpBelowMinimum.Name = "tbpBelowMinimum";
            this.tbpBelowMinimum.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBelowMinimum.Size = new System.Drawing.Size(508, 245);
            this.tbpBelowMinimum.TabIndex = 0;
            this.tbpBelowMinimum.Text = "Below min";
            this.tbpBelowMinimum.UseVisualStyleBackColor = true;
            // 
            // tbpAboveMinimum
            // 
            this.tbpAboveMinimum.Controls.Add(this.lbxProductsAboveMinimum);
            this.tbpAboveMinimum.Location = new System.Drawing.Point(4, 38);
            this.tbpAboveMinimum.Name = "tbpAboveMinimum";
            this.tbpAboveMinimum.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAboveMinimum.Size = new System.Drawing.Size(508, 245);
            this.tbpAboveMinimum.TabIndex = 1;
            this.tbpAboveMinimum.Text = "Above min";
            this.tbpAboveMinimum.UseVisualStyleBackColor = true;
            // 
            // lbxProductsAboveMinimum
            // 
            this.lbxProductsAboveMinimum.BackColor = System.Drawing.Color.White;
            this.lbxProductsAboveMinimum.CausesValidation = false;
            this.lbxProductsAboveMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxProductsAboveMinimum.FormattingEnabled = true;
            this.lbxProductsAboveMinimum.ItemHeight = 29;
            this.lbxProductsAboveMinimum.Location = new System.Drawing.Point(10, 4);
            this.lbxProductsAboveMinimum.Name = "lbxProductsAboveMinimum";
            this.lbxProductsAboveMinimum.Size = new System.Drawing.Size(489, 236);
            this.lbxProductsAboveMinimum.TabIndex = 1;
            this.lbxProductsAboveMinimum.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxProductsAboveMinimum_DrawItem);
            this.lbxProductsAboveMinimum.DoubleClick += new System.EventHandler(this.lbxProductsAboveMinimum_DoubleClick);
            this.lbxProductsAboveMinimum.MouseLeave += new System.EventHandler(this.lbxProductsAboveMinimum_MouseLeave);
            this.lbxProductsAboveMinimum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxProductsAboveMinimum_MouseMove);
            // 
            // StoreWorkerRestockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbxSendRestockRequest);
            this.Controls.Add(this.gbxMinimumStockInStore);
            this.Controls.Add(this.gbxRestocRProductInformation);
            this.Controls.Add(this.lblCreateRestockRequest);
            this.Name = "StoreWorkerRestockRequest";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxRestocRProductInformation.ResumeLayout(false);
            this.gbxRestocRProductInformation.PerformLayout();
            this.pnlMinimumStock.ResumeLayout(false);
            this.pnlMinimumStock.PerformLayout();
            this.pnlAmountInStore.ResumeLayout(false);
            this.pnlAmountInStore.PerformLayout();
            this.gbxMinimumStockInStore.ResumeLayout(false);
            this.gbxMinimumStockInStore.PerformLayout();
            this.gbxSendRestockRequest.ResumeLayout(false);
            this.gbxSendRestockRequest.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbpBelowMinimum.ResumeLayout(false);
            this.tbpAboveMinimum.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateRestockRequest;
        private System.Windows.Forms.ListBox lbxProductsBelowMinimum;
        private System.Windows.Forms.GroupBox gbxRestocRProductInformation;
        private System.Windows.Forms.Label lblAmoutnOfStockInStore;
        private System.Windows.Forms.Panel pnlAmountInStore;
        private System.Windows.Forms.Label lblAmountInStore;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblMinimumStock;
        private System.Windows.Forms.GroupBox gbxMinimumStockInStore;
        private System.Windows.Forms.Button btnAdjustMinStock;
        private System.Windows.Forms.TextBox txbMinimumAmountInStore;
        private System.Windows.Forms.GroupBox gbxSendRestockRequest;
        private System.Windows.Forms.Button btnStoreSend;
        private System.Windows.Forms.Label lblSendToStore;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Panel pnlMinimumStock;
        private System.Windows.Forms.Label lblMinimumAmount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbpBelowMinimum;
        private System.Windows.Forms.TabPage tbpAboveMinimum;
        private System.Windows.Forms.ListBox lbxProductsAboveMinimum;
        private System.Windows.Forms.TextBox txbRestockRequesrtAmount;
    }
}
