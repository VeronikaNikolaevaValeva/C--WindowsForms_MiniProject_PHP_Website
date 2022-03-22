
namespace MediaBazaar
{
    partial class ManageEmployeeInterface
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
            this.tcManageEmployee = new System.Windows.Forms.TabControl();
            this.tpAllEmployees = new System.Windows.Forms.TabPage();
            this.rbtnActiveEmployees = new System.Windows.Forms.RadioButton();
            this.rbtnFiredEmployees = new System.Windows.Forms.RadioButton();
            this.rbtnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lbxViewEmployees = new System.Windows.Forms.ListBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.lblRegister = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.cbxTypeOfEmployee = new System.Windows.Forms.ComboBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.tbxTown = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.tbxHouseNumber = new System.Windows.Forms.TextBox();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbxContractType = new System.Windows.Forms.ComboBox();
            this.lblContractType = new System.Windows.Forms.Label();
            this.lblTypeOfEmployee = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblBankAccNum = new System.Windows.Forms.Label();
            this.lblEmTelNum = new System.Windows.Forms.Label();
            this.lblBSN = new System.Windows.Forms.Label();
            this.dtpDateFWD = new System.Windows.Forms.DateTimePicker();
            this.lblDateFWD = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbxHourlyWage = new System.Windows.Forms.TextBox();
            this.tbxBankAccNum = new System.Windows.Forms.TextBox();
            this.tbxEmTelNum = new System.Windows.Forms.TextBox();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxLName = new System.Windows.Forms.TextBox();
            this.tbxFName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tpChangeCOntract = new System.Windows.Forms.TabPage();
            this.lblChooseEmployee = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lbxDisplayEMployees = new System.Windows.Forms.ListBox();
            this.tcManageEmployee.SuspendLayout();
            this.tpAllEmployees.SuspendLayout();
            this.tpRegister.SuspendLayout();
            this.tpChangeCOntract.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManageEmployee
            // 
            this.tcManageEmployee.Controls.Add(this.tpAllEmployees);
            this.tcManageEmployee.Controls.Add(this.tpRegister);
            this.tcManageEmployee.Controls.Add(this.tpChangeCOntract);
            this.tcManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcManageEmployee.Location = new System.Drawing.Point(3, 14);
            this.tcManageEmployee.Name = "tcManageEmployee";
            this.tcManageEmployee.SelectedIndex = 0;
            this.tcManageEmployee.Size = new System.Drawing.Size(1115, 730);
            this.tcManageEmployee.TabIndex = 2;
            // 
            // tpAllEmployees
            // 
            this.tpAllEmployees.BackColor = System.Drawing.Color.LightBlue;
            this.tpAllEmployees.Controls.Add(this.rbtnActiveEmployees);
            this.tpAllEmployees.Controls.Add(this.rbtnFiredEmployees);
            this.tpAllEmployees.Controls.Add(this.rbtnAllEmployees);
            this.tpAllEmployees.Controls.Add(this.btnEditEmployee);
            this.tpAllEmployees.Controls.Add(this.label1);
            this.tpAllEmployees.Controls.Add(this.tbSearch);
            this.tpAllEmployees.Controls.Add(this.btnFullInfo);
            this.tpAllEmployees.Controls.Add(this.btnRemoveEmployee);
            this.tpAllEmployees.Controls.Add(this.lbxViewEmployees);
            this.tpAllEmployees.Controls.Add(this.lblEmployees);
            this.tpAllEmployees.Location = new System.Drawing.Point(4, 31);
            this.tpAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllEmployees.Name = "tpAllEmployees";
            this.tpAllEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAllEmployees.Size = new System.Drawing.Size(1107, 695);
            this.tpAllEmployees.TabIndex = 2;
            this.tpAllEmployees.Text = "View Employees";
            // 
            // rbtnActiveEmployees
            // 
            this.rbtnActiveEmployees.AutoSize = true;
            this.rbtnActiveEmployees.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnActiveEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnActiveEmployees.Location = new System.Drawing.Point(875, 141);
            this.rbtnActiveEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnActiveEmployees.Name = "rbtnActiveEmployees";
            this.rbtnActiveEmployees.Size = new System.Drawing.Size(51, 38);
            this.rbtnActiveEmployees.TabIndex = 88;
            this.rbtnActiveEmployees.TabStop = true;
            this.rbtnActiveEmployees.Text = "Active";
            this.rbtnActiveEmployees.UseVisualStyleBackColor = true;
            this.rbtnActiveEmployees.CheckedChanged += new System.EventHandler(this.rbtnActiveEmployees_CheckedChanged);
            // 
            // rbtnFiredEmployees
            // 
            this.rbtnFiredEmployees.AutoSize = true;
            this.rbtnFiredEmployees.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnFiredEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnFiredEmployees.Location = new System.Drawing.Point(997, 141);
            this.rbtnFiredEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFiredEmployees.Name = "rbtnFiredEmployees";
            this.rbtnFiredEmployees.Size = new System.Drawing.Size(36, 38);
            this.rbtnFiredEmployees.TabIndex = 87;
            this.rbtnFiredEmployees.TabStop = true;
            this.rbtnFiredEmployees.Text = "Left";
            this.rbtnFiredEmployees.UseVisualStyleBackColor = true;
            this.rbtnFiredEmployees.CheckedChanged += new System.EventHandler(this.rbtnFiredEmployees_CheckedChanged);
            // 
            // rbtnAllEmployees
            // 
            this.rbtnAllEmployees.AutoSize = true;
            this.rbtnAllEmployees.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnAllEmployees.Location = new System.Drawing.Point(782, 141);
            this.rbtnAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnAllEmployees.Name = "rbtnAllEmployees";
            this.rbtnAllEmployees.Size = new System.Drawing.Size(27, 38);
            this.rbtnAllEmployees.TabIndex = 86;
            this.rbtnAllEmployees.TabStop = true;
            this.rbtnAllEmployees.Text = "All";
            this.rbtnAllEmployees.UseVisualStyleBackColor = true;
            this.rbtnAllEmployees.CheckedChanged += new System.EventHandler(this.rbtnAllEmployees_CheckedChanged);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.Location = new System.Drawing.Point(782, 435);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(260, 63);
            this.btnEditEmployee.TabIndex = 85;
            this.btnEditEmployee.Text = "Edit personal information";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(257, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "🔍";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(39, 90);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(260, 28);
            this.tbSearch.TabIndex = 83;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnFullInfo
            // 
            this.btnFullInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFullInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullInfo.Location = new System.Drawing.Point(782, 272);
            this.btnFullInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFullInfo.Name = "btnFullInfo";
            this.btnFullInfo.Size = new System.Drawing.Size(260, 63);
            this.btnFullInfo.TabIndex = 82;
            this.btnFullInfo.Text = "View full information";
            this.btnFullInfo.UseVisualStyleBackColor = false;
            this.btnFullInfo.Click += new System.EventHandler(this.btnFullInfo_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(782, 607);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(260, 63);
            this.btnRemoveEmployee.TabIndex = 80;
            this.btnRemoveEmployee.Text = "Remove an employee\r\n/Only when necessary/";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // lbxViewEmployees
            // 
            this.lbxViewEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxViewEmployees.FormattingEnabled = true;
            this.lbxViewEmployees.HorizontalScrollbar = true;
            this.lbxViewEmployees.ItemHeight = 18;
            this.lbxViewEmployees.Location = new System.Drawing.Point(39, 138);
            this.lbxViewEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxViewEmployees.Name = "lbxViewEmployees";
            this.lbxViewEmployees.Size = new System.Drawing.Size(668, 526);
            this.lbxViewEmployees.TabIndex = 2;
            // 
            // lblEmployees
            // 
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEmployees.Location = new System.Drawing.Point(6, 31);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(1095, 31);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Employees";
            this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpRegister
            // 
            this.tpRegister.AutoScroll = true;
            this.tpRegister.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpRegister.Controls.Add(this.lblRegister);
            this.tpRegister.Controls.Add(this.cbxGender);
            this.tpRegister.Controls.Add(this.lblGender);
            this.tpRegister.Controls.Add(this.tbxUsername);
            this.tpRegister.Controls.Add(this.lblUsername);
            this.tpRegister.Controls.Add(this.tbxZipCode);
            this.tpRegister.Controls.Add(this.lblZipCode);
            this.tpRegister.Controls.Add(this.cbxTypeOfEmployee);
            this.tpRegister.Controls.Add(this.tbxCountry);
            this.tpRegister.Controls.Add(this.tbxTown);
            this.tpRegister.Controls.Add(this.lblCountry);
            this.tpRegister.Controls.Add(this.lblTown);
            this.tpRegister.Controls.Add(this.tbxHouseNumber);
            this.tpRegister.Controls.Add(this.lblHouseNumber);
            this.tpRegister.Controls.Add(this.btnRegister);
            this.tpRegister.Controls.Add(this.cbxContractType);
            this.tpRegister.Controls.Add(this.lblContractType);
            this.tpRegister.Controls.Add(this.lblTypeOfEmployee);
            this.tpRegister.Controls.Add(this.lblHourlyWage);
            this.tpRegister.Controls.Add(this.lblBankAccNum);
            this.tpRegister.Controls.Add(this.lblEmTelNum);
            this.tpRegister.Controls.Add(this.lblBSN);
            this.tpRegister.Controls.Add(this.dtpDateFWD);
            this.tpRegister.Controls.Add(this.lblDateFWD);
            this.tpRegister.Controls.Add(this.dtpDateOfBirth);
            this.tpRegister.Controls.Add(this.lblDateOBirth);
            this.tpRegister.Controls.Add(this.lblEmail);
            this.tpRegister.Controls.Add(this.lblStreet);
            this.tpRegister.Controls.Add(this.tbxHourlyWage);
            this.tpRegister.Controls.Add(this.tbxBankAccNum);
            this.tpRegister.Controls.Add(this.tbxEmTelNum);
            this.tpRegister.Controls.Add(this.tbxBSN);
            this.tpRegister.Controls.Add(this.tbxEmail);
            this.tpRegister.Controls.Add(this.tbxStreet);
            this.tpRegister.Controls.Add(this.tbxLName);
            this.tpRegister.Controls.Add(this.tbxFName);
            this.tpRegister.Controls.Add(this.lblLName);
            this.tpRegister.Controls.Add(this.lblFName);
            this.tpRegister.Location = new System.Drawing.Point(4, 31);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRegister.Size = new System.Drawing.Size(1107, 695);
            this.tpRegister.TabIndex = 0;
            this.tpRegister.Text = "Register";
            // 
            // lblRegister
            // 
            this.lblRegister.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(6, 31);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(1095, 31);
            this.lblRegister.TabIndex = 94;
            this.lblRegister.Text = "Register an employee";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.cbxGender.Location = new System.Drawing.Point(35, 285);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(249, 30);
            this.cbxGender.TabIndex = 93;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(34, 257);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(249, 24);
            this.lblGender.TabIndex = 92;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(34, 343);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(249, 28);
            this.tbxUsername.TabIndex = 90;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(34, 317);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(249, 24);
            this.lblUsername.TabIndex = 89;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(431, 286);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(249, 28);
            this.tbxZipCode.TabIndex = 88;
            // 
            // lblZipCode
            // 
            this.lblZipCode.Location = new System.Drawing.Point(431, 259);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(249, 24);
            this.lblZipCode.TabIndex = 87;
            this.lblZipCode.Text = "Zip code:";
            this.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTypeOfEmployee
            // 
            this.cbxTypeOfEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeOfEmployee.FormattingEnabled = true;
            this.cbxTypeOfEmployee.Items.AddRange(new object[] {
            "CASHIER",
            "STORE_WORKER",
            "STOCK_WORKER",
            "DEPARTMENT_MANAGER",
            "STORE_MANAGER",
            "STOCK_MANAGER",
            "HR"});
            this.cbxTypeOfEmployee.Location = new System.Drawing.Point(824, 401);
            this.cbxTypeOfEmployee.Name = "cbxTypeOfEmployee";
            this.cbxTypeOfEmployee.Size = new System.Drawing.Size(249, 30);
            this.cbxTypeOfEmployee.TabIndex = 86;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(431, 400);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(249, 28);
            this.tbxCountry.TabIndex = 85;
            // 
            // tbxTown
            // 
            this.tbxTown.Location = new System.Drawing.Point(431, 344);
            this.tbxTown.Name = "tbxTown";
            this.tbxTown.Size = new System.Drawing.Size(249, 28);
            this.tbxTown.TabIndex = 84;
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(431, 375);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(249, 24);
            this.lblCountry.TabIndex = 83;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTown
            // 
            this.lblTown.Location = new System.Drawing.Point(431, 317);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(249, 24);
            this.lblTown.TabIndex = 82;
            this.lblTown.Text = "Town:";
            this.lblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHouseNumber
            // 
            this.tbxHouseNumber.Location = new System.Drawing.Point(431, 226);
            this.tbxHouseNumber.Name = "tbxHouseNumber";
            this.tbxHouseNumber.Size = new System.Drawing.Size(249, 28);
            this.tbxHouseNumber.TabIndex = 81;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.Location = new System.Drawing.Point(431, 202);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(249, 24);
            this.lblHouseNumber.TabIndex = 80;
            this.lblHouseNumber.Text = "House number:";
            this.lblHouseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(385, 586);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(344, 51);
            this.btnRegister.TabIndex = 79;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbxContractType
            // 
            this.cbxContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContractType.FormattingEnabled = true;
            this.cbxContractType.Items.AddRange(new object[] {
            "FULLTIME",
            "EIGHTYPERCENT",
            "FLEX",
            "LEFT"});
            this.cbxContractType.Location = new System.Drawing.Point(824, 459);
            this.cbxContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxContractType.Name = "cbxContractType";
            this.cbxContractType.Size = new System.Drawing.Size(249, 30);
            this.cbxContractType.TabIndex = 39;
            // 
            // lblContractType
            // 
            this.lblContractType.Location = new System.Drawing.Point(823, 432);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(249, 24);
            this.lblContractType.TabIndex = 38;
            this.lblContractType.Text = "Contract type:";
            this.lblContractType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeOfEmployee
            // 
            this.lblTypeOfEmployee.Location = new System.Drawing.Point(823, 373);
            this.lblTypeOfEmployee.Name = "lblTypeOfEmployee";
            this.lblTypeOfEmployee.Size = new System.Drawing.Size(249, 24);
            this.lblTypeOfEmployee.TabIndex = 34;
            this.lblTypeOfEmployee.Text = "Position:";
            this.lblTypeOfEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.Location = new System.Drawing.Point(823, 144);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(249, 24);
            this.lblHourlyWage.TabIndex = 32;
            this.lblHourlyWage.Text = "Hourly wage:";
            this.lblHourlyWage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankAccNum
            // 
            this.lblBankAccNum.Location = new System.Drawing.Point(431, 434);
            this.lblBankAccNum.Name = "lblBankAccNum";
            this.lblBankAccNum.Size = new System.Drawing.Size(249, 24);
            this.lblBankAccNum.TabIndex = 31;
            this.lblBankAccNum.Text = "Bank account number:";
            this.lblBankAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmTelNum
            // 
            this.lblEmTelNum.Location = new System.Drawing.Point(34, 431);
            this.lblEmTelNum.Name = "lblEmTelNum";
            this.lblEmTelNum.Size = new System.Drawing.Size(249, 24);
            this.lblEmTelNum.TabIndex = 30;
            this.lblEmTelNum.Text = "Telephone number:";
            this.lblEmTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBSN
            // 
            this.lblBSN.Location = new System.Drawing.Point(34, 373);
            this.lblBSN.Name = "lblBSN";
            this.lblBSN.Size = new System.Drawing.Size(249, 24);
            this.lblBSN.TabIndex = 29;
            this.lblBSN.Text = "BSN:";
            this.lblBSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateFWD
            // 
            this.dtpDateFWD.Location = new System.Drawing.Point(823, 342);
            this.dtpDateFWD.Name = "dtpDateFWD";
            this.dtpDateFWD.Size = new System.Drawing.Size(249, 28);
            this.dtpDateFWD.TabIndex = 28;
            // 
            // lblDateFWD
            // 
            this.lblDateFWD.Location = new System.Drawing.Point(823, 315);
            this.lblDateFWD.Name = "lblDateFWD";
            this.lblDateFWD.Size = new System.Drawing.Size(249, 24);
            this.lblDateFWD.TabIndex = 27;
            this.lblDateFWD.Text = "Date of first working day:";
            this.lblDateFWD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(823, 283);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(249, 28);
            this.dtpDateOfBirth.TabIndex = 26;
            // 
            // lblDateOBirth
            // 
            this.lblDateOBirth.Location = new System.Drawing.Point(823, 260);
            this.lblDateOBirth.Name = "lblDateOBirth";
            this.lblDateOBirth.Size = new System.Drawing.Size(249, 24);
            this.lblDateOBirth.TabIndex = 25;
            this.lblDateOBirth.Text = "Date of birth:";
            this.lblDateOBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(823, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(249, 24);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreet
            // 
            this.lblStreet.Location = new System.Drawing.Point(431, 144);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(249, 24);
            this.lblStreet.TabIndex = 23;
            this.lblStreet.Text = "Street:";
            this.lblStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHourlyWage
            // 
            this.tbxHourlyWage.Location = new System.Drawing.Point(823, 171);
            this.tbxHourlyWage.Name = "tbxHourlyWage";
            this.tbxHourlyWage.Size = new System.Drawing.Size(249, 28);
            this.tbxHourlyWage.TabIndex = 22;
            // 
            // tbxBankAccNum
            // 
            this.tbxBankAccNum.Location = new System.Drawing.Point(431, 458);
            this.tbxBankAccNum.Name = "tbxBankAccNum";
            this.tbxBankAccNum.Size = new System.Drawing.Size(249, 28);
            this.tbxBankAccNum.TabIndex = 21;
            // 
            // tbxEmTelNum
            // 
            this.tbxEmTelNum.Location = new System.Drawing.Point(34, 458);
            this.tbxEmTelNum.Name = "tbxEmTelNum";
            this.tbxEmTelNum.Size = new System.Drawing.Size(249, 28);
            this.tbxEmTelNum.TabIndex = 20;
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(34, 400);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(249, 28);
            this.tbxBSN.TabIndex = 19;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(823, 229);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(249, 28);
            this.tbxEmail.TabIndex = 16;
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(431, 171);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(249, 28);
            this.tbxStreet.TabIndex = 15;
            // 
            // tbxLName
            // 
            this.tbxLName.Location = new System.Drawing.Point(34, 226);
            this.tbxLName.Name = "tbxLName";
            this.tbxLName.Size = new System.Drawing.Size(249, 28);
            this.tbxLName.TabIndex = 14;
            // 
            // tbxFName
            // 
            this.tbxFName.Location = new System.Drawing.Point(34, 171);
            this.tbxFName.Name = "tbxFName";
            this.tbxFName.Size = new System.Drawing.Size(249, 28);
            this.tbxFName.TabIndex = 2;
            // 
            // lblLName
            // 
            this.lblLName.Location = new System.Drawing.Point(34, 202);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(249, 24);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name:";
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFName
            // 
            this.lblFName.Location = new System.Drawing.Point(34, 144);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(249, 24);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpChangeCOntract
            // 
            this.tpChangeCOntract.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpChangeCOntract.Controls.Add(this.lblChooseEmployee);
            this.tpChangeCOntract.Controls.Add(this.btnViewDetails);
            this.tpChangeCOntract.Controls.Add(this.lbxDisplayEMployees);
            this.tpChangeCOntract.Location = new System.Drawing.Point(4, 31);
            this.tpChangeCOntract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpChangeCOntract.Name = "tpChangeCOntract";
            this.tpChangeCOntract.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpChangeCOntract.Size = new System.Drawing.Size(1107, 695);
            this.tpChangeCOntract.TabIndex = 1;
            this.tpChangeCOntract.Text = "Change contract";
            // 
            // lblChooseEmployee
            // 
            this.lblChooseEmployee.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblChooseEmployee.Location = new System.Drawing.Point(9, 31);
            this.lblChooseEmployee.Name = "lblChooseEmployee";
            this.lblChooseEmployee.Size = new System.Drawing.Size(1095, 31);
            this.lblChooseEmployee.TabIndex = 79;
            this.lblChooseEmployee.Text = "Choose an employee";
            this.lblChooseEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.Location = new System.Drawing.Point(385, 586);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(344, 51);
            this.btnViewDetails.TabIndex = 78;
            this.btnViewDetails.Text = "Continue";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lbxDisplayEMployees
            // 
            this.lbxDisplayEMployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxDisplayEMployees.FormattingEnabled = true;
            this.lbxDisplayEMployees.ItemHeight = 20;
            this.lbxDisplayEMployees.Location = new System.Drawing.Point(6, 104);
            this.lbxDisplayEMployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxDisplayEMployees.Name = "lbxDisplayEMployees";
            this.lbxDisplayEMployees.Size = new System.Drawing.Size(1096, 444);
            this.lbxDisplayEMployees.TabIndex = 0;
            // 
            // ManageEmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcManageEmployee);
            this.Name = "ManageEmployeeInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.Load += new System.EventHandler(this.ManageEmployeeInterface_Load);
            this.tcManageEmployee.ResumeLayout(false);
            this.tpAllEmployees.ResumeLayout(false);
            this.tpAllEmployees.PerformLayout();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            this.tpChangeCOntract.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManageEmployee;
        private System.Windows.Forms.TabPage tpAllEmployees;
        private System.Windows.Forms.RadioButton rbtnActiveEmployees;
        private System.Windows.Forms.RadioButton rbtnFiredEmployees;
        private System.Windows.Forms.RadioButton rbtnAllEmployees;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnFullInfo;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.ListBox lbxViewEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.ComboBox cbxTypeOfEmployee;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.TextBox tbxTown;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox tbxHouseNumber;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbxContractType;
        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.Label lblTypeOfEmployee;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblBankAccNum;
        private System.Windows.Forms.Label lblEmTelNum;
        private System.Windows.Forms.Label lblBSN;
        private System.Windows.Forms.DateTimePicker dtpDateFWD;
        private System.Windows.Forms.Label lblDateFWD;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox tbxHourlyWage;
        private System.Windows.Forms.TextBox tbxBankAccNum;
        private System.Windows.Forms.TextBox tbxEmTelNum;
        private System.Windows.Forms.TextBox tbxBSN;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxLName;
        private System.Windows.Forms.TextBox tbxFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TabPage tpChangeCOntract;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ListBox lbxDisplayEMployees;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblChooseEmployee;
    }
}
