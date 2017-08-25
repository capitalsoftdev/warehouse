namespace WarehouseClient
{
     public partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserLabel2 = new System.Windows.Forms.Label();
            this.UserLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductManagementTab = new System.Windows.Forms.TabPage();
            this.FilterProdManadButton = new System.Windows.Forms.Button();
            this.CategoryProdMagTabComboBox = new System.Windows.Forms.ComboBox();
            this.UserProdManagTabComboBox = new System.Windows.Forms.ComboBox();
            this.ProductProdManagTabComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateProductManagmentButton = new System.Windows.Forms.Button();
            this.DeleteProductManagmentButton = new System.Windows.Forms.Button();
            this.AddProductManagmentButton = new System.Windows.Forms.Button();
            this.ProductManagmentGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.disableProductButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.RoleMapTab = new System.Windows.Forms.TabPage();
            this.addRoleGroupMapButton = new System.Windows.Forms.Button();
            this.RoleGroupMapDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductCategoryTab = new System.Windows.Forms.TabPage();
            this.addProductCategoryButton = new System.Windows.Forms.Button();
            this.productCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.RoleTab = new System.Windows.Forms.TabPage();
            this.addRoleGroupButton = new System.Windows.Forms.Button();
            this.roleGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.addRole = new System.Windows.Forms.Button();
            this.RoleDataGridView = new System.Windows.Forms.DataGridView();
            this.SignOutTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ProductManagementTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductManagmentGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.RoleMapTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGroupMapDataGridView)).BeginInit();
            this.ProductCategoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).BeginInit();
            this.RoleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleGroupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 120;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(572, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.ProductManagementTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.RoleMapTab);
            this.tabControl1.Controls.Add(this.ProductCategoryTab);
            this.tabControl1.Controls.Add(this.RoleTab);
            this.tabControl1.Controls.Add(this.SignOutTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 382);
            this.tabControl1.TabIndex = 1;
            // 
            // UserTab
            // 
            this.UserTab.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.UserTab.Controls.Add(this.panel1);
            this.UserTab.Controls.Add(this.menuStrip1);
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(936, 356);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User management";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.UserLabel2);
            this.panel1.Controls.Add(this.UserLabel1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 318);
            this.panel1.TabIndex = 2;
            // 
            // UserLabel2
            // 
            this.UserLabel2.AutoSize = true;
            this.UserLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel2.Location = new System.Drawing.Point(735, 4);
            this.UserLabel2.Name = "UserLabel2";
            this.UserLabel2.Size = new System.Drawing.Size(0, 25);
            this.UserLabel2.TabIndex = 2;
            // 
            // UserLabel1
            // 
            this.UserLabel1.AutoSize = true;
            this.UserLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel1.Location = new System.Drawing.Point(582, 4);
            this.UserLabel1.Name = "UserLabel1";
            this.UserLabel1.Size = new System.Drawing.Size(156, 25);
            this.UserLabel1.TabIndex = 1;
            this.UserLabel1.Text = "Selected user :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
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
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // ProductManagementTab
            // 
            this.ProductManagementTab.Controls.Add(this.FilterProdManadButton);
            this.ProductManagementTab.Controls.Add(this.CategoryProdMagTabComboBox);
            this.ProductManagementTab.Controls.Add(this.UserProdManagTabComboBox);
            this.ProductManagementTab.Controls.Add(this.ProductProdManagTabComboBox);
            this.ProductManagementTab.Controls.Add(this.UpdateProductManagmentButton);
            this.ProductManagementTab.Controls.Add(this.DeleteProductManagmentButton);
            this.ProductManagementTab.Controls.Add(this.AddProductManagmentButton);
            this.ProductManagementTab.Controls.Add(this.ProductManagmentGridView);
            this.ProductManagementTab.Location = new System.Drawing.Point(4, 22);
            this.ProductManagementTab.Name = "ProductManagementTab";
            this.ProductManagementTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductManagementTab.Size = new System.Drawing.Size(936, 356);
            this.ProductManagementTab.TabIndex = 1;
            this.ProductManagementTab.Text = "Product management";
            this.ProductManagementTab.UseVisualStyleBackColor = true;
            this.ProductManagementTab.Enter += new System.EventHandler(this.ProductManagementTab_Enter);
            // 
            // FilterProdManadButton
            // 
            this.FilterProdManadButton.Location = new System.Drawing.Point(461, 247);
            this.FilterProdManadButton.Name = "FilterProdManadButton";
            this.FilterProdManadButton.Size = new System.Drawing.Size(121, 28);
            this.FilterProdManadButton.TabIndex = 6;
            this.FilterProdManadButton.Text = "Filter";
            this.FilterProdManadButton.UseVisualStyleBackColor = true;
            this.FilterProdManadButton.Click += new System.EventHandler(this.FilterProdManadButton_Click);
            // 
            // CategoryProdMagTabComboBox
            // 
            this.CategoryProdMagTabComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CategoryProdMagTabComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryProdMagTabComboBox.FormattingEnabled = true;
            this.CategoryProdMagTabComboBox.Location = new System.Drawing.Point(19, 14);
            this.CategoryProdMagTabComboBox.Name = "CategoryProdMagTabComboBox";
            this.CategoryProdMagTabComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryProdMagTabComboBox.TabIndex = 5;
            this.CategoryProdMagTabComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryProdMagTabComboBox_SelectedIndexChanged);
            // 
            // UserProdManagTabComboBox
            // 
            this.UserProdManagTabComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UserProdManagTabComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UserProdManagTabComboBox.FormattingEnabled = true;
            this.UserProdManagTabComboBox.Location = new System.Drawing.Point(329, 14);
            this.UserProdManagTabComboBox.Name = "UserProdManagTabComboBox";
            this.UserProdManagTabComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserProdManagTabComboBox.TabIndex = 4;
            this.UserProdManagTabComboBox.SelectedIndexChanged += new System.EventHandler(this.UserProdManagTabComboBox_SelectedIndexChanged);
            // 
            // ProductProdManagTabComboBox
            // 
            this.ProductProdManagTabComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProductProdManagTabComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductProdManagTabComboBox.FormattingEnabled = true;
            this.ProductProdManagTabComboBox.Location = new System.Drawing.Point(186, 14);
            this.ProductProdManagTabComboBox.Name = "ProductProdManagTabComboBox";
            this.ProductProdManagTabComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductProdManagTabComboBox.TabIndex = 4;
            // 
            // UpdateProductManagmentButton
            // 
            this.UpdateProductManagmentButton.Location = new System.Drawing.Point(300, 247);
            this.UpdateProductManagmentButton.Name = "UpdateProductManagmentButton";
            this.UpdateProductManagmentButton.Size = new System.Drawing.Size(130, 29);
            this.UpdateProductManagmentButton.TabIndex = 3;
            this.UpdateProductManagmentButton.Text = "Update";
            this.UpdateProductManagmentButton.UseVisualStyleBackColor = true;
            this.UpdateProductManagmentButton.Click += new System.EventHandler(this.UpdateProductManagmentButton_Click);
            // 
            // DeleteProductManagmentButton
            // 
            this.DeleteProductManagmentButton.Location = new System.Drawing.Point(186, 247);
            this.DeleteProductManagmentButton.Name = "DeleteProductManagmentButton";
            this.DeleteProductManagmentButton.Size = new System.Drawing.Size(88, 29);
            this.DeleteProductManagmentButton.TabIndex = 2;
            this.DeleteProductManagmentButton.Text = "Delete";
            this.DeleteProductManagmentButton.UseVisualStyleBackColor = true;
            this.DeleteProductManagmentButton.Click += new System.EventHandler(this.DeleteProductManagmentButton_Click);
            // 
            // AddProductManagmentButton
            // 
            this.AddProductManagmentButton.Location = new System.Drawing.Point(8, 247);
            this.AddProductManagmentButton.Name = "AddProductManagmentButton";
            this.AddProductManagmentButton.Size = new System.Drawing.Size(133, 29);
            this.AddProductManagmentButton.TabIndex = 1;
            this.AddProductManagmentButton.Text = "Add";
            this.AddProductManagmentButton.UseVisualStyleBackColor = true;
            this.AddProductManagmentButton.Click += new System.EventHandler(this.AddProductManagmentButton_Click);
            // 
            // ProductManagmentGridView
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductManagmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.ProductManagmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductManagmentGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.ProductManagmentGridView.Location = new System.Drawing.Point(8, 41);
            this.ProductManagmentGridView.Name = "ProductManagmentGridView";
            this.ProductManagmentGridView.Size = new System.Drawing.Size(936, 178);
            this.ProductManagmentGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.productDataGridView);
            this.tabPage3.Controls.Add(this.disableProductButton);
            this.tabPage3.Controls.Add(this.addNewProductButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(936, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // productDataGridView
            // 
            this.productDataGridView.Location = new System.Drawing.Point(13, 51);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(561, 194);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellDoubleClick);
            // 
            // disableProductButton
            // 
            this.disableProductButton.Location = new System.Drawing.Point(171, 8);
            this.disableProductButton.Name = "disableProductButton";
            this.disableProductButton.Size = new System.Drawing.Size(159, 24);
            this.disableProductButton.TabIndex = 1;
            this.disableProductButton.Text = "Disable product";
            this.disableProductButton.UseVisualStyleBackColor = true;
            this.disableProductButton.Click += new System.EventHandler(this.disableProductButton_Click);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(13, 7);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(133, 26);
            this.addNewProductButton.TabIndex = 0;
            this.addNewProductButton.Text = "Add new product";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // RoleMapTab
            // 
            this.RoleMapTab.Controls.Add(this.addRoleGroupMapButton);
            this.RoleMapTab.Controls.Add(this.RoleGroupMapDataGridView);
            this.RoleMapTab.Location = new System.Drawing.Point(4, 22);
            this.RoleMapTab.Name = "RoleMapTab";
            this.RoleMapTab.Size = new System.Drawing.Size(936, 356);
            this.RoleMapTab.TabIndex = 3;
            this.RoleMapTab.Text = "RoleGroupMap Manager";
            this.RoleMapTab.UseVisualStyleBackColor = true;
            // 
            // addRoleGroupMapButton
            // 
            this.addRoleGroupMapButton.Location = new System.Drawing.Point(263, 29);
            this.addRoleGroupMapButton.Name = "addRoleGroupMapButton";
            this.addRoleGroupMapButton.Size = new System.Drawing.Size(75, 23);
            this.addRoleGroupMapButton.TabIndex = 1;
            this.addRoleGroupMapButton.Text = "Add";
            this.addRoleGroupMapButton.UseVisualStyleBackColor = true;
            // 
            // RoleGroupMapDataGridView
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleGroupMapDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.RoleGroupMapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoleGroupMapDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.RoleGroupMapDataGridView.Location = new System.Drawing.Point(3, 3);
            this.RoleGroupMapDataGridView.Name = "RoleGroupMapDataGridView";
            this.RoleGroupMapDataGridView.Size = new System.Drawing.Size(240, 150);
            this.RoleGroupMapDataGridView.TabIndex = 0;
            // 
            // ProductCategoryTab
            // 
            this.ProductCategoryTab.Controls.Add(this.addProductCategoryButton);
            this.ProductCategoryTab.Controls.Add(this.productCategoryDataGridView);
            this.ProductCategoryTab.Location = new System.Drawing.Point(4, 22);
            this.ProductCategoryTab.Name = "ProductCategoryTab";
            this.ProductCategoryTab.Size = new System.Drawing.Size(936, 356);
            this.ProductCategoryTab.TabIndex = 4;
            this.ProductCategoryTab.Text = "Product Category";
            this.ProductCategoryTab.UseVisualStyleBackColor = true;
            this.ProductCategoryTab.Enter += new System.EventHandler(this.ProductCategoryTab_Enter);
            // 
            // addProductCategoryButton
            // 
            this.addProductCategoryButton.Location = new System.Drawing.Point(250, 343);
            this.addProductCategoryButton.Name = "addProductCategoryButton";
            this.addProductCategoryButton.Size = new System.Drawing.Size(102, 23);
            this.addProductCategoryButton.TabIndex = 1;
            this.addProductCategoryButton.Text = "AddNewColumn";
            this.addProductCategoryButton.UseVisualStyleBackColor = true;
            this.addProductCategoryButton.Click += new System.EventHandler(this.addProductCategoryButton_Click);
            // 
            // productCategoryDataGridView
            // 
            this.productCategoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productCategoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.productCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productCategoryDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.productCategoryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productCategoryDataGridView.Location = new System.Drawing.Point(8, 12);
            this.productCategoryDataGridView.Name = "productCategoryDataGridView";
            this.productCategoryDataGridView.Size = new System.Drawing.Size(598, 311);
            this.productCategoryDataGridView.TabIndex = 0;
            // 
            // RoleTab
            // 
            this.RoleTab.Controls.Add(this.addRoleGroupButton);
            this.RoleTab.Controls.Add(this.roleGroupDataGridView);
            this.RoleTab.Controls.Add(this.addRole);
            this.RoleTab.Controls.Add(this.RoleDataGridView);
            this.RoleTab.Location = new System.Drawing.Point(4, 22);
            this.RoleTab.Name = "RoleTab";
            this.RoleTab.Size = new System.Drawing.Size(936, 356);
            this.RoleTab.TabIndex = 5;
            this.RoleTab.Text = "Role";
            this.RoleTab.UseVisualStyleBackColor = true;
            this.RoleTab.Enter += new System.EventHandler(this.RoleTab_Enter);
            // 
            // addRoleGroupButton
            // 
            this.addRoleGroupButton.Location = new System.Drawing.Point(511, 41);
            this.addRoleGroupButton.Name = "addRoleGroupButton";
            this.addRoleGroupButton.Size = new System.Drawing.Size(91, 23);
            this.addRoleGroupButton.TabIndex = 3;
            this.addRoleGroupButton.Text = "Add Role Group";
            this.addRoleGroupButton.UseVisualStyleBackColor = true;
            this.addRoleGroupButton.Click += new System.EventHandler(this.addRoleGroupButton_Click);
            // 
            // roleGroupDataGridView
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleGroupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.roleGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roleGroupDataGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.roleGroupDataGridView.Location = new System.Drawing.Point(255, 3);
            this.roleGroupDataGridView.Name = "roleGroupDataGridView";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roleGroupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.roleGroupDataGridView.Size = new System.Drawing.Size(240, 350);
            this.roleGroupDataGridView.TabIndex = 2;
            // 
            // addRole
            // 
            this.addRole.Location = new System.Drawing.Point(511, 12);
            this.addRole.Name = "addRole";
            this.addRole.Size = new System.Drawing.Size(91, 23);
            this.addRole.TabIndex = 1;
            this.addRole.Text = "Add Role";
            this.addRole.UseVisualStyleBackColor = true;
            this.addRole.Click += new System.EventHandler(this.addRole_Click);
            // 
            // RoleDataGridView
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.RoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoleDataGridView.DefaultCellStyle = dataGridViewCellStyle22;
            this.RoleDataGridView.Location = new System.Drawing.Point(9, 3);
            this.RoleDataGridView.Name = "RoleDataGridView";
            this.RoleDataGridView.Size = new System.Drawing.Size(240, 350);
            this.RoleDataGridView.TabIndex = 0;
            // 
            // SignOutTab
            // 
            this.SignOutTab.Location = new System.Drawing.Point(4, 22);
            this.SignOutTab.Name = "SignOutTab";
            this.SignOutTab.Size = new System.Drawing.Size(936, 356);
            this.SignOutTab.TabIndex = 6;
            this.SignOutTab.Text = "Sign out";
            this.SignOutTab.UseVisualStyleBackColor = true;
            this.SignOutTab.Enter += new System.EventHandler(this.SignOutTab_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductManagementTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductManagmentGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.RoleMapTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoleGroupMapDataGridView)).EndInit();
            this.ProductCategoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).EndInit();
            this.RoleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleGroupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage ProductManagementTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage RoleMapTab;
        private System.Windows.Forms.TabPage ProductCategoryTab;
        private System.Windows.Forms.TabPage RoleTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProductManagmentGridView;
        private System.Windows.Forms.Button AddProductManagmentButton;
        private System.Windows.Forms.Button DeleteProductManagmentButton;
        private System.Windows.Forms.Button addProductCategoryButton;
        private System.Windows.Forms.DataGridView productCategoryDataGridView;
        private System.Windows.Forms.Button UpdateProductManagmentButton;
        private System.Windows.Forms.ComboBox ProductProdManagTabComboBox;
        private System.Windows.Forms.ComboBox UserProdManagTab;
        private System.Windows.Forms.DataGridView RoleGroupMapDataGridView;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button disableProductButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button addRole;
        private System.Windows.Forms.DataGridView RoleDataGridView;
        private System.Windows.Forms.TabPage SignOutTab;
        private System.Windows.Forms.ComboBox UserProdManagTabComboBox;
        private System.Windows.Forms.Button addRoleGroupMapButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UserLabel1;
        private System.Windows.Forms.Label UserLabel2;
        private System.Windows.Forms.DataGridView roleGroupDataGridView;
        private System.Windows.Forms.ComboBox CategoryProdMagTabComboBox;
        private System.Windows.Forms.Button FilterProdManadButton;
        private System.Windows.Forms.Button addRoleGroupButton;
    }
}

