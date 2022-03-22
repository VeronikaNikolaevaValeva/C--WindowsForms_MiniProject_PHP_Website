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
    public partial class AssignSubCategoryForm : Form
    {
        private int id;
        private string name;
        private DepartmentManager departmentManager;

        public AssignSubCategoryForm(int id, string name, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.departmentManager = departmentManager;
            lblCategoryName.Text = this.name;
            this.Subcategory();
            this.AssignSubCategory(this.id);
        }

        public void Subcategory()
        {
            cbxSubCategory.Items.Clear();
            foreach (var subCategory in this.departmentManager.GetSubCategories())
            {
                cbxSubCategory.Items.Add(subCategory.Value);
            }
            cbxSubCategory.SelectedIndex = 0;
        }

        public void AssignSubCategory(int code)
        {
            lbxSubCategory.Items.Clear();
            foreach (string category in this.departmentManager.GetSubCategory(code))
            {
                lbxSubCategory.Items.Add(category);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string subCategory = (string)cbxSubCategory.SelectedItem;
            this.departmentManager.AssignSubcategoryDB(this.id, subCategory);
            this.AssignSubCategory(this.id);
        }
    }
}
