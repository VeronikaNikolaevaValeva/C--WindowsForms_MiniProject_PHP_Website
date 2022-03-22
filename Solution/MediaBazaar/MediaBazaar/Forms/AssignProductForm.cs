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
    public partial class AssignProductForm : Form
    {
        private int id;
        private string name;
        private DepartmentManager departmentManager;
        public AssignProductForm(int id, string name, DepartmentManager departmentManager)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.departmentManager = departmentManager;
            lblSubCategoryName.Text = name;
            this.Product();
            this.AssignProduct(this.id);
        }

        public void Product()
        {
            cbxProduct.Items.Clear();
            foreach (Product p in this.departmentManager.GetProducts())
            {
                cbxProduct.Items.Add(p);
            }
            cbxProduct.SelectedIndex = 0;
        }

        public void AssignProduct(int code)
        {
            lbxProduct.Items.Clear();
            foreach (var p in this.departmentManager.GetProduct(code))
            {
                lbxProduct.Items.Add(p.Key);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Product p = (Product)cbxProduct.SelectedItem;
            this.departmentManager.AssignProductDB(this.id, p.PNumber);
            this.AssignProduct(this.id);
        }
    }
}
