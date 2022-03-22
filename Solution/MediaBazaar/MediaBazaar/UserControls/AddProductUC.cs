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
    public partial class AddProductInterface : UserControl
    {
        ProductManager pManager;

        public AddProductInterface()
        {
            InitializeComponent();
            this.pManager = new ProductManager(DatabaseType.MAIN);
        }
        private void AddProductInterface_Load(object sender, EventArgs e)
        {
            UpdateListBoxAllProducts();
            //prepareListBox();
        }

        //private void prepareListBox()
        //{
        //    lbxProductDisplay.CustomTabOffsets.Add(100);
        //    lbxProductDisplay.UseCustomTabOffsets = true;
        //}

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (pManager.AddProductToDB(new Product(0,
                                                        tbxProductBrand.Text,
                                                        tbxProductType.Text,
                                                        tbxProductModel.Text,
                                                        tbxProductDescription.Text,
                                                        tbxBarcode.Text,
                                                        Convert.ToDecimal(tbxProductCostPrice.Text),
                                                        Convert.ToDecimal(tbxProductSalesPrice.Text),
                                                        Convert.ToInt32(tbxProductAmountInStore.Text),
                                                        Convert.ToInt32(tbxProductAmountInWarehouse.Text),
                                                        50, 
                                                        txbSupplierPhone.Text, 
                                                        txbSupplierEmail.Text)))
                {
                    MessageBox.Show("Success!");
                    UpdateListBoxAllProducts();
                }
                else
                {
                    MessageBox.Show("One of the field is too long");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill all the fields and\nfill the fields with the correct format");
            }
            catch (IncorrectPricingException)
            {
                MessageBox.Show("The sale price can not be smaller than the cost price");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("This product already exist");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }
        private void UpdateListBoxAllProducts()
        {
            lbxProductDisplay.Items.Clear();
            foreach (Product i in pManager.GetAllProducts())
            {
                lbxProductDisplay.Items.Add(i.ToString());
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lbxProductDisplay.SelectedItem == null || lbxProductDisplay.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select a product");
                return;
            }
            foreach (Product i in pManager.GetAllProducts())
            {
                if (lbxProductDisplay.SelectedItem.ToString() == i.ToString())
                {
                    if(pManager.DeleteAProduct(i.PNumber))
                    {
                        MessageBox.Show("Success");
                        UpdateListBoxAllProducts();
                        return;
                        
                    }
                    else
                    {
                        MessageBox.Show("Failed deleting");
                        UpdateListBoxAllProducts();
                        return;
                        
                    }
                }
            }
        }

        private void btnViewProductInfo_Click(object sender, EventArgs e)
        {
            if (lbxProductDisplay.SelectedItem == null || lbxProductDisplay.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select a product.");
            }
            else
            {
                foreach (Product i in pManager.GetAllProducts())
                {
                    if (lbxProductDisplay.SelectedItem.ToString() == i.ToString())
                    {
                        ProductInfoForm productInfo = new ProductInfoForm(i);
                        productInfo.Show();
                    }
                }
            }
        }

        private void tpAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
