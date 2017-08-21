namespace WarehouseClient
{
     partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteProdManag = new System.Windows.Forms.Button();
            this.AddNewItemProdManag = new System.Windows.Forms.Button();
            this.ProductManagmentGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.productCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductManagmentGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(10, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 120;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(353, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 429);
            this.tabControl1.Size = new System.Drawing.Size(958, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User management";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(447, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 280);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 280);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.outToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.outToolStripMenuItem.Text = "Out";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteProdManag);
            this.tabPage2.Controls.Add(this.AddNewItemProdManag);
            this.tabPage2.Controls.Add(this.ProductManagmentGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 356);
            this.tabPage2.Size = new System.Drawing.Size(806, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DeleteProdManag
            // 
            this.DeleteProdManag.Location = new System.Drawing.Point(243, 302);
            this.DeleteProdManag.Name = "DeleteProdManag";
            this.DeleteProdManag.Size = new System.Drawing.Size(88, 29);
            this.DeleteProdManag.TabIndex = 2;
            this.DeleteProdManag.Text = "Delete";
            this.DeleteProdManag.UseVisualStyleBackColor = true;
            this.DeleteProdManag.Click += new System.EventHandler(this.DeleteProdManag_Click);
            // 
            // AddNewItemProdManag
            // 
            this.AddNewItemProdManag.Location = new System.Drawing.Point(67, 302);
            this.AddNewItemProdManag.Name = "AddNewItemProdManag";
            this.AddNewItemProdManag.Size = new System.Drawing.Size(133, 29);
            this.AddNewItemProdManag.TabIndex = 1;
            this.AddNewItemProdManag.Text = "AddNewItem";
            this.AddNewItemProdManag.UseVisualStyleBackColor = true;
            this.AddNewItemProdManag.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // ProductManagmentGridView
            // 
            this.ProductManagmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductManagmentGridView.Location = new System.Drawing.Point(8, 41);
            this.ProductManagmentGridView.Name = "ProductManagmentGridView";
            this.ProductManagmentGridView.Size = new System.Drawing.Size(936, 178);
            this.ProductManagmentGridView.TabIndex = 0;
            this.ProductManagmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductManagmentGridView_CellContentClick);
            this.ProductManagmentGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ProductManagmentGridView_RowsAdded);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(806, 403);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(806, 403);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RoleGroupMap Manager";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.productCategoryDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(950, 356);
            this.tabPage5.Size = new System.Drawing.Size(806, 403);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Product Category";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddNewColumn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productCategoryDataGridView
            // 
            this.productCategoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productCategoryDataGridView.Location = new System.Drawing.Point(8, 12);
            this.productCategoryDataGridView.Name = "productCategoryDataGridView";
            this.productCategoryDataGridView.Size = new System.Drawing.Size(598, 311);
            this.productCategoryDataGridView.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(806, 403);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 430);
            this.ClientSize = new System.Drawing.Size(958, 383);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProductManagmentGridView;
        private System.Windows.Forms.Button AddNewItemProdManag;
        private System.Windows.Forms.Button DeleteProdManag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productCategoryDataGridView;
    }
}

