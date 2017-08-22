using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseDAL.DataContracts;
using WarehouseBL.UserManagement;


namespace WarehouseClient.UserManagement
{
    public partial class AddUser : Form
    {

        MainForm f;
        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(MainForm form)
        {
            f = form;
            f.Enabled = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addUserName.TextLength>4  && addPassword.Text==addConfirmPassword.Text && addRoleGroup.Text != "" && addPassword.TextLength > 5)
            {
                WarehouseDAL.DataContracts.User user = new WarehouseDAL.DataContracts.User();
                user.Id = -1;
                user.Username = addUserName.Text.ToString();
                user.Password = addPassword.Text.ToString();
                user.RoleGroupId = Convert.ToInt32(addRoleGroup.Text);
                WarehouseBL.UserManagement.UserManager manager = new WarehouseBL.UserManagement.UserManager();
                manager.AddOrInsertUser(user);

                f.Enabled = true;
                f.ReloadUserGrid(true);
                Close();
                
            }
            else {
                label6.Text = "Enter correct user information";
            }
        }

        private void close1(object sender, FormClosedEventArgs e)
        {
            f.Enabled = true;
        }

        private void txtbxconfirmpass_TextChanged(object sender, EventArgs e)
        {
            if (addPassword.Text != addConfirmPassword.Text)
            {
                label6.Text = "Passwords must match";
            }
            else {
                label6.Text = "";
                addUserName_TextChanged(null,null);
            }
        }

        private void txtbxpass_TextChanged(object sender, EventArgs e)
        {
            if (addPassword.TextLength < 6)
            {
                label6.Text = "The password must be at least 10 characters";
            }
            else {
                label6.Text = "";
            }
        }

        private void addUserName_TextChanged(object sender, EventArgs e)
        {
            if (addUserName.TextLength < 5)
            {
                label6.Text = "Min 5 Chars";
            }
            else {
                label6.Text = "";
            }
        }
    }
}
