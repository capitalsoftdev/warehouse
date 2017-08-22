using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Interfaces;
using WarehouseBL.ProductManagmentManagment;
using WarehouseDAL.DataContracts;


namespace WarehouseClient
{
    public partial class MainForm
    {
        IProductManagmentManager prodManag = new ProductManagmentManager();
        static IList<ProductManagment> prodManagList = null;

        //private void tabControl1_Click(object sender, EventArgs e)
        //{
        //    if (tabControl1.SelectedIndex == 1)
        //    {
        //        prodManagList = prodManag.GetItem(0, 0, 0);

        //        ProductManagmentGridView.DataSource = prodManagList.ToList();
        //    }
        //}
        private void AddNewItemProdManag_Click(object sender, EventArgs e)
        {

        }

        private void ProductManagementTab_Click(object sender, EventArgs e)
        {

            prodManagList = prodManag.GetItem(0, 0, 0);

            ProductManagmentGridView.DataSource = prodManagList.ToList();
        }
    }
}
