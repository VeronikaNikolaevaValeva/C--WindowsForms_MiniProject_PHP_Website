
namespace MediaBazaar
{
    partial class AssignStoreWorkerToDepartmentUC
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
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.cbxDisplayStoreWorker = new System.Windows.Forms.ComboBox();
            this.lbxDisplayAssignStoreWorker = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.lblUnassignStoreWorker = new System.Windows.Forms.Label();
            this.lblAssignStoreWorker = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(6, 36);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(1123, 35);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "label1";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDisplayStoreWorker
            // 
            this.cbxDisplayStoreWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisplayStoreWorker.FormattingEnabled = true;
            this.cbxDisplayStoreWorker.Location = new System.Drawing.Point(532, 235);
            this.cbxDisplayStoreWorker.Name = "cbxDisplayStoreWorker";
            this.cbxDisplayStoreWorker.Size = new System.Drawing.Size(241, 24);
            this.cbxDisplayStoreWorker.TabIndex = 1;
            // 
            // lbxDisplayAssignStoreWorker
            // 
            this.lbxDisplayAssignStoreWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDisplayAssignStoreWorker.FormattingEnabled = true;
            this.lbxDisplayAssignStoreWorker.ItemHeight = 20;
            this.lbxDisplayAssignStoreWorker.Location = new System.Drawing.Point(148, 235);
            this.lbxDisplayAssignStoreWorker.Name = "lbxDisplayAssignStoreWorker";
            this.lbxDisplayAssignStoreWorker.Size = new System.Drawing.Size(334, 244);
            this.lbxDisplayAssignStoreWorker.TabIndex = 2;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(532, 265);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(241, 30);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.Location = new System.Drawing.Point(532, 301);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(241, 30);
            this.btnUnassign.TabIndex = 4;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // lblUnassignStoreWorker
            // 
            this.lblUnassignStoreWorker.AutoSize = true;
            this.lblUnassignStoreWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassignStoreWorker.Location = new System.Drawing.Point(532, 212);
            this.lblUnassignStoreWorker.Name = "lblUnassignStoreWorker";
            this.lblUnassignStoreWorker.Size = new System.Drawing.Size(177, 20);
            this.lblUnassignStoreWorker.TabIndex = 5;
            this.lblUnassignStoreWorker.Text = "Unassign store worker";
            // 
            // lblAssignStoreWorker
            // 
            this.lblAssignStoreWorker.AutoSize = true;
            this.lblAssignStoreWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignStoreWorker.Location = new System.Drawing.Point(145, 212);
            this.lblAssignStoreWorker.Name = "lblAssignStoreWorker";
            this.lblAssignStoreWorker.Size = new System.Drawing.Size(158, 20);
            this.lblAssignStoreWorker.TabIndex = 6;
            this.lblAssignStoreWorker.Text = "Assign store worker";
            // 
            // AssignStoreWorkerToDepartmentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.lblAssignStoreWorker);
            this.Controls.Add(this.lblUnassignStoreWorker);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lbxDisplayAssignStoreWorker);
            this.Controls.Add(this.cbxDisplayStoreWorker);
            this.Controls.Add(this.lblDepartmentName);
            this.Name = "AssignStoreWorkerToDepartmentUC";
            this.Size = new System.Drawing.Size(1129, 812);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.ComboBox cbxDisplayStoreWorker;
        private System.Windows.Forms.ListBox lbxDisplayAssignStoreWorker;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Label lblUnassignStoreWorker;
        private System.Windows.Forms.Label lblAssignStoreWorker;
    }
}
