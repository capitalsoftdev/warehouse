using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.RoleGroupMapManagment;

namespace WarehouseClient.RoleGroupMapManagment
{
    public partial class AddRoleGroupMap : Form
    {
        public AddRoleGroupMap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarehouseDAL.DataContracts.RoleGroupMap rgm = new WarehouseDAL.DataContracts.RoleGroupMap();
            rgm.RoleGroupId = Convert.ToInt32(textBox1.Text);
            rgm.RoleId      = Convert.ToInt32(textBox2.Text);
            WarehouseBL.RoleGroupMapManagment.RoleGroupMapManager manager = new WarehouseBL.RoleGroupMapManagment.RoleGroupMapManager();
            manager.CreateRoleGroupMap(rgm);

            


        }
    }
}
