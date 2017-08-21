namespace WarehouseClient.ProductCategoryManagement
{
    partial class AddProductCategory
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
            this.PCTextBox1 = new System.Windows.Forms.TextBox();
            this.PCLabel1 = new System.Windows.Forms.Label();
            this.PCLabel2 = new System.Windows.Forms.Label();
            this.addinfo = new System.Windows.Forms.Button();
            this.PCNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PCNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PCTextBox1
            // 
            this.PCTextBox1.Location = new System.Drawing.Point(98, 14);
            this.PCTextBox1.Name = "PCTextBox1";
            this.PCTextBox1.Size = new System.Drawing.Size(120, 20);
            this.PCTextBox1.TabIndex = 0;
            // 
            // PCLabel1
            // 
            this.PCLabel1.AutoSize = true;
            this.PCLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCLabel1.Location = new System.Drawing.Point(22, 15);
            this.PCLabel1.Name = "PCLabel1";
            this.PCLabel1.Size = new System.Drawing.Size(45, 16);
            this.PCLabel1.TabIndex = 3;
            this.PCLabel1.Text = "Name";
            // 
            // PCLabel2
            // 
            this.PCLabel2.AutoSize = true;
            this.PCLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCLabel2.Location = new System.Drawing.Point(22, 54);
            this.PCLabel2.Name = "PCLabel2";
            this.PCLabel2.Size = new System.Drawing.Size(58, 16);
            this.PCLabel2.TabIndex = 3;
            this.PCLabel2.Text = "ParentId";
            this.PCLabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addinfo
            // 
            this.addinfo.Location = new System.Drawing.Point(88, 102);
            this.addinfo.Name = "addinfo";
            this.addinfo.Size = new System.Drawing.Size(75, 23);
            this.addinfo.TabIndex = 4;
            this.addinfo.Text = "Add";
            this.addinfo.UseVisualStyleBackColor = true;
            this.addinfo.Click += new System.EventHandler(this.addinfo_Click);
            // 
            // PCNumericUpDown1
            // 
            this.PCNumericUpDown1.Location = new System.Drawing.Point(98, 54);
            this.PCNumericUpDown1.Name = "PCNumericUpDown1";
            this.PCNumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.PCNumericUpDown1.TabIndex = 5;
            // 
            // AddProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 143);
            this.Controls.Add(this.PCNumericUpDown1);
            this.Controls.Add(this.addinfo);
            this.Controls.Add(this.PCLabel2);
            this.Controls.Add(this.PCLabel1);
            this.Controls.Add(this.PCTextBox1);
            this.Name = "AddProductCategory";
            this.Text = "AddProductCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProductCategory_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PCNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PCTextBox1;
        private System.Windows.Forms.Label PCLabel1;
        private System.Windows.Forms.Label PCLabel2;
        private System.Windows.Forms.Button addinfo;
        private System.Windows.Forms.NumericUpDown PCNumericUpDown1;
    }
}