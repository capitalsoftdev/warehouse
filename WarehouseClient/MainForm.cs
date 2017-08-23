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
using WarehouseClient.ProdManagForm;
//using WarehouseBL.ProductCategoryManagement;

namespace WarehouseClient
{
     public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllStaticInfo();
            switch (loginUser.RoleGroupId)
            {
                case 1: {

                        WarehouseClient.Constants.ApplicationData.Users = manage.SelectActiveUser();
                        tabControl1.SelectedTab = UserTab;
                        dataGridView1.DataSource = WarehouseClient.Constants.ApplicationData.Users.Values.ToList();
                        dataGridView1.Columns[2].Visible = false;
                        dataGridView1.Columns[0].Visible = false;
                        break;
                        }
               default:
                        {
                        tabControl1.TabPages.Remove(UserTab);
                        tabControl1.TabPages.Remove(RoleTab);
                        tabControl1.TabPages.Remove(RoleMapTab);
                        break;
                        }
            } 
        }
        //private void DataRefresh()
        //{
        //    us = manage.SelectActiveUser();
        //    dataGridView1.DataSource = us.ToList();
        //}

        private void MainForm_Activated(object sender, EventArgs e)
        {
           // MainForm_Load(null, null);
        }

        private void roleGroupMapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    var form = new Login();
        //    form.Closed += (s, args) => this.Close();
        //    form.Show();
        //}

        //public void addToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    UserManagement.AddUser add = new UserManagement.AddUser(this);
        //    add.Show();
        //}

        private static void LoadAllStaticInfo()
        {
            #region Load Product Categories

            var prodCategoryBL = new WarehouseBL.ProductCategoryManagement.ProductCategoryManager();

            var allCats = prodCategoryBL.GetAllProductCategories();

            Constants.ApplicationData.ProductCategory = new Dictionary<int, ProductCategory>();

            foreach (var item in allCats)
            {
                Constants.ApplicationData.ProductCategory.Add(item.Id, item);
            }
            
            #endregion
        }

        
    }
}