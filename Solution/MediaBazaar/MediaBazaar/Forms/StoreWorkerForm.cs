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
    public partial class StoreWorkerForm : Form
    {
        private EmployeeManager manageEmployees;
        private Employee currentEmp;
        public StoreWorkerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new EmployeeManager(DatabaseType.MAIN);
            this.currentEmp = currentEmp;
            userInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnStoreWRestockRequest.BackColor = Color.SlateGray;
            btnStoreWAccount.BackColor = Color.SlateGray;
            btnStoreWLogOut.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            storeWorkerRestockRequest1.Hide();
        }

        private void btnStoreWAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreWAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void btnStoreWLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStoreWRestockRequest_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreWRestockRequest.BackColor = Color.White;
            HideAllInterfaces();
            storeWorkerRestockRequest1.Show();
        }
    }
}
