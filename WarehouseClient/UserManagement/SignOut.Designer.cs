namespace WarehouseClient.UserManagement
{
    partial class SignOut
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
            this.SignOutLabel = new System.Windows.Forms.Label();
            this.SignOutButtonYes = new System.Windows.Forms.Button();
            this.SignOutButtonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignOutLabel
            // 
            this.SignOutLabel.AutoSize = true;
            this.SignOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutLabel.Location = new System.Drawing.Point(3, 9);
            this.SignOutLabel.Name = "SignOutLabel";
            this.SignOutLabel.Size = new System.Drawing.Size(182, 31);
            this.SignOutLabel.TabIndex = 0;
            this.SignOutLabel.Text = "Are you sure?";
            // 
            // SignOutButtonYes
            // 
            this.SignOutButtonYes.Location = new System.Drawing.Point(245, 19);
            this.SignOutButtonYes.Name = "SignOutButtonYes";
            this.SignOutButtonYes.Size = new System.Drawing.Size(75, 23);
            this.SignOutButtonYes.TabIndex = 1;
            this.SignOutButtonYes.Text = "Yes";
            this.SignOutButtonYes.UseVisualStyleBackColor = true;
            this.SignOutButtonYes.Click += new System.EventHandler(this.SignOutButtonYes_Click);
            // 
            // SignOutButtonNo
            // 
            this.SignOutButtonNo.Location = new System.Drawing.Point(335, 17);
            this.SignOutButtonNo.Name = "SignOutButtonNo";
            this.SignOutButtonNo.Size = new System.Drawing.Size(75, 23);
            this.SignOutButtonNo.TabIndex = 2;
            this.SignOutButtonNo.Text = "No";
            this.SignOutButtonNo.UseVisualStyleBackColor = true;
            this.SignOutButtonNo.Click += new System.EventHandler(this.SignOutButtonNo_Click);
            // 
            // SignOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 49);
            this.Controls.Add(this.SignOutButtonNo);
            this.Controls.Add(this.SignOutButtonYes);
            this.Controls.Add(this.SignOutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignOut_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignOutLabel;
        private System.Windows.Forms.Button SignOutButtonYes;
        private System.Windows.Forms.Button SignOutButtonNo;
    }
}