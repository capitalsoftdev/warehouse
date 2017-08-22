namespace WarehouseClient.ProductManagement
{
    partial class NewProductAddForm
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
            this.addNewProductLabel1 = new System.Windows.Forms.Label();
            this.addNewProductLabel2 = new System.Windows.Forms.Label();
            this.addNewProductLabel3 = new System.Windows.Forms.Label();
            this.addNewProductLabel4 = new System.Windows.Forms.Label();
            this.newProductNameTextBox = new System.Windows.Forms.TextBox();
            this.productCategorySelectProductComboBox1 = new System.Windows.Forms.ComboBox();
            this.munitSelectProductComboBox2 = new System.Windows.Forms.ComboBox();
            this.newProductAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewProductLabel1
            // 
            this.addNewProductLabel1.AutoSize = true;
            this.addNewProductLabel1.Location = new System.Drawing.Point(101, 21);
            this.addNewProductLabel1.Name = "addNewProductLabel1";
            this.addNewProductLabel1.Size = new System.Drawing.Size(91, 13);
            this.addNewProductLabel1.TabIndex = 0;
            this.addNewProductLabel1.Text = "Add New Product";
            // 
            // addNewProductLabel2
            // 
            this.addNewProductLabel2.AutoSize = true;
            this.addNewProductLabel2.Location = new System.Drawing.Point(11, 60);
            this.addNewProductLabel2.Name = "addNewProductLabel2";
            this.addNewProductLabel2.Size = new System.Drawing.Size(75, 13);
            this.addNewProductLabel2.TabIndex = 1;
            this.addNewProductLabel2.Text = "Product Name";
            // 
            // addNewProductLabel3
            // 
            this.addNewProductLabel3.AutoSize = true;
            this.addNewProductLabel3.Location = new System.Drawing.Point(8, 102);
            this.addNewProductLabel3.Name = "addNewProductLabel3";
            this.addNewProductLabel3.Size = new System.Drawing.Size(89, 13);
            this.addNewProductLabel3.TabIndex = 2;
            this.addNewProductLabel3.Text = "Product Category";
            // 
            // addNewProductLabel4
            // 
            this.addNewProductLabel4.AutoSize = true;
            this.addNewProductLabel4.Location = new System.Drawing.Point(11, 138);
            this.addNewProductLabel4.Name = "addNewProductLabel4";
            this.addNewProductLabel4.Size = new System.Drawing.Size(33, 13);
            this.addNewProductLabel4.TabIndex = 3;
            this.addNewProductLabel4.Text = "Munit";
            // 
            // newProductNameTextBox
            // 
            this.newProductNameTextBox.Location = new System.Drawing.Point(144, 56);
            this.newProductNameTextBox.Name = "newProductNameTextBox";
            this.newProductNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.newProductNameTextBox.TabIndex = 4;
            // 
            // productCategorySelectProductComboBox1
            // 
            this.productCategorySelectProductComboBox1.FormattingEnabled = true;
            this.productCategorySelectProductComboBox1.Location = new System.Drawing.Point(144, 94);
            this.productCategorySelectProductComboBox1.Name = "productCategorySelectProductComboBox1";
            this.productCategorySelectProductComboBox1.Size = new System.Drawing.Size(169, 21);
            this.productCategorySelectProductComboBox1.TabIndex = 5;
            // 
            // munitSelectProductComboBox2
            // 
            this.munitSelectProductComboBox2.FormattingEnabled = true;
            this.munitSelectProductComboBox2.Location = new System.Drawing.Point(144, 130);
            this.munitSelectProductComboBox2.Name = "munitSelectProductComboBox2";
            this.munitSelectProductComboBox2.Size = new System.Drawing.Size(169, 21);
            this.munitSelectProductComboBox2.TabIndex = 6;
            // 
            // newProductAddButton
            // 
            this.newProductAddButton.Location = new System.Drawing.Point(99, 201);
            this.newProductAddButton.Name = "newProductAddButton";
            this.newProductAddButton.Size = new System.Drawing.Size(122, 40);
            this.newProductAddButton.TabIndex = 7;
            this.newProductAddButton.Text = "Add";
            this.newProductAddButton.UseVisualStyleBackColor = true;
            this.newProductAddButton.Click += new System.EventHandler(this.newProductAddButton_Click);
            // 
            // NewProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 297);
            this.Controls.Add(this.newProductAddButton);
            this.Controls.Add(this.munitSelectProductComboBox2);
            this.Controls.Add(this.productCategorySelectProductComboBox1);
            this.Controls.Add(this.newProductNameTextBox);
            this.Controls.Add(this.addNewProductLabel4);
            this.Controls.Add(this.addNewProductLabel3);
            this.Controls.Add(this.addNewProductLabel2);
            this.Controls.Add(this.addNewProductLabel1);
            this.Name = "NewProductAddForm";
            this.Text = "NewProductAddForm";
            this.Load += new System.EventHandler(this.NewProductAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewProductLabel1;
        private System.Windows.Forms.Label addNewProductLabel2;
        private System.Windows.Forms.Label addNewProductLabel3;
        private System.Windows.Forms.Label addNewProductLabel4;
        private System.Windows.Forms.TextBox newProductNameTextBox;
        private System.Windows.Forms.ComboBox productCategorySelectProductComboBox1;
        private System.Windows.Forms.ComboBox munitSelectProductComboBox2;
        private System.Windows.Forms.Button newProductAddButton;
    }
}