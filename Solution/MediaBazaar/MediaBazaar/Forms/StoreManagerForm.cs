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
    public partial class StoreManagerForm : Form
    {
        private EmployeeManager manageEmployees;
        private Employee currentEmp;

        public StoreManagerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new EmployeeManager(DatabaseType.MAIN);
            this.currentEmp = currentEmp;
            userInterface1.SendInfo(currentEmp);
            HideAllInterfaces();
            userInterface1.Show();
        }
        private void PaintAllButtons()
        {
            btnStoreMEmployeeStatistic.BackColor = Color.SlateGray;
            btnStoreMStockStatistic.BackColor = Color.SlateGray;
            btnStoreM.BackColor = Color.SlateGray;
            btnDepartment.BackColor = Color.SlateGray;
            btnStoreWorkersSchedule.BackColor = Color.SlateGray;
        }
        private void HideAllInterfaces()
        {
            employeeStatistics1.Hide();
            productStatisticInterface1.Hide();
            userInterface1.Hide();
            departmentInterface1.Hide();
            storeWorkerScheduleInterface.Hide();
        }
        private void btnStoreMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnStoreMEmployeeStatistic_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreMEmployeeStatistic.BackColor = Color.White;
            HideAllInterfaces();
            employeeStatistics1.Show();
            
        }

        private void btnStoreMStockStatistic_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreMStockStatistic.BackColor = Color.White;
            HideAllInterfaces();
            productStatisticInterface1.Show();
        }

        private void btnStoreM_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreM.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void userInterface1_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreM.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartment.BackColor = Color.White;
            HideAllInterfaces();
            departmentInterface1.Show();
        }

        private void btnStoreWorkersSchedule_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnStoreWorkersSchedule.BackColor = Color.White;
            HideAllInterfaces();
            storeWorkerScheduleInterface.Show();
        }
    }
}
