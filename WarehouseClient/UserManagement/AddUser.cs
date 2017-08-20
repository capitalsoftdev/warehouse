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


namespace WarehouseClient.UserManagement
{
    public partial class AddUser : Form
    {
        bool flag;
        Form f;
        public AddUser()
        {
            InitializeComponent();
        }
        public AddUser(Form form)
        {
            f = form;
            f.Enabled = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                WarehouseDAL.DataContracts.User user = new WarehouseDAL.DataContracts.User();
                user.Id = -1;
                user.Username = textBox1.Text.ToString();
                user.Password = txtbxpass.Text.ToString();
                user.RoleGroupId = Convert.ToInt32(txtbxconfirmpass.Text);
                user.IsActive = true;
                user.CreationDate = DateTime.MinValue;
                user.LastModifireDate = DateTime.MinValue;
                user.LastLoginDate = DateTime.MinValue;
                WarehouseBL.UserManagement.UserManager manager = new WarehouseBL.UserManagement.UserManager();
                manager.AddOrInsertUser(user);

                f.Enabled = true;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flag = true;
            if (textBox1.TextLength < 5)
            {
                label6.Text = "The username must be at least five characters";
                flag = false;
            }
            else
            {
                label6.Text = "";
                WarehouseBL.UserManagement.UserManager user = new WarehouseBL.UserManagement.UserManager();
                IList<User> userlist = user.SelectActiveUser();
                foreach (User oneuser in userlist) {
                    if (oneuser.Username == textBox1.Text) {
                        label6.Text = "This username is busy";
                        flag = false;
                    }
                }
            }
        }

        private void txtbxconfirmpass_TextChanged(object sender, EventArgs e)
        {
            flag = true;
            if (txtbxpass.Text != txtbxconfirmpass.Text)
            {
                label6.Text = "Passwords must match";
                flag = false;
            }
            else {
                label6.Text = "";
            }
        }
    }
}
