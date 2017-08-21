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
using WarehouseBL.ProductManagmentManagment;
using WarehouseBL.Interfaces;
using WarehouseClient.ProdManagForm;

namespace WarehouseClient
{
    public partial class MainForm : Form
    {
        User loginUser;
        UserManager manage = new UserManager();
        static IList<User> us = null;


        //productManagment
        IProductManagmentManager prodManag = new ProductManagmentManager();
        static IList<ProductManagment> prodManagList = null;

        public static IList<User> SelectUsers()
        {
            return us;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(WarehouseDAL.DataContracts.User user)
        {
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

            //productManagment 
            prodManagList = prodManag.GetItem(0, 0, 0);
            ProductManagmentGridView.DataSource = prodManagList.ToList();
        }
        public void DataRefresh()
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

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
        {
        }
    }
}
