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
        MunitForm munitForm;
        WWS.Munit munit;
        public NewMunitAddForm()
        {
            InitializeComponent();
        }

        public NewMunitAddForm( WWS.Munit munit, MunitForm munitForm )
        {
            InitializeComponent();
            this.munitForm = munitForm;
            this.munit = munit;
        }

        public NewMunitAddForm(MunitForm munitForm)
        {
            InitializeComponent();

            this.munitForm = munitForm;
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


                    WWS.WarehouseServiceClient munitManager = new WWS.WarehouseServiceClient(ServiceParametor.Parametor);

                    var allMunit = munitManager.GetActiveMunit();

                    Constants.ApplicationData.Munits = new Dictionary<int, WWS.Munit>();

                    foreach (var item in allMunit)
                    {
                        Constants.ApplicationData.Munits.Add(item.Id.Value, item);
                    }

                    

                        munitForm.LoadMunitToGrid(true);

                    
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

                munitAddTextBox.Text = munit.MunitName;
            }
        }
    }
}
