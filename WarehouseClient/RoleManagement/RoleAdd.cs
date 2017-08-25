using System;
using System.Windows.Forms;
using WarehouseClient.WWS;

namespace WarehouseClient.RoleManagement
{
    public partial class RoleAdd : Form
    {
        MainForm mainForm;
        public RoleAdd(MainForm baseForm)
        {
            mainForm = baseForm;
            mainForm.Enabled = false;
            InitializeComponent();
        }

        private void RoleAdd_Load(object sender, EventArgs e)
        {

        }

        private void roleAddButton_Click(object sender, EventArgs e)
        {
            if (RoleNameTextBox.Text != "")
            {
                try
                {
                    using (WarehouseServiceClient wwsClient = new WarehouseServiceClient("HTTP"))
                    {
                        wwsClient.CreateOrUpdateRole(new Role() { Name = RoleNameTextBox.Text });
                    }
                }
                catch
                {

                }
                mainForm.Enabled = true;
                mainForm.RoleDataGridRefresh();
                Close();
            }
            else
            {
                MessageBox.Show("Uncorrect role name.");
            }
        }

        private void RoleAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
