using System;
using System.Windows.Forms;
using WarehouseBL.RoleManagement;
using WarehouseDAL.DataContracts;

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
            RoleManager roleManagemer = new RoleManager();
            roleManagemer.CreateOrUpdateRole(new Role() { Name = RoleNameTextBox.Text});
            mainForm.Enabled = true;
            mainForm.RoleDataGridRefresh();
            Close();
        }

        private void RoleAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
