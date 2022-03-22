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

namespace CashierApp
{
    public partial class LoginForm : Form
    {
        EmployeeManager empManager;
        public LoginForm()
        {
            InitializeComponent();
            empManager = new EmployeeManager(DatabaseType.MAIN);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Employee currentEmp = empManager.Login(tbUserName.Text,tbPassword.Text);
            if (currentEmp == null)
            {
                MessageBox.Show("This user does not exist");
                tbPassword.Text = "";
                return;
            }
            else if (currentEmp.Position == EmployeeType.CASHIER)
            {
                //When the login information of a HR is correct
                MainForm form = new MainForm(currentEmp,this);
                this.Hide();
                form.ShowDialog();
                clearTextBoxes();
            }
            else
            {
                MessageBox.Show("You don't have access to the Cashier app");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "Tony001";
            tbPassword.Text = "0";
        }
        private void clearTextBoxes()
        {
            tbPassword.Text = "";
            tbUserName.Text = "";
        }
    }
}
