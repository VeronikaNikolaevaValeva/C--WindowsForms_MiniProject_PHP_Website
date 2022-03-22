
namespace MediaBazaar
{
    partial class ProductStatisticInterface
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.lbxDisplayPRevenueProfit = new System.Windows.Forms.ListBox();
            this.gbxProductInformation = new System.Windows.Forms.GroupBox();
            this.pnlAmountInWarehouse = new System.Windows.Forms.Panel();
            this.lblAmountOfSoldProducts = new System.Windows.Forms.Label();
            this.lblSoldProducts = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblPriceCost = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPriceSale = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpIndividualProdStats = new System.Windows.Forms.TabPage();
            this.tbpTopTenSold = new System.Windows.Forms.TabPage();
            this.cbbTypeOfStats = new System.Windows.Forms.ComboBox();
            this.lblTopTen = new System.Windows.Forms.Label();
            this.chartProductStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxProductInformation.SuspendLayout();
            this.pnlAmountInWarehouse.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpIndividualProdStats.SuspendLayout();
            this.tbpTopTenSold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatistics
            // 
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatistics.Location = new System.Drawing.Point(22, 30);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(255, 40);
            this.lblStatistics.TabIndex = 9;
            this.lblStatistics.Text = "Product Statistics";
            // 
            // lbxDisplayPRevenueProfit
            // 
            this.lbxDisplayPRevenueProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDisplayPRevenueProfit.FormattingEnabled = true;
            this.lbxDisplayPRevenueProfit.HorizontalExtent = 1000;
            this.lbxDisplayPRevenueProfit.HorizontalScrollbar = true;
            this.lbxDisplayPRevenueProfit.ItemHeight = 25;
            this.lbxDisplayPRevenueProfit.Location = new System.Drawing.Point(28, 73);
            this.lbxDisplayPRevenueProfit.Name = "lbxDisplayPRevenueProfit";
            this.lbxDisplayPRevenueProfit.ScrollAlwaysVisible = true;
            this.lbxDisplayPRevenueProfit.Size = new System.Drawing.Size(509, 479);
            this.lbxDisplayPRevenueProfit.TabIndex = 8;
            this.lbxDisplayPRevenueProfit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxDisplayPRevenueProfit_DrawItem);
            this.lbxDisplayPRevenueProfit.DoubleClick += new System.EventHandler(this.lbxDisplayPRevenueProfit_DoubleClick);
            this.lbxDisplayPRevenueProfit.MouseLeave += new System.EventHandler(this.lbxDisplayPRevenueProfit_MouseLeave);
            this.lbxDisplayPRevenueProfit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxDisplayPRevenueProfit_MouseMove);
            // 
            // gbxProductInformation
            // 
            this.gbxProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxProductInformation.Controls.Add(this.pnlAmountInWarehouse);
            this.gbxProductInformation.Controls.Add(this.lblSoldProducts);
            this.gbxProductInformation.Controls.Add(this.lblCostPrice);
            this.gbxProductInformation.Controls.Add(this.lblPriceCost);
            this.gbxProductInformation.Controls.Add(this.lblSalePrice);
            this.gbxProductInformation.Controls.Add(this.lblPriceSale);
            this.gbxProductInformation.Controls.Add(this.lblProductDescription);
            this.gbxProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProductInformation.Location = new System.Drawing.Point(562, 73);
            this.gbxProductInformation.Name = "gbxProductInformation";
            this.gbxProductInformation.Size = new System.Drawing.Size(517, 479);
            this.gbxProductInformation.TabIndex = 10;
            this.gbxProductInformation.TabStop = false;
            // 
            // pnlAmountInWarehouse
            // 
            this.pnlAmountInWarehouse.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlAmountInWarehouse.Controls.Add(this.lblAmountOfSoldProducts);
            this.pnlAmountInWarehouse.Location = new System.Drawing.Point(241, 377);
            this.pnlAmountInWarehouse.Name = "pnlAmountInWarehouse";
            this.pnlAmountInWarehouse.Size = new System.Drawing.Size(178, 63);
            this.pnlAmountInWarehouse.TabIndex = 8;
            // 
            // lblAmountOfSoldProducts
            // 
            this.lblAmountOfSoldProducts.AutoSize = true;
            this.lblAmountOfSoldProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountOfSoldProducts.Location = new System.Drawing.Point(71, 16);
            this.lblAmountOfSoldProducts.Name = "lblAmountOfSoldProducts";
            this.lblAmountOfSoldProducts.Size = new System.Drawing.Size(39, 29);
            this.lblAmountOfSoldProducts.TabIndex = 5;
            this.lblAmountOfSoldProducts.Text = "00";
            // 
            // lblSoldProducts
            // 
            this.lblSoldProducts.AutoSize = true;
            this.lblSoldProducts.Location = new System.Drawing.Point(30, 323);
            this.lblSoldProducts.Name = "lblSoldProducts";
            this.lblSoldProducts.Size = new System.Drawing.Size(253, 29);
            this.lblSoldProducts.TabIndex = 7;
            this.lblSoldProducts.Text = "Sold products in store:";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblCostPrice.Location = new System.Drawing.Point(235, 256);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(49, 32);
            this.lblCostPrice.TabIndex = 6;
            this.lblCostPrice.Text = "00";
            // 
            // lblPriceCost
            // 
            this.lblPriceCost.AutoSize = true;
            this.lblPriceCost.Location = new System.Drawing.Point(30, 256);
            this.lblPriceCost.Name = "lblPriceCost";
            this.lblPriceCost.Size = new System.Drawing.Size(128, 29);
            this.lblPriceCost.TabIndex = 5;
            this.lblPriceCost.Text = "Cost price:";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblSalePrice.Location = new System.Drawing.Point(235, 189);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(49, 32);
            this.lblSalePrice.TabIndex = 4;
            this.lblSalePrice.Text = "00";
            // 
            // lblPriceSale
            // 
            this.lblPriceSale.AutoSize = true;
            this.lblPriceSale.Location = new System.Drawing.Point(30, 192);
            this.lblPriceSale.Name = "lblPriceSale";
            this.lblPriceSale.Size = new System.Drawing.Size(134, 29);
            this.lblPriceSale.TabIndex = 3;
            this.lblPriceSale.Text = "Sale price: ";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Location = new System.Drawing.Point(30, 138);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(135, 29);
            this.lblProductDescription.TabIndex = 2;
            this.lblProductDescription.Text = "Description";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpIndividualProdStats);
            this.tabControl1.Controls.Add(this.tbpTopTenSold);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 741);
            this.tabControl1.TabIndex = 11;
            // 
            // tbpIndividualProdStats
            // 
            this.tbpIndividualProdStats.Controls.Add(this.gbxProductInformation);
            this.tbpIndividualProdStats.Controls.Add(this.lblStatistics);
            this.tbpIndividualProdStats.Controls.Add(this.lbxDisplayPRevenueProfit);
            this.tbpIndividualProdStats.Location = new System.Drawing.Point(4, 34);
            this.tbpIndividualProdStats.Name = "tbpIndividualProdStats";
            this.tbpIndividualProdStats.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIndividualProdStats.Size = new System.Drawing.Size(1110, 703);
            this.tbpIndividualProdStats.TabIndex = 0;
            this.tbpIndividualProdStats.Text = "Product statistics";
            this.tbpIndividualProdStats.UseVisualStyleBackColor = true;
            // 
            // tbpTopTenSold
            // 
            this.tbpTopTenSold.Controls.Add(this.cbbTypeOfStats);
            this.tbpTopTenSold.Controls.Add(this.lblTopTen);
            this.tbpTopTenSold.Controls.Add(this.chartProductStatistics);
            this.tbpTopTenSold.Location = new System.Drawing.Point(4, 34);
            this.tbpTopTenSold.Name = "tbpTopTenSold";
            this.tbpTopTenSold.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTopTenSold.Size = new System.Drawing.Size(1110, 703);
            this.tbpTopTenSold.TabIndex = 1;
            this.tbpTopTenSold.Text = "Top ten products";
            this.tbpTopTenSold.UseVisualStyleBackColor = true;
            // 
            // cbbTypeOfStats
            // 
            this.cbbTypeOfStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeOfStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbTypeOfStats.FormattingEnabled = true;
            this.cbbTypeOfStats.Items.AddRange(new object[] {
            "Sold products",
            "Profitable products"});
            this.cbbTypeOfStats.Location = new System.Drawing.Point(235, 43);
            this.cbbTypeOfStats.Name = "cbbTypeOfStats";
            this.cbbTypeOfStats.Size = new System.Drawing.Size(310, 33);
            this.cbbTypeOfStats.TabIndex = 2;
            this.cbbTypeOfStats.SelectedIndexChanged += new System.EventHandler(this.cbbTypeOfStats_SelectedIndexChanged);
            // 
            // lblTopTen
            // 
            this.lblTopTen.AutoSize = true;
            this.lblTopTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTopTen.Location = new System.Drawing.Point(45, 43);
            this.lblTopTen.Name = "lblTopTen";
            this.lblTopTen.Size = new System.Drawing.Size(160, 29);
            this.lblTopTen.TabIndex = 1;
            this.lblTopTen.Text = "Top ten most:";
            // 
            // chartProductStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProductStatistics.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartProductStatistics.Legends.Add(legend1);
            this.chartProductStatistics.Location = new System.Drawing.Point(27, 127);
            this.chartProductStatistics.Name = "chartProductStatistics";
            this.chartProductStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Sold products";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Profitable products";
            this.chartProductStatistics.Series.Add(series1);
            this.chartProductStatistics.Series.Add(series2);
            this.chartProductStatistics.Size = new System.Drawing.Size(1055, 537);
            this.chartProductStatistics.TabIndex = 0;
            this.chartProductStatistics.Text = "chart1";
            // 
            // ProductStatisticInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductStatisticInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxProductInformation.ResumeLayout(false);
            this.gbxProductInformation.PerformLayout();
            this.pnlAmountInWarehouse.ResumeLayout(false);
            this.pnlAmountInWarehouse.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpIndividualProdStats.ResumeLayout(false);
            this.tbpTopTenSold.ResumeLayout(false);
            this.tbpTopTenSold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.ListBox lbxDisplayPRevenueProfit;
        private System.Windows.Forms.GroupBox gbxProductInformation;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPriceSale;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblPriceCost;
        private System.Windows.Forms.Label lblSoldProducts;
        private System.Windows.Forms.Panel pnlAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountOfSoldProducts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpIndividualProdStats;
        private System.Windows.Forms.TabPage tbpTopTenSold;
        private System.Windows.Forms.ComboBox cbbTypeOfStats;
        private System.Windows.Forms.Label lblTopTen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductStatistics;
    }
}
