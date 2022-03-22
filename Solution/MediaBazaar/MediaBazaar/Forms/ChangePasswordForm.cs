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
    public partial class ChangePasswordForm : Form
    {
        Employee employee;
        EmployeeManager mngEmp;
        public ChangePasswordForm(Employee emp)
        {
            InitializeComponent();
            this.employee = emp;
            mngEmp = new EmployeeManager(DatabaseType.MAIN);
        }

        private void btnSubmitChanges_Click(object sender, EventArgs e)
        {
            string newPass = txbNewPassword.Text.ToString();
            string repeatOldPass = txbRepeatNewPassword.Text.ToString();

            if (String.IsNullOrEmpty(txbNewPassword.Text.ToString()) ||
                String.IsNullOrEmpty(txbRepeatNewPassword.Text.ToString()))
            {
                MessageBox.Show("Your input is not valid");
                return;
            }else if (newPass != repeatOldPass)
            { 
                MessageBox.Show("Your repeat password does not match your new password!");
                return;
            }
            else if (mngEmp.ChangePassword(newPass, employee.Id))
            { 
                MessageBox.Show("Password changed successfully!");
                this.Close();
            }
            else 
            { 
                MessageBox.Show("Change password failed. Please try again."); 
            }
        }
    }
}
