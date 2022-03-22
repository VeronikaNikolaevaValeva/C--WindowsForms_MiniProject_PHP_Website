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
    public partial class StockWorkerForm : Form
    {
        private EmployeeManager manageEmployees;
        private Employee currentEmp;

        public StockWorkerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new EmployeeManager(DatabaseType.MAIN);
            this.currentEmp = currentEmp;
            userInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnStockWProductData.BackColor = Color.SlateGray;
            btnStockWRestockRequest.BackColor = Color.SlateGray;
            btnStockWAccount.BackColor = Color.SlateGray;
            btnStockWLogOut.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            restockRequestInterface1.Hide();
            productData1.Hide();
        }
        private void btnStockWLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStockWProductData_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWProductData.BackColor = Color.White;
            HideAllInterfaces();
            productData1.Show();
        }

        private void btnStockWRestockRequest_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWRestockRequest.BackColor = Color.White;
            HideAllInterfaces();
            restockRequestInterface1.Show();
        }

        private void btnStockWAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void userInterface1_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStockWAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }
    }
}
