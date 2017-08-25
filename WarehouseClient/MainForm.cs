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
using WarehouseBL.ProductManagement;

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
                        

                        //WarehouseClient.Constants.ApplicationData.Users = manage.SelectActiveUser();
                        //tabControl1.SelectedTab = UserTab;
                        //dataGridView1.DataSource = WarehouseClient.Constants.ApplicationData.Users.Values.ToList();
                        //dataGridView1.Columns[2].Visible = false;
                        //dataGridView1.Columns[0].Visible = false;
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


        private void MainForm_Activated(object sender, EventArgs e)
        {
   
        }



        private static void LoadAllStaticInfo()
        {
            #region Load Role Groups

            var roleGroupManagerBL = new WarehouseBL.RoleGroupManagement.RoleGroupManager();

            var allRoleGroups = roleGroupManagerBL.GetRoleGroups();

            Constants.ApplicationData.RoleGroups = new Dictionary<int, RoleGroup>();

            foreach (var roleGroup in allRoleGroups)
            {
                Constants.ApplicationData.RoleGroups.Add(roleGroup.Id, roleGroup);
            }

            #endregion

            #region Load Roles

            var roleManagerBL = new WarehouseBL.RoleManagement.RoleManager();

            var allRoles = roleManagerBL.GetRoles();

            Constants.ApplicationData.Roles = new Dictionary<int, Role>();

            foreach(var role in allRoles)
            {
                Constants.ApplicationData.Roles.Add(role.Id, role);
            }
             
            #endregion
            
            #region Load Product Categories

            var prodCategoryBL = new WarehouseBL.ProductCategoryManagement.ProductCategoryManager();

            var allCats = prodCategoryBL.GetAllProductCategories();

            Constants.ApplicationData.ProductCategory = new Dictionary<int, ProductCategory>();

            foreach (var item in allCats)
            {
                Constants.ApplicationData.ProductCategory.Add(item.Id, item);
            }

            #endregion

            #region Load Product

            ProductManager productManager = new ProductManager();

            var allProduct = productManager.GetActiveProduct();

            Constants.ApplicationData.Products = new Dictionary<int, Product>();

            foreach (var item in allProduct)
            {
                Constants.ApplicationData.Products.Add(item.Id.Value, item);
            }


            #endregion

            #region Load Munit

            MunitManager munitManager = new MunitManager();

            var allMunit = munitManager.GetMunit();

            Constants.ApplicationData.Munits = new Dictionary<int, Munit>();

            foreach (var item in allMunit)
            {
                Constants.ApplicationData.Munits.Add(item.Id, item);
            }


            #endregion

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           UserLabel2.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

    }
}