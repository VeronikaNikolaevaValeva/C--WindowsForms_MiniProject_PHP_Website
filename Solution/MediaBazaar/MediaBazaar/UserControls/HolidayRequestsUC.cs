using ProjectClasses;
using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.UserControls
{
    public partial class HolidayRequestsUC : UserControl
    {
        HolidayManager hm;
        public HolidayRequestsUC()
        {
            InitializeComponent();
            hm = new HolidayManager(DatabaseType.MAIN);
            UpdateRequestedHolidays();
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;

        }
        private void UpdateRequestedHolidays()
        {
            lbRequestedHolidays.Items.Clear();
            foreach (Holiday requestedHoliday in hm.GetRequestedHolidays())
            {
               lbRequestedHolidays.Items.Add(requestedHoliday);
            }
        }
        private void ClearFields()
        {
            tbEmployeeBSN.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }
        private void ShowAllHolidays()
        {
            cbSort.SelectedIndex = 0;
            lbHolidays.Items.Clear();
            foreach (Holiday holiday in hm.GetHolidays())
            {
                lbHolidays.Items.Add(holiday);
            }
        }
        private void UpdateHolidays()
        {
            if (cbSort.SelectedItem.ToString() == "All")
            {
                ShowAllHolidays();
            }
            else if (cbSort.SelectedItem.ToString() == "By employee")
            {
                SortHolidaysByEmployee();

            }
            else if (cbSort.SelectedItem.ToString() == "By start date")
            {
                SortHolidaysByStartDate();
            }
        }
        private void btnDeleteHoliday_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbHolidays.SelectedItem == null)
                {
                    throw new ArgumentException();
                }
                hm.DeleteHoliday(Convert.ToInt32(lbHolidays.SelectedItem.ToString().Substring(0, lbHolidays.SelectedItem.ToString().IndexOf('.'))));
                UpdateHolidays();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDeleteHoliday.Visible = false;
            }
        }

        private void tcHolidays_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tcHolidays.SelectedTab == tpViewHolidays)
            {
                ShowAllHolidays();
                btnDeleteHoliday.Visible = false;
                ClearFields();
            }
            else
            {

                btnDenyHolidayRequest.Visible = false;
                UpdateRequestedHolidays();
            }
        }
        private void btnRegisterNewHoliday_Click_1(object sender, EventArgs e)
        {
            try
            {
                string employeeBSN = tbEmployeeBSN.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                DateTime requestedTime = DateTime.Now;
                Holiday newHoliday = new Holiday(1, employeeBSN, startDate, endDate, requestedTime);
                hm.RegisterNewHoliday(newHoliday);
                MessageBox.Show($"The new holiday for employee with BSN: {employeeBSN} was registered!");
                UpdateRequestedHolidays();
                ClearFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDenyHolidayRequest.Visible = false;
            }
        }

        private void dtpStartDate_ValueChanged_1(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnDenyHolidayRequest_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lbRequestedHolidays.SelectedItem == null)
                {
                    throw new ArgumentException();
                }
                hm.DenyRequestedHoliday(Convert.ToInt32(lbRequestedHolidays.SelectedItem.ToString().Substring(0, lbRequestedHolidays.SelectedItem.ToString().IndexOf('.'))));
                UpdateRequestedHolidays();
                ClearFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDenyHolidayRequest.Visible = false;
            }
        }

        private void lbRequestedHolidays_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                if (lbRequestedHolidays.SelectedItem == null)
                {
                    throw new ArgumentException();
                }
                btnDenyHolidayRequest.Visible = true;
                Holiday foundHoliday = hm.GetRequestedHolidayById(Convert.ToInt32(lbRequestedHolidays.SelectedItem.ToString().Substring(0, lbRequestedHolidays.SelectedItem.ToString().IndexOf('.'))));
                ClearFields();
                tbEmployeeBSN.Text = foundHoliday.EmployeeBsn;
                dtpEndDate.Value = foundHoliday.EndDate;
                dtpStartDate.Value = foundHoliday.StartDate;
            }
            catch (NotExistingHolidayException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbSortByRequestedTime_CheckedChanged(object sender, EventArgs e)
        {
            lbRequestedHolidays.Items.Clear();
            if (rbSortByRequestedTime.Checked == true)
            {
                foreach (Holiday requestedHoliday in hm.GetRequestedHolidaysByRequestedTime())
                {
                    lbRequestedHolidays.Items.Add(requestedHoliday);
                }
            }
            else
            {
                UpdateRequestedHolidays();
            }
        }

        private void rbSortByEmployee_CheckedChanged(object sender, EventArgs e)
        {
            lbRequestedHolidays.Items.Clear();
            if (rbSortByEmployee.Checked == true)
            {
                foreach (Holiday requestedHoliday in hm.GetRequestedHolidaysByEmployee())
                {
                    lbRequestedHolidays.Items.Add(requestedHoliday);
                }
            }
            else
            {
                UpdateRequestedHolidays();
            }
        }

        private void lbHolidays_DoubleClick(object sender, EventArgs e)
        {
            btnDeleteHoliday.Visible = true;
        }

        private void SortHolidaysByEmployee()
        {
            lbHolidays.Items.Clear();
            foreach (Holiday holiday in hm.GetHolidaysByEmployee())
            {
                lbHolidays.Items.Add(holiday);
            }
        }
        private void SortHolidaysByStartDate()
        {
            lbHolidays.Items.Clear();
            foreach (Holiday holiday in hm.GetHolidaysByStartDate())
            {
                lbHolidays.Items.Add(holiday);
            }
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHolidays();
        }

        
    }
}
