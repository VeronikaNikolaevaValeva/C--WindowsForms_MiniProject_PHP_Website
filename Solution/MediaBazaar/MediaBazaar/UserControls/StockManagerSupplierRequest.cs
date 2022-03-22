using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class StockManagerSupplierRequest : UserControl
    {
        private int prevIndex = -1;
        RestockRequestManager requestManager;
        public StockManagerSupplierRequest()
        {
            InitializeComponent();
            requestManager = new RestockRequestManager(DatabaseType.MAIN);
            lbxSupplierRequests.DrawMode = DrawMode.OwnerDrawFixed;
            lbxSupplierRequests.DrawItem += new DrawItemEventHandler(lbxSupplierRequests_DrawItem);
            this.UpdateListBox();
        }
        public void UpdateListBox()
        {
            btnProceedRequest.Enabled = false;
            btnDenyRequest.Enabled = false;
            gbxSupplierContact.Visible = false;
            lbxSupplierRequests.Items.Clear();
            foreach (var request in requestManager.GetAllSupplierRequests())
            {
                lbxSupplierRequests.Items.Add($"{request.Key.Type} - ({request.Key.Brand})");
            }
        }
        private void lbxSupplierRequests_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                gbxSupplierContact.Visible = false;
                foreach (var request in requestManager.GetAllSupplierRequests())
                {
                    if (lbxSupplierRequests.Items[prevIndex].ToString() == $"{request.Key.Type} - ({request.Key.Brand})")
                    {
                        lblProductTypeAndModel.Text = request.Key.Type + request.Key.Model;
                        lblProductBrand.Text = request.Key.Brand;
                        lblSupplierRequestAmount.Text = request.Value.ToString();
                        btnProceedRequest.Enabled = true;
                        btnDenyRequest.Enabled = true;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please click a stock request.");
            }
        }

        private void btnProceedRequest_Click(object sender, EventArgs e)
        {
            gbxSupplierContact.Visible = true;
            foreach (var request in requestManager.GetAllSupplierRequests())
            {
                if (lblProductTypeAndModel.Text.ToString() == request.Key.Type + request.Key.Model)
                {
                    lblSupplierPhone.Text = request.Key.SupplierPhoneNumber;
                    lblSupplierEmail.Text = request.Key.SupplierEmail;
                    rtxbEmailContent.Text = "Hello, \r\n \r\n \r\n Kind regards, \r\n Media Bazaar.";
                }
            }
        }

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            foreach (var request in requestManager.GetAllSupplierRequests())
            {
                if (lblProductTypeAndModel.Text.ToString() == request.Key.Type + request.Key.Model)
                {
                    requestManager.DeleteSupplierRequest(request.Key.PNumber);
                    lblProductTypeAndModel.Text = "Type and model";
                    lblProductBrand.Text = "Brand";
                    lblSupplierRequestAmount.Text = "00";
                }
            }
            lbxSupplierRequests.Items.Clear();
            foreach (var request in requestManager.GetAllSupplierRequests())
            {
                lbxSupplierRequests.Items.Add($"{request.Key.Type} - ({request.Key.Brand})");
            }
        }

        private void lbxSupplierRequests_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbxSupplierRequests.IndexFromPoint(lbxSupplierRequests.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                lbxSupplierRequests.Invalidate();
            }
        }

        private void lbxSupplierRequests_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            lbxSupplierRequests.Invalidate();
        }

        private void lbxSupplierRequests_DrawItem(object sender, DrawItemEventArgs e)
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
                g.DrawString(lbxSupplierRequests.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (lblSupplierEmail.Text != "Supplier email" && !String.IsNullOrEmpty(txbEmailSubject.Text) && !String.IsNullOrEmpty(rtxbEmailContent.Text))
            {
                this.SendEmailToSupplier(lblSupplierEmail.Text, txbEmailSubject.Text, rtxbEmailContent.Text);
                txbEmailSubject.Text = String.Empty;
                rtxbEmailContent.Text = String.Empty;
                MessageBox.Show("Email successfully sent!");
            }
            else { MessageBox.Show("Invalid input"); }

        }
        private void SendEmailToSupplier(string clientEmail, string emailSubject, string emailContent)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("mediabazaar.mail@gmail.com", "media@bazaar"),
                EnableSsl = true,
            };

            smtpClient.Send("mediabazaar.mail@gmail.com", $"{clientEmail}", $"{emailSubject}", $"{emailContent}");
        }
    }
}
