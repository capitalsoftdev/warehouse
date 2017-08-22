using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.Interfaces;
using WarehouseBL.ProductManagmentManagment;
using WarehouseClient.ProdManagForm;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class MainForm
    {
        IProductManagmentManager prodManag = new ProductManagmentManager();
        static IList<ProductManagment> prodManagList = null;
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                prodManagList = prodManag.GetItem(0, 0, 0);
                if (prodManagList != null)
                {
                    ProductManagmentGridView.DataSource = prodManagList.ToList();
                }
                else
                {
                    MessageBox.Show("Empity list");
                }
            }

        }


        private void AddProductManagmentButton_Click(object sender, EventArgs e)
        {
            NewItemProdManag newItemForm = new NewItemProdManag();
            newItemForm.Show();
        }

        private void DeleteProductManagmentButton_Click(object sender, EventArgs e)
        {
            var id = ProductManagmentGridView.CurrentRow.Cells[0].Value;
            prodManag.DeleteItem(Convert.ToInt32(id.ToString()));

            //stugel
            //prodManagList = prodManag.GetItem(0, 0, 0);
            //ProductManagmentGridView.DataSource = prodManagList.ToList();
        }

        private void UpdateProductManagmentButton_Click(object sender, EventArgs e)
        {
            UpdateProductManagment updateItemForm = new UpdateProductManagment();
            updateItemForm.Show();
        }
    }
}
