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
    public partial class DepartmentInterface : UserControl
    {
        private DepartmentManager deptMngr;
        private EmployeeManager empMng;
        public DepartmentInterface()
        {
            InitializeComponent();
            this.deptMngr = new DepartmentManager(DatabaseType.MAIN);
            this.empMng = new EmployeeManager(DatabaseType.MAIN);
            this.DisplayDepartments();
            this.DisplayCategory();
            this.DisplaySubCategory();
        }

        private void DisplayDepartments()//DISPLAY ON THE DEPARMENT TAB WHEN CREATING A DEPARTMENT
        {
            lbxDepartments.Items.Clear();
            foreach (Department i in this.deptMngr.GetDepartments())
            {
                lbxDepartments.Items.Add(i);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//ADD DEPARTMENT
        {
            try
            {
                this.deptMngr.AddDepartment(new Department((int)nudDepartmentCode.Value, tbxDepartmentName.Text));
                MessageBox.Show("Succesfully added");
                this.DisplayDepartments();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please fill in the name.");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("The code or the department name already exist.");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
            
            tbxDepartmentName.Clear();
            nudDepartmentCode.Value = 1000;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach(Department dept in this.deptMngr.GetDepartments())
                {
                    if(lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        this.deptMngr.DeleteDepartment(dept);
                        MessageBox.Show("Successfully deleted.");
                        this.DisplayDepartments();
                        break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach(Department dept in this.deptMngr.GetDepartments())
                {
                    if(lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        ModifyDepartment modifyDept = new ModifyDepartment(dept, deptMngr);
                        modifyDept.ShowDialog();
                        break;
                    }
                }
            }
            this.DisplayDepartments();
        }

        private void tbxSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            lbxDepartments.Items.Clear();
            foreach(Department dept in this.deptMngr.GetDepartments())
            {
                if (dept.ToString().ToLower().Contains(tbxSearchDepartment.Text))
                {
                    lbxDepartments.Items.Add(dept);
                }
            }
        }

        private void btnAssignDepartmentManager_Click(object sender, EventArgs e)
        {
            if (lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department.");
            }
            else
            {
                foreach (Department dept in this.deptMngr.GetDepartments())
                {
                    if (lbxDepartments.SelectedItem.ToString() == dept.ToString())
                    {
                        AssignDepartmentManagerToDepartment assignDepartmentManagerToDepartment = 
                            new AssignDepartmentManagerToDepartment(dept);
                        assignDepartmentManagerToDepartment.ShowDialog();
                        break;
                    }
                }
            }
            this.DisplayDepartments();
        }

        private void lbxDepartments_DoubleClick(object sender, EventArgs e)
        {
            Department d = (Department)lbxDepartments.SelectedItem;
            DepartmentDetailsForm departmentDetailsForm = new DepartmentDetailsForm(d, this.deptMngr);
            departmentDetailsForm.ShowDialog();
        }

        public void DisplayCategory()
        {
            lbxCategory.Items.Clear();
            foreach(var category in this.deptMngr.GetCategories())
            {
                lbxCategory.Items.Add(category.Value);
            }
        }

        public void DisplaySubCategory()
        {
            lbxSubCategory.Items.Clear();
            foreach(var subCategory in this.deptMngr.GetSubCategories())
            {
                lbxSubCategory.Items.Add(subCategory.Value);
            }
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            try
            {
                this.deptMngr.AddCategoryDB(tbxCName.Text);
                this.DisplayCategory();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in the name.");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This name already exist");
            }
        }

        private void btnAssignC_Click(object sender, EventArgs e)
        {
            if(lbxDepartments.SelectedItem == null)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                Department d = (Department)lbxDepartments.SelectedItem;
                AssignCategoryForm assignCategoryForm = new AssignCategoryForm(d, this.deptMngr);
                assignCategoryForm.ShowDialog();
            }
            
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if(lbxCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category");
            }
            else
            {
                string category = (string)lbxCategory.SelectedItem;
                if (this.deptMngr.DeleteCategoryByName(category))
                {
                    MessageBox.Show("successfully deleted");
                }
            }
            this.DisplayCategory();
        }

        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            try
            {
                this.deptMngr.AddSubCategoryDB(tbxSubCategoryName.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill in a name");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This name already exist");
            }
            this.DisplaySubCategory();
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e)
        {
            if(lbxSubCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a subcategory");
            }
            else
            {
                string subCategory = (string)lbxSubCategory.SelectedItem;
                if (this.deptMngr.DeleteSubCategoryByName(subCategory))
                {
                    MessageBox.Show("successfully deleted");
                }
            }
            this.DisplaySubCategory();
        }

        private void tbxSearchC_TextChanged(object sender, EventArgs e)
        {
            lbxCategory.Items.Clear();
            foreach(var category in this.deptMngr.GetCategories())
            {
                if (category.ToString().ToLower().Contains(tbxSearchC.Text))
                {
                    lbxCategory.Items.Add(category.Value);
                }
            }
        }

        private void tbxSearchSubCategory_TextChanged(object sender, EventArgs e)
        {
            lbxSubCategory.Items.Clear();
            foreach (var subCategory in this.deptMngr.GetSubCategories())
            {
                if (subCategory.ToString().ToLower().Contains(tbxSearchSubCategory.Text))
                {
                    lbxSubCategory.Items.Add(subCategory.Value);
                }
            }
        }

        private void btnAssignSubCategory_Click(object sender, EventArgs e)
        {
            if(lbxCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category");
            }
            else
            {
                foreach(var category in this.deptMngr.GetCategories())
                {
                    if(category.Value == lbxCategory.SelectedItem.ToString())
                    {
                        AssignSubCategoryForm assignSubCategoryForm = new AssignSubCategoryForm(category.Key, category.Value, this.deptMngr);
                        assignSubCategoryForm.ShowDialog();
                    }
                }
            }
        }

        private void btnAssignProduct_Click(object sender, EventArgs e)
        {
            if (lbxSubCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a subcategory");
            }
            else
            {
                foreach (var SubCategory in this.deptMngr.GetSubCategories())
                {
                    if (SubCategory.Value == lbxSubCategory.SelectedItem.ToString())
                    {
                        AssignProductForm assignProductForm = new AssignProductForm(SubCategory.Key, SubCategory.Value, this.deptMngr);
                        assignProductForm.ShowDialog();
                    }
                }
            }
        }
    }
}
