namespace MediaBazaar
{
    partial class ChangePasswordForm
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
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblRepeatNewPass = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.btnSubmitChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewPass.Location = new System.Drawing.Point(71, 67);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(140, 24);
            this.lblNewPass.TabIndex = 1;
            this.lblNewPass.Text = "New password:";
            // 
            // lblRepeatNewPass
            // 
            this.lblRepeatNewPass.AutoSize = true;
            this.lblRepeatNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeatNewPass.Location = new System.Drawing.Point(9, 124);
            this.lblRepeatNewPass.Name = "lblRepeatNewPass";
            this.lblRepeatNewPass.Size = new System.Drawing.Size(202, 24);
            this.lblRepeatNewPass.TabIndex = 2;
            this.lblRepeatNewPass.Text = "Repeat new password:";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbNewPassword.Location = new System.Drawing.Point(249, 66);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(265, 27);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbRepeatNewPassword
            // 
            this.txbRepeatNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbRepeatNewPassword.Location = new System.Drawing.Point(249, 123);
            this.txbRepeatNewPassword.Name = "txbRepeatNewPassword";
            this.txbRepeatNewPassword.Size = new System.Drawing.Size(265, 27);
            this.txbRepeatNewPassword.TabIndex = 5;
            this.txbRepeatNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmitChanges
            // 
            this.btnSubmitChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmitChanges.Location = new System.Drawing.Point(249, 183);
            this.btnSubmitChanges.Name = "btnSubmitChanges";
            this.btnSubmitChanges.Size = new System.Drawing.Size(265, 38);
            this.btnSubmitChanges.TabIndex = 6;
            this.btnSubmitChanges.Text = "Change password";
            this.btnSubmitChanges.UseVisualStyleBackColor = true;
            this.btnSubmitChanges.Click += new System.EventHandler(this.btnSubmitChanges_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(580, 267);
            this.Controls.Add(this.btnSubmitChanges);
            this.Controls.Add(this.txbRepeatNewPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.lblRepeatNewPass);
            this.Controls.Add(this.lblNewPass);
            this.MaximizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblRepeatNewPass;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbRepeatNewPassword;
        private System.Windows.Forms.Button btnSubmitChanges;
    }
}