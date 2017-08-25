using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.UserManagement;
using WarehouseClient.Constants;
using WarehouseClient.WWS;

namespace WarehouseClient
{
    public partial class MainForm
    {
        User loginUser;
        public User LoginUser
        {
            get
            {
                return loginUser;
            }

            set
            {
                loginUser = value;
            }
        }

        public MainForm(User user)
        {
            InitializeComponent();
            loginUser = user;
        }
        public void ReloadUserGrid(bool reload = false)
        {


            if (reload)
            {
                using (var client = new WarehouseServiceClient(ServiceParametor.Parametor))
                {
                    foreach (User user in client.SelectActiveUsers())
                    {
                        ApplicationData.Users.Add(user.Id.Value, user);
                    }
                }
                dataGridView1.DataSource = ApplicationData.Users.Values.ToList();
                dataGridView1.Refresh();
            }
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement.AddUser add = new UserManagement.AddUser(this);
            add.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                if ((bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    DialogResult result = MessageBox.Show("DeActivate ?", "IsActive", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //using (var client = new WarehouseServiceClient()
                        //UserManager manager = new UserManager();
                        //manager.ActivateOrDeActivate((Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
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
        public void SingOutChangePabControl()
        {
            tabControl1.SelectedTab = RoleTab;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
