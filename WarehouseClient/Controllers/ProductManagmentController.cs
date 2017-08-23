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

        
        IList<ProductManagment> GetItems(int id, int productId, int userId)
        {
            return prodManag.GetItem(0, 0, 0);
            
        }
        private void ProductManagementTab_Enter(object sender, EventArgs e)
        {
           // if (tabControl1.SelectedIndex == 1)
           // {                
                prodManagList = GetItems(0, 0, 0);
                if (prodManagList != null)
                {
                    ProductManagmentGridView.DataSource = prodManagList.ToList();
                }
                else
                {
                    MessageBox.Show("Empity list");
                }
           // }

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
            //int selectedIndex = ProductManagmentGridView.SelectedCells[0].RowIndex;
            //var row = ProductManagmentGridView.Rows[selectedIndex];

            var id = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[0].Value);
            var productId = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[1].Value);
            var quantity = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[2].Value);
            var actionDate = Convert.ToDateTime(ProductManagmentGridView.CurrentRow.Cells[3].Value);
            var action = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[4].Value);
            var userId = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[5].Value);
            var price = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[6].Value);
            var supplierId = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[7].Value);
            var reason = Convert.ToString(ProductManagmentGridView.CurrentRow.Cells[8].Value);
            var brand = Convert.ToString(ProductManagmentGridView.CurrentRow.Cells[9].Value);
            var lastModifyDate = Convert.ToDateTime(ProductManagmentGridView.CurrentRow.Cells[10].Value);
            var isActive =Convert.ToBoolean(ProductManagmentGridView.CurrentRow.Cells[11].Value);
        
           // MessageBox.Show(id.ToString());
            
             UpdateProductManagment updateItemForm = new UpdateProductManagment(id, productId, quantity, actionDate, action, userId, reason, price, supplierId, brand, lastModifyDate, isActive);
             updateItemForm.Show();
        }
    }
}
