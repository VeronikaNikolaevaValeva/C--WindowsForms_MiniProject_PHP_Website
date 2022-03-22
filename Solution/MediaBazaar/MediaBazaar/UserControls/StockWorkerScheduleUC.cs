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
using ProjectClasses.Exceptions;
using ProjectClasses.LogicLayer;

namespace MediaBazaar
{
    public partial class StockWorkerScheduleInterface : UserControl
    {

        private ShiftManager shiftManager;
        private List<Shift> shifts = null;
        private WeekSchedule newSchedule;
        private Shift currentSelectedShift;
        public StockWorkerScheduleInterface()
        {
            InitializeComponent();
            shiftManager = new ShiftManager(DatabaseType.MAIN);
        }
        private void AddDefaultRows(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = ((DayOfWeek)i).ToString();
                dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
            }


        }
        private void DisplayAllPanelsInAutoSchedule(bool visible)
        {
            pnlSelectedWeek.Visible = visible;
            pnlManageCreatedSchedule.Visible = visible;
            pnlSchedule.Visible = visible;
            pnlSchedule.BringToFront();
        }
        private void DisplayAllPanelsInViewSchedule(bool visible)
        {
            pnlSelectedWeek.Visible = visible;
            pnlManageCreatedSchedule.Visible = visible;
            btnSave.Visible = false;
            pnlSchedule.Visible = visible;
            pnlSchedule.BringToFront();
        }
        private void UpdateInfoInAutoSchedule()
        {
            lbxAvailableEmployeesForShift.Items.Clear();
            lbxAssignedEmployeesToShift.Items.Clear();
            foreach (Employee employee in currentSelectedShift.GetAssignedEmployees())
            {
                lbxAssignedEmployeesToShift.Items.Add($"{employee.Id}. {employee.GetEmployeeNames} - {newSchedule.GetAssignedHoursPerWeek(employee)}h assigned for the week");
            }
            foreach (EmployeeInSchedule employeeInSchedule in newSchedule.GetAllAvailableStockWorker(currentSelectedShift))
            {
                ListViewItem newItem = new ListViewItem($"{employeeInSchedule.Employee.Id}. {employeeInSchedule.Employee.GetEmployeeNames} - {newSchedule.GetAssignedHoursPerWeek(employeeInSchedule.Employee)}h assigned for the week");
                lbxAvailableEmployeesForShift.Items.Add(newItem);
                if (newSchedule.HasEmployeeReachedWeeklyHoursLimit(employeeInSchedule))
                {
                    lbxAvailableEmployeesForShift.Items[lbxAvailableEmployeesForShift.Items.IndexOf(newItem)].BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
                }
            }
        }
        private void UpdateDisplayOfShiftsInGrid()
        {
            foreach (Shift s in shifts)
            {
                int rowIndex = dgvViewGeneratedSchedule.Rows.IndexOf(dgvViewGeneratedSchedule.Rows[Convert.ToInt32(s.Date.DayOfWeek)]);
                if (s.AssignableEmployees == s.GetAssignedEmployees().Count)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#63A375");
                }
                if (s.GetAssignedEmployees().Count > 0 && s.GetAssignedEmployees().Count < s.AssignableEmployees)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFB563");
                }
                if (s.GetAssignedEmployees().Count == 0)
                {
                    dgvViewGeneratedSchedule.Rows[rowIndex].Cells[$"cl{s.Type}Schedule"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF686B");
                }
                dgvViewGeneratedSchedule[$"cl{s.Type}Schedule", rowIndex].Value = $"{s.GetAssignedEmployees().Count}/{s.AssignableEmployees} emp. assigned";
            }
        }


        private void btnClosePanelAssignedEmployees_Click(object sender, EventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = false;
        }

        private void btnEditShift_Click(object sender, EventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = false;
            btnSave.Enabled = false;
            btnDiscard.Enabled = false;
            pnlEditShift.Visible = true;
            pnlEditShift.BringToFront();
            UpdateInfoInAutoSchedule();
            tbMaxAssignableEmployees.Text = currentSelectedShift.AssignableEmployees.ToString();
        }

        private void btnCloseEditMode_Click_2(object sender, EventArgs e)
        {

            btnDiscard.Enabled = true;
            btnSave.Enabled = true;
            pnlEditShift.Visible = false;
            pnlDisplayAssignedEmployees.Visible = false;
            UpdateDisplayOfShiftsInGrid();
        }

        private void btnRemoveEmployee_Click_1(object sender, EventArgs e)
        {
            int selectedUser;
            try
            {
                if (lbxAssignedEmployeesToShift.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a store worker from the assigned store workers for the selected shift!");
                }
                else
                {
                    selectedUser = Convert.ToInt32(lbxAssignedEmployeesToShift.SelectedItem.ToString().Substring(0, lbxAssignedEmployeesToShift.SelectedItem.ToString().IndexOf('.')));
                    if (currentSelectedShift.RemoveEmployee(selectedUser))
                    {
                        MessageBox.Show("Employee was removed from this shift.");
                        UpdateInfoInAutoSchedule();
                    }
                    else
                    {
                        MessageBox.Show("System failed to remove the employee.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAssignEmployee_Click_1(object sender, EventArgs e)
        {
            int selectedUser;

            if (lbxAvailableEmployeesForShift.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a store worker from the available store workers for the selected shift!");
            }
            else
            {
                string selectedItem = lbxAvailableEmployeesForShift.SelectedItems[0].Text;
                selectedUser = Convert.ToInt32(selectedItem.Substring(0, selectedItem.IndexOf('.')));
                EmployeeInSchedule foundEmployee = newSchedule.GetEmployeeFromAvailableEmployees(currentSelectedShift, selectedUser,EmployeeType.STOCK_WORKER);
                if (newSchedule.AssignEmployeeToShift(currentSelectedShift, foundEmployee))
                {
                    UpdateInfoInAutoSchedule();
                }
                else
                {
                    MessageBox.Show("The employee cannot be assigned to the shift!");
                }

            }
        }

        private void btnChangeMaxAssignableEmployees_Click_1(object sender, EventArgs e)
        {
            try
            {
                int newValue = Convert.ToInt32(tbMaxAssignableEmployees.Text);
                currentSelectedShift.AssignableEmployees = newValue;
                tbMaxAssignableEmployees.Text = newValue.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            shiftManager.SaveGeneratedSchedule(newSchedule);
            MessageBox.Show("The schedule was successfully saved!");
            DisplayAllPanelsInAutoSchedule(false);
            pnlGenerateSchedule.Visible = true;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {

            DisplayAllPanelsInAutoSchedule(false);
            pnlGenerateSchedule.Visible = true;
        }

        private void dgvViewGeneratedSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pnlDisplayAssignedEmployees.Visible = true;
            pnlDisplayAssignedEmployees.BringToFront();
            lbxAssignedEmployees.Items.Clear();
            int rowIndex = dgvViewGeneratedSchedule.CurrentCell.RowIndex;
            int columnIndex = dgvViewGeneratedSchedule.CurrentCell.ColumnIndex;
            Enum.TryParse(dgvViewGeneratedSchedule.Rows[rowIndex].HeaderCell.Value.ToString(), out DayOfWeek day);
            Enum.TryParse(dgvViewGeneratedSchedule.Columns[columnIndex].HeaderText.ToString(), out ShiftType shiftType);
            currentSelectedShift = newSchedule.GetShift(shiftType, day);
            if (currentSelectedShift.GetAssignedEmployees().Count == 0)
            {
                lbxAssignedEmployees.Items.Add($"0 out of {currentSelectedShift.AssignableEmployees} employees are assigned to this shift!");
            }
            else
            {
                foreach (Employee employee in currentSelectedShift.GetAssignedEmployees())
                {
                    lbxAssignedEmployees.Items.Add($"{employee.Id}. {employee.GetEmployeeNames}");
                }
            }
            if (btnSave.Visible == false)
            {
                btnEditShift.Visible = false;
            }
            else
            {
                btnEditShift.Visible = true;
            }
        }

        private void picInfo_MouseHover_1(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void picInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void btnGenerateSchedule_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (monthCalendarAutoSchedule.SelectionRange.Start < DateTime.Today)
                {
                    MessageBox.Show("Please select a date in the future");
                }
                else
                {
                    btnSave.Visible = true;
                    DisplayAllPanelsInAutoSchedule(true);
                    pnlGenerateSchedule.Visible = false;
                    pnlSchedule.Visible = true;
                    DateTime selectedDate = monthCalendarAutoSchedule.SelectionRange.Start;
                    newSchedule = shiftManager.CreateWeekSchedule(selectedDate);

                    lblSelectedWeekAndDepartment.Text = $"Week: {newSchedule.WeekStartDate.ToShortDateString()} - {newSchedule.WeekEndDate.ToShortDateString()}";
                    shifts = newSchedule.GetAllShifts();
                    AddDefaultRows(dgvViewGeneratedSchedule);
                    UpdateDisplayOfShiftsInGrid();
                }
            }
            catch (NotEnoughEmmployeesException ex)
            {
                DisplayAllPanelsInAutoSchedule(false);
                pnlGenerateSchedule.Visible = true;
                MessageBox.Show(ex.Message);

            }
        }

        private void btnViewSchedule_Click_1(object sender, EventArgs e)
        {
            DisplayAllPanelsInViewSchedule(true);
            pnlGenerateSchedule.Visible = false;
            DateTime selectedDate = monthCalendarAutoSchedule.SelectionRange.Start;

            newSchedule = shiftManager.GetSchedule(selectedDate);

            lblSelectedWeekAndDepartment.Text = $"Week: {newSchedule.WeekStartDate.ToShortDateString()} - {newSchedule.WeekEndDate.ToShortDateString()}";
            shifts = newSchedule.GetAllShifts();
            AddDefaultRows(dgvViewGeneratedSchedule);
            UpdateDisplayOfShiftsInGrid();
        }
    }
}
