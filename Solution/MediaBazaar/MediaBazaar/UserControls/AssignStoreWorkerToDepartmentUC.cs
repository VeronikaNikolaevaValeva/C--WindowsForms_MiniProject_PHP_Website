using ProjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class AssignStoreWorkerToDepartmentUC : UserControl
    {
        private Employee employee;
        private AssignPersonDepartmentManager assignPersonDepartmentManager;
        private EmployeeManager employeeManager;
        private int departmentCode;
        //private string departmentName;
        //private Department department;
        private Department department;

        public AssignStoreWorkerToDepartmentUC()
        {
            InitializeComponent();
            this.employeeManager = new EmployeeManager(DatabaseType.MAIN);
            this.assignPersonDepartmentManager = new AssignPersonDepartmentManager(DatabaseType.MAIN);
            this.DisplayStoreWorker();
            //this.DisplayAssignStoreWorker();
        }

        public void SendInfo(Employee employee, Department department)
        {
            this.employee = employee;
            //this.department = department;
            this.departmentCode = department.Code;
            //lblDepartmentName.Text = $"Department name: {departmentName}";
            this.department = department;
            lblDepartmentName.Text = $"Department name: {department.Name}";
            this.DisplayAssignStoreWorker();
        }

        private void DisplayStoreWorker()
        {
            cbxDisplayStoreWorker.Items.Clear();
            foreach (Employee emp in this.employeeManager.GetListOFAllEmployees())
            {
                if(emp.Position == EmployeeType.STORE_WORKER)
                {
                    cbxDisplayStoreWorker.Items.Add(emp.GetEmployeeNames);
                }
            }
            //cbxDisplayStoreWorker.SelectedIndex = 0;
        }

        private void DisplayAssignStoreWorker()
        {
            lbxDisplayAssignStoreWorker.Items.Clear();
            foreach(AssignPersonDepartment dm in this.assignPersonDepartmentManager.GetStoreWorker(this.departmentCode))
            {
                lbxDisplayAssignStoreWorker.Items.Add(dm.Person.GetEmployeeNames);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbxDisplayStoreWorker.SelectedItem==null)
            {
                MessageBox.Show("Please select a store worker.");
                return;
            }
            try
            {
                foreach (Employee emp in this.employeeManager.GetListOFAllEmployees())
                {
                    if (cbxDisplayStoreWorker.SelectedItem.ToString() == emp.GetEmployeeNames)
                    {
                        this.assignPersonDepartmentManager.AssignStoreWorkerDepartment(new AssignStoreWorkerDepartment(this.department, emp));
                    }
                }

                this.DisplayAssignStoreWorker();
            }
            catch(AssignDMDepartmentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if(lbxDisplayAssignStoreWorker.SelectedItem == null)
            {
                MessageBox.Show("Please select a store worker.");
            }
            else
            {
                foreach(Employee emp in this.employeeManager.GetListOFAllEmployees())
                {
                    if(lbxDisplayAssignStoreWorker.SelectedItem.ToString() == emp.GetEmployeeNames)
                    {
                        this.assignPersonDepartmentManager.RemoveStoreWorker(emp.Id);
                    }
                }
            }
            this.DisplayAssignStoreWorker();
        }
    }
}
