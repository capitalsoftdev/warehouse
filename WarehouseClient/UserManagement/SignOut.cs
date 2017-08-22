using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseClient.UserManagement
{
    public partial class SignOut : Form
    {
        MainForm sendedForm;
        public SignOut(MainForm sendedForm)
        {
           this.sendedForm = sendedForm;
            sendedForm.Enabled = false;
            InitializeComponent();
        }

        private void SignOutButtonYes_Click(object sender, EventArgs e)
        {
            sendedForm.Hide();
            var form = new Login();
            form.Closed += (s, args) => sendedForm.Close();
            form.Show();
            this.Close();
        }

        private void SignOutButtonNo_Click(object sender, EventArgs e)
        {
            sendedForm.Enabled = true;
            sendedForm.SingOutChangePabControl();
            this.Close();
        }

    }
}
