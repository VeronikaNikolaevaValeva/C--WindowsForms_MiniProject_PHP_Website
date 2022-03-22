
namespace MediaBazaar
{
    partial class AssignDepartmentManagerToDepartment
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
            this.lbxAssignDepartmentManager = new System.Windows.Forms.ListBox();
            this.cbxDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lblUnassignDepartmentManager = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblAssignDepartmentManager = new System.Windows.Forms.Label();
            this.btnUnAssign = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAssignDepartmentManager
            // 
            this.lbxAssignDepartmentManager.FormattingEnabled = true;
            this.lbxAssignDepartmentManager.ItemHeight = 16;
            this.lbxAssignDepartmentManager.Location = new System.Drawing.Point(113, 106);
            this.lbxAssignDepartmentManager.Name = "lbxAssignDepartmentManager";
            this.lbxAssignDepartmentManager.Size = new System.Drawing.Size(327, 212);
            this.lbxAssignDepartmentManager.TabIndex = 0;
            // 
            // cbxDepartmentManager
            // 
            this.cbxDepartmentManager.FormattingEnabled = true;
            this.cbxDepartmentManager.Location = new System.Drawing.Point(457, 106);
            this.cbxDepartmentManager.Name = "cbxDepartmentManager";
            this.cbxDepartmentManager.Size = new System.Drawing.Size(208, 24);
            this.cbxDepartmentManager.TabIndex = 1;
            // 
            // lblUnassignDepartmentManager
            // 
            this.lblUnassignDepartmentManager.AutoSize = true;
            this.lblUnassignDepartmentManager.Location = new System.Drawing.Point(457, 83);
            this.lblUnassignDepartmentManager.Name = "lblUnassignDepartmentManager";
            this.lblUnassignDepartmentManager.Size = new System.Drawing.Size(203, 17);
            this.lblUnassignDepartmentManager.TabIndex = 2;
            this.lblUnassignDepartmentManager.Text = "Unassign department manager";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(457, 136);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(208, 30);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblAssignDepartmentManager
            // 
            this.lblAssignDepartmentManager.AutoSize = true;
            this.lblAssignDepartmentManager.Location = new System.Drawing.Point(110, 83);
            this.lblAssignDepartmentManager.Name = "lblAssignDepartmentManager";
            this.lblAssignDepartmentManager.Size = new System.Drawing.Size(186, 17);
            this.lblAssignDepartmentManager.TabIndex = 4;
            this.lblAssignDepartmentManager.Text = "Assign department manager";
            // 
            // btnUnAssign
            // 
            this.btnUnAssign.Location = new System.Drawing.Point(457, 172);
            this.btnUnAssign.Name = "btnUnAssign";
            this.btnUnAssign.Size = new System.Drawing.Size(208, 30);
            this.btnUnAssign.TabIndex = 5;
            this.btnUnAssign.Text = "Unassign";
            this.btnUnAssign.UseVisualStyleBackColor = true;
            this.btnUnAssign.Click += new System.EventHandler(this.btnUnAssign_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(12, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(745, 34);
            this.lblDepartmentName.TabIndex = 6;
            this.lblDepartmentName.Text = "label1";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignDepartmentManagerToDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(769, 404);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnUnAssign);
            this.Controls.Add(this.lblAssignDepartmentManager);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lblUnassignDepartmentManager);
            this.Controls.Add(this.cbxDepartmentManager);
            this.Controls.Add(this.lbxAssignDepartmentManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssignDepartmentManagerToDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignDepartmentManagerToDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAssignDepartmentManager;
        private System.Windows.Forms.ComboBox cbxDepartmentManager;
        private System.Windows.Forms.Label lblUnassignDepartmentManager;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblAssignDepartmentManager;
        private System.Windows.Forms.Button btnUnAssign;
        private System.Windows.Forms.Label lblDepartmentName;
    }
}