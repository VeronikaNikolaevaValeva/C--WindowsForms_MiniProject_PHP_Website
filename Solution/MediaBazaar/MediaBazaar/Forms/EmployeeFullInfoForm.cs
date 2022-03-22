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
    public partial class EmployeeFullInfoForm : Form
    {
        Employee currentEmp;
        ContractHistoryManager contractHistoryManager;
        public EmployeeFullInfoForm(Employee currentEmp)
        {
            InitializeComponent();
            this.currentEmp = currentEmp;
            this.contractHistoryManager = new ContractHistoryManager(currentEmp.Id, DatabaseType.MAIN);
            UpdateLables();
            UpdateContractHistory();
        }


        private void UpdateLables()
        {
            lblId.Text += $" {currentEmp.Id}";
            lblBSN.Text += $" {currentEmp.BSN}";
            lblFName.Text += $" {currentEmp.FirstName}";
            lblLName.Text += $" {currentEmp.LastName}";
            lblGender.Text += $" {currentEmp.Gender}";
            lblEmail.Text += $" {currentEmp.Email}";
            lblUName.Text += $" {currentEmp.Username}";
            lblBirthday.Text += $" {currentEmp.Birthday}";
            lblFirstWorkingDay.Text += $" {currentEmp.FirstWorkingDay}";
            lblPhoneNumber.Text += $" {currentEmp.PhoneNumber}";
            lblIban.Text += $" {currentEmp.Iban}";
            lblHourlyWage.Text += $" {currentEmp.HourlyWage}";
            lblContractType.Text += $" {currentEmp.Contract}";
            lblPosition.Text += $" {currentEmp.Position}";
            lblStreet.Text += $" {currentEmp.Street}";
            lblNumber.Text += $" {currentEmp.StreetNumber}";
            lblZipcode.Text += $" {currentEmp.Zipcode}";
            lblTown.Text += $" {currentEmp.Town}";
            lblCountry.Text += $" {currentEmp.Country}";
        }
        private void UpdateContractHistory()
        {
            lbxContractHistory.Items.Clear();
            foreach (ContractHistory contract in contractHistoryManager.ContractHistories)
            {
                lbxContractHistory.Items.Add(contract.ToString());
            }
        }
    }
}
