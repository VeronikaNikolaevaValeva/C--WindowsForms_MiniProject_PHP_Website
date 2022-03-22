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
    public partial class EditEmployeeForm : Form
    {
        Employee currentEmp;
        EmployeeManager employeeManager;
        public EditEmployeeForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            employeeManager = new EmployeeManager(DatabaseType.MAIN);
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            tboxFName.Text = currentEmp.FirstName;
            tboxLName.Text = currentEmp.LastName;
            cbxGender.SelectedIndex = Convert.ToInt32(currentEmp.Gender);
            tboxEmail.Text = currentEmp.Email;
            dtpDateOfBirth.Value = Convert.ToDateTime(currentEmp.Birthday);
            tboxPhoneNumber.Text = currentEmp.PhoneNumber;
            tboxIban.Text = currentEmp.Iban;
            tboxStreet.Text = currentEmp.Street;
            tboxStreetNumber.Text = currentEmp.StreetNumber;
            tboxZipcode.Text = currentEmp.Zipcode;
            tboxTown.Text = currentEmp.Town;
            tboxCountry.Text = currentEmp.Country;
            tboxUsername.Text = currentEmp.Username;
            tboxHourlyWage.Text = currentEmp.HourlyWage.ToString();
            cbxContractType.SelectedIndex = Convert.ToInt32(currentEmp.Contract);
            cbxTypeOfEmployee.SelectedIndex = Convert.ToInt32(currentEmp.Position);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee empNewInfo = new Employee(currentEmp.Id, currentEmp.BSN, tboxFName.Text, tboxLName.Text, (Gender)cbxGender.SelectedIndex,
                                                  tboxEmail.Text, tboxUsername.Text, dtpDateOfBirth.Value, tboxStreet.Text, tboxStreetNumber.Text, 
                                                  tboxZipcode.Text, tboxTown.Text, tboxCountry.Text,Convert.ToDateTime(currentEmp.FirstWorkingDay), tboxPhoneNumber.Text, tboxIban.Text,
                                                  Convert.ToDouble(tboxHourlyWage.Text),Convert.ToDateTime(currentEmp.ContractStartDate),
                                                  (ContractType)cbxContractType.SelectedIndex, (EmployeeType)cbxTypeOfEmployee.SelectedIndex);

                if (employeeManager.UpdateEmployeeInfoDB(empNewInfo))
                {
                    MessageBox.Show("Success");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("The user is not edited, double check your input information");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
        }
    }
}
