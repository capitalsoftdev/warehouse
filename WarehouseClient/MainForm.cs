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
                UserManager manage = new UserManager();
                IList<User> us = manage.SelectActiveUser();
                dataGridView1.DataSource = us.ToList();
            }
        }


    }
}
