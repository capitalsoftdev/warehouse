namespace WarehouseClient.RoleGroupManageet
{
    partial class RoleGroupAdd
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
            this.addRoleGroupButton = new System.Windows.Forms.Button();
            this.RoleGroupLabel = new System.Windows.Forms.Label();
            this.RoleGroupTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addRoleGroupButton
            // 
            this.addRoleGroupButton.Location = new System.Drawing.Point(237, 7);
            this.addRoleGroupButton.Name = "addRoleGroupButton";
            this.addRoleGroupButton.Size = new System.Drawing.Size(75, 23);
            this.addRoleGroupButton.TabIndex = 0;
            this.addRoleGroupButton.Text = "Add";
            this.addRoleGroupButton.UseVisualStyleBackColor = true;
            this.addRoleGroupButton.Click += new System.EventHandler(this.addRoleGroupButton_Click);
            // 
            // RoleGroupLabel
            // 
            this.RoleGroupLabel.AutoSize = true;
            this.RoleGroupLabel.Location = new System.Drawing.Point(12, 12);
            this.RoleGroupLabel.Name = "RoleGroupLabel";
            this.RoleGroupLabel.Size = new System.Drawing.Size(93, 13);
            this.RoleGroupLabel.TabIndex = 1;
            this.RoleGroupLabel.Text = "Insert Role Group:";
            // 
            // RoleGroupTextBox
            // 
            this.RoleGroupTextBox.Location = new System.Drawing.Point(111, 9);
            this.RoleGroupTextBox.Name = "RoleGroupTextBox";
            this.RoleGroupTextBox.Size = new System.Drawing.Size(110, 20);
            this.RoleGroupTextBox.TabIndex = 2;
            // 
            // RoleGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 43);
            this.Controls.Add(this.RoleGroupTextBox);
            this.Controls.Add(this.RoleGroupLabel);
            this.Controls.Add(this.addRoleGroupButton);
            this.Name = "RoleGroupAdd";
            this.Text = "RoleGroupAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRoleGroupButton;
        private System.Windows.Forms.Label RoleGroupLabel;
        private System.Windows.Forms.TextBox RoleGroupTextBox;
    }
}