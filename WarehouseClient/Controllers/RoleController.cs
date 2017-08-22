using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.RoleManagement;
using WarehouseClient.RoleManagement;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class MainForm
    {
        RoleManager roleManager = new RoleManager();

        private void RoleTab_Enter(object sender, EventArgs e)
        {
            RoleDataGridRefresh();
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            RoleAdd addRole = new RoleAdd(this);
            addRole.Show();
        }
        
        public void RoleDataGridRefresh()
        {
            IList<Role> roleList = roleManager.GetRole();
            RoleDataGridView.DataSource = roleList.ToList();
        }
    }
}
