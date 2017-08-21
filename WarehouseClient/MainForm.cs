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
//using WarehouseBL.ProductCategoryManagement;

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
                {
                    tabControl1.SelectedTab = tabPage1;
                    us = manage.SelectActiveUser();
                    dataGridView1.DataSource = us.ToList();
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[0].Visible = false;
                }
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage1);
            }

            //productManagment 
            prodManagList = prodManag.GetItem(0, 0, 0);
            ProductManagmentGridView.DataSource = prodManagList.ToList();




            //
            IList<ProductCategory> productCategoryList = productCategoryManager.GetAllProductCategories();
           // dataGridView2.DataSource = productCategoryList.ToList();
        //
        IList<ProductCategory> productCategoryList = productCategoryManager.GetAllProductCategories();
        dataGridView2.DataSource = productCategoryList.ToList();
        }
        private void DataRefresh()
        {
            us = manage.SelectActiveUser();
            dataGridView1.DataSource = us.ToList();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
           // MainForm_Load(null, null);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        public void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

    private void tabPage2_Click(object sender, EventArgs e)
    {


    }
    private void button1_Click(object sender, EventArgs e)
    {
        AddProductCategory add = new AddProductCategory(this);
        add.Show();
    }
 
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductCategory add = new AddProductCategory(this);
            add.Show();
        }

    private void AddNewItem_Click(object sender, EventArgs e)
    {
        NewItemProdManag newItem = new NewItemProdManag();
        newItem.Show();
    }

    private void DeleteProdManag_Click(object sender, EventArgs e)
    {
        var id = ProductManagmentGridView.CurrentRow.Cells[1].Value;
        prodManag.DeleteItem(Convert.ToInt32(id));
        //MessageBox.Show(id.ToString());
    }

    private void ProductManagmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // MessageBox.Show( ProductManagmentGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
    }

    private void ProductManagmentGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    { }

    }
}















































































































































































































































































































































































































































































































































































































































































































































































































































































