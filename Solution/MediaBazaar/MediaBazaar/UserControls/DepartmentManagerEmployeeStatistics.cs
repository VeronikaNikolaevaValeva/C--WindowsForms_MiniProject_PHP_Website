using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectClasses;


namespace MediaBazaar
{
    public partial class DepartmentManagerEmployeeStatistics : UserControl
    {
        Employee employee;
        EmpStatisticManager empStatistics;
        DepartmentManager departmentManager;
        string TypeOfStats = "Total salary";
        string periodOverviewStats = "year";
        string contract = "no contract";
        DateTime dateOverviewStats = DateTime.Now;
        DateTime dateIndividualStats = DateTime.Now;
        string deptCode;
        string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] day = new string[7] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public DepartmentManagerEmployeeStatistics()
        {
            InitializeComponent();
            empStatistics = new EmpStatisticManager(DatabaseType.MAIN);
            departmentManager = new DepartmentManager(DatabaseType.MAIN);
        }

        public void SetDepartmentCode(string departmentCode)
        {
            this.deptCode = departmentCode;
            this.SetStatistics();
        }
        public void SetStatistics()
        {
            lbxDeptEmployees.Items.Clear();
            foreach (Employee employee in departmentManager.GetAllStoreWorkersFormDepartment(deptCode))
            {
                lbxDeptEmployees.Items.Add(employee.GetEmployeeNames);
            }
            this.ShowDepartmentStatistics();
        }
        private void txbDeptEmployees_TextChanged(object sender, EventArgs e)
        {
            lbxDeptEmployees.Items.Clear();
            string empName = txbDeptEmployees.Text.ToString().ToLower();
            if (String.IsNullOrEmpty(empName))
            {
                foreach (Employee emp in departmentManager.GetAllStoreWorkersFormDepartment(deptCode))
                { lbxDeptEmployees.Items.Add(emp.GetEmployeeNames); }
            }
            else
            {
                this.ShowDepartmentStatistics();
                foreach (Employee emp in departmentManager.GetAllStoreWorkersFormDepartment(deptCode))
                {
                    if (emp.GetEmployeeNames.ToLower().Contains(empName))
                    {
                        lbxDeptEmployees.Items.Add(emp.GetEmployeeNames);
                    }
                }
            }

        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            if (lbxDeptEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Select an employee from the list box.");
            }
            else
            {
                foreach (Employee emp in departmentManager.GetAllStoreWorkersFormDepartment(deptCode))
                {
                    if (emp.GetEmployeeNames == lbxDeptEmployees.SelectedItem.ToString())
                    {
                        this.employee = emp;
                        this.dateIndividualStats = dtpTimePeriod.Value;
                        FillDeptEmployeeInformationCard();
                        FillDeptEmployeeUtilizationChart();

                    }
                }
            }
        }

        public void FillDeptEmployeeInformationCard()
        {
            if (employee != null)
            {
                lblEmpNames.Text = employee.GetEmployeeNames;
                lblEmpId.Text = employee.Id.ToString();
                lblEmpContract.Text = employee.Contract.ToString();
                lblEmpHourlyWage.Text = employee.HourlyWage.ToString();
                lblEmpPosition.Text = employee.Position.ToString();
                List<int> TotalAssignedHours = empStatistics.GetEmployeeHoursPerTimeUnit(employee.Id, dateIndividualStats);
                lblTotalSalaryPerDay.Text = TotalAssignedHours[0].ToString() + " /day";
                lblTotalSalaryPerWeek.Text = TotalAssignedHours[1].ToString() + " /week"; ;
                lblTotalSalaryPerMonth.Text = TotalAssignedHours[2].ToString() + " /month"; ;
                lblTotalSalaryPerYear.Text = TotalAssignedHours[3].ToString() + " /year"; ;
            }
        }

        public void FillDeptEmployeeUtilizationChart()
        {
            if (employee != null)
            {
                ClearchartutilizationOfDeptEmployee();
                List<int> TotalAssignedHours = empStatistics.GetEmployeeHoursPerTimeUnit(employee.Id, dateIndividualStats);
                List<double> ContractualHours = empStatistics.GetEmployeeContractualHours(employee.Contract.ToString());
                if (rdbtnYear.Checked)
                {
                    chartutilizationOfDeptEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Year.ToString(), TotalAssignedHours[3]);
                    chartutilizationOfDeptEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Year.ToString(), ContractualHours[3]);
                }
                else if (rdbtnMonth.Checked)
                {
                    chartutilizationOfDeptEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Month.ToString(), TotalAssignedHours[2]);
                    chartutilizationOfDeptEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Month.ToString(), ContractualHours[2]);
                }
                else if (rdbtnWeek.Checked)
                {
                    chartutilizationOfDeptEmployee.Series["Actual hours worked"].Points.AddXY("Week", TotalAssignedHours[1]);
                    chartutilizationOfDeptEmployee.Series["Contractual hours"].Points.AddXY("Week", ContractualHours[1]);
                }
                else if (rdbtnDay.Checked)
                {
                    chartutilizationOfDeptEmployee.Series["Actual hours worked"].Points.AddXY(dateIndividualStats.Day.ToString(), TotalAssignedHours[0]);
                    chartutilizationOfDeptEmployee.Series["Contractual hours"].Points.AddXY(dateIndividualStats.Day.ToString(), ContractualHours[0]);
                }
            }
        }
        private void rdbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfDeptEmployee();
            FillDeptEmployeeUtilizationChart();
        }

        private void rdbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfDeptEmployee();
            FillDeptEmployeeUtilizationChart();
        }

        private void rdbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfDeptEmployee();
            FillDeptEmployeeUtilizationChart();
        }

        private void rdbtnDay_CheckedChanged(object sender, EventArgs e)
        {
            ClearchartutilizationOfDeptEmployee();
            FillDeptEmployeeUtilizationChart();
        }
        private void dtpTimePeriod_ValueChanged(object sender, EventArgs e)
        {
            this.dateIndividualStats = dtpTimePeriod.Value;
            ClearchartutilizationOfDeptEmployee();
            FillDeptEmployeeInformationCard();
            FillDeptEmployeeUtilizationChart();
        }
        public void ClearchartutilizationOfDeptEmployee()
        {
            chartutilizationOfDeptEmployee.Series["Actual hours worked"].Points.Clear();
            chartutilizationOfDeptEmployee.Series["Contractual hours"].Points.Clear();
        }

        private void DepartmentManagerEmployeeStatistics_Load(object sender, EventArgs e)
        {

        }
        public void ShowDepartmentStatistics()
        {
            List<double> EmpStats = empStatistics.ShowDepartmentOverallStatistics(TypeOfStats, periodOverviewStats, dateOverviewStats, deptCode, contract);
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
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(month[i], EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "month")
            {
                int daysInMonth = System.DateTime.DaysInMonth(dateOverviewStats.Year, dateOverviewStats.Month);
                for (int i = 0; i < daysInMonth; i++)
                {
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(i + 1, EmpStats[i]);
                }
            }
            else if (periodOverviewStats == "week")
            {
                for (int i = 0; i < 7; i++)
                {
                    chartDepStatistics.Series[TypeOfStats].Points.AddXY(day[i], EmpStats[i]);
                }
            }
        }

        public void ClearEmpStatsChart()
        {
            lblChartTitle.Text = String.Empty;

            chartDepStatistics.Series["Total salary"].Points.Clear();
            chartDepStatistics.Series["Average salary"].Points.Clear();
            chartDepStatistics.Series["Total hours worked"].Points.Clear();
            chartDepStatistics.Series["Average hours worked"].Points.Clear();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "year";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "month";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            periodOverviewStats = "week";
            ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void cbbAllKindsOfStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeOfStats = cbbAllKindsOfStatistics.SelectedItem.ToString();
            this.ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            dateOverviewStats = dtDateStatistic.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contract = cbbFilterByContract.SelectedItem.ToString();
            this.ClearEmpStatsChart();
            ShowDepartmentStatistics();
        }
    }
}
