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
        public MainForm(User user) {
            InitializeComponent();
            loginUser = user;
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
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            tabPage1.Hide();
        }

   

        private void se(object sender, EventArgs e)
        {
            if ((loginUser.RoleGroupId==1) && (tabControl1.SelectedTab == tabPage1))
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if ((loginUser.RoleGroupId != 1 ) && (tabControl1.SelectedTab == tabPage1))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                tabControl1.SelectedTab = tabPage2;
            }
        }
    }
}
