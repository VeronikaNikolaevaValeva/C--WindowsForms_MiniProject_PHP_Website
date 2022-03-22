
namespace MediaBazaar
{
    partial class AddProductInterface
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
            this.tcProducts = new System.Windows.Forms.TabControl();
            this.tpAllProducts = new System.Windows.Forms.TabPage();
            this.btnViewProductInfo = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lbxProductDisplay = new System.Windows.Forms.ListBox();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.txbSupplierEmail = new System.Windows.Forms.TextBox();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.txbSupplierPhone = new System.Windows.Forms.TextBox();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.tbxProductAmountInWarehouse = new System.Windows.Forms.TextBox();
            this.tbxProductAmountInStore = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.tbxProductSalesPrice = new System.Windows.Forms.TextBox();
            this.lblProductModel = new System.Windows.Forms.Label();
            this.tbxProductCostPrice = new System.Windows.Forms.TextBox();
            this.lblProductAmountInWarehouse = new System.Windows.Forms.Label();
            this.tbxProductModel = new System.Windows.Forms.TextBox();
            this.tbxProductType = new System.Windows.Forms.TextBox();
            this.lblProductAmountInStore = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.tbxProductBrand = new System.Windows.Forms.TextBox();
            this.lblProductSalesPrice = new System.Windows.Forms.Label();
            this.lblProductCostPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbxProductDescription = new System.Windows.Forms.TextBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.tcProducts.SuspendLayout();
            this.tpAllProducts.SuspendLayout();
            this.tpAddProduct.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcProducts
            // 
            this.tcProducts.Controls.Add(this.tpAllProducts);
            this.tcProducts.Controls.Add(this.tpAddProduct);
            this.tcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProducts.Location = new System.Drawing.Point(0, 0);
            this.tcProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcProducts.Name = "tcProducts";
            this.tcProducts.SelectedIndex = 0;
            this.tcProducts.Size = new System.Drawing.Size(1129, 785);
            this.tcProducts.TabIndex = 24;
            // 
            // tpAllProducts
            // 
            this.tpAllProducts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpAllProducts.Controls.Add(this.btnViewProductInfo);
            this.tpAllProducts.Controls.Add(this.btnDeleteProduct);
            this.tpAllProducts.Controls.Add(this.lblProduct);
            this.tpAllProducts.Controls.Add(this.lbxProductDisplay);
            this.tpAllProducts.Location = new System.Drawing.Point(4, 34);
            this.tpAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Name = "tpAllProducts";
            this.tpAllProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllProducts.Size = new System.Drawing.Size(1121, 747);
            this.tpAllProducts.TabIndex = 0;
            this.tpAllProducts.Text = "All Products";
            // 
            // btnViewProductInfo
            // 
            this.btnViewProductInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewProductInfo.Location = new System.Drawing.Point(634, 97);
            this.btnViewProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProductInfo.Name = "btnViewProductInfo";
            this.btnViewProductInfo.Size = new System.Drawing.Size(329, 78);
            this.btnViewProductInfo.TabIndex = 4;
            this.btnViewProductInfo.Text = "View a product information";
            this.btnViewProductInfo.UseVisualStyleBackColor = false;
            this.btnViewProductInfo.Click += new System.EventHandler(this.btnViewProductInfo_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(634, 215);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(329, 106);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Remove a product\r\n/Only when necessary/";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.Location = new System.Drawing.Point(6, 17);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(622, 47);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "All products in the store";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxProductDisplay
            // 
            this.lbxProductDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxProductDisplay.FormattingEnabled = true;
            this.lbxProductDisplay.HorizontalScrollbar = true;
            this.lbxProductDisplay.ItemHeight = 29;
            this.lbxProductDisplay.Location = new System.Drawing.Point(3, 67);
            this.lbxProductDisplay.Name = "lbxProductDisplay";
            this.lbxProductDisplay.ScrollAlwaysVisible = true;
            this.lbxProductDisplay.Size = new System.Drawing.Size(625, 642);
            this.lbxProductDisplay.TabIndex = 1;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpAddProduct.Controls.Add(this.gbxAddProduct);
            this.tpAddProduct.Controls.Add(this.lblTitle);
            this.tpAddProduct.Controls.Add(this.btnAddProduct);
            this.tpAddProduct.Controls.Add(this.tbxProductDescription);
            this.tpAddProduct.Controls.Add(this.lblProductDescription);
            this.tpAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpAddProduct.Location = new System.Drawing.Point(4, 34);
            this.tpAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAddProduct.Size = new System.Drawing.Size(1121, 747);
            this.tpAddProduct.TabIndex = 1;
            this.tpAddProduct.Text = "Add product";
            this.tpAddProduct.Click += new System.EventHandler(this.tpAddProduct_Click);
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.BackColor = System.Drawing.Color.White;
            this.gbxAddProduct.Controls.Add(this.txbSupplierEmail);
            this.gbxAddProduct.Controls.Add(this.lblSupplierEmail);
            this.gbxAddProduct.Controls.Add(this.txbSupplierPhone);
            this.gbxAddProduct.Controls.Add(this.lblSupplierPhone);
            this.gbxAddProduct.Controls.Add(this.tbxBarcode);
            this.gbxAddProduct.Controls.Add(this.lbBarcode);
            this.gbxAddProduct.Controls.Add(this.tbxProductAmountInWarehouse);
            this.gbxAddProduct.Controls.Add(this.tbxProductAmountInStore);
            this.gbxAddProduct.Controls.Add(this.lblProductType);
            this.gbxAddProduct.Controls.Add(this.tbxProductSalesPrice);
            this.gbxAddProduct.Controls.Add(this.lblProductModel);
            this.gbxAddProduct.Controls.Add(this.tbxProductCostPrice);
            this.gbxAddProduct.Controls.Add(this.lblProductAmountInWarehouse);
            this.gbxAddProduct.Controls.Add(this.tbxProductModel);
            this.gbxAddProduct.Controls.Add(this.tbxProductType);
            this.gbxAddProduct.Controls.Add(this.lblProductAmountInStore);
            this.gbxAddProduct.Controls.Add(this.lblProductBrand);
            this.gbxAddProduct.Controls.Add(this.tbxProductBrand);
            this.gbxAddProduct.Controls.Add(this.lblProductSalesPrice);
            this.gbxAddProduct.Controls.Add(this.lblProductCostPrice);
            this.gbxAddProduct.Location = new System.Drawing.Point(43, 97);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(1032, 330);
            this.gbxAddProduct.TabIndex = 26;
            this.gbxAddProduct.TabStop = false;
            // 
            // txbSupplierEmail
            // 
            this.txbSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSupplierEmail.Location = new System.Drawing.Point(756, 244);
            this.txbSupplierEmail.Name = "txbSupplierEmail";
            this.txbSupplierEmail.Size = new System.Drawing.Size(218, 34);
            this.txbSupplierEmail.TabIndex = 29;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierEmail.Location = new System.Drawing.Point(480, 244);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(175, 29);
            this.lblSupplierEmail.TabIndex = 28;
            this.lblSupplierEmail.Text = "Supplier email:";
            // 
            // txbSupplierPhone
            // 
            this.txbSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbSupplierPhone.Location = new System.Drawing.Point(756, 190);
            this.txbSupplierPhone.Name = "txbSupplierPhone";
            this.txbSupplierPhone.Size = new System.Drawing.Size(218, 34);
            this.txbSupplierPhone.TabIndex = 27;
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierPhone.Location = new System.Drawing.Point(479, 193);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(184, 29);
            this.lblSupplierPhone.TabIndex = 26;
            this.lblSupplierPhone.Text = "Supplier phone:";
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxBarcode.Location = new System.Drawing.Point(756, 130);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(218, 34);
            this.tbxBarcode.TabIndex = 25;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBarcode.Location = new System.Drawing.Point(479, 132);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(110, 29);
            this.lbBarcode.TabIndex = 24;
            this.lbBarcode.Text = "Barcode:";
            // 
            // tbxProductAmountInWarehouse
            // 
            this.tbxProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductAmountInWarehouse.Location = new System.Drawing.Point(756, 80);
            this.tbxProductAmountInWarehouse.Name = "tbxProductAmountInWarehouse";
            this.tbxProductAmountInWarehouse.Size = new System.Drawing.Size(218, 34);
            this.tbxProductAmountInWarehouse.TabIndex = 21;
            // 
            // tbxProductAmountInStore
            // 
            this.tbxProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductAmountInStore.Location = new System.Drawing.Point(756, 31);
            this.tbxProductAmountInStore.Name = "tbxProductAmountInStore";
            this.tbxProductAmountInStore.Size = new System.Drawing.Size(218, 34);
            this.tbxProductAmountInStore.TabIndex = 19;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductType.Location = new System.Drawing.Point(8, 36);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 29);
            this.lblProductType.TabIndex = 8;
            this.lblProductType.Text = "Type:";
            // 
            // tbxProductSalesPrice
            // 
            this.tbxProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductSalesPrice.Location = new System.Drawing.Point(204, 249);
            this.tbxProductSalesPrice.Name = "tbxProductSalesPrice";
            this.tbxProductSalesPrice.Size = new System.Drawing.Size(218, 34);
            this.tbxProductSalesPrice.TabIndex = 17;
            // 
            // lblProductModel
            // 
            this.lblProductModel.AutoSize = true;
            this.lblProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductModel.Location = new System.Drawing.Point(6, 137);
            this.lblProductModel.Name = "lblProductModel";
            this.lblProductModel.Size = new System.Drawing.Size(87, 29);
            this.lblProductModel.TabIndex = 2;
            this.lblProductModel.Text = "Model:";
            // 
            // tbxProductCostPrice
            // 
            this.tbxProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductCostPrice.Location = new System.Drawing.Point(204, 190);
            this.tbxProductCostPrice.Name = "tbxProductCostPrice";
            this.tbxProductCostPrice.Size = new System.Drawing.Size(218, 34);
            this.tbxProductCostPrice.TabIndex = 15;
            // 
            // lblProductAmountInWarehouse
            // 
            this.lblProductAmountInWarehouse.AutoSize = true;
            this.lblProductAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductAmountInWarehouse.Location = new System.Drawing.Point(480, 85);
            this.lblProductAmountInWarehouse.Name = "lblProductAmountInWarehouse";
            this.lblProductAmountInWarehouse.Size = new System.Drawing.Size(250, 29);
            this.lblProductAmountInWarehouse.TabIndex = 20;
            this.lblProductAmountInWarehouse.Text = "Amount in warehouse:";
            // 
            // tbxProductModel
            // 
            this.tbxProductModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductModel.Location = new System.Drawing.Point(204, 131);
            this.tbxProductModel.Name = "tbxProductModel";
            this.tbxProductModel.Size = new System.Drawing.Size(218, 34);
            this.tbxProductModel.TabIndex = 3;
            // 
            // tbxProductType
            // 
            this.tbxProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductType.Location = new System.Drawing.Point(204, 33);
            this.tbxProductType.Name = "tbxProductType";
            this.tbxProductType.Size = new System.Drawing.Size(218, 34);
            this.tbxProductType.TabIndex = 9;
            // 
            // lblProductAmountInStore
            // 
            this.lblProductAmountInStore.AutoSize = true;
            this.lblProductAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductAmountInStore.Location = new System.Drawing.Point(480, 34);
            this.lblProductAmountInStore.Name = "lblProductAmountInStore";
            this.lblProductAmountInStore.Size = new System.Drawing.Size(185, 29);
            this.lblProductAmountInStore.TabIndex = 18;
            this.lblProductAmountInStore.Text = "Amount in store:";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductBrand.Location = new System.Drawing.Point(6, 86);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 10;
            this.lblProductBrand.Text = "Brand:";
            // 
            // tbxProductBrand
            // 
            this.tbxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxProductBrand.Location = new System.Drawing.Point(204, 83);
            this.tbxProductBrand.Name = "tbxProductBrand";
            this.tbxProductBrand.Size = new System.Drawing.Size(218, 34);
            this.tbxProductBrand.TabIndex = 11;
            // 
            // lblProductSalesPrice
            // 
            this.lblProductSalesPrice.AutoSize = true;
            this.lblProductSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductSalesPrice.Location = new System.Drawing.Point(3, 249);
            this.lblProductSalesPrice.Name = "lblProductSalesPrice";
            this.lblProductSalesPrice.Size = new System.Drawing.Size(140, 29);
            this.lblProductSalesPrice.TabIndex = 16;
            this.lblProductSalesPrice.Text = "Sales price:";
            // 
            // lblProductCostPrice
            // 
            this.lblProductCostPrice.AutoSize = true;
            this.lblProductCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductCostPrice.Location = new System.Drawing.Point(6, 193);
            this.lblProductCostPrice.Name = "lblProductCostPrice";
            this.lblProductCostPrice.Size = new System.Drawing.Size(128, 29);
            this.lblProductCostPrice.TabIndex = 14;
            this.lblProductCostPrice.Text = "Cost price:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(50, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1025, 58);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add a product";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddProduct.Location = new System.Drawing.Point(799, 577);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(218, 48);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(70, 492);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.Size = new System.Drawing.Size(723, 133);
            this.tbxProductDescription.TabIndex = 13;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.Location = new System.Drawing.Point(65, 430);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(151, 71);
            this.lblProductDescription.TabIndex = 12;
            this.lblProductDescription.Text = "Description:";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcProducts);
            this.Name = "AddProductInterface";
            this.Size = new System.Drawing.Size(1129, 785);
            this.Load += new System.EventHandler(this.AddProductInterface_Load);
            this.tcProducts.ResumeLayout(false);
            this.tpAllProducts.ResumeLayout(false);
            this.tpAddProduct.ResumeLayout(false);
            this.tpAddProduct.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProducts;
        private System.Windows.Forms.TabPage tpAllProducts;
        private System.Windows.Forms.Button btnViewProductInfo;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListBox lbxProductDisplay;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblProductModel;
        private System.Windows.Forms.TextBox tbxProductAmountInWarehouse;
        private System.Windows.Forms.TextBox tbxProductModel;
        private System.Windows.Forms.Label lblProductAmountInWarehouse;
        private System.Windows.Forms.TextBox tbxProductAmountInStore;
        private System.Windows.Forms.Label lblProductAmountInStore;
        private System.Windows.Forms.TextBox tbxProductSalesPrice;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductSalesPrice;
        private System.Windows.Forms.TextBox tbxProductType;
        private System.Windows.Forms.TextBox tbxProductCostPrice;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductCostPrice;
        private System.Windows.Forms.TextBox tbxProductBrand;
        private System.Windows.Forms.TextBox tbxProductDescription;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.TextBox txbSupplierEmail;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.TextBox txbSupplierPhone;
        private System.Windows.Forms.Label lblSupplierPhone;
    }
}
