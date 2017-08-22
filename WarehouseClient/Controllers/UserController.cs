using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.UserManagement;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class MainForm 
    {
        User loginUser;
        UserManager manage = new UserManager();
        static IList<User> us = null;
        public static IList<User> SelectUsers()
        {
            return us;
        }
        public MainForm(User user)
        {
            InitializeComponent();
            loginUser = user;
        }
        public void DataRefresh()
        {
            us = manage.SelectActiveUser();
            dataGridView1.DataSource = us.ToList();
        }
      
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
        public void ReloadUserGrid(bool reload=false) {
            if(reload)
                us = manage.SelectActiveUser();
            dataGridView1.DataSource = us.ToList();
            dataGridView1.Refresh();
        }
        private void SignOutTab_Enter(object sender, EventArgs e)
        {
            UserManagement.SignOut signOut = new UserManagement.SignOut(this);
            signOut.Show();
        }
        public void SingOutChangePabControl() {
            tabControl1.SelectedTab = ProductManagementTab;
        }
    }
}
