using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseClient.RoleGroupManageet;
using WarehouseClient.RoleManagement;
using WarehouseClient.WWS;

namespace WarehouseClient
{
    public partial class MainForm
    {
        private void RoleTab_Enter(object sender, EventArgs e)
        {
            RoleDataGridRefresh();
            RoleGroupDataGridRefresh();
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            RoleAdd addRole = new RoleAdd(this);
            addRole.Show();
        }


        private void addRoleGroupButton_Click(object sender, EventArgs e)
        {
            RoleGroupAdd addRoleGroup = new RoleGroupAdd(this);
            addRoleGroup.Show();
        }
        
        public void RoleDataGridRefresh()
        {
            using (WarehouseServiceClient wwsClient = new WarehouseServiceClient(ServiceParametor.Parametor))
            {
                IList<Role> roleList = wwsClient.GetRoles().ToList();
                RoleDataGridView.DataSource = roleList.ToList();
            }
        }
        public void RoleGroupDataGridRefresh()
        {
            using (WarehouseServiceClient wwsClient = new WarehouseServiceClient(ServiceParametor.Parametor))
            {
                IList<RoleGroup> roleGroupList = wwsClient.GetRoleGroups().ToList();
                roleGroupDataGridView.DataSource = roleGroupList.ToList();
            }
        }
    }
}
