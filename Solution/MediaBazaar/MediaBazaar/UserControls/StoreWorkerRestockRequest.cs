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
    public partial class StoreWorkerRestockRequest : UserControl
    {
        private int prevIndex = -1;
        RestockRequestManager requestManager;
        public StoreWorkerRestockRequest()
        {
            InitializeComponent();
            requestManager = new RestockRequestManager(DatabaseType.MAIN);
            lbxProductsBelowMinimum.DrawMode = DrawMode.OwnerDrawFixed;
            lbxProductsBelowMinimum.DrawItem += new DrawItemEventHandler(lbxCreateRestockRequests_DrawItem);
            lbxProductsAboveMinimum.DrawMode = DrawMode.OwnerDrawFixed;
            lbxProductsAboveMinimum.DrawItem += new DrawItemEventHandler(lbxProductsAboveMinimum_DrawItem);
            this.UpdateProductListBox();
        }

        public void UpdateProductListBox()
        {
            lbxProductsBelowMinimum.Items.Clear();
            lbxProductsAboveMinimum.Items.Clear();
            foreach (Product product in requestManager.GetListOfAllProducts())
            {
                if (product.AmountInStore < 50)
                {
                    lbxProductsBelowMinimum.Items.Add($"{product.Type} ({product.Model})");
                }
                else if (product.AmountInStore >= 50)
                {
                    lbxProductsAboveMinimum.Items.Add($"{product.Type} ({product.Model})");
                }
            }
        }

        private void lbxCreateRestockRequests_DoubleClick(object sender, EventArgs e)
        {
            gbxSendRestockRequest.Enabled = true;
            lblSendToStore.Text = "Send restock \r\nrequest: ";
            foreach (Product product in requestManager.GetListOfAllProducts())
            {
                if ((lbxProductsBelowMinimum.Items[prevIndex].ToString() == $"{product.Type} ({product.Model})") && product.AmountInStore < 50)
                {
                    foreach (var requestedProduct in requestManager.GetAllRequestedProducts())
                    {
                        if (requestedProduct.Key.PNumber == product.PNumber)
                        {
                            gbxSendRestockRequest.Enabled = false;
                            lblSendToStore.Text = "Request already \r\nsent";
                        }
                    }
                    lblProductBrand.Text = $"{product.Brand}";
                    lblProductTypeAndModel.Text = $"{product.Type} ({product.Model})";
                    lblAmountInStore.Text = $"{product.AmountInStore}";
                    pnlMinimumStock.BackColor = Color.OrangeRed;
                    txbMinimumAmountInStore.Text = $"{product.MinimumAmountInStore}";
                }
            }
        }
        private void lbxProductsAboveMinimum_DoubleClick(object sender, EventArgs e)
        {
            gbxSendRestockRequest.Enabled = true;
            lblSendToStore.Text = "Send restock \r\nrequest: ";
            foreach (Product product in requestManager.GetListOfAllProducts())
            {
                if ((lbxProductsAboveMinimum.Items[prevIndex].ToString() == $"{product.Type} ({product.Model})") && product.AmountInStore >= 50)
                {
                    foreach (var requestedProduct in requestManager.GetAllRequestedProducts())
                    {
                        if (requestedProduct.Key.PNumber == product.PNumber)
                        {
                            gbxSendRestockRequest.Enabled = false;
                            lblSendToStore.Text = "Request already \r\nsent";
                        }
                    }
                    lblProductBrand.Text = $"{product.Brand}";
                    lblProductTypeAndModel.Text = $"{product.Type} ({product.Model})";
                    lblAmountInStore.Text = $"{product.AmountInStore}";
                    pnlMinimumStock.BackColor = Color.YellowGreen;
                }
            }
        }
        private void btnStoreSend_Click(object sender, EventArgs e)
        {
            if (txbRestockRequesrtAmount.Text.ToString() == String.Empty)
            {
                MessageBox.Show("Invalid quantity input. Restock request not sent.");
            }
            else
            {
                foreach (Product product in requestManager.GetListOfAllProducts())
                {
                    if ((lblProductTypeAndModel.Text == $"{product.Type} ({product.Model})") && (lblProductBrand.Text == $"{product.Brand}"))
                    {
                        requestManager.CreateCreateStockRequest(product.PNumber, Convert.ToInt32(txbRestockRequesrtAmount.Text));
                        gbxSendRestockRequest.Enabled = false;
                        lblSendToStore.Text = "Request already \r\nsent";
                        txbRestockRequesrtAmount.Text = String.Empty;
                    }
                }
            }
        }
        private void lbxCreateRestockRequests_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxProductsBelowMinimum.IndexFromPoint(lbxProductsBelowMinimum.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxProductsBelowMinimum.Invalidate();
            }
        }

        private void lbxCreateRestockRequests_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxProductsBelowMinimum.Invalidate();
        }

        private void lbxCreateRestockRequests_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.GreenYellow;
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
                g.DrawString(lbxProductsBelowMinimum.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        private void lbxProductsAboveMinimum_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxProductsAboveMinimum.IndexFromPoint(lbxProductsAboveMinimum.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxProductsAboveMinimum.Invalidate();
            }
        }

        private void lbxProductsAboveMinimum_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxProductsAboveMinimum.Invalidate();
        }

        private void lbxProductsAboveMinimum_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.GreenYellow;
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
                g.DrawString(lbxProductsAboveMinimum.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        private void btnAdjustMinStock_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbMinimumAmountInStore.Text))
            {
                foreach (Product product in requestManager.GetListOfAllProducts())
                {
                    if ((lblProductTypeAndModel.Text == $"{product.Type} ({product.Model})") && (lblProductBrand.Text == $"{product.Brand}"))
                    {
                        requestManager.UpdateMinimumAmountOfStockInStore(product.PNumber, Convert.ToInt32(txbMinimumAmountInStore.Text));
                    }
                }
            }

        }
    }
}
