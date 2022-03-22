
namespace MediaBazaar
{
    partial class DepartmentDetailsForm
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lbxDepartmentManager = new System.Windows.Forms.ListBox();
            this.lbxStoreWorker = new System.Windows.Forms.ListBox();
            this.lblDepartmentManager = new System.Windows.Forms.Label();
            this.lblStoreWorker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(12, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(705, 32);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "label1";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxDepartmentManager
            // 
            this.lbxDepartmentManager.FormattingEnabled = true;
            this.lbxDepartmentManager.ItemHeight = 16;
            this.lbxDepartmentManager.Location = new System.Drawing.Point(97, 116);
            this.lbxDepartmentManager.Name = "lbxDepartmentManager";
            this.lbxDepartmentManager.Size = new System.Drawing.Size(233, 196);
            this.lbxDepartmentManager.TabIndex = 1;
            // 
            // lbxStoreWorker
            // 
            this.lbxStoreWorker.FormattingEnabled = true;
            this.lbxStoreWorker.ItemHeight = 16;
            this.lbxStoreWorker.Location = new System.Drawing.Point(401, 116);
            this.lbxStoreWorker.Name = "lbxStoreWorker";
            this.lbxStoreWorker.Size = new System.Drawing.Size(233, 196);
            this.lbxStoreWorker.TabIndex = 2;
            // 
            // lblDepartmentManager
            // 
            this.lblDepartmentManager.AutoSize = true;
            this.lblDepartmentManager.Location = new System.Drawing.Point(94, 96);
            this.lblDepartmentManager.Name = "lblDepartmentManager";
            this.lblDepartmentManager.Size = new System.Drawing.Size(142, 17);
            this.lblDepartmentManager.TabIndex = 3;
            this.lblDepartmentManager.Text = "Department manager";
            // 
            // lblStoreWorker
            // 
            this.lblStoreWorker.AutoSize = true;
            this.lblStoreWorker.Location = new System.Drawing.Point(398, 96);
            this.lblStoreWorker.Name = "lblStoreWorker";
            this.lblStoreWorker.Size = new System.Drawing.Size(88, 17);
            this.lblStoreWorker.TabIndex = 4;
            this.lblStoreWorker.Text = "Store worker";
            // 
            // DepartmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(729, 387);
            this.Controls.Add(this.lblStoreWorker);
            this.Controls.Add(this.lblDepartmentManager);
            this.Controls.Add(this.lbxStoreWorker);
            this.Controls.Add(this.lbxDepartmentManager);
            this.Controls.Add(this.lblDepartmentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DepartmentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.ListBox lbxDepartmentManager;
        private System.Windows.Forms.ListBox lbxStoreWorker;
        private System.Windows.Forms.Label lblDepartmentManager;
        private System.Windows.Forms.Label lblStoreWorker;
    }
}