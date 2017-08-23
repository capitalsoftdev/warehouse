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
        static IList<User> userList = null;
        public static IList<User> SelectUsers()
        {
            return userList;
        }
        public MainForm(User user)
        {
            InitializeComponent();
            loginUser = user;
        }
        public void ReloadUserGrid(bool reload = false)
        {
            if (reload)
                WarehouseClient.Constants.ApplicationData.Users = manage.SelectActiveUser();
            dataGridView1.DataSource = WarehouseClient.Constants.ApplicationData.Users.Values.ToList();
            dataGridView1.Refresh();
        }
    

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7 && e.RowIndex!=-1)
            {
                if ((bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    DialogResult result = MessageBox.Show("DeActivate ?", "IsActive", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        UserManager manager = new UserManager();
                        manager.ActivateOrDeActivate((Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    }
                }
                else 
                {
                    DialogResult result = MessageBox.Show("Activate ?", "IsActive", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        UserManager manager = new UserManager();
                        manager.ActivateOrDeActivate((Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    }

                }
                ReloadUserGrid(true);
            }
        }
       
        private void SignOutTab_Enter(object sender, EventArgs e)
        {
            UserManagement.SignOut signOut = new UserManagement.SignOut(this);
            signOut.Show();
        }
        public void SingOutChangePabControl() {
            tabControl1.SelectedTab = RoleTab;
        }
    }
}
