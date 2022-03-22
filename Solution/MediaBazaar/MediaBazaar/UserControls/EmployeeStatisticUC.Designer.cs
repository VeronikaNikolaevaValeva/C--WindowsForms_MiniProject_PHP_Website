namespace MediaBazaar
{
    partial class EmployeeStatistics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcEmployeeStatistics = new System.Windows.Forms.TabControl();
            this.tbpAllEmployees = new System.Windows.Forms.TabPage();
            this.cbbFilterByPosition = new System.Windows.Forms.ComboBox();
            this.lblFilterByPosition = new System.Windows.Forms.Label();
            this.lblFilterByContract = new System.Windows.Forms.Label();
            this.cbbFilterByContract = new System.Windows.Forms.ComboBox();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbAllKindsOfStatistics = new System.Windows.Forms.ComboBox();
            this.dtDateStatistic = new System.Windows.Forms.DateTimePicker();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSpecificEmployee = new System.Windows.Forms.TabPage();
            this.gbxChart = new System.Windows.Forms.GroupBox();
            this.rdbtnDay = new System.Windows.Forms.RadioButton();
            this.rdbtnYear = new System.Windows.Forms.RadioButton();
            this.rdbtnWeek = new System.Windows.Forms.RadioButton();
            this.rdbtnMonth = new System.Windows.Forms.RadioButton();
            this.chartutilizationOfAnEmployee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxEmpInformation = new System.Windows.Forms.GroupBox();
            this.lblTotalSalaryPerYear = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerDay = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerWeek = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerMonth = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lblEmpNames = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblEmpHourlyWage = new System.Windows.Forms.Label();
            this.lblEmpContract = new System.Windows.Forms.Label();
            this.lblEmpPosition = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.txbEmployees = new System.Windows.Forms.TextBox();
            this.dtpTimePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodOfTime = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblChooseAnEmployee = new System.Windows.Forms.Label();
            this.tbcEmployeeStatistics.SuspendLayout();
            this.tbpAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.tbpSpecificEmployee.SuspendLayout();
            this.gbxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartutilizationOfAnEmployee)).BeginInit();
            this.gbxEmpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmployeeStatistics
            // 
            this.tbcEmployeeStatistics.Controls.Add(this.tbpAllEmployees);
            this.tbcEmployeeStatistics.Controls.Add(this.tbpSpecificEmployee);
            this.tbcEmployeeStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcEmployeeStatistics.Location = new System.Drawing.Point(3, 0);
            this.tbcEmployeeStatistics.Name = "tbcEmployeeStatistics";
            this.tbcEmployeeStatistics.SelectedIndex = 0;
            this.tbcEmployeeStatistics.Size = new System.Drawing.Size(1124, 782);
            this.tbcEmployeeStatistics.TabIndex = 4;
            // 
            // tbpAllEmployees
            // 
            this.tbpAllEmployees.Controls.Add(this.cbbFilterByPosition);
            this.tbpAllEmployees.Controls.Add(this.lblFilterByPosition);
            this.tbpAllEmployees.Controls.Add(this.lblFilterByContract);
            this.tbpAllEmployees.Controls.Add(this.cbbFilterByContract);
            this.tbpAllEmployees.Controls.Add(this.lblChartTitle);
            this.tbpAllEmployees.Controls.Add(this.rbtnWeek);
            this.tbpAllEmployees.Controls.Add(this.rbtnMonth);
            this.tbpAllEmployees.Controls.Add(this.rbtnYear);
            this.tbpAllEmployees.Controls.Add(this.chartStatistics);
            this.tbpAllEmployees.Controls.Add(this.cbbAllKindsOfStatistics);
            this.tbpAllEmployees.Controls.Add(this.dtDateStatistic);
            this.tbpAllEmployees.Controls.Add(this.lblEmpStat);
            this.tbpAllEmployees.Controls.Add(this.label1);
            this.tbpAllEmployees.Location = new System.Drawing.Point(4, 27);
            this.tbpAllEmployees.Name = "tbpAllEmployees";
            this.tbpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllEmployees.Size = new System.Drawing.Size(1116, 751);
            this.tbpAllEmployees.TabIndex = 0;
            this.tbpAllEmployees.Text = " Overall statistics";
            this.tbpAllEmployees.UseVisualStyleBackColor = true;
            this.tbpAllEmployees.Click += new System.EventHandler(this.tbpAllEmployees_Click);
            // 
            // cbbFilterByPosition
            // 
            this.cbbFilterByPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterByPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbFilterByPosition.FormattingEnabled = true;
            this.cbbFilterByPosition.Items.AddRange(new object[] {
            "all",
            "HR",
            "STORE_MANAGER",
            "STOCK_MANAGER",
            "STORE_WORKER",
            "STOCK_WORKER",
            ""});
            this.cbbFilterByPosition.Location = new System.Drawing.Point(775, 111);
            this.cbbFilterByPosition.Name = "cbbFilterByPosition";
            this.cbbFilterByPosition.Size = new System.Drawing.Size(291, 28);
            this.cbbFilterByPosition.TabIndex = 32;
            this.cbbFilterByPosition.SelectedIndexChanged += new System.EventHandler(this.cbbFilterByPosition_SelectedIndexChanged);
            // 
            // lblFilterByPosition
            // 
            this.lblFilterByPosition.AutoSize = true;
            this.lblFilterByPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterByPosition.Location = new System.Drawing.Point(572, 112);
            this.lblFilterByPosition.Name = "lblFilterByPosition";
            this.lblFilterByPosition.Size = new System.Drawing.Size(151, 24);
            this.lblFilterByPosition.TabIndex = 31;
            this.lblFilterByPosition.Text = "Filter by position:";
            // 
            // lblFilterByContract
            // 
            this.lblFilterByContract.AutoSize = true;
            this.lblFilterByContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilterByContract.Location = new System.Drawing.Point(34, 108);
            this.lblFilterByContract.Name = "lblFilterByContract";
            this.lblFilterByContract.Size = new System.Drawing.Size(152, 24);
            this.lblFilterByContract.TabIndex = 30;
            this.lblFilterByContract.Text = "Filter by contract:";
            // 
            // cbbFilterByContract
            // 
            this.cbbFilterByContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterByContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbFilterByContract.FormattingEnabled = true;
            this.cbbFilterByContract.Items.AddRange(new object[] {
            "no contract",
            "FULLTIME",
            "EIGHTYPERCENT",
            "FLEX"});
            this.cbbFilterByContract.Location = new System.Drawing.Point(238, 108);
            this.cbbFilterByContract.Name = "cbbFilterByContract";
            this.cbbFilterByContract.Size = new System.Drawing.Size(291, 28);
            this.cbbFilterByContract.TabIndex = 29;
            this.cbbFilterByContract.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartTitle.Location = new System.Drawing.Point(99, 222);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(0, 24);
            this.lblChartTitle.TabIndex = 28;
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnWeek.Location = new System.Drawing.Point(872, 188);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(85, 29);
            this.rbtnWeek.TabIndex = 25;
            this.rbtnWeek.TabStop = true;
            this.rbtnWeek.Text = "Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtnWeek_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnMonth.Location = new System.Drawing.Point(720, 188);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(88, 29);
            this.rbtnMonth.TabIndex = 22;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Checked = true;
            this.rbtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnYear.Location = new System.Drawing.Point(576, 188);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(74, 29);
            this.rbtnYear.TabIndex = 21;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // chartStatistics
            // 
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(5, 249);
            this.chartStatistics.Name = "chartStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Total salary";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Average salary";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Total hours worked";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Average hours worked";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Series.Add(series2);
            this.chartStatistics.Series.Add(series3);
            this.chartStatistics.Series.Add(series4);
            this.chartStatistics.Size = new System.Drawing.Size(1111, 498);
            this.chartStatistics.TabIndex = 20;
            this.chartStatistics.Text = "chart1";
            // 
            // cbbAllKindsOfStatistics
            // 
            this.cbbAllKindsOfStatistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAllKindsOfStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbAllKindsOfStatistics.FormattingEnabled = true;
            this.cbbAllKindsOfStatistics.Items.AddRange(new object[] {
            "Total salary",
            "Average salary",
            "Total hours worked",
            "Average hours worked"});
            this.cbbAllKindsOfStatistics.Location = new System.Drawing.Point(775, 34);
            this.cbbAllKindsOfStatistics.Name = "cbbAllKindsOfStatistics";
            this.cbbAllKindsOfStatistics.Size = new System.Drawing.Size(291, 28);
            this.cbbAllKindsOfStatistics.TabIndex = 19;
            this.cbbAllKindsOfStatistics.SelectedIndexChanged += new System.EventHandler(this.cbbAllKindsOfStatistics_SelectedIndexChanged);
            // 
            // dtDateStatistic
            // 
            this.dtDateStatistic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Location = new System.Drawing.Point(238, 32);
            this.dtDateStatistic.Name = "dtDateStatistic";
            this.dtDateStatistic.Size = new System.Drawing.Size(291, 27);
            this.dtDateStatistic.TabIndex = 17;
            this.dtDateStatistic.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            this.dtDateStatistic.ValueChanged += new System.EventHandler(this.dtDateStatistic_ValueChanged);
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(34, 34);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(122, 24);
            this.lblEmpStat.TabIndex = 16;
            this.lblEmpStat.Text = "Choose date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(572, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show statistics of: ";
            // 
            // tbpSpecificEmployee
            // 
            this.tbpSpecificEmployee.Controls.Add(this.gbxChart);
            this.tbpSpecificEmployee.Controls.Add(this.gbxEmpInformation);
            this.tbpSpecificEmployee.Controls.Add(this.lbxEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.txbEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.dtpTimePeriod);
            this.tbpSpecificEmployee.Controls.Add(this.lblPeriodOfTime);
            this.tbpSpecificEmployee.Controls.Add(this.btnShowStatistics);
            this.tbpSpecificEmployee.Controls.Add(this.lblChooseAnEmployee);
            this.tbpSpecificEmployee.Location = new System.Drawing.Point(4, 27);
            this.tbpSpecificEmployee.Name = "tbpSpecificEmployee";
            this.tbpSpecificEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpecificEmployee.Size = new System.Drawing.Size(1116, 751);
            this.tbpSpecificEmployee.TabIndex = 1;
            this.tbpSpecificEmployee.Text = "Employee statistics";
            this.tbpSpecificEmployee.UseVisualStyleBackColor = true;
            // 
            // gbxChart
            // 
            this.gbxChart.BackColor = System.Drawing.Color.LightBlue;
            this.gbxChart.Controls.Add(this.rdbtnDay);
            this.gbxChart.Controls.Add(this.rdbtnYear);
            this.gbxChart.Controls.Add(this.rdbtnWeek);
            this.gbxChart.Controls.Add(this.rdbtnMonth);
            this.gbxChart.Controls.Add(this.chartutilizationOfAnEmployee);
            this.gbxChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxChart.Location = new System.Drawing.Point(400, 228);
            this.gbxChart.Name = "gbxChart";
            this.gbxChart.Size = new System.Drawing.Size(688, 502);
            this.gbxChart.TabIndex = 21;
            this.gbxChart.TabStop = false;
            this.gbxChart.Text = "Actual hours worked (in blue) vs. Contractual hours (in green)";
            // 
            // rdbtnDay
            // 
            this.rdbtnDay.AutoSize = true;
            this.rdbtnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnDay.Location = new System.Drawing.Point(552, 309);
            this.rdbtnDay.Name = "rdbtnDay";
            this.rdbtnDay.Size = new System.Drawing.Size(60, 24);
            this.rdbtnDay.TabIndex = 19;
            this.rdbtnDay.Text = "Day";
            this.rdbtnDay.UseVisualStyleBackColor = true;
            this.rdbtnDay.CheckedChanged += new System.EventHandler(this.rdbtnDay_CheckedChanged);
            // 
            // rdbtnYear
            // 
            this.rdbtnYear.AutoSize = true;
            this.rdbtnYear.Checked = true;
            this.rdbtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnYear.Location = new System.Drawing.Point(552, 148);
            this.rdbtnYear.Name = "rdbtnYear";
            this.rdbtnYear.Size = new System.Drawing.Size(64, 24);
            this.rdbtnYear.TabIndex = 16;
            this.rdbtnYear.TabStop = true;
            this.rdbtnYear.Text = "Year";
            this.rdbtnYear.UseVisualStyleBackColor = true;
            this.rdbtnYear.CheckedChanged += new System.EventHandler(this.rdbtnYear_CheckedChanged);
            // 
            // rdbtnWeek
            // 
            this.rdbtnWeek.AutoSize = true;
            this.rdbtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnWeek.Location = new System.Drawing.Point(552, 253);
            this.rdbtnWeek.Name = "rdbtnWeek";
            this.rdbtnWeek.Size = new System.Drawing.Size(72, 24);
            this.rdbtnWeek.TabIndex = 18;
            this.rdbtnWeek.Text = "Week";
            this.rdbtnWeek.UseVisualStyleBackColor = true;
            this.rdbtnWeek.CheckedChanged += new System.EventHandler(this.rdbtnWeek_CheckedChanged);
            // 
            // rdbtnMonth
            // 
            this.rdbtnMonth.AutoSize = true;
            this.rdbtnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnMonth.Location = new System.Drawing.Point(552, 200);
            this.rdbtnMonth.Name = "rdbtnMonth";
            this.rdbtnMonth.Size = new System.Drawing.Size(76, 24);
            this.rdbtnMonth.TabIndex = 17;
            this.rdbtnMonth.Text = "Month";
            this.rdbtnMonth.UseVisualStyleBackColor = true;
            this.rdbtnMonth.CheckedChanged += new System.EventHandler(this.rdbtnMonth_CheckedChanged);
            // 
            // chartutilizationOfAnEmployee
            // 
            this.chartutilizationOfAnEmployee.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartutilizationOfAnEmployee.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartutilizationOfAnEmployee.Legends.Add(legend2);
            this.chartutilizationOfAnEmployee.Location = new System.Drawing.Point(13, 40);
            this.chartutilizationOfAnEmployee.Name = "chartutilizationOfAnEmployee";
            this.chartutilizationOfAnEmployee.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.IsValueShownAsLabel = true;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.LegendText = "Actual hours worked";
            series5.Name = "Actual hours worked";
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series6.IsValueShownAsLabel = true;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.LegendText = "Contractual hours";
            series6.Name = "Contractual hours";
            this.chartutilizationOfAnEmployee.Series.Add(series5);
            this.chartutilizationOfAnEmployee.Series.Add(series6);
            this.chartutilizationOfAnEmployee.Size = new System.Drawing.Size(669, 462);
            this.chartutilizationOfAnEmployee.TabIndex = 15;
            this.chartutilizationOfAnEmployee.Text = "chart1";
            // 
            // gbxEmpInformation
            // 
            this.gbxEmpInformation.BackColor = System.Drawing.Color.LightBlue;
            this.gbxEmpInformation.Controls.Add(this.lblTotalSalaryPerYear);
            this.gbxEmpInformation.Controls.Add(this.lblTotalSalaryPerDay);
            this.gbxEmpInformation.Controls.Add(this.lblTotalSalaryPerWeek);
            this.gbxEmpInformation.Controls.Add(this.lblTotalSalaryPerMonth);
            this.gbxEmpInformation.Controls.Add(this.lblTotalSalary);
            this.gbxEmpInformation.Controls.Add(this.lblEmpNames);
            this.gbxEmpInformation.Controls.Add(this.lblNames);
            this.gbxEmpInformation.Controls.Add(this.lblEmpHourlyWage);
            this.gbxEmpInformation.Controls.Add(this.lblEmpContract);
            this.gbxEmpInformation.Controls.Add(this.lblEmpPosition);
            this.gbxEmpInformation.Controls.Add(this.lblEmpId);
            this.gbxEmpInformation.Controls.Add(this.lblHourlyWage);
            this.gbxEmpInformation.Controls.Add(this.lblContract);
            this.gbxEmpInformation.Controls.Add(this.lblPosition);
            this.gbxEmpInformation.Controls.Add(this.lblid);
            this.gbxEmpInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxEmpInformation.Location = new System.Drawing.Point(28, 228);
            this.gbxEmpInformation.Name = "gbxEmpInformation";
            this.gbxEmpInformation.Size = new System.Drawing.Size(366, 502);
            this.gbxEmpInformation.TabIndex = 14;
            this.gbxEmpInformation.TabStop = false;
            this.gbxEmpInformation.Text = "Employee information";
            // 
            // lblTotalSalaryPerYear
            // 
            this.lblTotalSalaryPerYear.AutoSize = true;
            this.lblTotalSalaryPerYear.Location = new System.Drawing.Point(161, 417);
            this.lblTotalSalaryPerYear.Name = "lblTotalSalaryPerYear";
            this.lblTotalSalaryPerYear.Size = new System.Drawing.Size(99, 25);
            this.lblTotalSalaryPerYear.TabIndex = 14;
            this.lblTotalSalaryPerYear.Text = "0.00 /year";
            // 
            // lblTotalSalaryPerDay
            // 
            this.lblTotalSalaryPerDay.AutoSize = true;
            this.lblTotalSalaryPerDay.Location = new System.Drawing.Point(161, 283);
            this.lblTotalSalaryPerDay.Name = "lblTotalSalaryPerDay";
            this.lblTotalSalaryPerDay.Size = new System.Drawing.Size(93, 25);
            this.lblTotalSalaryPerDay.TabIndex = 13;
            this.lblTotalSalaryPerDay.Text = "0.00 /day";
            // 
            // lblTotalSalaryPerWeek
            // 
            this.lblTotalSalaryPerWeek.AutoSize = true;
            this.lblTotalSalaryPerWeek.Location = new System.Drawing.Point(161, 324);
            this.lblTotalSalaryPerWeek.Name = "lblTotalSalaryPerWeek";
            this.lblTotalSalaryPerWeek.Size = new System.Drawing.Size(107, 25);
            this.lblTotalSalaryPerWeek.TabIndex = 12;
            this.lblTotalSalaryPerWeek.Text = "0.00 /week";
            // 
            // lblTotalSalaryPerMonth
            // 
            this.lblTotalSalaryPerMonth.AutoSize = true;
            this.lblTotalSalaryPerMonth.Location = new System.Drawing.Point(161, 369);
            this.lblTotalSalaryPerMonth.Name = "lblTotalSalaryPerMonth";
            this.lblTotalSalaryPerMonth.Size = new System.Drawing.Size(115, 25);
            this.lblTotalSalaryPerMonth.TabIndex = 11;
            this.lblTotalSalaryPerMonth.Text = "0.00 /month";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(11, 283);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(119, 25);
            this.lblTotalSalary.TabIndex = 10;
            this.lblTotalSalary.Text = "Total salary:";
            // 
            // lblEmpNames
            // 
            this.lblEmpNames.AutoSize = true;
            this.lblEmpNames.Location = new System.Drawing.Point(161, 40);
            this.lblEmpNames.Name = "lblEmpNames";
            this.lblEmpNames.Size = new System.Drawing.Size(19, 25);
            this.lblEmpNames.TabIndex = 9;
            this.lblEmpNames.Text = "-";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(16, 40);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(94, 25);
            this.lblNames.TabIndex = 8;
            this.lblNames.Text = "Name(s):";
            // 
            // lblEmpHourlyWage
            // 
            this.lblEmpHourlyWage.AutoSize = true;
            this.lblEmpHourlyWage.Location = new System.Drawing.Point(161, 235);
            this.lblEmpHourlyWage.Name = "lblEmpHourlyWage";
            this.lblEmpHourlyWage.Size = new System.Drawing.Size(50, 25);
            this.lblEmpHourlyWage.TabIndex = 7;
            this.lblEmpHourlyWage.Text = "0.00";
            // 
            // lblEmpContract
            // 
            this.lblEmpContract.AutoSize = true;
            this.lblEmpContract.Location = new System.Drawing.Point(161, 189);
            this.lblEmpContract.Name = "lblEmpContract";
            this.lblEmpContract.Size = new System.Drawing.Size(19, 25);
            this.lblEmpContract.TabIndex = 6;
            this.lblEmpContract.Text = "-";
            // 
            // lblEmpPosition
            // 
            this.lblEmpPosition.AutoSize = true;
            this.lblEmpPosition.Location = new System.Drawing.Point(161, 112);
            this.lblEmpPosition.Name = "lblEmpPosition";
            this.lblEmpPosition.Size = new System.Drawing.Size(19, 25);
            this.lblEmpPosition.TabIndex = 5;
            this.lblEmpPosition.Text = "-";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(161, 77);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(19, 25);
            this.lblEmpId.TabIndex = 4;
            this.lblEmpId.Text = "-";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(11, 235);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(126, 25);
            this.lblHourlyWage.TabIndex = 3;
            this.lblHourlyWage.Text = "Hourly wage:";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(11, 189);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(92, 25);
            this.lblContract.TabIndex = 2;
            this.lblContract.Text = "Contract:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(16, 112);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 25);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 77);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(34, 25);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id:";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 22;
            this.lbxEmployees.Location = new System.Drawing.Point(764, 39);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(318, 158);
            this.lbxEmployees.TabIndex = 13;
            // 
            // txbEmployees
            // 
            this.txbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbEmployees.Location = new System.Drawing.Point(400, 53);
            this.txbEmployees.Name = "txbEmployees";
            this.txbEmployees.Size = new System.Drawing.Size(299, 28);
            this.txbEmployees.TabIndex = 12;
            this.txbEmployees.TextChanged += new System.EventHandler(this.txbEmployees_TextChanged);
            // 
            // dtpTimePeriod
            // 
            this.dtpTimePeriod.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Location = new System.Drawing.Point(40, 53);
            this.dtpTimePeriod.Name = "dtpTimePeriod";
            this.dtpTimePeriod.Size = new System.Drawing.Size(299, 28);
            this.dtpTimePeriod.TabIndex = 9;
            this.dtpTimePeriod.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            this.dtpTimePeriod.ValueChanged += new System.EventHandler(this.dtpTimePeriod_ValueChanged);
            // 
            // lblPeriodOfTime
            // 
            this.lblPeriodOfTime.AutoSize = true;
            this.lblPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriodOfTime.Location = new System.Drawing.Point(119, 26);
            this.lblPeriodOfTime.Name = "lblPeriodOfTime";
            this.lblPeriodOfTime.Size = new System.Drawing.Size(122, 24);
            this.lblPeriodOfTime.TabIndex = 8;
            this.lblPeriodOfTime.Text = "Choose date:";
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStatistics.Location = new System.Drawing.Point(447, 122);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(211, 35);
            this.btnShowStatistics.TabIndex = 2;
            this.btnShowStatistics.Text = "Show statistics";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // lblChooseAnEmployee
            // 
            this.lblChooseAnEmployee.AutoSize = true;
            this.lblChooseAnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseAnEmployee.Location = new System.Drawing.Point(452, 26);
            this.lblChooseAnEmployee.Name = "lblChooseAnEmployee";
            this.lblChooseAnEmployee.Size = new System.Drawing.Size(196, 24);
            this.lblChooseAnEmployee.TabIndex = 0;
            this.lblChooseAnEmployee.Text = "Choose an employee:";
            // 
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbcEmployeeStatistics);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(1130, 785);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            this.tbcEmployeeStatistics.ResumeLayout(false);
            this.tbpAllEmployees.ResumeLayout(false);
            this.tbpAllEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.tbpSpecificEmployee.ResumeLayout(false);
            this.tbpSpecificEmployee.PerformLayout();
            this.gbxChart.ResumeLayout(false);
            this.gbxChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartutilizationOfAnEmployee)).EndInit();
            this.gbxEmpInformation.ResumeLayout(false);
            this.gbxEmpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcEmployeeStatistics;
        private System.Windows.Forms.TabPage tbpAllEmployees;
        private System.Windows.Forms.TabPage tbpSpecificEmployee;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblChooseAnEmployee;
        private System.Windows.Forms.Label lblPeriodOfTime;
        private System.Windows.Forms.DateTimePicker dtpTimePeriod;
        private System.Windows.Forms.TextBox txbEmployees;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.DateTimePicker dtDateStatistic;
        private System.Windows.Forms.ComboBox cbbAllKindsOfStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.GroupBox gbxEmpInformation;
        private System.Windows.Forms.Label lblEmpHourlyWage;
        private System.Windows.Forms.Label lblEmpContract;
        private System.Windows.Forms.Label lblEmpPosition;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartutilizationOfAnEmployee;
        private System.Windows.Forms.Label lblTotalSalaryPerYear;
        private System.Windows.Forms.Label lblTotalSalaryPerDay;
        private System.Windows.Forms.Label lblTotalSalaryPerWeek;
        private System.Windows.Forms.Label lblTotalSalaryPerMonth;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label lblEmpNames;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.RadioButton rdbtnDay;
        private System.Windows.Forms.RadioButton rdbtnWeek;
        private System.Windows.Forms.RadioButton rdbtnMonth;
        private System.Windows.Forms.RadioButton rdbtnYear;
        private System.Windows.Forms.GroupBox gbxChart;
        private System.Windows.Forms.Label lblFilterByContract;
        private System.Windows.Forms.ComboBox cbbFilterByContract;
        private System.Windows.Forms.ComboBox cbbFilterByPosition;
        private System.Windows.Forms.Label lblFilterByPosition;
    }
}
