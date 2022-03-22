
namespace MediaBazaar
{
    partial class StockManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewSupplierRequests = new System.Windows.Forms.Button();
            this.btnStockMAddProduct = new System.Windows.Forms.Button();
            this.btnStockMSchedule = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStockMLogOut = new System.Windows.Forms.Button();
            this.btnStockMAccount = new System.Windows.Forms.Button();
            this.stockWorkerScheduleInterface = new MediaBazaar.StockWorkerScheduleInterface();
            this.stockManagerSupplierRequest1 = new MediaBazaar.StockManagerSupplierRequest();
            this.addProductInterface1 = new MediaBazaar.AddProductInterface();
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewSupplierRequests);
            this.panel1.Controls.Add(this.btnStockMAddProduct);
            this.panel1.Controls.Add(this.btnStockMSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 785);
            this.panel1.TabIndex = 43;
            // 
            // btnViewSupplierRequests
            // 
            this.btnViewSupplierRequests.BackColor = System.Drawing.Color.SlateGray;
            this.btnViewSupplierRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSupplierRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSupplierRequests.Location = new System.Drawing.Point(21, 310);
            this.btnViewSupplierRequests.Name = "btnViewSupplierRequests";
            this.btnViewSupplierRequests.Size = new System.Drawing.Size(155, 59);
            this.btnViewSupplierRequests.TabIndex = 5;
            this.btnViewSupplierRequests.Text = "Supplier requests";
            this.btnViewSupplierRequests.UseVisualStyleBackColor = false;
            this.btnViewSupplierRequests.Click += new System.EventHandler(this.btnViewSupplierRequests_Click);
            // 
            // btnStockMAddProduct
            // 
            this.btnStockMAddProduct.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockMAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMAddProduct.Location = new System.Drawing.Point(21, 235);
            this.btnStockMAddProduct.Name = "btnStockMAddProduct";
            this.btnStockMAddProduct.Size = new System.Drawing.Size(155, 59);
            this.btnStockMAddProduct.TabIndex = 4;
            this.btnStockMAddProduct.Text = "Product";
            this.btnStockMAddProduct.UseVisualStyleBackColor = false;
            this.btnStockMAddProduct.Click += new System.EventHandler(this.btnStockMAddProduct_Click);
            // 
            // btnStockMSchedule
            // 
            this.btnStockMSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockMSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMSchedule.Location = new System.Drawing.Point(21, 159);
            this.btnStockMSchedule.Name = "btnStockMSchedule";
            this.btnStockMSchedule.Size = new System.Drawing.Size(155, 59);
            this.btnStockMSchedule.TabIndex = 3;
            this.btnStockMSchedule.Text = "Schedule";
            this.btnStockMSchedule.UseVisualStyleBackColor = false;
            this.btnStockMSchedule.Click += new System.EventHandler(this.btnStockMSchedule_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(20, 11);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(156, 142);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStockMLogOut);
            this.panel2.Controls.Add(this.btnStockMAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 399);
            this.panel2.TabIndex = 0;
            // 
            // btnStockMLogOut
            // 
            this.btnStockMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMLogOut.Location = new System.Drawing.Point(20, 252);
            this.btnStockMLogOut.Name = "btnStockMLogOut";
            this.btnStockMLogOut.Size = new System.Drawing.Size(155, 59);
            this.btnStockMLogOut.TabIndex = 3;
            this.btnStockMLogOut.Text = "Log out";
            this.btnStockMLogOut.UseVisualStyleBackColor = false;
            this.btnStockMLogOut.Click += new System.EventHandler(this.btnStockMLogOut_Click);
            // 
            // btnStockMAccount
            // 
            this.btnStockMAccount.BackColor = System.Drawing.Color.White;
            this.btnStockMAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMAccount.Location = new System.Drawing.Point(20, 81);
            this.btnStockMAccount.Name = "btnStockMAccount";
            this.btnStockMAccount.Size = new System.Drawing.Size(155, 59);
            this.btnStockMAccount.TabIndex = 2;
            this.btnStockMAccount.Text = "My account";
            this.btnStockMAccount.UseVisualStyleBackColor = false;
            this.btnStockMAccount.Click += new System.EventHandler(this.btnStockMAccount_Click);
            // 
            // stockWorkerScheduleInterface
            // 
            this.stockWorkerScheduleInterface.Location = new System.Drawing.Point(213, 0);
            this.stockWorkerScheduleInterface.Name = "stockWorkerScheduleInterface";
            this.stockWorkerScheduleInterface.Size = new System.Drawing.Size(1129, 812);
            this.stockWorkerScheduleInterface.TabIndex = 52;
            this.stockWorkerScheduleInterface.Visible = false;
            // 
            // stockManagerSupplierRequest1
            // 
            this.stockManagerSupplierRequest1.Location = new System.Drawing.Point(213, 0);
            this.stockManagerSupplierRequest1.Name = "stockManagerSupplierRequest1";
            this.stockManagerSupplierRequest1.Size = new System.Drawing.Size(1129, 785);
            this.stockManagerSupplierRequest1.TabIndex = 51;
            // 
            // addProductInterface1
            // 
            this.addProductInterface1.Location = new System.Drawing.Point(212, 1);
            this.addProductInterface1.Name = "addProductInterface1";
            this.addProductInterface1.Size = new System.Drawing.Size(1129, 785);
            this.addProductInterface1.TabIndex = 49;
            this.addProductInterface1.Visible = false;
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(213, 1);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(1129, 785);
            this.userInterface1.TabIndex = 50;
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1340, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userInterface1);
            this.Controls.Add(this.stockWorkerScheduleInterface);
            this.Controls.Add(this.stockManagerSupplierRequest1);
            this.Controls.Add(this.addProductInterface1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagerForm";
            this.Load += new System.EventHandler(this.StockManagerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockMSchedule;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStockMLogOut;
        private System.Windows.Forms.Button btnStockMAccount;
        private System.Windows.Forms.Button btnStockMAddProduct;
        private AddProductInterface addProductInterface1;
        private UserInterface userInterface1;
        private System.Windows.Forms.Button btnViewSupplierRequests;
        private StockManagerSupplierRequest stockManagerSupplierRequest1;
        private StockWorkerScheduleInterface stockWorkerScheduleInterface;
    }
}