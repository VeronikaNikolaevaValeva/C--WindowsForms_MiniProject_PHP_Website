
namespace MediaBazaar
{
    partial class AssignCategoryForm
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
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblAssignCategory = new System.Windows.Forms.Label();
            this.lblUnAssignCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCategory
            // 
            this.lbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 22;
            this.lbxCategory.Location = new System.Drawing.Point(150, 82);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(293, 312);
            this.lbxCategory.TabIndex = 2;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(485, 82);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(151, 24);
            this.cbxCategory.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(485, 125);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(151, 31);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(12, 9);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(726, 27);
            this.lblDepartmentName.TabIndex = 5;
            this.lblDepartmentName.Text = "label1";
            this.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignCategory
            // 
            this.lblAssignCategory.AutoSize = true;
            this.lblAssignCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignCategory.Location = new System.Drawing.Point(150, 59);
            this.lblAssignCategory.Name = "lblAssignCategory";
            this.lblAssignCategory.Size = new System.Drawing.Size(127, 17);
            this.lblAssignCategory.TabIndex = 6;
            this.lblAssignCategory.Text = "Assigned Category";
            // 
            // lblUnAssignCategory
            // 
            this.lblUnAssignCategory.AutoSize = true;
            this.lblUnAssignCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnAssignCategory.Location = new System.Drawing.Point(486, 59);
            this.lblUnAssignCategory.Name = "lblUnAssignCategory";
            this.lblUnAssignCategory.Size = new System.Drawing.Size(145, 17);
            this.lblUnAssignCategory.TabIndex = 7;
            this.lblUnAssignCategory.Text = "UnAssigned Category";
            // 
            // AssignCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(750, 437);
            this.Controls.Add(this.lblUnAssignCategory);
            this.Controls.Add(this.lblAssignCategory);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.lbxCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AssignCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblAssignCategory;
        private System.Windows.Forms.Label lblUnAssignCategory;
    }
}