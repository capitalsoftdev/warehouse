using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.RoleGroupManagement;
using WarehouseDAL.DataContracts;

namespace WarehouseClient.RoleGroupManageet
{
    public partial class RoleGroupAdd : Form
    {
        MainForm mainForm;

        public RoleGroupAdd(MainForm baseForm)
        {
            mainForm = baseForm;
            mainForm.Enabled = false;
            InitializeComponent();
        }

        private void addRoleGroupButton_Click(object sender, EventArgs e)
        {
            RoleGroupManager roleGroupManagemer = new RoleGroupManager();
            roleGroupManagemer.CreateOrUpdateRoleGroup(new RoleGroup() { Name = RoleGroupTextBox.Text });
            mainForm.Enabled = true;
            mainForm.RoleGroupDataGridRefresh();
            Close();
        }
    }
}
