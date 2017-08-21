using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.UserManagement;
using WarehouseDAL.DataContracts;
using WarehouseClient.ProductCategoryManagement;
using WarehouseBL.ProductCategoryManagement;

namespace WarehouseClient
{
     public partial class MainForm : Form
    {

        ProductCategoryManager productCategoryManager = new ProductCategoryManager();

        public MainForm()
        {
            InitializeComponent();
        }
       

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (loginUser.RoleGroupId == 1)
            {
                tabControl1.SelectedTab = tabPage1;
                us = manage.SelectActiveUser();
                dataGridView1.DataSource = us.ToList();
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[0].Visible = false;
            }
            else {
                tabControl1.TabPages.Remove(tabPage1);
            }
        //
        IList<ProductCategory> productCategoryList = productCategoryManager.GetAllProductCategories();
        dataGridView2.DataSource = productCategoryList.ToList();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
           // MainForm_Load(null, null);
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductCategory add = new AddProductCategory(this);
            add.Show();
        }

    }
}
