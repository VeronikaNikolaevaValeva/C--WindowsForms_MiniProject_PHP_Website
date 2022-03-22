
namespace MediaBazaar
{
    partial class ProductInfoForm
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
            this.tbxProductDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategorization = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCategorization = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubCategory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlProductName = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAmountInWarehouse = new System.Windows.Forms.Label();
            this.lblAmountInStore = new System.Windows.Forms.Label();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.pnlCategorization.SuspendLayout();
            this.pnlProductName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxProductDescription
            // 
            this.tbxProductDescription.Location = new System.Drawing.Point(23, 282);
            this.tbxProductDescription.Multiline = true;
            this.tbxProductDescription.Name = "tbxProductDescription";
            this.tbxProductDescription.ReadOnly = true;
            this.tbxProductDescription.Size = new System.Drawing.Size(969, 123);
            this.tbxProductDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 238);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(969, 41);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategorization
            // 
            this.lblCategorization.AutoSize = true;
            this.lblCategorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorization.Location = new System.Drawing.Point(18, 74);
            this.lblCategorization.Name = "lblCategorization";
            this.lblCategorization.Size = new System.Drawing.Size(144, 25);
            this.lblCategorization.TabIndex = 16;
            this.lblCategorization.Text = "Categorization:";
            this.lblCategorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(992, 43);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Product information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCategorization
            // 
            this.pnlCategorization.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCategorization.Controls.Add(this.lblSubCategory);
            this.pnlCategorization.Controls.Add(this.lblType);
            this.pnlCategorization.Controls.Add(this.lblCategory);
            this.pnlCategorization.Location = new System.Drawing.Point(23, 102);
            this.pnlCategorization.Name = "pnlCategorization";
            this.pnlCategorization.Size = new System.Drawing.Size(217, 133);
            this.pnlCategorization.TabIndex = 18;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 17);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // lblSubCategory
            // 
            this.lblSubCategory.AutoSize = true;
            this.lblSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategory.Location = new System.Drawing.Point(12, 53);
            this.lblSubCategory.Name = "lblSubCategory";
            this.lblSubCategory.Size = new System.Drawing.Size(99, 18);
            this.lblSubCategory.TabIndex = 9;
            this.lblSubCategory.Text = "Sub category:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 89);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Type:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(261, 74);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(139, 25);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product name:";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProductName
            // 
            this.pnlProductName.BackColor = System.Drawing.SystemColors.Window;
            this.pnlProductName.Controls.Add(this.lblProductNumber);
            this.pnlProductName.Controls.Add(this.lblModel);
            this.pnlProductName.Controls.Add(this.lblBrand);
            this.pnlProductName.Location = new System.Drawing.Point(266, 102);
            this.pnlProductName.Name = "pnlProductName";
            this.pnlProductName.Size = new System.Drawing.Size(254, 133);
            this.pnlProductName.TabIndex = 19;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(14, 53);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(51, 18);
            this.lblBrand.TabIndex = 11;
            this.lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(14, 89);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 18);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Model:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblSalesPrice);
            this.panel1.Controls.Add(this.lblCostPrice);
            this.panel1.Location = new System.Drawing.Point(548, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 133);
            this.panel1.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(543, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPrice.Location = new System.Drawing.Point(13, 53);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(85, 18);
            this.lblSalesPrice.TabIndex = 18;
            this.lblSalesPrice.Text = "Sales price:";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostPrice.Location = new System.Drawing.Point(13, 17);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(80, 18);
            this.lblCostPrice.TabIndex = 17;
            this.lblCostPrice.Text = "Cost price:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(760, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 25);
            this.lblAmount.TabIndex = 23;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lblAmountInWarehouse);
            this.panel2.Controls.Add(this.lblAmountInStore);
            this.panel2.Location = new System.Drawing.Point(765, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 133);
            this.panel2.TabIndex = 22;
            // 
            // lblAmountInWarehouse
            // 
            this.lblAmountInWarehouse.AutoSize = true;
            this.lblAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInWarehouse.Location = new System.Drawing.Point(12, 53);
            this.lblAmountInWarehouse.Name = "lblAmountInWarehouse";
            this.lblAmountInWarehouse.Size = new System.Drawing.Size(155, 18);
            this.lblAmountInWarehouse.TabIndex = 22;
            this.lblAmountInWarehouse.Text = "Amount in warehouse:";
            // 
            // lblAmountInStore
            // 
            this.lblAmountInStore.AutoSize = true;
            this.lblAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInStore.Location = new System.Drawing.Point(12, 17);
            this.lblAmountInStore.Name = "lblAmountInStore";
            this.lblAmountInStore.Size = new System.Drawing.Size(116, 18);
            this.lblAmountInStore.TabIndex = 21;
            this.lblAmountInStore.Text = "Amount in store:";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNumber.Location = new System.Drawing.Point(14, 17);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(118, 18);
            this.lblProductNumber.TabIndex = 13;
            this.lblProductNumber.Text = "Product number:";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1016, 418);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlCategorization);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCategorization);
            this.Controls.Add(this.tbxProductDescription);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.pnlCategorization.ResumeLayout(false);
            this.pnlCategorization.PerformLayout();
            this.pnlProductName.ResumeLayout(false);
            this.pnlProductName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxProductDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategorization;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCategorization;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubCategory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlProductName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountInStore;
        private System.Windows.Forms.Label lblProductNumber;
    }
}