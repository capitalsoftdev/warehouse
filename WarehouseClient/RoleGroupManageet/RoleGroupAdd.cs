using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseClient.WWS;

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
            if (RoleGroupTextBox.Text != "")
            {
                try
                {
                    using (WarehouseServiceClient wwsClient = new WarehouseServiceClient("HTTP"))
                    {
                        wwsClient.CreateOrUpdateRoleGroup(new WWS.RoleGroup() { Name = RoleGroupTextBox.Text });
                    }
                }
                catch
                {

                }
                mainForm.Enabled = true;
                mainForm.RoleGroupDataGridRefresh();
                Close();
            }
            else
            {
                MessageBox.Show("Uncorrect role group name.");
            }
            
        }
    }
}
