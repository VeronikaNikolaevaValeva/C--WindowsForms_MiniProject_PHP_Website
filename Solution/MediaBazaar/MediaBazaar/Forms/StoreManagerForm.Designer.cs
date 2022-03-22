
namespace MediaBazaar
{
    partial class StoreManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnStoreMEmployeeStatistic = new System.Windows.Forms.Button();
            this.btnStoreMStockStatistic = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStoreMLogOut = new System.Windows.Forms.Button();
            this.btnStoreM = new System.Windows.Forms.Button();
            this.productStatisticInterface1 = new MediaBazaar.ProductStatisticInterface();
            this.employeeStatistics1 = new MediaBazaar.EmployeeStatistics();
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.departmentInterface1 = new MediaBazaar.DepartmentInterface();
            this.btnStoreWorkersSchedule = new System.Windows.Forms.Button();
            this.storeWorkerScheduleInterface = new MediaBazaar.StoreWorkerScheduleInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStoreWorkersSchedule);
            this.panel1.Controls.Add(this.btnDepartment);
            this.panel1.Controls.Add(this.btnStoreMEmployeeStatistic);
            this.panel1.Controls.Add(this.btnStoreMStockStatistic);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 786);
            this.panel1.TabIndex = 44;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(24, 325);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(155, 59);
            this.btnDepartment.TabIndex = 51;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnStoreMEmployeeStatistic
            // 
            this.btnStoreMEmployeeStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreMEmployeeStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMEmployeeStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMEmployeeStatistic.Location = new System.Drawing.Point(23, 174);
            this.btnStoreMEmployeeStatistic.Name = "btnStoreMEmployeeStatistic";
            this.btnStoreMEmployeeStatistic.Size = new System.Drawing.Size(155, 59);
            this.btnStoreMEmployeeStatistic.TabIndex = 4;
            this.btnStoreMEmployeeStatistic.Text = "Employee Statistic";
            this.btnStoreMEmployeeStatistic.UseVisualStyleBackColor = false;
            this.btnStoreMEmployeeStatistic.Click += new System.EventHandler(this.btnStoreMEmployeeStatistic_Click);
            // 
            // btnStoreMStockStatistic
            // 
            this.btnStoreMStockStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreMStockStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMStockStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMStockStatistic.Location = new System.Drawing.Point(24, 250);
            this.btnStoreMStockStatistic.Name = "btnStoreMStockStatistic";
            this.btnStoreMStockStatistic.Size = new System.Drawing.Size(155, 59);
            this.btnStoreMStockStatistic.TabIndex = 3;
            this.btnStoreMStockStatistic.Text = "Stock Statistic";
            this.btnStoreMStockStatistic.UseVisualStyleBackColor = false;
            this.btnStoreMStockStatistic.Click += new System.EventHandler(this.btnStoreMStockStatistic_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(23, 11);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(156, 142);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStoreMLogOut);
            this.panel2.Controls.Add(this.btnStoreM);
            this.panel2.Location = new System.Drawing.Point(-1, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 314);
            this.panel2.TabIndex = 0;
            // 
            // btnStoreMLogOut
            // 
            this.btnStoreMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStoreMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMLogOut.Location = new System.Drawing.Point(23, 230);
            this.btnStoreMLogOut.Name = "btnStoreMLogOut";
            this.btnStoreMLogOut.Size = new System.Drawing.Size(155, 59);
            this.btnStoreMLogOut.TabIndex = 3;
            this.btnStoreMLogOut.Text = "Log out";
            this.btnStoreMLogOut.UseVisualStyleBackColor = false;
            this.btnStoreMLogOut.Click += new System.EventHandler(this.btnStoreMLogOut_Click);
            // 
            // btnStoreM
            // 
            this.btnStoreM.BackColor = System.Drawing.Color.White;
            this.btnStoreM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreM.Location = new System.Drawing.Point(23, 77);
            this.btnStoreM.Name = "btnStoreM";
            this.btnStoreM.Size = new System.Drawing.Size(155, 59);
            this.btnStoreM.TabIndex = 2;
            this.btnStoreM.Text = "My account";
            this.btnStoreM.UseVisualStyleBackColor = false;
            this.btnStoreM.Click += new System.EventHandler(this.btnStoreM_Click);
            // 
            // productStatisticInterface1
            // 
            this.productStatisticInterface1.Location = new System.Drawing.Point(213, 0);
            this.productStatisticInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productStatisticInterface1.Name = "productStatisticInterface1";
            this.productStatisticInterface1.Size = new System.Drawing.Size(1129, 786);
            this.productStatisticInterface1.TabIndex = 47;
            // 
            // employeeStatistics1
            // 
            this.employeeStatistics1.BackColor = System.Drawing.Color.Transparent;
            this.employeeStatistics1.Location = new System.Drawing.Point(213, 1);
            this.employeeStatistics1.Name = "employeeStatistics1";
            this.employeeStatistics1.Size = new System.Drawing.Size(1129, 785);
            this.employeeStatistics1.TabIndex = 49;
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(212, 1);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(1121, 747);
            this.userInterface1.TabIndex = 50;
            // 
            // departmentInterface1
            // 
            this.departmentInterface1.BackColor = System.Drawing.Color.Transparent;
            this.departmentInterface1.Location = new System.Drawing.Point(213, 0);
            this.departmentInterface1.Name = "departmentInterface1";
            this.departmentInterface1.Size = new System.Drawing.Size(1129, 785);
            this.departmentInterface1.TabIndex = 51;
            // 
            // btnStoreWorkersSchedule
            // 
            this.btnStoreWorkersSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreWorkersSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreWorkersSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreWorkersSchedule.Location = new System.Drawing.Point(23, 406);
            this.btnStoreWorkersSchedule.Name = "btnStoreWorkersSchedule";
            this.btnStoreWorkersSchedule.Size = new System.Drawing.Size(155, 59);
            this.btnStoreWorkersSchedule.TabIndex = 52;
            this.btnStoreWorkersSchedule.Text = "Schedule";
            this.btnStoreWorkersSchedule.UseVisualStyleBackColor = false;
            this.btnStoreWorkersSchedule.Click += new System.EventHandler(this.btnStoreWorkersSchedule_Click);
            // 
            // storeWorkerScheduleInterface
            // 
            this.storeWorkerScheduleInterface.Location = new System.Drawing.Point(213, 1);
            this.storeWorkerScheduleInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeWorkerScheduleInterface.Name = "storeWorkerScheduleInterface";
            this.storeWorkerScheduleInterface.Size = new System.Drawing.Size(1129, 812);
            this.storeWorkerScheduleInterface.TabIndex = 52;
            // 
            // StoreManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1340, 786);
            this.Controls.Add(this.storeWorkerScheduleInterface);
            this.Controls.Add(this.departmentInterface1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productStatisticInterface1);
            this.Controls.Add(this.employeeStatistics1);
            this.Controls.Add(this.userInterface1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StoreManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreManagerForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStoreMLogOut;
        private System.Windows.Forms.Button btnStoreM;
        private System.Windows.Forms.Button btnStoreMStockStatistic;
        private System.Windows.Forms.Button btnStoreMEmployeeStatistic;
        private ProductStatisticInterface productStatisticInterface1;
        private EmployeeStatistics employeeStatistics1;
        private UserInterface userInterface1;
        private System.Windows.Forms.Button btnDepartment;
        private DepartmentInterface departmentInterface1;
        private System.Windows.Forms.Button btnStoreWorkersSchedule;
        private StoreWorkerScheduleInterface storeWorkerScheduleInterface;
    }
}