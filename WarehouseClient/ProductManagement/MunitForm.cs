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
    public partial class MunitForm : Form
    {
        WWS.WarehouseServiceClient munitManager = new WWS.WarehouseServiceClient(ServiceParametor.Parametor);
        IList<WWS.Munit> munitList;

        public MunitForm()
        {
            InitializeComponent();
        }

        public void LoadMunitToGrid(bool reLoad)
        {
            try
            {
                if(reLoad)
                {
                    munitList = Constants.ApplicationData.Munits.Select(m => m.Value).ToList();


                    munitDataGridView.DataSource = munitList.ToList();
                    munitDataGridView.Columns[0].Visible = false;
                    munitDataGridView.Columns[1].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MunitForm_Load(object sender, EventArgs e)
        {
            LoadMunitToGrid(true);
        }

        private void addMunitButton_Click(object sender, EventArgs e)
        {
            NewMunitAddForm newMunitAddForm = new NewMunitAddForm(this);
            newMunitAddForm.Show();
        }

        private void disableMunitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRowsList = munitDataGridView.SelectedRows;

                if (selectedRowsList.Count == 0)
                {
                    MessageBox.Show("Select row");
                }
                else
                {
                    
                    foreach (var munit in selectedRowsList)
                    {
                        var a = (DataGridViewRow)munit;
                        int idDisableMunit = munitList[(int)a.Index].Id.Value;
                        munitManager.DisableMunit(idDisableMunit);
                        Constants.ApplicationData.Munits.Remove(idDisableMunit);
                    }
                    this.LoadMunitToGrid(true);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void munitDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NewMunitAddForm newMunitAddForm = new NewMunitAddForm(munitList[e.RowIndex], this);
                newMunitAddForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
