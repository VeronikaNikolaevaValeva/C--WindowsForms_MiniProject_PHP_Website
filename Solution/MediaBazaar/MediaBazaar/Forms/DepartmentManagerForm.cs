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
    public partial class DepartmentManagerForm : Form
    {
        private Employee currentEmp;
        private AssignPersonDepartmentManager assignPersonDepartmentManager;

        public DepartmentManagerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.assignPersonDepartmentManager = new AssignPersonDepartmentManager(DatabaseType.MAIN);
            userInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnDepartmentMAccount.BackColor = Color.SlateGray;
            btnDepartmentMSchedule.BackColor = Color.SlateGray;
            btnDepartmentMLogOut.BackColor = Color.SlateGray;
            btnDepartment.BackColor = Color.SlateGray;
            btnHolidayRequests.BackColor = Color.SlateGray;
            btnDepartmentStatistics.BackColor = Color.SlateGray;
        }
        private void btnDepartmentMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            storeWorkerScheduleInterface.Hide();
            holidayRequestsUC.Hide();
            assignStoreWorkerToDepartmentUC1.Hide();
            unAssignDepartmentManagerUC1.Hide();
            departmentManagerEmployeeStatistics1.Hide();
        }
        private void btnDepartmentMSchedule_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMSchedule.BackColor = Color.White;
            HideAllInterfaces();
            storeWorkerScheduleInterface.Visible = true;
            storeWorkerScheduleInterface.BringToFront();

        }

        private void btnDepartmentMAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void userInterface1_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartment.BackColor = Color.White;
            HideAllInterfaces();

            if (this.assignPersonDepartmentManager.CheckIfDepartmentManagerExist(this.currentEmp.Id))
            {
                assignStoreWorkerToDepartmentUC1.SendInfo(this.currentEmp,
                    this.assignPersonDepartmentManager.GetAssignDepartment(currentEmp.Id));
                assignStoreWorkerToDepartmentUC1.Show();
            }
            else
            {
                HideAllInterfaces();
                unAssignDepartmentManagerUC1.Show();
            }
        }

        private void btnHolidayRequests_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnHolidayRequests.BackColor = Color.White;
            HideAllInterfaces();
            holidayRequestsUC.Visible = true;
            holidayRequestsUC.BringToFront();
        }

        private void btnDepartmentStatistics_Click(object sender, EventArgs e)
        {
            
            PaintAllButtons();
            btnDepartmentStatistics.BackColor = Color.White;
            HideAllInterfaces();
            departmentManagerEmployeeStatistics1.SetDepartmentCode(assignPersonDepartmentManager.GetAssignDepartment(currentEmp.Id).Code.ToString());
            departmentManagerEmployeeStatistics1.Visible = true;
            departmentManagerEmployeeStatistics1.BringToFront();
        }
    }
}
