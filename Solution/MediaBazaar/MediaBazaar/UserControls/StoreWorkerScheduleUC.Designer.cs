
namespace MediaBazaar
{
    partial class StoreWorkerScheduleInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcStoreWorkerSchedule = new System.Windows.Forms.TabControl();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.pnlDisplayAssignedEmployees = new System.Windows.Forms.Panel();
            this.btnEditShift = new System.Windows.Forms.Button();
            this.btnClosePanelAssignedEmployees = new System.Windows.Forms.Button();
            this.lbxAssignedEmployees = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSelectedWeek = new System.Windows.Forms.Panel();
            this.lblSelectedWeekAndDepartment = new System.Windows.Forms.Label();
            this.pnlManageCreatedSchedule = new System.Windows.Forms.Panel();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlEditShift = new System.Windows.Forms.Panel();
            this.lbxAvailableEmployeesForShift = new System.Windows.Forms.ListView();
            this.availableEmployees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeMaxAssignableEmployees = new System.Windows.Forms.Button();
            this.tbMaxAssignableEmployees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnCloseEditMode = new System.Windows.Forms.Button();
            this.lbxAssignedEmployeesToShift = new System.Windows.Forms.ListBox();
            this.lblSelectedShift = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.dgvViewGeneratedSchedule = new System.Windows.Forms.DataGridView();
            this.clMorningSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAfternoonSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEveningSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNightSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGenerateSchedule = new System.Windows.Forms.Panel();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.monthCalendarAutoSchedule = new System.Windows.Forms.MonthCalendar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.tcStoreWorkerSchedule.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.pnlDisplayAssignedEmployees.SuspendLayout();
            this.pnlSelectedWeek.SuspendLayout();
            this.pnlManageCreatedSchedule.SuspendLayout();
            this.pnlEditShift.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewGeneratedSchedule)).BeginInit();
            this.pnlGenerateSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStoreWorkerSchedule
            // 
            this.tcStoreWorkerSchedule.Controls.Add(this.tpSchedule);
            this.tcStoreWorkerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcStoreWorkerSchedule.Location = new System.Drawing.Point(6, 2);
            this.tcStoreWorkerSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcStoreWorkerSchedule.Name = "tcStoreWorkerSchedule";
            this.tcStoreWorkerSchedule.SelectedIndex = 0;
            this.tcStoreWorkerSchedule.Size = new System.Drawing.Size(1123, 809);
            this.tcStoreWorkerSchedule.TabIndex = 4;
            // 
            // tpSchedule
            // 
            this.tpSchedule.BackColor = System.Drawing.Color.Azure;
            this.tpSchedule.Controls.Add(this.pnlDisplayAssignedEmployees);
            this.tpSchedule.Controls.Add(this.pnlSelectedWeek);
            this.tpSchedule.Controls.Add(this.pnlEditShift);
            this.tpSchedule.Controls.Add(this.pnlSchedule);
            this.tpSchedule.Controls.Add(this.pnlGenerateSchedule);
            this.tpSchedule.Location = new System.Drawing.Point(4, 34);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Size = new System.Drawing.Size(1115, 771);
            this.tpSchedule.TabIndex = 3;
            this.tpSchedule.Text = "Schedule";
            // 
            // pnlDisplayAssignedEmployees
            // 
            this.pnlDisplayAssignedEmployees.Controls.Add(this.btnEditShift);
            this.pnlDisplayAssignedEmployees.Controls.Add(this.btnClosePanelAssignedEmployees);
            this.pnlDisplayAssignedEmployees.Controls.Add(this.lbxAssignedEmployees);
            this.pnlDisplayAssignedEmployees.Controls.Add(this.label3);
            this.pnlDisplayAssignedEmployees.Location = new System.Drawing.Point(278, 150);
            this.pnlDisplayAssignedEmployees.Name = "pnlDisplayAssignedEmployees";
            this.pnlDisplayAssignedEmployees.Size = new System.Drawing.Size(558, 470);
            this.pnlDisplayAssignedEmployees.TabIndex = 115;
            this.pnlDisplayAssignedEmployees.Visible = false;
            // 
            // btnEditShift
            // 
            this.btnEditShift.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditShift.Location = new System.Drawing.Point(163, 400);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(240, 46);
            this.btnEditShift.TabIndex = 3;
            this.btnEditShift.Text = "Edit Shift";
            this.btnEditShift.UseVisualStyleBackColor = false;
            this.btnEditShift.Click += new System.EventHandler(this.btnEditShift_Click_1);
            // 
            // btnClosePanelAssignedEmployees
            // 
            this.btnClosePanelAssignedEmployees.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClosePanelAssignedEmployees.Location = new System.Drawing.Point(466, 15);
            this.btnClosePanelAssignedEmployees.Name = "btnClosePanelAssignedEmployees";
            this.btnClosePanelAssignedEmployees.Size = new System.Drawing.Size(75, 46);
            this.btnClosePanelAssignedEmployees.TabIndex = 2;
            this.btnClosePanelAssignedEmployees.Text = "X";
            this.btnClosePanelAssignedEmployees.UseVisualStyleBackColor = false;
            this.btnClosePanelAssignedEmployees.Click += new System.EventHandler(this.btnClosePanelAssignedEmployees_Click_1);
            // 
            // lbxAssignedEmployees
            // 
            this.lbxAssignedEmployees.FormattingEnabled = true;
            this.lbxAssignedEmployees.ItemHeight = 25;
            this.lbxAssignedEmployees.Location = new System.Drawing.Point(20, 78);
            this.lbxAssignedEmployees.Name = "lbxAssignedEmployees";
            this.lbxAssignedEmployees.Size = new System.Drawing.Size(521, 304);
            this.lbxAssignedEmployees.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Assigned Employees";
            // 
            // pnlSelectedWeek
            // 
            this.pnlSelectedWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedWeek.Controls.Add(this.lblSelectedWeekAndDepartment);
            this.pnlSelectedWeek.Controls.Add(this.pnlManageCreatedSchedule);
            this.pnlSelectedWeek.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectedWeek.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectedWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSelectedWeek.Name = "pnlSelectedWeek";
            this.pnlSelectedWeek.Size = new System.Drawing.Size(1115, 91);
            this.pnlSelectedWeek.TabIndex = 99;
            this.pnlSelectedWeek.Visible = false;
            // 
            // lblSelectedWeekAndDepartment
            // 
            this.lblSelectedWeekAndDepartment.AutoSize = true;
            this.lblSelectedWeekAndDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedWeekAndDepartment.Location = new System.Drawing.Point(17, 34);
            this.lblSelectedWeekAndDepartment.Name = "lblSelectedWeekAndDepartment";
            this.lblSelectedWeekAndDepartment.Size = new System.Drawing.Size(64, 25);
            this.lblSelectedWeekAndDepartment.TabIndex = 1;
            this.lblSelectedWeekAndDepartment.Text = "label3";
            // 
            // pnlManageCreatedSchedule
            // 
            this.pnlManageCreatedSchedule.Controls.Add(this.btnDiscard);
            this.pnlManageCreatedSchedule.Controls.Add(this.btnSave);
            this.pnlManageCreatedSchedule.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlManageCreatedSchedule.Location = new System.Drawing.Point(738, 0);
            this.pnlManageCreatedSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlManageCreatedSchedule.Name = "pnlManageCreatedSchedule";
            this.pnlManageCreatedSchedule.Size = new System.Drawing.Size(375, 89);
            this.pnlManageCreatedSchedule.TabIndex = 0;
            // 
            // btnDiscard
            // 
            this.btnDiscard.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscard.Location = new System.Drawing.Point(192, 25);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(178, 43);
            this.btnDiscard.TabIndex = 95;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(8, 25);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 43);
            this.btnSave.TabIndex = 94;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlEditShift
            // 
            this.pnlEditShift.Controls.Add(this.lbxAvailableEmployeesForShift);
            this.pnlEditShift.Controls.Add(this.groupBox1);
            this.pnlEditShift.Controls.Add(this.label6);
            this.pnlEditShift.Controls.Add(this.label5);
            this.pnlEditShift.Controls.Add(this.btnAssignEmployee);
            this.pnlEditShift.Controls.Add(this.btnRemoveEmployee);
            this.pnlEditShift.Controls.Add(this.btnCloseEditMode);
            this.pnlEditShift.Controls.Add(this.lbxAssignedEmployeesToShift);
            this.pnlEditShift.Controls.Add(this.lblSelectedShift);
            this.pnlEditShift.Location = new System.Drawing.Point(3, 95);
            this.pnlEditShift.Name = "pnlEditShift";
            this.pnlEditShift.Size = new System.Drawing.Size(1106, 670);
            this.pnlEditShift.TabIndex = 117;
            this.pnlEditShift.Visible = false;
            // 
            // lbxAvailableEmployeesForShift
            // 
            this.lbxAvailableEmployeesForShift.AutoArrange = false;
            this.lbxAvailableEmployeesForShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.availableEmployees});
            this.lbxAvailableEmployeesForShift.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lbxAvailableEmployeesForShift.HideSelection = false;
            this.lbxAvailableEmployeesForShift.Location = new System.Drawing.Point(17, 315);
            this.lbxAvailableEmployeesForShift.MultiSelect = false;
            this.lbxAvailableEmployeesForShift.Name = "lbxAvailableEmployeesForShift";
            this.lbxAvailableEmployeesForShift.Size = new System.Drawing.Size(813, 204);
            this.lbxAvailableEmployeesForShift.TabIndex = 96;
            this.lbxAvailableEmployeesForShift.UseCompatibleStateImageBehavior = false;
            this.lbxAvailableEmployeesForShift.View = System.Windows.Forms.View.Details;
            // 
            // availableEmployees
            // 
            this.availableEmployees.Text = "";
            this.availableEmployees.Width = 2000;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeMaxAssignableEmployees);
            this.groupBox1.Controls.Add(this.tbMaxAssignableEmployees);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(20, 524);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(813, 112);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // btnChangeMaxAssignableEmployees
            // 
            this.btnChangeMaxAssignableEmployees.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnChangeMaxAssignableEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMaxAssignableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeMaxAssignableEmployees.Location = new System.Drawing.Point(571, 32);
            this.btnChangeMaxAssignableEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeMaxAssignableEmployees.Name = "btnChangeMaxAssignableEmployees";
            this.btnChangeMaxAssignableEmployees.Size = new System.Drawing.Size(175, 50);
            this.btnChangeMaxAssignableEmployees.TabIndex = 95;
            this.btnChangeMaxAssignableEmployees.Text = "Change";
            this.btnChangeMaxAssignableEmployees.UseVisualStyleBackColor = false;
            this.btnChangeMaxAssignableEmployees.Click += new System.EventHandler(this.btnChangeMaxAssignableEmployees_Click);
            // 
            // tbMaxAssignableEmployees
            // 
            this.tbMaxAssignableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxAssignableEmployees.Location = new System.Drawing.Point(350, 47);
            this.tbMaxAssignableEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaxAssignableEmployees.Name = "tbMaxAssignableEmployees";
            this.tbMaxAssignableEmployees.Size = new System.Drawing.Size(145, 27);
            this.tbMaxAssignableEmployees.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Maximum employees per shift:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Available Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Assigned Employees";
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAssignEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssignEmployee.Location = new System.Drawing.Point(900, 411);
            this.btnAssignEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(115, 54);
            this.btnAssignEmployee.TabIndex = 82;
            this.btnAssignEmployee.Text = "Assign";
            this.btnAssignEmployee.UseVisualStyleBackColor = false;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click_1);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(900, 166);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(115, 54);
            this.btnRemoveEmployee.TabIndex = 81;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnCloseEditMode
            // 
            this.btnCloseEditMode.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCloseEditMode.Location = new System.Drawing.Point(1011, 18);
            this.btnCloseEditMode.Name = "btnCloseEditMode";
            this.btnCloseEditMode.Size = new System.Drawing.Size(75, 46);
            this.btnCloseEditMode.TabIndex = 2;
            this.btnCloseEditMode.Text = "X";
            this.btnCloseEditMode.UseVisualStyleBackColor = false;
            this.btnCloseEditMode.Click += new System.EventHandler(this.btnCloseEditMode_Click);
            // 
            // lbxAssignedEmployeesToShift
            // 
            this.lbxAssignedEmployeesToShift.FormattingEnabled = true;
            this.lbxAssignedEmployeesToShift.ItemHeight = 25;
            this.lbxAssignedEmployeesToShift.Location = new System.Drawing.Point(20, 74);
            this.lbxAssignedEmployeesToShift.Name = "lbxAssignedEmployeesToShift";
            this.lbxAssignedEmployeesToShift.Size = new System.Drawing.Size(813, 204);
            this.lbxAssignedEmployeesToShift.TabIndex = 1;
            // 
            // lblSelectedShift
            // 
            this.lblSelectedShift.AutoSize = true;
            this.lblSelectedShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedShift.Location = new System.Drawing.Point(486, 10);
            this.lblSelectedShift.Name = "lblSelectedShift";
            this.lblSelectedShift.Size = new System.Drawing.Size(162, 29);
            this.lblSelectedShift.TabIndex = 0;
            this.lblSelectedShift.Text = "Selected Shift";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Controls.Add(this.dgvViewGeneratedSchedule);
            this.pnlSchedule.Location = new System.Drawing.Point(3, 95);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(1109, 676);
            this.pnlSchedule.TabIndex = 114;
            this.pnlSchedule.Visible = false;
            // 
            // dgvViewGeneratedSchedule
            // 
            this.dgvViewGeneratedSchedule.AllowUserToAddRows = false;
            this.dgvViewGeneratedSchedule.AllowUserToDeleteRows = false;
            this.dgvViewGeneratedSchedule.AllowUserToResizeColumns = false;
            this.dgvViewGeneratedSchedule.AllowUserToResizeRows = false;
            this.dgvViewGeneratedSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewGeneratedSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewGeneratedSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewGeneratedSchedule.ColumnHeadersHeight = 50;
            this.dgvViewGeneratedSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMorningSchedule,
            this.clAfternoonSchedule,
            this.clEveningSchedule,
            this.clNightSchedule});
            this.dgvViewGeneratedSchedule.GridColor = System.Drawing.Color.White;
            this.dgvViewGeneratedSchedule.Location = new System.Drawing.Point(3, 1);
            this.dgvViewGeneratedSchedule.Name = "dgvViewGeneratedSchedule";
            this.dgvViewGeneratedSchedule.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewGeneratedSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewGeneratedSchedule.RowHeadersWidth = 150;
            this.dgvViewGeneratedSchedule.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvViewGeneratedSchedule.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvViewGeneratedSchedule.RowTemplate.DefaultCellStyle.NullValue = "0 emp. assigned";
            this.dgvViewGeneratedSchedule.RowTemplate.Height = 60;
            this.dgvViewGeneratedSchedule.RowTemplate.ReadOnly = true;
            this.dgvViewGeneratedSchedule.Size = new System.Drawing.Size(1103, 644);
            this.dgvViewGeneratedSchedule.TabIndex = 101;
            this.dgvViewGeneratedSchedule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViewGeneratedSchedule_CellMouseDoubleClick_1);
            // 
            // clMorningSchedule
            // 
            this.clMorningSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMorningSchedule.HeaderText = "Morning";
            this.clMorningSchedule.MinimumWidth = 6;
            this.clMorningSchedule.Name = "clMorningSchedule";
            this.clMorningSchedule.ReadOnly = true;
            // 
            // clAfternoonSchedule
            // 
            this.clAfternoonSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clAfternoonSchedule.HeaderText = "Afternoon";
            this.clAfternoonSchedule.MinimumWidth = 6;
            this.clAfternoonSchedule.Name = "clAfternoonSchedule";
            this.clAfternoonSchedule.ReadOnly = true;
            // 
            // clEveningSchedule
            // 
            this.clEveningSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEveningSchedule.HeaderText = "Evening";
            this.clEveningSchedule.MinimumWidth = 6;
            this.clEveningSchedule.Name = "clEveningSchedule";
            this.clEveningSchedule.ReadOnly = true;
            // 
            // clNightSchedule
            // 
            this.clNightSchedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNightSchedule.HeaderText = "Night";
            this.clNightSchedule.MinimumWidth = 6;
            this.clNightSchedule.Name = "clNightSchedule";
            this.clNightSchedule.ReadOnly = true;
            // 
            // pnlGenerateSchedule
            // 
            this.pnlGenerateSchedule.Controls.Add(this.btnViewSchedule);
            this.pnlGenerateSchedule.Controls.Add(this.picInfo);
            this.pnlGenerateSchedule.Controls.Add(this.lblWeek);
            this.pnlGenerateSchedule.Controls.Add(this.lblDepartment);
            this.pnlGenerateSchedule.Controls.Add(this.cbxDepartment);
            this.pnlGenerateSchedule.Controls.Add(this.monthCalendarAutoSchedule);
            this.pnlGenerateSchedule.Controls.Add(this.lblInfo);
            this.pnlGenerateSchedule.Controls.Add(this.btnGenerateSchedule);
            this.pnlGenerateSchedule.Location = new System.Drawing.Point(3, 95);
            this.pnlGenerateSchedule.Name = "pnlGenerateSchedule";
            this.pnlGenerateSchedule.Size = new System.Drawing.Size(1112, 673);
            this.pnlGenerateSchedule.TabIndex = 105;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewSchedule.Location = new System.Drawing.Point(577, 411);
            this.btnViewSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(253, 59);
            this.btnViewSchedule.TabIndex = 112;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // picInfo
            // 
            this.picInfo.Image = global::MediaBazaar.Properties.Resources.info;
            this.picInfo.Location = new System.Drawing.Point(156, 512);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(50, 46);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo.TabIndex = 111;
            this.picInfo.TabStop = false;
            this.picInfo.MouseLeave += new System.EventHandler(this.picInfo_MouseLeave);
            this.picInfo.MouseHover += new System.EventHandler(this.picInfo_MouseHover_1);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(249, 61);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(75, 25);
            this.lblWeek.TabIndex = 110;
            this.lblWeek.Text = "Week: ";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(249, 305);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(119, 25);
            this.lblDepartment.TabIndex = 109;
            this.lblDepartment.Text = "Department:";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(402, 305);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(377, 33);
            this.cbxDepartment.TabIndex = 108;
            this.cbxDepartment.Click += new System.EventHandler(this.cbxDepartment_Click);
            // 
            // monthCalendarAutoSchedule
            // 
            this.monthCalendarAutoSchedule.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarAutoSchedule.Location = new System.Drawing.Point(425, 61);
            this.monthCalendarAutoSchedule.Name = "monthCalendarAutoSchedule";
            this.monthCalendarAutoSchedule.ShowWeekNumbers = true;
            this.monthCalendarAutoSchedule.TabIndex = 107;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(212, 522);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(633, 25);
            this.lblInfo.TabIndex = 106;
            this.lblInfo.Text = "Select a date and department and the schedule for week will be created:";
            this.lblInfo.Visible = false;
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGenerateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateSchedule.Location = new System.Drawing.Point(295, 411);
            this.btnGenerateSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(253, 59);
            this.btnGenerateSchedule.TabIndex = 105;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = false;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // StoreWorkerScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcStoreWorkerSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoreWorkerScheduleInterface";
            this.Size = new System.Drawing.Size(1129, 812);
            this.tcStoreWorkerSchedule.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.pnlDisplayAssignedEmployees.ResumeLayout(false);
            this.pnlDisplayAssignedEmployees.PerformLayout();
            this.pnlSelectedWeek.ResumeLayout(false);
            this.pnlSelectedWeek.PerformLayout();
            this.pnlManageCreatedSchedule.ResumeLayout(false);
            this.pnlEditShift.ResumeLayout(false);
            this.pnlEditShift.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewGeneratedSchedule)).EndInit();
            this.pnlGenerateSchedule.ResumeLayout(false);
            this.pnlGenerateSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcStoreWorkerSchedule;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.Panel pnlSelectedWeek;
        private System.Windows.Forms.Label lblSelectedWeekAndDepartment;
        private System.Windows.Forms.Panel pnlManageCreatedSchedule;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlGenerateSchedule;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.MonthCalendar monthCalendarAutoSchedule;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Panel pnlDisplayAssignedEmployees;
        private System.Windows.Forms.Button btnEditShift;
        private System.Windows.Forms.Button btnClosePanelAssignedEmployees;
        private System.Windows.Forms.ListBox lbxAssignedEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.DataGridView dgvViewGeneratedSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMorningSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAfternoonSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEveningSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNightSchedule;
        private System.Windows.Forms.Panel pnlEditShift;
        private System.Windows.Forms.ListView lbxAvailableEmployeesForShift;
        private System.Windows.Forms.ColumnHeader availableEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeMaxAssignableEmployees;
        private System.Windows.Forms.TextBox tbMaxAssignableEmployees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAssignEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnCloseEditMode;
        private System.Windows.Forms.ListBox lbxAssignedEmployeesToShift;
        private System.Windows.Forms.Label lblSelectedShift;
    }
}
