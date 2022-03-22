
namespace MediaBazaar.UserControls
{
    partial class HolidayRequestsUC
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
            this.tcHolidays = new System.Windows.Forms.TabControl();
            this.tpManageHolidays = new System.Windows.Forms.TabPage();
            this.gbRequestedHolidays = new System.Windows.Forms.GroupBox();
            this.rbSortByEmployee = new System.Windows.Forms.RadioButton();
            this.btnDenyHolidayRequest = new System.Windows.Forms.Button();
            this.rbSortByRequestedTime = new System.Windows.Forms.RadioButton();
            this.lbRequestedHolidays = new System.Windows.Forms.ListBox();
            this.gbRegisterNewHoliday = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterNewHoliday = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeBsn = new System.Windows.Forms.Label();
            this.tbEmployeeBSN = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tpViewHolidays = new System.Windows.Forms.TabPage();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnDeleteHoliday = new System.Windows.Forms.Button();
            this.lbHolidays = new System.Windows.Forms.ListBox();
            this.tcHolidays.SuspendLayout();
            this.tpManageHolidays.SuspendLayout();
            this.gbRequestedHolidays.SuspendLayout();
            this.gbRegisterNewHoliday.SuspendLayout();
            this.tpViewHolidays.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHolidays
            // 
            this.tcHolidays.Controls.Add(this.tpManageHolidays);
            this.tcHolidays.Controls.Add(this.tpViewHolidays);
            this.tcHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcHolidays.Location = new System.Drawing.Point(7, 7);
            this.tcHolidays.Name = "tcHolidays";
            this.tcHolidays.SelectedIndex = 0;
            this.tcHolidays.Size = new System.Drawing.Size(1115, 775);
            this.tcHolidays.TabIndex = 1;
            this.tcHolidays.SelectedIndexChanged += new System.EventHandler(this.tcHolidays_SelectedIndexChanged);
            // 
            // tpManageHolidays
            // 
            this.tpManageHolidays.BackColor = System.Drawing.Color.Azure;
            this.tpManageHolidays.Controls.Add(this.gbRequestedHolidays);
            this.tpManageHolidays.Controls.Add(this.gbRegisterNewHoliday);
            this.tpManageHolidays.Location = new System.Drawing.Point(4, 29);
            this.tpManageHolidays.Name = "tpManageHolidays";
            this.tpManageHolidays.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageHolidays.Size = new System.Drawing.Size(1107, 742);
            this.tpManageHolidays.TabIndex = 1;
            this.tpManageHolidays.Text = "Manage holidays";
            // 
            // gbRequestedHolidays
            // 
            this.gbRequestedHolidays.Controls.Add(this.rbSortByEmployee);
            this.gbRequestedHolidays.Controls.Add(this.btnDenyHolidayRequest);
            this.gbRequestedHolidays.Controls.Add(this.rbSortByRequestedTime);
            this.gbRequestedHolidays.Controls.Add(this.lbRequestedHolidays);
            this.gbRequestedHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRequestedHolidays.Location = new System.Drawing.Point(39, 33);
            this.gbRequestedHolidays.Name = "gbRequestedHolidays";
            this.gbRequestedHolidays.Size = new System.Drawing.Size(1028, 334);
            this.gbRequestedHolidays.TabIndex = 105;
            this.gbRequestedHolidays.TabStop = false;
            this.gbRequestedHolidays.Text = "Requested Holidays";
            // 
            // rbSortByEmployee
            // 
            this.rbSortByEmployee.AutoSize = true;
            this.rbSortByEmployee.Location = new System.Drawing.Point(265, 37);
            this.rbSortByEmployee.Name = "rbSortByEmployee";
            this.rbSortByEmployee.Size = new System.Drawing.Size(159, 24);
            this.rbSortByEmployee.TabIndex = 98;
            this.rbSortByEmployee.TabStop = true;
            this.rbSortByEmployee.Text = "Sort by employee";
            this.rbSortByEmployee.UseVisualStyleBackColor = true;
            this.rbSortByEmployee.CheckedChanged += new System.EventHandler(this.rbSortByEmployee_CheckedChanged);
            // 
            // btnDenyHolidayRequest
            // 
            this.btnDenyHolidayRequest.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDenyHolidayRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyHolidayRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyHolidayRequest.Location = new System.Drawing.Point(809, 143);
            this.btnDenyHolidayRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDenyHolidayRequest.Name = "btnDenyHolidayRequest";
            this.btnDenyHolidayRequest.Size = new System.Drawing.Size(183, 80);
            this.btnDenyHolidayRequest.TabIndex = 99;
            this.btnDenyHolidayRequest.Text = "Deny holiday request";
            this.btnDenyHolidayRequest.UseVisualStyleBackColor = false;
            this.btnDenyHolidayRequest.Visible = false;
            this.btnDenyHolidayRequest.Click += new System.EventHandler(this.btnDenyHolidayRequest_Click_1);
            // 
            // rbSortByRequestedTime
            // 
            this.rbSortByRequestedTime.AutoSize = true;
            this.rbSortByRequestedTime.Location = new System.Drawing.Point(27, 37);
            this.rbSortByRequestedTime.Name = "rbSortByRequestedTime";
            this.rbSortByRequestedTime.Size = new System.Drawing.Size(199, 24);
            this.rbSortByRequestedTime.TabIndex = 96;
            this.rbSortByRequestedTime.TabStop = true;
            this.rbSortByRequestedTime.Text = "Sort by requested time";
            this.rbSortByRequestedTime.UseVisualStyleBackColor = true;
            this.rbSortByRequestedTime.CheckedChanged += new System.EventHandler(this.rbSortByRequestedTime_CheckedChanged);
            // 
            // lbRequestedHolidays
            // 
            this.lbRequestedHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRequestedHolidays.FormattingEnabled = true;
            this.lbRequestedHolidays.ItemHeight = 20;
            this.lbRequestedHolidays.Location = new System.Drawing.Point(27, 78);
            this.lbRequestedHolidays.Name = "lbRequestedHolidays";
            this.lbRequestedHolidays.Size = new System.Drawing.Size(746, 224);
            this.lbRequestedHolidays.TabIndex = 97;
            this.lbRequestedHolidays.DoubleClick += new System.EventHandler(this.lbRequestedHolidays_DoubleClick);
            // 
            // gbRegisterNewHoliday
            // 
            this.gbRegisterNewHoliday.Controls.Add(this.dtpEndDate);
            this.gbRegisterNewHoliday.Controls.Add(this.btnRegisterNewHoliday);
            this.gbRegisterNewHoliday.Controls.Add(this.lblEndDate);
            this.gbRegisterNewHoliday.Controls.Add(this.dtpStartDate);
            this.gbRegisterNewHoliday.Controls.Add(this.lblEmployeeBsn);
            this.gbRegisterNewHoliday.Controls.Add(this.tbEmployeeBSN);
            this.gbRegisterNewHoliday.Controls.Add(this.lblStartDate);
            this.gbRegisterNewHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRegisterNewHoliday.Location = new System.Drawing.Point(39, 373);
            this.gbRegisterNewHoliday.Name = "gbRegisterNewHoliday";
            this.gbRegisterNewHoliday.Size = new System.Drawing.Size(1028, 320);
            this.gbRegisterNewHoliday.TabIndex = 104;
            this.gbRegisterNewHoliday.TabStop = false;
            this.gbRegisterNewHoliday.Text = "Register new holiday";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndDate.Location = new System.Drawing.Point(265, 242);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(290, 30);
            this.dtpEndDate.TabIndex = 94;
            // 
            // btnRegisterNewHoliday
            // 
            this.btnRegisterNewHoliday.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegisterNewHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewHoliday.Location = new System.Drawing.Point(809, 131);
            this.btnRegisterNewHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterNewHoliday.Name = "btnRegisterNewHoliday";
            this.btnRegisterNewHoliday.Size = new System.Drawing.Size(183, 80);
            this.btnRegisterNewHoliday.TabIndex = 100;
            this.btnRegisterNewHoliday.Text = "Register new holiday";
            this.btnRegisterNewHoliday.UseVisualStyleBackColor = false;
            this.btnRegisterNewHoliday.Click += new System.EventHandler(this.btnRegisterNewHoliday_Click_1);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(22, 247);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(164, 25);
            this.lblEndDate.TabIndex = 90;
            this.lblEndDate.Text = "Holiday end date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStartDate.Location = new System.Drawing.Point(265, 152);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(290, 30);
            this.dtpStartDate.TabIndex = 93;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged_1);
            // 
            // lblEmployeeBsn
            // 
            this.lblEmployeeBsn.AutoSize = true;
            this.lblEmployeeBsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeBsn.Location = new System.Drawing.Point(22, 73);
            this.lblEmployeeBsn.Name = "lblEmployeeBsn";
            this.lblEmployeeBsn.Size = new System.Drawing.Size(151, 25);
            this.lblEmployeeBsn.TabIndex = 87;
            this.lblEmployeeBsn.Text = "Employee BSN:";
            // 
            // tbEmployeeBSN
            // 
            this.tbEmployeeBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployeeBSN.Location = new System.Drawing.Point(265, 68);
            this.tbEmployeeBSN.Name = "tbEmployeeBSN";
            this.tbEmployeeBSN.Size = new System.Drawing.Size(290, 30);
            this.tbEmployeeBSN.TabIndex = 91;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Location = new System.Drawing.Point(22, 157);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(168, 25);
            this.lblStartDate.TabIndex = 89;
            this.lblStartDate.Text = "Holiday start date:";
            // 
            // tpViewHolidays
            // 
            this.tpViewHolidays.BackColor = System.Drawing.Color.Azure;
            this.tpViewHolidays.Controls.Add(this.lblSort);
            this.tpViewHolidays.Controls.Add(this.cbSort);
            this.tpViewHolidays.Controls.Add(this.btnDeleteHoliday);
            this.tpViewHolidays.Controls.Add(this.lbHolidays);
            this.tpViewHolidays.Location = new System.Drawing.Point(4, 29);
            this.tpViewHolidays.Name = "tpViewHolidays";
            this.tpViewHolidays.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewHolidays.Size = new System.Drawing.Size(1107, 742);
            this.tpViewHolidays.TabIndex = 0;
            this.tpViewHolidays.Text = "View Holidays";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(36, 52);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(45, 20);
            this.lblSort.TabIndex = 104;
            this.lblSort.Text = "Sort:";
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "All",
            "By employee",
            "By start date"});
            this.cbSort.Location = new System.Drawing.Point(114, 44);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(247, 28);
            this.cbSort.TabIndex = 103;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // btnDeleteHoliday
            // 
            this.btnDeleteHoliday.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteHoliday.Location = new System.Drawing.Point(468, 578);
            this.btnDeleteHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteHoliday.Name = "btnDeleteHoliday";
            this.btnDeleteHoliday.Size = new System.Drawing.Size(183, 80);
            this.btnDeleteHoliday.TabIndex = 101;
            this.btnDeleteHoliday.Text = "Delete holiday";
            this.btnDeleteHoliday.UseVisualStyleBackColor = false;
            this.btnDeleteHoliday.Visible = false;
            this.btnDeleteHoliday.Click += new System.EventHandler(this.btnDeleteHoliday_Click);
            // 
            // lbHolidays
            // 
            this.lbHolidays.FormattingEnabled = true;
            this.lbHolidays.ItemHeight = 20;
            this.lbHolidays.Location = new System.Drawing.Point(40, 111);
            this.lbHolidays.Name = "lbHolidays";
            this.lbHolidays.Size = new System.Drawing.Size(1025, 424);
            this.lbHolidays.TabIndex = 0;
            this.lbHolidays.DoubleClick += new System.EventHandler(this.lbHolidays_DoubleClick);
            // 
            // HolidayRequestsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcHolidays);
            this.Name = "HolidayRequestsUC";
            this.Size = new System.Drawing.Size(1128, 785);
            this.tcHolidays.ResumeLayout(false);
            this.tpManageHolidays.ResumeLayout(false);
            this.gbRequestedHolidays.ResumeLayout(false);
            this.gbRequestedHolidays.PerformLayout();
            this.gbRegisterNewHoliday.ResumeLayout(false);
            this.gbRegisterNewHoliday.PerformLayout();
            this.tpViewHolidays.ResumeLayout(false);
            this.tpViewHolidays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHolidays;
        private System.Windows.Forms.TabPage tpManageHolidays;
        private System.Windows.Forms.GroupBox gbRequestedHolidays;
        private System.Windows.Forms.RadioButton rbSortByEmployee;
        private System.Windows.Forms.Button btnDenyHolidayRequest;
        private System.Windows.Forms.RadioButton rbSortByRequestedTime;
        private System.Windows.Forms.ListBox lbRequestedHolidays;
        private System.Windows.Forms.GroupBox gbRegisterNewHoliday;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnRegisterNewHoliday;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEmployeeBsn;
        private System.Windows.Forms.TextBox tbEmployeeBSN;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TabPage tpViewHolidays;
        private System.Windows.Forms.ListBox lbHolidays;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btnDeleteHoliday;
    }
}
