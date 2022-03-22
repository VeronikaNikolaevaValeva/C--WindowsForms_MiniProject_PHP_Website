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
    public partial class StockManagerForm : Form
    {
        private EmployeeManager manageEmployees;
        private Employee currentEmp;

        public StockManagerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new EmployeeManager(DatabaseType.MAIN);
            this.currentEmp = currentEmp;
            userInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnStockMSchedule.BackColor = Color.SlateGray;
            btnStockMAccount.BackColor = Color.SlateGray;
            btnStockMLogOut.BackColor = Color.SlateGray;
            btnStockMAddProduct.BackColor = Color.SlateGray;
            btnViewSupplierRequests.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            addProductInterface1.Hide();
            stockWorkerScheduleInterface.Hide();
            stockManagerSupplierRequest1.Hide();
        }
        private void btnStockMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStockMSchedule_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockMSchedule.BackColor = Color.White;
            HideAllInterfaces();
            stockWorkerScheduleInterface.Show();
        }

        private void btnStockMAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockMAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void StockManagerForm_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnStockMAccount.BackColor = Color.White;
            userInterface1.Show();
        }

        private void btnStockMAddProduct_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnStockMAddProduct.BackColor = Color.White;
            addProductInterface1.Show();
        }

        private void btnViewSupplierRequests_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            HideAllInterfaces();
            btnViewSupplierRequests.BackColor = Color.White;
            stockManagerSupplierRequest1.Show();
        }
    }
}
