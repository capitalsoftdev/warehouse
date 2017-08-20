using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.UserManagement;

namespace WarehouseClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager();
            WarehouseDAL.DataContracts.User user1 = user.Login(textBox1.Text, textBox2.Text);
            if (user1 == null)
            {
                MessageBox.Show("Invalid User name or password\nAshot, 12c3sddd4);");
            }
            else
            {
                user.UpdateUserLoginDate(user1.Id.Value);
                this.Hide();
                var formx = new MainForm(user1);
                formx.Closed += (s, args) => this.Close();
                formx.Show();
            }
        }
    }
}
