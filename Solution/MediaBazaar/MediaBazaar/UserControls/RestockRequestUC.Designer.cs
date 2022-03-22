
namespace MediaBazaar
{
    partial class RestockRequestInterface
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
            this.lblRestockRequest = new System.Windows.Forms.Label();
            this.gbxProductInformation = new System.Windows.Forms.GroupBox();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.pnlAmountInWarehouse = new System.Windows.Forms.Panel();
            this.lblAmountInWarehouse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStockInStoreLabel = new System.Windows.Forms.Label();
            this.lblStockMessage = new System.Windows.Forms.Label();
            this.pnlAmountInStore = new System.Windows.Forms.Panel();
            this.lblAmountInStore = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.lbxRestockRequests = new System.Windows.Forms.ListBox();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.gbxStore = new System.Windows.Forms.GroupBox();
            this.btnStoreSend = new System.Windows.Forms.Button();
            this.lblSendToStore = new System.Windows.Forms.Label();
            this.numSendAmount = new System.Windows.Forms.NumericUpDown();
            this.txbRequestedAmount = new System.Windows.Forms.TextBox();
            this.lblSendRequestToTheSupplier = new System.Windows.Forms.Label();
            this.gbxSupplier = new System.Windows.Forms.GroupBox();
            this.btnSendSupplierRequest = new System.Windows.Forms.Button();
            this.tbcntrlProductsInWarehouse = new System.Windows.Forms.TabControl();
            this.tbpRestockRequests = new System.Windows.Forms.TabPage();
            this.tbpStockInWarehouse = new System.Windows.Forms.TabPage();
            this.lbxStockInWarehouse = new System.Windows.Forms.ListBox();
            this.tbpRestockRequest = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbpStockRecieving = new System.Windows.Forms.TabPage();
            this.gbxRecievingStock = new System.Windows.Forms.GroupBox();
            this.btnRecieveStock = new System.Windows.Forms.Button();
            this.lblRecievedStock = new System.Windows.Forms.Label();
            this.txbAmountOfRecievedStock = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecievingSBrand = new System.Windows.Forms.Label();
            this.lblRecievingSTypeAndModel = new System.Windows.Forms.Label();
            this.txbFindProduct = new System.Windows.Forms.TextBox();
            this.pnlStockInSystem = new System.Windows.Forms.Panel();
            this.lbxStockInSystem = new System.Windows.Forms.ListBox();
            this.lblStockRecieving = new System.Windows.Forms.Label();
            this.gbxProductInformation.SuspendLayout();
            this.pnlAmountInWarehouse.SuspendLayout();
            this.pnlAmountInStore.SuspendLayout();
            this.gbxStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendAmount)).BeginInit();
            this.gbxSupplier.SuspendLayout();
            this.tbcntrlProductsInWarehouse.SuspendLayout();
            this.tbpRestockRequests.SuspendLayout();
            this.tbpStockInWarehouse.SuspendLayout();
            this.tbpRestockRequest.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbpStockRecieving.SuspendLayout();
            this.gbxRecievingStock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlStockInSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRestockRequest
            // 
            this.lblRestockRequest.AutoSize = true;
            this.lblRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestockRequest.Location = new System.Drawing.Point(22, 18);
            this.lblRestockRequest.Name = "lblRestockRequest";
            this.lblRestockRequest.Size = new System.Drawing.Size(233, 32);
            this.lblRestockRequest.TabIndex = 0;
            this.lblRestockRequest.Text = "Restock requests";
            // 
            // gbxProductInformation
            // 
            this.gbxProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxProductInformation.Controls.Add(this.lblRequestedAmount);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInWarehouse);
            this.gbxProductInformation.Controls.Add(this.label3);
            this.gbxProductInformation.Controls.Add(this.lblAmount);
            this.gbxProductInformation.Controls.Add(this.lblStockInStoreLabel);
            this.gbxProductInformation.Controls.Add(this.lblStockMessage);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInStore);
            this.gbxProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProductInformation.Location = new System.Drawing.Point(564, 35);
            this.gbxProductInformation.Name = "gbxProductInformation";
            this.gbxProductInformation.Size = new System.Drawing.Size(517, 368);
            this.gbxProductInformation.TabIndex = 3;
            this.gbxProductInformation.TabStop = false;
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestedAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRequestedAmount.Location = new System.Drawing.Point(295, 142);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(41, 29);
            this.lblRequestedAmount.TabIndex = 8;
            this.lblRequestedAmount.Text = "00";
            // 
            // pnlAmountInWarehouse
            // 
            this.pnlAmountInWarehouse.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlAmountInWarehouse.Controls.Add(this.lblAmountInWarehouse);
            this.pnlAmountInWarehouse.Location = new System.Drawing.Point(300, 237);
            this.pnlAmountInWarehouse.Name = "pnlAmountInWarehouse";
            this.pnlAmountInWarehouse.Size = new System.Drawing.Size(178, 63);
            this.pnlAmountInWarehouse.TabIndex = 3;
            // 
            // lblAmountInWarehouse
            // 
            this.lblAmountInWarehouse.AutoSize = true;
            this.lblAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInWarehouse.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInWarehouse.Name = "lblAmountInWarehouse";
            this.lblAmountInWarehouse.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInWarehouse.TabIndex = 5;
            this.lblAmountInWarehouse.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "In warehouse:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(222, 29);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Requested amount:";
            // 
            // lblStockInStoreLabel
            // 
            this.lblStockInStoreLabel.AutoSize = true;
            this.lblStockInStoreLabel.Location = new System.Drawing.Point(30, 205);
            this.lblStockInStoreLabel.Name = "lblStockInStoreLabel";
            this.lblStockInStoreLabel.Size = new System.Drawing.Size(98, 29);
            this.lblStockInStoreLabel.TabIndex = 5;
            this.lblStockInStoreLabel.Text = "In store:";
            // 
            // lblStockMessage
            // 
            this.lblStockMessage.AutoSize = true;
            this.lblStockMessage.Location = new System.Drawing.Point(30, 325);
            this.lblStockMessage.Name = "lblStockMessage";
            this.lblStockMessage.Size = new System.Drawing.Size(31, 29);
            this.lblStockMessage.TabIndex = 4;
            this.lblStockMessage.Text = "...";
            // 
            // pnlAmountInStore
            // 
            this.pnlAmountInStore.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlAmountInStore.Controls.Add(this.lblAmountInStore);
            this.pnlAmountInStore.Location = new System.Drawing.Point(34, 237);
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
            // lbxRestockRequests
            // 
            this.lbxRestockRequests.BackColor = System.Drawing.Color.White;
            this.lbxRestockRequests.CausesValidation = false;
            this.lbxRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxRestockRequests.FormattingEnabled = true;
            this.lbxRestockRequests.ItemHeight = 29;
            this.lbxRestockRequests.Location = new System.Drawing.Point(8, 1);
            this.lbxRestockRequests.Name = "lbxRestockRequests";
            this.lbxRestockRequests.Size = new System.Drawing.Size(489, 236);
            this.lbxRestockRequests.TabIndex = 0;
            this.lbxRestockRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxRestockRequests_DrawItem_1);
            this.lbxRestockRequests.SelectedIndexChanged += new System.EventHandler(this.lbxRestockRequests_SelectedIndexChanged);
            this.lbxRestockRequests.DoubleClick += new System.EventHandler(this.lbxRestockRequests_DoubleClick);
            this.lbxRestockRequests.MouseLeave += new System.EventHandler(this.lbxRestockRequests_MouseLeave);
            this.lbxRestockRequests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxRestockRequests_MouseMove);
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnDenyRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyRequest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDenyRequest.Location = new System.Drawing.Point(313, 360);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(218, 43);
            this.btnDenyRequest.TabIndex = 6;
            this.btnDenyRequest.Text = "Decline request";
            this.btnDenyRequest.UseVisualStyleBackColor = false;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            this.btnDenyRequest.MouseLeave += new System.EventHandler(this.btnDenyRequest_MouseLeave);
            this.btnDenyRequest.MouseHover += new System.EventHandler(this.btnDenyRequest_MouseHover);
            // 
            // gbxStore
            // 
            this.gbxStore.BackColor = System.Drawing.Color.White;
            this.gbxStore.Controls.Add(this.btnStoreSend);
            this.gbxStore.Controls.Add(this.lblSendToStore);
            this.gbxStore.Controls.Add(this.numSendAmount);
            this.gbxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxStore.Location = new System.Drawing.Point(565, 543);
            this.gbxStore.Name = "gbxStore";
            this.gbxStore.Size = new System.Drawing.Size(516, 122);
            this.gbxStore.TabIndex = 7;
            this.gbxStore.TabStop = false;
            // 
            // btnStoreSend
            // 
            this.btnStoreSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnStoreSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStoreSend.Location = new System.Drawing.Point(376, 59);
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
            this.lblSendToStore.Size = new System.Drawing.Size(131, 50);
            this.lblSendToStore.TabIndex = 6;
            this.lblSendToStore.Text = "Send items to\r\nthe store:";
            // 
            // numSendAmount
            // 
            this.numSendAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSendAmount.Location = new System.Drawing.Point(236, 39);
            this.numSendAmount.Name = "numSendAmount";
            this.numSendAmount.Size = new System.Drawing.Size(100, 30);
            this.numSendAmount.TabIndex = 1;
            // 
            // txbRequestedAmount
            // 
            this.txbRequestedAmount.Location = new System.Drawing.Point(235, 37);
            this.txbRequestedAmount.Name = "txbRequestedAmount";
            this.txbRequestedAmount.Size = new System.Drawing.Size(100, 30);
            this.txbRequestedAmount.TabIndex = 0;
            // 
            // lblSendRequestToTheSupplier
            // 
            this.lblSendRequestToTheSupplier.AutoSize = true;
            this.lblSendRequestToTheSupplier.Location = new System.Drawing.Point(26, 37);
            this.lblSendRequestToTheSupplier.Name = "lblSendRequestToTheSupplier";
            this.lblSendRequestToTheSupplier.Size = new System.Drawing.Size(155, 50);
            this.lblSendRequestToTheSupplier.TabIndex = 7;
            this.lblSendRequestToTheSupplier.Text = "Send request to \r\nthe supplier:";
            // 
            // gbxSupplier
            // 
            this.gbxSupplier.BackColor = System.Drawing.Color.White;
            this.gbxSupplier.Controls.Add(this.btnSendSupplierRequest);
            this.gbxSupplier.Controls.Add(this.lblSendRequestToTheSupplier);
            this.gbxSupplier.Controls.Add(this.txbRequestedAmount);
            this.gbxSupplier.Enabled = false;
            this.gbxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSupplier.Location = new System.Drawing.Point(564, 409);
            this.gbxSupplier.Name = "gbxSupplier";
            this.gbxSupplier.Size = new System.Drawing.Size(516, 128);
            this.gbxSupplier.TabIndex = 8;
            this.gbxSupplier.TabStop = false;
            // 
            // btnSendSupplierRequest
            // 
            this.btnSendSupplierRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendSupplierRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendSupplierRequest.Location = new System.Drawing.Point(376, 61);
            this.btnSendSupplierRequest.Name = "btnSendSupplierRequest";
            this.btnSendSupplierRequest.Size = new System.Drawing.Size(103, 43);
            this.btnSendSupplierRequest.TabIndex = 8;
            this.btnSendSupplierRequest.Text = "Send";
            this.btnSendSupplierRequest.UseVisualStyleBackColor = false;
            this.btnSendSupplierRequest.Click += new System.EventHandler(this.btnSendSupplierRequest_Click);
            // 
            // tbcntrlProductsInWarehouse
            // 
            this.tbcntrlProductsInWarehouse.Controls.Add(this.tbpRestockRequests);
            this.tbcntrlProductsInWarehouse.Controls.Add(this.tbpStockInWarehouse);
            this.tbcntrlProductsInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcntrlProductsInWarehouse.Location = new System.Drawing.Point(28, 56);
            this.tbcntrlProductsInWarehouse.Name = "tbcntrlProductsInWarehouse";
            this.tbcntrlProductsInWarehouse.SelectedIndex = 0;
            this.tbcntrlProductsInWarehouse.Size = new System.Drawing.Size(516, 298);
            this.tbcntrlProductsInWarehouse.TabIndex = 9;
            // 
            // tbpRestockRequests
            // 
            this.tbpRestockRequests.Controls.Add(this.lbxRestockRequests);
            this.tbpRestockRequests.Location = new System.Drawing.Point(4, 38);
            this.tbpRestockRequests.Name = "tbpRestockRequests";
            this.tbpRestockRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRestockRequests.Size = new System.Drawing.Size(508, 256);
            this.tbpRestockRequests.TabIndex = 0;
            this.tbpRestockRequests.Text = "Restock requests";
            this.tbpRestockRequests.UseVisualStyleBackColor = true;
            // 
            // tbpStockInWarehouse
            // 
            this.tbpStockInWarehouse.Controls.Add(this.lbxStockInWarehouse);
            this.tbpStockInWarehouse.Location = new System.Drawing.Point(4, 38);
            this.tbpStockInWarehouse.Name = "tbpStockInWarehouse";
            this.tbpStockInWarehouse.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStockInWarehouse.Size = new System.Drawing.Size(508, 256);
            this.tbpStockInWarehouse.TabIndex = 1;
            this.tbpStockInWarehouse.Text = "Stock in warehouse";
            this.tbpStockInWarehouse.UseVisualStyleBackColor = true;
            // 
            // lbxStockInWarehouse
            // 
            this.lbxStockInWarehouse.BackColor = System.Drawing.Color.White;
            this.lbxStockInWarehouse.CausesValidation = false;
            this.lbxStockInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxStockInWarehouse.FormattingEnabled = true;
            this.lbxStockInWarehouse.ItemHeight = 29;
            this.lbxStockInWarehouse.Location = new System.Drawing.Point(10, 2);
            this.lbxStockInWarehouse.Name = "lbxStockInWarehouse";
            this.lbxStockInWarehouse.Size = new System.Drawing.Size(489, 236);
            this.lbxStockInWarehouse.TabIndex = 1;
            this.lbxStockInWarehouse.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxStockInWarehouse_DrawItem);
            this.lbxStockInWarehouse.DoubleClick += new System.EventHandler(this.lbxStockInWarehouse_DoubleClick);
            this.lbxStockInWarehouse.MouseLeave += new System.EventHandler(this.lbxStockInWarehouse_MouseLeave);
            this.lbxStockInWarehouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxStockInWarehouse_MouseMove);
            // 
            // tbpRestockRequest
            // 
            this.tbpRestockRequest.Controls.Add(this.tabPage1);
            this.tbpRestockRequest.Controls.Add(this.tbpStockRecieving);
            this.tbpRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbpRestockRequest.Location = new System.Drawing.Point(3, 4);
            this.tbpRestockRequest.Name = "tbpRestockRequest";
            this.tbpRestockRequest.SelectedIndex = 0;
            this.tbpRestockRequest.Size = new System.Drawing.Size(1115, 740);
            this.tbpRestockRequest.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblRestockRequest);
            this.tabPage1.Controls.Add(this.gbxProductInformation);
            this.tabPage1.Controls.Add(this.gbxSupplier);
            this.tabPage1.Controls.Add(this.tbcntrlProductsInWarehouse);
            this.tabPage1.Controls.Add(this.gbxStore);
            this.tabPage1.Controls.Add(this.btnDenyRequest);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 698);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Restock request";
            // 
            // tbpStockRecieving
            // 
            this.tbpStockRecieving.BackColor = System.Drawing.SystemColors.Control;
            this.tbpStockRecieving.Controls.Add(this.gbxRecievingStock);
            this.tbpStockRecieving.Controls.Add(this.groupBox1);
            this.tbpStockRecieving.Controls.Add(this.txbFindProduct);
            this.tbpStockRecieving.Controls.Add(this.pnlStockInSystem);
            this.tbpStockRecieving.Controls.Add(this.lblStockRecieving);
            this.tbpStockRecieving.Location = new System.Drawing.Point(4, 38);
            this.tbpStockRecieving.Name = "tbpStockRecieving";
            this.tbpStockRecieving.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStockRecieving.Size = new System.Drawing.Size(1107, 698);
            this.tbpStockRecieving.TabIndex = 1;
            this.tbpStockRecieving.Text = "Stock receiving";
            // 
            // gbxRecievingStock
            // 
            this.gbxRecievingStock.BackColor = System.Drawing.Color.White;
            this.gbxRecievingStock.Controls.Add(this.btnRecieveStock);
            this.gbxRecievingStock.Controls.Add(this.lblRecievedStock);
            this.gbxRecievingStock.Controls.Add(this.txbAmountOfRecievedStock);
            this.gbxRecievingStock.Enabled = false;
            this.gbxRecievingStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxRecievingStock.Location = new System.Drawing.Point(567, 283);
            this.gbxRecievingStock.Name = "gbxRecievingStock";
            this.gbxRecievingStock.Size = new System.Drawing.Size(516, 128);
            this.gbxRecievingStock.TabIndex = 9;
            this.gbxRecievingStock.TabStop = false;
            // 
            // btnRecieveStock
            // 
            this.btnRecieveStock.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecieveStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecieveStock.Location = new System.Drawing.Point(376, 61);
            this.btnRecieveStock.Name = "btnRecieveStock";
            this.btnRecieveStock.Size = new System.Drawing.Size(103, 43);
            this.btnRecieveStock.TabIndex = 8;
            this.btnRecieveStock.Text = "Send";
            this.btnRecieveStock.UseVisualStyleBackColor = false;
            this.btnRecieveStock.Click += new System.EventHandler(this.btnRecieveStock_Click);
            // 
            // lblRecievedStock
            // 
            this.lblRecievedStock.AutoSize = true;
            this.lblRecievedStock.Location = new System.Drawing.Point(26, 37);
            this.lblRecievedStock.Name = "lblRecievedStock";
            this.lblRecievedStock.Size = new System.Drawing.Size(158, 50);
            this.lblRecievedStock.TabIndex = 7;
            this.lblRecievedStock.Text = "Receive stock in \r\nwarehouse:";
            // 
            // txbAmountOfRecievedStock
            // 
            this.txbAmountOfRecievedStock.Location = new System.Drawing.Point(235, 37);
            this.txbAmountOfRecievedStock.Name = "txbAmountOfRecievedStock";
            this.txbAmountOfRecievedStock.Size = new System.Drawing.Size(100, 30);
            this.txbAmountOfRecievedStock.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblRecievingSBrand);
            this.groupBox1.Controls.Add(this.lblRecievingSTypeAndModel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(566, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblRecievingSBrand
            // 
            this.lblRecievingSBrand.AutoSize = true;
            this.lblRecievingSBrand.Location = new System.Drawing.Point(30, 84);
            this.lblRecievingSBrand.Name = "lblRecievingSBrand";
            this.lblRecievingSBrand.Size = new System.Drawing.Size(83, 29);
            this.lblRecievingSBrand.TabIndex = 1;
            this.lblRecievingSBrand.Text = "Brand ";
            // 
            // lblRecievingSTypeAndModel
            // 
            this.lblRecievingSTypeAndModel.AutoSize = true;
            this.lblRecievingSTypeAndModel.Location = new System.Drawing.Point(30, 31);
            this.lblRecievingSTypeAndModel.Name = "lblRecievingSTypeAndModel";
            this.lblRecievingSTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblRecievingSTypeAndModel.TabIndex = 0;
            this.lblRecievingSTypeAndModel.Text = "Type and model";
            // 
            // txbFindProduct
            // 
            this.txbFindProduct.Location = new System.Drawing.Point(29, 81);
            this.txbFindProduct.Name = "txbFindProduct";
            this.txbFindProduct.Size = new System.Drawing.Size(516, 34);
            this.txbFindProduct.TabIndex = 3;
            this.txbFindProduct.TextChanged += new System.EventHandler(this.txbFindProduct_TextChanged);
            // 
            // pnlStockInSystem
            // 
            this.pnlStockInSystem.BackColor = System.Drawing.Color.White;
            this.pnlStockInSystem.Controls.Add(this.lbxStockInSystem);
            this.pnlStockInSystem.Location = new System.Drawing.Point(29, 130);
            this.pnlStockInSystem.Name = "pnlStockInSystem";
            this.pnlStockInSystem.Size = new System.Drawing.Size(516, 298);
            this.pnlStockInSystem.TabIndex = 2;
            // 
            // lbxStockInSystem
            // 
            this.lbxStockInSystem.FormattingEnabled = true;
            this.lbxStockInSystem.ItemHeight = 29;
            this.lbxStockInSystem.Location = new System.Drawing.Point(16, 16);
            this.lbxStockInSystem.Name = "lbxStockInSystem";
            this.lbxStockInSystem.Size = new System.Drawing.Size(485, 265);
            this.lbxStockInSystem.TabIndex = 0;
            this.lbxStockInSystem.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxStockInSystem_DrawItem);
            this.lbxStockInSystem.DoubleClick += new System.EventHandler(this.lbxStockInSystem_DoubleClick);
            this.lbxStockInSystem.MouseLeave += new System.EventHandler(this.lbxStockInSystem_MouseLeave);
            this.lbxStockInSystem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxStockInSystem_MouseMove);
            // 
            // lblStockRecieving
            // 
            this.lblStockRecieving.AutoSize = true;
            this.lblStockRecieving.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStockRecieving.Location = new System.Drawing.Point(23, 20);
            this.lblStockRecieving.Name = "lblStockRecieving";
            this.lblStockRecieving.Size = new System.Drawing.Size(208, 32);
            this.lblStockRecieving.TabIndex = 1;
            this.lblStockRecieving.Text = "Stock receiving";
            // 
            // RestockRequestInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbpRestockRequest);
            this.Name = "RestockRequestInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxProductInformation.ResumeLayout(false);
            this.gbxProductInformation.PerformLayout();
            this.pnlAmountInWarehouse.ResumeLayout(false);
            this.pnlAmountInWarehouse.PerformLayout();
            this.pnlAmountInStore.ResumeLayout(false);
            this.pnlAmountInStore.PerformLayout();
            this.gbxStore.ResumeLayout(false);
            this.gbxStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendAmount)).EndInit();
            this.gbxSupplier.ResumeLayout(false);
            this.gbxSupplier.PerformLayout();
            this.tbcntrlProductsInWarehouse.ResumeLayout(false);
            this.tbpRestockRequests.ResumeLayout(false);
            this.tbpStockInWarehouse.ResumeLayout(false);
            this.tbpRestockRequest.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbpStockRecieving.ResumeLayout(false);
            this.tbpStockRecieving.PerformLayout();
            this.gbxRecievingStock.ResumeLayout(false);
            this.gbxRecievingStock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlStockInSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRestockRequest;
        private System.Windows.Forms.GroupBox gbxProductInformation;
        private System.Windows.Forms.ListBox lbxRestockRequests;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblStockMessage;
        private System.Windows.Forms.Panel pnlAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountInWarehouse;
        private System.Windows.Forms.Panel pnlAmountInStore;
        private System.Windows.Forms.Label lblAmountInStore;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStockInStoreLabel;
        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.GroupBox gbxStore;
        private System.Windows.Forms.Label lblSendToStore;
        private System.Windows.Forms.NumericUpDown numSendAmount;
        private System.Windows.Forms.Button btnStoreSend;
        private System.Windows.Forms.TextBox txbRequestedAmount;
        private System.Windows.Forms.Label lblSendRequestToTheSupplier;
        private System.Windows.Forms.GroupBox gbxSupplier;
        private System.Windows.Forms.Button btnSendSupplierRequest;
        private System.Windows.Forms.TabControl tbcntrlProductsInWarehouse;
        private System.Windows.Forms.TabPage tbpRestockRequests;
        private System.Windows.Forms.TabPage tbpStockInWarehouse;
        private System.Windows.Forms.ListBox lbxStockInWarehouse;
        private System.Windows.Forms.TabControl tbpRestockRequest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbpStockRecieving;
        private System.Windows.Forms.Panel pnlStockInSystem;
        private System.Windows.Forms.ListBox lbxStockInSystem;
        private System.Windows.Forms.Label lblStockRecieving;
        private System.Windows.Forms.TextBox txbFindProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecievingSBrand;
        private System.Windows.Forms.Label lblRecievingSTypeAndModel;
        private System.Windows.Forms.GroupBox gbxRecievingStock;
        private System.Windows.Forms.Button btnRecieveStock;
        private System.Windows.Forms.Label lblRecievedStock;
        private System.Windows.Forms.TextBox txbAmountOfRecievedStock;
    }
}
