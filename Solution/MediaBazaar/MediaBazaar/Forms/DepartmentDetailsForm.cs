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
    public partial class DepartmentDetailsForm : Form
    {
        private Department department;
        private DepartmentManager departmentManager;

        public DepartmentDetailsForm(Department department, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.department = department;
            lblDepartmentName.Text = this.department.Name;
            this.departmentManager = departmentManager;
            this.DiplayDepartmentManager(department.Code);
            this.DisplayStoreWorker(department.Code);
        }

        public void DiplayDepartmentManager(int code)
        {
            lbxDepartmentManager.Items.Clear();
            foreach(Employee emp in this.departmentManager.GetDepartmentManagersDB(code))
            {
                lbxDepartmentManager.Items.Add(emp.GetEmployeeNames);
            }
        }

        public void DisplayStoreWorker(int code)
        {
            lbxStoreWorker.Items.Clear();
            foreach(Employee emp in this.departmentManager.GetStoreWorkerDB(code))
            {
                lbxStoreWorker.Items.Add(emp.GetEmployeeNames);
            }
        }
    }
}
