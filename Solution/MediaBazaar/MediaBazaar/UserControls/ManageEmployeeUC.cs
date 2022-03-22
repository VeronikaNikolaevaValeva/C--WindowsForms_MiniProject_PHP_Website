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
    public partial class ManageEmployeeInterface : UserControl
    {
        EmployeeManager manageEmployees;
        ChangeEmployeeWorkingContractForm changeContractForm;
        EmployeeFullInfoForm employeeFullInfoForm;
        EditEmployeeForm EditEmployeeForm;
        public ManageEmployeeInterface()
        {
            InitializeComponent();
            manageEmployees = new EmployeeManager(DatabaseType.MAIN);
        }


        private void ManageEmployeeInterface_Load(object sender, EventArgs e)
        {
            manageEmployees.UpdateEmployees();
            UpdateListBoxEmployee();
            SetComboBoxes();
            rbtnAllEmployees.Checked = true;
        }
        private void UpdateListBoxAllEmployees()
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                lbxViewEmployees.Items.Add(emp.ToString());
                lbxViewEmployees.Items.Add("");
            }
        }
        private void UpdateListBoxActiveEmployees()
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                if (emp.Contract != ContractType.LEFT)
                {
                    lbxViewEmployees.Items.Add(emp.ToString());
                    lbxViewEmployees.Items.Add("");
                }
            }
            if (lbxViewEmployees.Items.Count < 0)
            {
                lbxViewEmployees.Items.Add("There is no active Employees");
            }
        }
        private void UpdateListBoxFiredEmployees()
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                if (emp.Contract == ContractType.LEFT)
                {
                    lbxViewEmployees.Items.Add(emp.ToString());
                    lbxViewEmployees.Items.Add("");
                }
            }
            if (lbxViewEmployees.Items.Count < 0)
            {

                lbxViewEmployees.Items.Add("There is no fired Employees");
            }
        }
        private void SetComboBoxes()
        {
            cbxContractType.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
            cbxTypeOfEmployee.SelectedIndex = 0;
        }
        private void UpdateListBoxEmployee()
        {
            lbxDisplayEMployees.CustomTabOffsets.Add(100);
            lbxDisplayEMployees.UseCustomTabOffsets = true;


            lbxDisplayEMployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                lbxDisplayEMployees.Items.Add(emp.GetInfo);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (lbxDisplayEMployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
                if (emp.GetInfo == lbxDisplayEMployees.SelectedItem.ToString())
                {
                    changeContractForm = new ChangeEmployeeWorkingContractForm(emp);
                    changeContractForm.ShowDialog();
                    manageEmployees.UpdateEmployees();
                    UpdateListBoxEmployee();
                    rbtnAllEmployees.Checked = true;
                    return;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmp = new Employee(0, tbxBSN.Text.ToString(),
                                                tbxFName.Text.ToString(),
                                                tbxLName.Text.ToString(),
                                                ((Gender)cbxGender.SelectedIndex),
                                                tbxEmail.Text.ToString(),
                                                tbxUsername.Text.ToString(),
                                                dtpDateOfBirth.Value,
                                                tbxStreet.Text.ToString(),
                                                tbxHouseNumber.Text.ToString(),
                                                tbxZipCode.Text.ToString(),
                                                tbxTown.Text.ToString(),
                                                tbxCountry.Text.ToString(),
                                                dtpDateFWD.Value,
                                                tbxEmTelNum.Text.ToString(),
                                                tbxBankAccNum.Text.ToString(),
                                                double.Parse(tbxHourlyWage.Text),
                                                DateTime.Now,
                                                (ContractType)(cbxContractType.SelectedIndex),
                                                (EmployeeType)(cbxTypeOfEmployee.SelectedIndex)
                                                );
                if (manageEmployees.AddEmployee(newEmp))
                {
                    MessageBox.Show("Success!");
                    manageEmployees.UpdateEmployees();
                    UpdateListBoxAllEmployees();
                    UpdateListBoxEmployee();
                }
                else { MessageBox.Show("Try again"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please fill all the fields");
            }
            catch (RepeatingObjectException)
            {
                MessageBox.Show("This bsn already exist");
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lbxViewEmployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
                if (lbxViewEmployees.SelectedItem.ToString() == emp.ToString())
                {
                    if (emp.Id == 2 || emp.Id == 3 || emp.Id == 4 || emp.Id == 6 || emp.Id == 8 || emp.Id == 28)
                    {
                        MessageBox.Show("You can not delete this user");
                    }
                    else if (manageEmployees.DeleteEmployeeFromDb(emp.Id))
                    {
                        MessageBox.Show("The employee is deleted");
                        manageEmployees.DeleteEmployee(emp);
                    }
                    else
                    {
                        MessageBox.Show("The employee is not deleted.");
                    }
                    UpdateListBoxAllEmployees();
                    UpdateListBoxEmployee();
                    return;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetEmployees())
            {
                if (emp.ToString().ToLower().Contains(tbSearch.Text.ToLower()))
                {
                    lbxViewEmployees.Items.Add(emp.ToString());
                    lbxViewEmployees.Items.Add("");
                }
            }

        }

        private void btnFullInfo_Click(object sender, EventArgs e)
        {
            Employee emp= GetSelectedEmployee();
            if (emp == null)
            {
                return;
            }
            employeeFullInfoForm = new EmployeeFullInfoForm(emp);
            employeeFullInfoForm.ShowDialog();
            employeeFullInfoForm.Close();

        }
        public Employee GetSelectedEmployee()
        {
            if (lbxViewEmployees.SelectedItem == null || lbxViewEmployees.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select an employee");
                return null;
            }
            else
            {
                foreach (Employee emp in manageEmployees.GetEmployees())
                {
                    if (lbxViewEmployees.SelectedItem.ToString() == emp.ToString())
                    {
                        return emp;
                    }
                }
                return null;
            }
        }

        private void rbtnAllEmployees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxAllEmployees();
        }

        private void rbtnActiveEmployees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxActiveEmployees();
        }

        private void rbtnFiredEmployees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBoxFiredEmployees();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = GetSelectedEmployee();
            if (emp == null)
            {
                return;
            }
            EditEmployeeForm = new EditEmployeeForm(emp);
            EditEmployeeForm.ShowDialog();
            EditEmployeeForm.Close();
            manageEmployees.UpdateEmployees();
            UpdateListBoxAllEmployees();
            UpdateListBoxEmployee();
        }
    }
}
