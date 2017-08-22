namespace WarehouseClient.RoleManagement
{
    partial class RoleAdd
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
            this.roleAddButton = new System.Windows.Forms.Button();
            this.RoleNameTextBox = new System.Windows.Forms.TextBox();
            this.RoleAddLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roleAddButton
            // 
            this.roleAddButton.Location = new System.Drawing.Point(232, 12);
            this.roleAddButton.Name = "roleAddButton";
            this.roleAddButton.Size = new System.Drawing.Size(75, 23);
            this.roleAddButton.TabIndex = 0;
            this.roleAddButton.Text = "Add";
            this.roleAddButton.UseVisualStyleBackColor = true;
            this.roleAddButton.Click += new System.EventHandler(this.roleAddButton_Click);
            // 
            // RoleNameTextBox
            // 
            this.RoleNameTextBox.Location = new System.Drawing.Point(126, 14);
            this.RoleNameTextBox.Name = "RoleNameTextBox";
            this.RoleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoleNameTextBox.TabIndex = 1;
            // 
            // RoleAddLabel
            // 
            this.RoleAddLabel.AutoSize = true;
            this.RoleAddLabel.Location = new System.Drawing.Point(12, 17);
            this.RoleAddLabel.Name = "RoleAddLabel";
            this.RoleAddLabel.Size = new System.Drawing.Size(108, 13);
            this.RoleAddLabel.TabIndex = 2;
            this.RoleAddLabel.Text = "Insert new role name:";
            // 
            // RoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 50);
            this.Controls.Add(this.RoleAddLabel);
            this.Controls.Add(this.RoleNameTextBox);
            this.Controls.Add(this.roleAddButton);
            this.Name = "RoleAdd";
            this.Text = "RoleAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoleAdd_FormClosed);
            this.Load += new System.EventHandler(this.RoleAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roleAddButton;
        private System.Windows.Forms.TextBox RoleNameTextBox;
        private System.Windows.Forms.Label RoleAddLabel;
    }
}