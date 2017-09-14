using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseClient.ProductManagement
{
    public partial class NewMunitAddForm : Form
    {
        MainForm mainFrm;
        WWS.Munit munit;
        public NewMunitAddForm()
        {
            InitializeComponent();
        }

        public NewMunitAddForm(MainForm mainFrm, WWS.Munit munit)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.munit = munit;
        }

        private void addNewOrUpdateMunitButton_Click(object sender, EventArgs e)
        {
            try
            {

                var munitName = munitAddTextBox.Text; 

                if ( munitName != "")
                {
                   WWS.WarehouseServiceClient munitAdaptor = new WWS.WarehouseServiceClient(ServiceParametor.Parametor);
                  if (munit == null)
                    {
                        munit = new WWS.Munit() { MunitName = munitName};
                    }
                    else
                    {
                        munit.MunitName = munitName;
                    }

                    munitAdaptor.CreateOrUpdateMunit(munit);
                  

                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void NewMunitAddForm_Load(object sender, EventArgs e)
        {
            if(munit != null)
            {
                addNewMunitLabel.Text = "Update Munit";
            }
        }
    }
}
