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
    public partial class ProductData : UserControl
    {
        ProductManager pManager;

        public ProductData()
        {
            InitializeComponent();
            this.pManager = new ProductManager(DatabaseType.MAIN);
            UpdateListBoxProducts();
        }

        private void UpdateListBoxProducts()
        {
            lbxProductDisplay.Items.Clear();
            foreach (Product i in pManager.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
            }
        }

        private void btnViewPInfo_Click(object sender, EventArgs e)
        {
            if(lbxProductDisplay.SelectedItem == null || lbxProductDisplay.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select a product.");
            }
            else
            {
                foreach(Product i in pManager.GetAllProducts())
                {
                    if(lbxProductDisplay.SelectedItem.ToString() == i.ToString())
                    {
                        ProductInfoForm productInfo = new ProductInfoForm(i);
                        productInfo.Show();
                    }
                }
            }
        }
    }
}
