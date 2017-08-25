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
using WarehouseClient.WWS;


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
            try
            {
                using (var client = new WarehouseServiceClient(ServiceParametor.Parametor))
                {
                    User user = client.Login(textBox1.Text, textBox2.Text);
                    if (user != null)
                    {
                        client.UpdateUserLoginDate(user.Id.Value);
                        this.Hide();
                        var formx = new MainForm(user);
                        formx.Closed += (s, args) => this.Close();
                        formx.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User name or password");
                       
                    }
                }
            }
            catch (System.ServiceModel.FaultException exception) {
                MessageBox.Show($"Connection error\n\n{exception.Message}");
            }
        }
    }
}
