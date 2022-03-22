using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace CashierApp
{
    public partial class MainForm : Form
    {
        Employee currentEmp;//Last login date
        ProductManager productManager;
        DepartmentManager departmentManager;
        BasketManager basketManager;
        string barcode;
        string searchtext;
        DateTime startSesion;
        LoginForm loginForm;

        public MainForm(Employee currentEmp, LoginForm form)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.productManager = new ProductManager(DatabaseType.MAIN);
            this.basketManager = new BasketManager(DatabaseType.MAIN);
            this.departmentManager = new DepartmentManager(DatabaseType.MAIN);
            loginForm = form;
            barcode = "";
            startSesion = DateTime.Now;
            Bounds = Screen.PrimaryScreen.Bounds;
            FormBorderStyle = FormBorderStyle.None;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            productManager.UpdateProducts();
            setComboboxes();
            setListBoxes();
            searchtext = "";
            updateBasket();
            MessageBox.Show(this, "If you want to search products,\njust start typing!", "Hidden features", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        /// <summary>
        /// Scanner and search input process & Key-enter handling
        /// </summary>
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Focus();
                searchtext = "";
                searchTextChanged();
                e.Handled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            char c = (char)keyData;

            if (char.IsNumber(c))
            {
                barcode += c;
            }
            if (char.IsLetterOrDigit(c))
            {
                searchtext += c;
                searchTextChanged();
            }
            else
            {
                searchtext = "";
                AllProducts();
            }
            if (c == (char)Keys.Return)
            {

                ScanedProductToBasket(barcode);
                barcode = "";
                searchtext = "";
                lboxBasket.Focus();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ScanedProductToBasket(string barcode)
        {
            Product scannedProduct = productManager.GetProductByBarcode(barcode);
            if (scannedProduct == null)
            {
                statusBox.Image = Properties.Resources.RedBarcode;
                statusBox.Show();
                timer.Start();
                return;
            }
            else
            {
                statusBox.Image = Properties.Resources.GreenBarcode;
                statusBox.Show();
                timer.Start();
                basketManager.AddProduct(new SoldProduct(scannedProduct, 1));
                updateBasket();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            statusBox.Hide();
            timer.Stop();
        }
        private void comboBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void searchTextChanged()
        {
            cbDepartment.SelectedIndex = 0;
            lboxProducts.Items.Clear();
            lboxProducts.Items.Add($"№:\tName:");
            lboxProducts.Items.Add("");
            foreach (Product product in productManager.GetAllProducts())
            {
                if (product.ToString().ToLower().Contains(searchtext.ToLower()))
                {
                    lboxProducts.Items.Add(product.ToString());
                    lboxProducts.Items.Add("");
                }
            }
        }

        private void setListBoxes()
        {
            lboxProducts.CustomTabOffsets.Add(30);
            lboxProducts.UseCustomTabOffsets = true;
            lboxBasket.CustomTabOffsets.Add(120);
            lboxBasket.UseCustomTabOffsets = true;
        }
        private void AllProducts()
        {
            lboxProducts.Items.Clear();
            lboxProducts.Items.Add($"№:\tName:");
            lboxProducts.Items.Add("");
            foreach (Product product in productManager.GetAllProducts())
            {
                lboxProducts.Items.Add(product.ToString());
                lboxProducts.Items.Add("");
            }
        }

        private void lboxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatetbProductPrice();
        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            if (lboxProducts.SelectedItem == null || lboxProducts.SelectedItem.ToString() == "" || lboxProducts.SelectedIndex == 0)
            {
                return;
            }
            Product newProd = productManager.GetNameFromToString(lboxProducts.SelectedItem.ToString());
            if (newProd == null)
            {
                MessageBox.Show("This product can not be found in the system");
                return;
            }
            basketManager.AddProduct(new SoldProduct(newProd, Convert.ToInt32(nudProductQuantity.Value)));
            updateBasket();
        }
        private void updateBasket()
        {
            lboxBasket.Items.Clear();
            lboxBasket.Items.Add($"Quantity:         Brand:                         Type:");
            lboxBasket.Items.Add("");
            foreach (SoldProduct product in basketManager.Basket)
            {
                lboxBasket.Items.Add(product.ToString());
                lboxBasket.Items.Add("");
            }
            tbFinalPrice.Text = basketManager.GetTotalPrice().ToString();
        }

        private void nudProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            updatetbProductPrice();
        }
        private void updatetbProductPrice()
        {
            if (lboxProducts.SelectedItem == null || lboxProducts.SelectedItem.ToString() == "")
            {
                return;
            }
            tbProductPrice.Text = (productManager.GetPriceFromNames(lboxProducts.SelectedItem.ToString()) * nudProductQuantity.Value).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (rbtnCash.Checked == true)
            {
                basketManager.ExecuteOrder(currentEmp.Id, PaymentType.CASH);
            }
            else if (rbtnCard.Checked == true)
            {
                basketManager.ExecuteOrder(currentEmp.Id, PaymentType.CARD);
            }
            productManager.UpdateProducts();
            basketManager.ClearBascet();
            updateBasket();
        }


        /// <summary>
        /// Used for filtering products by Department-Category-Subcategory
        /// </summary>
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbDepartment.SelectedIndex == 0)
            {
                clearCBCategories();
                AllProducts();
            }
            else
            {
                updateCBCategories();
            }

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbCategory.SelectedIndex == 0)
            {
                clearCBSubCategories();
            }
            else
            {
                updateCBSubCategories();
            }
        }
        private void cbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchtext = "";
            if (cbSubCategory.SelectedIndex == 0)
            {
                updateProducts();
            }
            else
            {
                updateProductsBySubCategory();
            }
        }
        private void updateProducts()
        {
            if (cbCategory.SelectedIndex == 0)
            {
                if (cbDepartment.SelectedIndex != 0)
                {
                    updateProductsByDepartment();
                }
                else
                {
                    AllProducts();
                }
            }
            else
            {
                updateProductsByCategory();
            }
        }
        private void updateProductsByDepartment()
        {
            lboxProducts.Items.Clear();
            lboxProducts.Items.Add($"№:\tName:");
            lboxProducts.Items.Add("");
            foreach (Product product in productManager.GetProductsFromDepartmentDB(getDeptCode()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void updateProductsByCategory()
        {
            lboxProducts.Items.Clear();
            lboxProducts.Items.Add($"№:\tName:");
            lboxProducts.Items.Add("");
            foreach (Product product in productManager.GetProductsFromDepartmentCategoryDB(getDeptCode(),
                                                                                           cbCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void updateProductsBySubCategory()
        {
            lboxProducts.Items.Clear();
            lboxProducts.Items.Add($"№:\tName:");
            lboxProducts.Items.Add("");
            foreach (Product product in productManager.GetProductsFromSubcategoryDB(getDeptCode(),
                                                                                    cbCategory.SelectedItem.ToString(),
                                                                                    cbSubCategory.SelectedItem.ToString()))
            {
                lboxProducts.Items.Add(product);
                lboxProducts.Items.Add("");
            }
        }
        private void setCBDepartments()
        {
            foreach (Department department in departmentManager.GetDepartments())
            {
                cbDepartment.Items.Add(department.Name);
            }
        }
        private void updateCBCategories()
        {
            clearCBCategories();
            foreach (string category in departmentManager.GetDepartmentCategorieDB(getDeptCode()))
            {
                cbCategory.Items.Add(category);
            }
        }
        private void updateCBSubCategories()
        {
            clearCBSubCategories();
            foreach (string category in departmentManager.GetDepartmentSubcategories(getDeptCode(),
                                                                                     cbCategory.SelectedItem.ToString()))
            {
                cbSubCategory.Items.Add(category);
            }
        }
        private int getDeptCode()
        {
            return departmentManager.GetDepartmentCode(cbDepartment.SelectedItem.ToString());
        }
        private void clearCBDepartments()
        {
            cbDepartment.Items.Clear();
            cbDepartment.Items.Add("All");
            cbDepartment.SelectedIndex = 0;
        }
        private void clearCBCategories()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("All");
            cbCategory.SelectedIndex = 0;
        }
        private void clearCBSubCategories()
        {
            cbSubCategory.Items.Clear();
            cbSubCategory.Items.Add("All");
            cbSubCategory.SelectedIndex = 0;
        }
        private void setComboboxes()
        {
            clearCBDepartments();
            clearCBCategories();
            clearCBSubCategories();
            setCBDepartments();
        }


        /// <summary>
        /// Used for remove actions for Basket listbox
        /// </summary>
        private void btnRemovePiece_Click(object sender, EventArgs e)
        {
            if (lboxBasket.SelectedItem == null|| lboxBasket.SelectedItem.ToString()=="" || lboxBasket.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string barcode = basketManager.GetProductBarcode(strProduct: lboxBasket.SelectedItem.ToString());
            if (barcode == null)
            {
                MessageBox.Show("This product can not be found in the system.\n Restart the application");
                return;
            }
            basketManager.RemovePiece(barcode);
            updateBasket();
        }
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lboxBasket.SelectedItem == null || lboxBasket.SelectedItem.ToString() == ""||lboxBasket.SelectedIndex==0)
            {
                MessageBox.Show("Please select a product");
                return;
            }
            string barcode = basketManager.GetProductBarcode(strProduct: lboxBasket.SelectedItem.ToString());
            if (barcode == null)
            {
                MessageBox.Show("This product can not be found in the system\n Restart the application");
                return;
            }
            basketManager.RemoveProduct(barcode);
            updateBasket();
        }
        private void btnClearBascet_Click(object sender, EventArgs e)
        {
            basketManager.ClearBascet();
            updateBasket();
        }


        /// <summary>
        /// Actions to logout
        /// </summary>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            closeSesion();
            this.Hide();
            loginForm.Show();
            this.Close();
        }
        private void closeSesion()
        {
            Stack<string> sesionInfo = basketManager.GetSesionInfoDB(startSesion, currentEmp.Id);
            if (sesionInfo == null)
            {
                MessageBox.Show("There is a problem with the database, contact the tehnical team", "Employee sesion info");
                return;
            }
            string totalAmount = sesionInfo.Pop();
            string numberProducts = sesionInfo.Pop();
            string numberOrders = sesionInfo.Pop();
            MessageBox.Show($"Number of orders:{numberOrders}\nTotal products:  {numberProducts}\nTotal amount:  {totalAmount}", $"Employee sesion info");
        }

    }
}