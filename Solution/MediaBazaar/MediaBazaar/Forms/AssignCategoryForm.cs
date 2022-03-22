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
    public partial class AssignCategoryForm : Form
    {
        private Department department;
        private DepartmentManager departmentManager;

        public AssignCategoryForm(Department department, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.department = department;
            this.departmentManager = departmentManager;
            lblDepartmentName.Text = department.Name;
            this.Category();
            this.AssignCategory(this.department.Code);
        }

        public void Category()
        {
            cbxCategory.Items.Clear();
            foreach(var category in this.departmentManager.GetCategories())
            {
                cbxCategory.Items.Add(category.Value);
            }
            cbxCategory.SelectedIndex = 0;
        }

        public void AssignCategory(int code)
        {
            lbxCategory.Items.Clear();
            foreach(string category in this.departmentManager.GetDepartmentCategorieDB(code))
            {
                lbxCategory.Items.Add(category);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string category = (string)cbxCategory.SelectedItem;
            this.departmentManager.AssignCategory(this.department.Code, category);
            this.AssignCategory(this.department.Code);
        }
    }
}
