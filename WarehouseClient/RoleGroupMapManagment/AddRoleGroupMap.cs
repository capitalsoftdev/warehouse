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
        Form mainForm;
        public AddRoleGroupMap(Form form)
        {
            mainForm = form;
            mainForm.Enabled = false;
            InitializeComponent();
        }

        private void AddRoleGroupMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void SubmitRoleGroupMap_button_Click(object sender, EventArgs e)
        {
            WarehouseDAL.DataContracts.RoleGroupMap roleGroupMap = new WarehouseDAL.DataContracts.RoleGroupMap();

            roleGroupMap.RoleGroupId = System.Convert.ToInt32(RoleGroupId_textBox.Text.ToString());
            roleGroupMap.RoleId = System.Convert.ToInt32(RoleId_textBox.Text.ToString());
            RoleGroupMapManager manager = new RoleGroupMapManager();
            manager.CreateRoleGroupMap(roleGroupMap);

            mainForm.Enabled = true;
            Close();
        }
    }
}
