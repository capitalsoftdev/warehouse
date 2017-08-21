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

        User loginUser;
        UserManager manage = new UserManager();
        static IList<User> us = null;
        public static IList<User> SelectUsers()
        {
            return us;
        }
       
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(WarehouseDAL.DataContracts.User user) {
            InitializeComponent();
            loginUser = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
            if (loginUser.RoleGroupId == 1)
            {      
                us = manage.SelectActiveUser();
                dataGridView1.DataSource = us.ToList();
                dataGridView1.Columns[2].Visible = false;
            }


            //
            IList<ProductCategory> productCategoryList = productCategoryManager.GetAllProductCategories();
            productCategoryDataGridView.DataSource = productCategoryList.ToList();
        }
        public  void DataRefresh()
        {
                us = manage.SelectActiveUser();
                dataGridView1.DataSource = us.ToList();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show();
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            dataGridView1.Columns[2].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductCategory add = new AddProductCategory(this);
            add.Show();
        }

    }
}
