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
            if (textBox1.TextLength>5  && txtbxpass.Text==txtbxconfirmpass.Text && (string)comboBox1.Text!="" && txtbxpass.TextLength > 9)
            {
                WarehouseDAL.DataContracts.User user = new WarehouseDAL.DataContracts.User();
                user.Id = -1;
                user.Username = textBox1.Text.ToString();
                user.Password = txtbxpass.Text.ToString();
                user.RoleGroupId = Convert.ToInt32(comboBox1.Text);
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
            if (textBox1.TextLength < 6)
            {
                label6.Text = "The username must be at least 5 characters";
            }
            else
            {
                label6.Text = "";
                UserManager user = new UserManager();
                IList<User> userlist = MainForm.SelectUsers();
                foreach (User oneuser in userlist) {
                    if (oneuser.Username == textBox1.Text) {
                        label6.Text = "This username is busy";
                    }
                }
            }
        }

        private void txtbxconfirmpass_TextChanged(object sender, EventArgs e)
        {
            if (txtbxpass.Text != txtbxconfirmpass.Text)
            {
                label6.Text = "Passwords must match";
            }
            else {
                label6.Text = "";
                textBox1_TextChanged(null,null);
            }
        }

        private void txtbxpass_TextChanged(object sender, EventArgs e)
        {
            if (txtbxpass.TextLength < 9)
            {
                label6.Text = "The password must be at least 10 characters";
            }
            else {
                label6.Text = "";
            }
        }
    }
}
