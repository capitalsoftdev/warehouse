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

namespace WarehouseClient
{
    public partial class MainForm : Form
    {
        UserManager manage = new UserManager();
        IList<User> us = null;
        User loginUser;
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
            }
        }

        private void click1(object sender, DataGridViewCellEventArgs e)
        {
            us = manage.SelectActiveUser();
            dataGridView1.DataSource = us.ToList();
        }

        private void doubleclick1(object sender, DataGridViewCellEventArgs e)
        {
         
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }
    }
}
