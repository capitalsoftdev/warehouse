namespace WarehouseClient.RoleGroupMapManagment
{
    partial class AddRoleGroupMap
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
            this.RoleGroupIdName_label = new System.Windows.Forms.Label();
            this.RoleIdName_label = new System.Windows.Forms.Label();
            this.RoleGroupId_textBox = new System.Windows.Forms.TextBox();
            this.RoleId_textBox = new System.Windows.Forms.TextBox();
            this.SubmitRoleGroupMap_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleGroupIdName_label
            // 
            this.RoleGroupIdName_label.AutoSize = true;
            this.RoleGroupIdName_label.Location = new System.Drawing.Point(13, 32);
            this.RoleGroupIdName_label.Name = "RoleGroupIdName_label";
            this.RoleGroupIdName_label.Size = new System.Drawing.Size(65, 13);
            this.RoleGroupIdName_label.TabIndex = 0;
            this.RoleGroupIdName_label.Text = "RolegroupId";
            // 
            // RoleIdName_label
            // 
            this.RoleIdName_label.AutoSize = true;
            this.RoleIdName_label.Location = new System.Drawing.Point(13, 62);
            this.RoleIdName_label.Name = "RoleIdName_label";
            this.RoleIdName_label.Size = new System.Drawing.Size(38, 13);
            this.RoleIdName_label.TabIndex = 1;
            this.RoleIdName_label.Text = "RoleId";
            // 
            // RoleGroupId_textBox
            // 
            this.RoleGroupId_textBox.Location = new System.Drawing.Point(102, 32);
            this.RoleGroupId_textBox.Name = "RoleGroupId_textBox";
            this.RoleGroupId_textBox.Size = new System.Drawing.Size(100, 20);
            this.RoleGroupId_textBox.TabIndex = 2;
            // 
            // RoleId_textBox
            // 
            this.RoleId_textBox.Location = new System.Drawing.Point(102, 62);
            this.RoleId_textBox.Name = "RoleId_textBox";
            this.RoleId_textBox.Size = new System.Drawing.Size(100, 20);
            this.RoleId_textBox.TabIndex = 2;
            // 
            // SubmitRoleGroupMap_button
            // 
            this.SubmitRoleGroupMap_button.Location = new System.Drawing.Point(102, 98);
            this.SubmitRoleGroupMap_button.Name = "SubmitRoleGroupMap_button";
            this.SubmitRoleGroupMap_button.Size = new System.Drawing.Size(75, 23);
            this.SubmitRoleGroupMap_button.TabIndex = 3;
            this.SubmitRoleGroupMap_button.Text = "Submit";
            this.SubmitRoleGroupMap_button.UseVisualStyleBackColor = true;
            this.SubmitRoleGroupMap_button.Click += new System.EventHandler(this.SubmitRoleGroupMap_button_Click);
            // 
            // AddRoleGroupMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 147);
            this.Controls.Add(this.SubmitRoleGroupMap_button);
            this.Controls.Add(this.RoleId_textBox);
            this.Controls.Add(this.RoleGroupId_textBox);
            this.Controls.Add(this.RoleIdName_label);
            this.Controls.Add(this.RoleGroupIdName_label);
            this.Name = "AddRoleGroupMap";
            this.Text = "AddRoleGroupMap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRoleGroupMap_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleGroupIdName_label;
        private System.Windows.Forms.Label RoleIdName_label;
        private System.Windows.Forms.TextBox RoleGroupId_textBox;
        private System.Windows.Forms.TextBox RoleId_textBox;
        private System.Windows.Forms.Button SubmitRoleGroupMap_button;
    }
}