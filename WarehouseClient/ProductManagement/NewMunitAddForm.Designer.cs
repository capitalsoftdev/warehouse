namespace WarehouseClient.ProductManagement
{
    partial class NewMunitAddForm
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
            this.addNewOrUpdateMunitButton = new System.Windows.Forms.Button();
            this.munitNameLabel = new System.Windows.Forms.Label();
            this.addNewMunitLabel = new System.Windows.Forms.Label();
            this.munitAddTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNewOrUpdateMunitButton
            // 
            this.addNewOrUpdateMunitButton.Location = new System.Drawing.Point(84, 172);
            this.addNewOrUpdateMunitButton.Name = "addNewOrUpdateMunitButton";
            this.addNewOrUpdateMunitButton.Size = new System.Drawing.Size(117, 31);
            this.addNewOrUpdateMunitButton.TabIndex = 7;
            this.addNewOrUpdateMunitButton.Text = "Add";
            this.addNewOrUpdateMunitButton.UseVisualStyleBackColor = true;
            this.addNewOrUpdateMunitButton.Click += new System.EventHandler(this.addNewOrUpdateMunitButton_Click);
            // 
            // munitNameLabel
            // 
            this.munitNameLabel.AutoSize = true;
            this.munitNameLabel.Location = new System.Drawing.Point(20, 114);
            this.munitNameLabel.Name = "munitNameLabel";
            this.munitNameLabel.Size = new System.Drawing.Size(64, 13);
            this.munitNameLabel.TabIndex = 5;
            this.munitNameLabel.Text = "Munit Name";
            // 
            // addNewMunitLabel
            // 
            this.addNewMunitLabel.AutoSize = true;
            this.addNewMunitLabel.Location = new System.Drawing.Point(95, 45);
            this.addNewMunitLabel.Name = "addNewMunitLabel";
            this.addNewMunitLabel.Size = new System.Drawing.Size(80, 13);
            this.addNewMunitLabel.TabIndex = 4;
            this.addNewMunitLabel.Text = "Add New Munit";
            // 
            // munitAddTextBox
            // 
            this.munitAddTextBox.Location = new System.Drawing.Point(142, 107);
            this.munitAddTextBox.Name = "munitAddTextBox";
            this.munitAddTextBox.Size = new System.Drawing.Size(130, 20);
            this.munitAddTextBox.TabIndex = 8;
            // 
            // NewMunitAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.munitAddTextBox);
            this.Controls.Add(this.addNewOrUpdateMunitButton);
            this.Controls.Add(this.munitNameLabel);
            this.Controls.Add(this.addNewMunitLabel);
            this.Name = "NewMunitAddForm";
            this.Text = "NewMunitAddForm";
            this.Load += new System.EventHandler(this.NewMunitAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewOrUpdateMunitButton;
        private System.Windows.Forms.Label munitNameLabel;
        private System.Windows.Forms.Label addNewMunitLabel;
        private System.Windows.Forms.TextBox munitAddTextBox;
    }
}