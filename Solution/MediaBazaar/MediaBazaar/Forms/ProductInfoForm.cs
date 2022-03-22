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
    public partial class ProductInfoForm : Form
    {
        Product product;
        public ProductInfoForm(Product product)
        {
            InitializeComponent();
            this.product = product;
            this.UpdateLabel();
        }

        private void UpdateLabel()
        {
            lblProductNumber.Text += $" {product.PNumber}";
            //lblCategory.Text += $" {product.Category}";
            //lblSubCategory.Text += $" {product.Subcategory}";
            lblType.Text += $" {product.Type}";
            lblBrand.Text += $" {product.Brand}";
            lblModel.Text += $" {product.Model}";
            lblCostPrice.Text += $" {product.CostPrice}";
            lblSalesPrice.Text += $" {product.SalePrice}";
            lblAmountInStore.Text += $" {product.AmountInStore}";
            lblAmountInWarehouse.Text += $" {product.AmountInWarehouse}";
            tbxProductDescription.Text = $" {product.Description}";
        }
    }
}
