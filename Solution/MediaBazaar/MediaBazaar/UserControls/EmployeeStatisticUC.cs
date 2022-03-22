using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{

    public partial class EmployeeStatistics : UserControl
    {
        Employee employee;
        EmpStatisticManager empStatistics;
        string TypeOfStats = "Total salary";
        string periodOverviewStats = "year";
        string position = "all";
        DateTime dateOverviewStats = DateTime.Now;
        DateTime dateIndividualStats = DateTime.Now;
        string contract = "no contract";
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public EmployeeStatistics()
        {
            InitializeComponent();
            empStatistics = new EmpStatisticManager(DatabaseType.MAIN);
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            foreach (Employee emp in empStatistics.GetListOfAllEmployees())
            {
                lbxEmployees.Items.Add(emp.GetEmployeeNames);
            }
        }
        private void tbpAllEmployees_Click(object sender, EventArgs e)
        {

        }

        private void txbEmployees_TextChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            string empName = txbEmployees.Text.ToString().ToLower();
            if (String.IsNullOrEmpty(empName))
            {
                foreach (Employee emp in empStatistics.GetListOfAllEmployees())
                { lbxEmployees.Items.Add(emp.GetEmployeeNames); }
            }
            else
            {
                lbxEmployees.Items.Clear();
                foreach (Employee emp in empStatistics.GetListOfAllEmployees())
                {
                    if (emp.GetEmployeeNames.ToLower().Contains(empName))
                    {
                        lbxEmployees.Items.Add(emp.GetEmployeeNames);
                    }

                }
            }
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            if (lbxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select an employee from the list box.");
            }
            else
            {
                foreach (Employee emp in empStatistics.GetListOfAllEmployees())
                {
                    if (emp.GetEmployeeNames == lbxEmployees.SelectedItem.ToString())
                    {
                        this.employee = emp;
                        this.dateIndividualStats = dtpTimePeriod.Value;
                        FillEmployeeInformationCard();
                        FillEmployeeUtilizationChart();

                    }
                }
            }

        }

        public void FillEmployeeInformationCard()
        {
            if (employee != null)
            {
                lblEmpNames.Text = employee.GetEmployeeNames;
                lblEmpId.Text = employee.Id.ToString();
                lblEmpContract.Text = employee.Contract.ToString();
                lblEmpHourlyWage.Text = employee.HourlyWage.ToString();
                if(employee.Position.ToString() == "DEPARTMENT_MANAGER")
                {
                    lblEmpPosition.Text = "DEPARTMENT \r\n MANAGER";
                }
                else { lblEmpPosition.Text = employee.Position.ToString(); }
                List<int> TotalAssignedHours = empStatistics.GetEmployeeHoursPerTimeUnit(employee.Id, dateIndividualStats);
                lblTotalSalaryPerDay.Text = TotalAssignedHours[0].ToString() + " /day";
                lblTotalSalaryPerWeek.Text = TotalAssignedHours[1].ToString() + " /week"; 
                lblTotalSalaryPerMonth.Text = TotalAssignedHours[2].ToString() + " /month"; 
                lblTotalSalaryPerYear.Text = TotalAssignedHours[3].ToString() + " /year"; 
            }

        }

        public void FillEmployeeUtilizationChart()
        {
            if (employee != null)
            {
                ClearchartutilizationOfAnEmployee();
                List<int> TotalAssignedHours = empStatistics.GetEmployeeHoursPerTimeUnit(employee.Id, dateIndividualStats);
                List<double> ContractualHours = empStatistics.GetEmployeeContractualHours(employee.Contract.ToString());
                if (rdbtnYear.Checked)
                {
                    chartutilizationOfAnEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Year.ToString(), TotalAssignedHours[3]);
                    chartutilizationOfAnEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Year.ToString(), ContractualHours[3]);
                }
                else if (rdbtnMonth.Checked)
                {
                    chartutilizationOfAnEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Month.ToString(), TotalAssignedHours[2]);
                    chartutilizationOfAnEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Month.ToString(), ContractualHours[2]);
                }
                else if (rdbtnWeek.Checked)
                {
                    chartutilizationOfAnEmployee.Series["Actual hours worked"].Points.AddXY("Week", TotalAssignedHours[1]);
                    chartutilizationOfAnEmployee.Series["Contractual hours"].Points.AddXY("Week", ContractualHours[1]);
                }
                else if (rdbtnDay.Checked)
                {
                    chartutilizationOfAnEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Day.ToString(), TotalAssignedHours[0]);
                    chartutilizationOfAnEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Day.ToString(), ContractualHours[0]);
                }
            }
        }
        private void rdbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfAnEmployee();
            FillEmployeeUtilizationChart();
        }

        private void rdbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfAnEmployee();
            FillEmployeeUtilizationChart();
        }

        private void rdbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfAnEmployee();
            FillEmployeeUtilizationChart();
        }

        private void rdbtnDay_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfAnEmployee();
            FillEmployeeUtilizationChart();
        }
        private void dtpTimePeriod_ValueChanged(object sender, EventArgs e)
        {
            this.dateIndividualStats = dtpTimePeriod.Value;
            ClearchartutilizationOfAnEmployee();
            FillEmployeeInformationCard();
            FillEmployeeUtilizationChart();
        }
        public void ClearchartutilizationOfAnEmployee()
        {
            chartutilizationOfAnEmployee.Series["Actual hours worked"].Points.Clear();
            chartutilizationOfAnEmployee.Series["Contractual hours"].Points.Clear();
        }
        //chart 
        public void ShowOverallStatisticsForTotalSalary()
        {
            List<double> EmpStats = empStatistics.ShowOverallStatistics(TypeOfStats, periodOverviewStats, dateOverviewStats, contract, position);
            if (!String.IsNullOrEmpty(lblChartTitle.Text))
            {
                lblChartTitle.Text += " x " + TypeOfStats;
            }
            else
            {
                lblChartTitle.Text = TypeOfStats;
            }

            if (periodOverviewStats == "year")
            {
                for (int i = 0; i < 12; i++)
                {
                    chartStatistics.Series[TypeOfStats].Points.AddXY(month[i], EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "month")
            {
                int daysInMonth = System.DateTime.DaysInMonth(dateOverviewStats.Year, dateOverviewStats.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartStatistics.Series[TypeOfStats].Points.AddXY(i + 1, EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "week")
            {
                for (int i = 0; i < 7; i++)
                {
                    chartStatistics.Series[TypeOfStats].Points.AddXY(day[i], EmpStats[i]);
                }
            }
        }
        public void ClearEmpStatsChart()
        {
            lblChartTitle.Text = String.Empty;

            chartStatistics.Series["Total salary"].Points.Clear();
            chartStatistics.Series["Average salary"].Points.Clear();
            chartStatistics.Series["Total hours worked"].Points.Clear();
            chartStatistics.Series["Average hours worked"].Points.Clear();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "year";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "month";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "week";
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void cbbAllKindsOfStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStats = cbbAllKindsOfStatistics.SelectedItem.ToString();
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            dateOverviewStats = dtDateStatistic.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contract = cbbFilterByContract.SelectedItem.ToString();
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }

        private void cbbFilterByPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = cbbFilterByPosition.SelectedItem.ToString();
            ClearEmpStatsChart();
            ShowOverallStatisticsForTotalSalary();
        }
    }
}
