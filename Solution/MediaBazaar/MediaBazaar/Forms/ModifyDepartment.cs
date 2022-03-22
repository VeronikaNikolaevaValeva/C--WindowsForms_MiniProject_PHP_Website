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
    public partial class ModifyDepartment : Form
    {
        private Department dept;
        private DepartmentManager deptMngr;

        public ModifyDepartment(Department dept, DepartmentManager deptMngr)
        {
            InitializeComponent();
            this.dept = dept;
            this.deptMngr = deptMngr;
            this.GetDeptInfo();
        }

        private void GetDeptInfo()
        {
            tbxCode.Text = this.dept.Code.ToString();
            tbxName.Text = this.dept.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbxCode.Text = this.dept.Code.ToString();
            this.dept.Name = tbxName.Text;
            this.deptMngr.UpdateDepartment(new Department(Convert.ToInt32(tbxCode.Text), this.dept.Name));
            this.Close();
        }
    }
}
