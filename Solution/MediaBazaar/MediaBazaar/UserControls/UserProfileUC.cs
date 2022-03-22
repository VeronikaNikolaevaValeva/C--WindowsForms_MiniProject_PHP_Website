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
    public partial class UserInterface : UserControl
    {
        Employee employee;
        ChangePasswordForm changePasswordForm;
        public UserInterface()
        {
            InitializeComponent();
        }
        public void SendInfo(Employee employee)
        {
            this.employee = employee;
            UpdateLabel();
            PictureBoxUpdate();
        }
        private void PictureBoxUpdate()
        {
            if (employee.Gender == Gender.MALE)
            {
                pbxHRAdmin.Image = Properties.Resources.Male;
            }
            else if (employee.Gender == Gender.FEMALE)
            {
                pbxHRAdmin.Image = Properties.Resources.Female;

            }
            else if (employee.Gender == Gender.OTHER)
            {
                pbxHRAdmin.Image = Properties.Resources.Other;
            }
        }

        private void UpdateLabel()
        {
            lblHRAdminFName.Text = $"First name: {employee.FirstName}";
            lblHRAdminLName.Text = $"Last name: {employee.LastName}";
            lblHRAdminGender.Text = $"Gender: {employee.Gender}";
            lblHRAdminBirthday.Text = $"Birthday: {employee.Birthday}";
            lblHRAdminBSN.Text = $"BSN: {employee.BSN}";
            lblHRAdminEmployeeType.Text = $"Eployee type: {employee.Position}";
            lblHRAdminContractType.Text = $"Contract type: {employee.Contract}";
            lblHRAdminPhoneNum.Text = $"Phone number: {employee.PhoneNumber}";
            lblHRAdminEmail.Text = $"Email: {employee.Email}";
            lblHRAdminAddress.Text = $"Address: {employee.GetAddress}";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm = new ChangePasswordForm(employee);
            changePasswordForm.ShowDialog();

        }

    }
}
