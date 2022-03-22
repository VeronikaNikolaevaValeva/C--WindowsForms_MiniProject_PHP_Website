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
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class AssignDepartmentManagerToDepartment : Form
    {
        private Department department;
        private EmployeeManager empoyeeManager;
        private AssignPersonDepartmentManager assignPersonDepartmentManager;

        public AssignDepartmentManagerToDepartment(Department department)
        {
            InitializeComponent();
            this.department = department;
            this.empoyeeManager = new EmployeeManager(DatabaseType.MAIN);
            this.assignPersonDepartmentManager = new AssignPersonDepartmentManager(DatabaseType.MAIN);
            lblDepartmentName.Text = this.department.Name;
            this.DisplayAssignDepartmentManager();
            this.DisplayDepartmentManager();
        }

        public void DisplayDepartmentManager()
        {
            cbxDepartmentManager.Items.Clear();
            foreach(Employee emp in this.empoyeeManager.GetListOFAllEmployees())
            {
                if(emp.Position == EmployeeType.DEPARTMENT_MANAGER)
                {
                    cbxDepartmentManager.Items.Add(emp.GetEmployeeNames);
                }
            }
            cbxDepartmentManager.SelectedIndex = 0;
        }

        public void DisplayAssignDepartmentManager()
        {
            lbxAssignDepartmentManager.Items.Clear();
            foreach(AssignPersonDepartment dm in this.assignPersonDepartmentManager.GetDepartmentManager(this.department.Code))
            {
                lbxAssignDepartmentManager.Items.Add($"{dm.Person.GetEmployeeNames}");
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Employee emp in this.empoyeeManager.GetListOFAllEmployees())
                {
                    if (cbxDepartmentManager.SelectedItem.ToString() == emp.GetEmployeeNames)
                    {
                        this.assignPersonDepartmentManager.AssignDeparmentManager(new AssignDepartmentManagerDepartment(department, emp));
                    }
                }
                this.DisplayAssignDepartmentManager();
            }
            catch (AssignDMDepartmentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxAssignDepartmentManager.SelectedItem == null)
                {
                    MessageBox.Show("Please select a department manager");
                }
                else
                {
                    foreach (Employee emp in this.empoyeeManager.GetListOFAllEmployees())
                    {
                        if (lbxAssignDepartmentManager.SelectedItem.ToString() == emp.GetEmployeeNames)
                        {
                            this.assignPersonDepartmentManager.RemoveDepartmentManager(emp.Id);
                        }
                    }
                }
                this.DisplayAssignDepartmentManager();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
