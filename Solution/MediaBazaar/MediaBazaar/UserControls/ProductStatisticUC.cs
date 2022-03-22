using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class ProductStatisticInterface : UserControl
    {
        ProductManager pManager;
        ProductStatisticsManager productStatsManager;
        string typeOfStats = "Sold products";
        private int prevIndex = -1;

        public ProductStatisticInterface()
        {
            InitializeComponent();
            this.pManager = new ProductManager(DatabaseType.MAIN);
            this.productStatsManager = new ProductStatisticsManager(DatabaseType.MAIN);
            UpdateListBoxAllProducts();
            lbxDisplayPRevenueProfit.DrawMode = DrawMode.OwnerDrawFixed;
            lbxDisplayPRevenueProfit.DrawItem += new DrawItemEventHandler(lbxDisplayPRevenueProfit_DrawItem);
            this.UpdateChart();
            cbbTypeOfStats.SelectedIndex = 0;
        }

        public void UpdateListBoxAllProducts()
        {
            lbxDisplayPRevenueProfit.Items.Clear();
            foreach (Product product in this.pManager.GetAllProducts())
            {
                lbxDisplayPRevenueProfit.Items.Add($"{product.Type} - {product.Model} ({product.Brand})");
            }
        }
        private void lbxDisplayPRevenueProfit_DoubleClick(object sender, EventArgs e)
        {
            foreach (Product product in this.pManager.GetAllProducts())
            {
                if (lbxDisplayPRevenueProfit.Items[prevIndex].ToString() == $"{product.Type} - {product.Model} ({product.Brand})")
                {
                    lblProductTypeAndModel.Text = $"{product.Type} - {product.Model}";
                    lblProductBrand.Text = $"{product.Brand}";
                    lblProductDescription.Text = $"{product.Description}";
                    lblSalePrice.Text = $"{product.SalePrice}";
                    lblCostPrice.Text = $"{product.CostPrice}";
                    lblAmountOfSoldProducts.Text = "00";
                    foreach (var soldProduct in pManager.GetListOfSoldProducts())
                    {
                        if (soldProduct.Key.PNumber == product.PNumber)
                        {
                            lblAmountOfSoldProducts.Text = soldProduct.Value.ToString();
                        }
                    }
                }
            }
        }
        private void lbxDisplayPRevenueProfit_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxDisplayPRevenueProfit.IndexFromPoint(lbxDisplayPRevenueProfit.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxDisplayPRevenueProfit.Invalidate();
            }
        }
        private void lbxDisplayPRevenueProfit_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxDisplayPRevenueProfit.Invalidate();
        }

        private void lbxDisplayPRevenueProfit_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.Yellow;
            }
            else
            {
                c = Color.LightBlue;
            }
            using (SolidBrush brsh = new SolidBrush(c))
            {
                g.FillRectangle(brsh, e.Bounds);
            }
            using (SolidBrush brsh = new SolidBrush(e.ForeColor))
            {
                g.DrawString(lbxDisplayPRevenueProfit.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }
        //----------------------Chart

        public void UpdateChart()
        {
            if(typeOfStats == "Sold products")
            {
                foreach(var soldProduct in productStatsManager.GetTenMostSoldProductsQuantity())
                {
                    chartProductStatistics.Series[typeOfStats].Points.AddXY($"{soldProduct.Key.Type} ({soldProduct.Key.Model})", soldProduct.Value);
                }
            }
            else if(typeOfStats == "Profitable products")
            {
                foreach (var soldProduct in productStatsManager.GetTenMostSoldProductsProfit())
                {
                    chartProductStatistics.Series[typeOfStats].Points.AddXY($"{soldProduct.Key.Type} ({soldProduct.Key.Model})", soldProduct.Value);
                }
            }
        }

        public void ClearChartStats()
        {
            chartProductStatistics.Series["Sold products"].Points.Clear();
            chartProductStatistics.Series["Profitable products"].Points.Clear();
        }

        private void cbbTypeOfStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeOfStats = cbbTypeOfStats.SelectedItem.ToString();
            this.ClearChartStats();
            this.UpdateChart();
        }
    }
}
