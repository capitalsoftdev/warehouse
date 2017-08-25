using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.Interfaces;
using WarehouseBL.ProductManagmentManagment;
using WarehouseBL.UserManagement;
using WarehouseClient.ProdManagForm;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class MainForm
    {
        IProductManagmentManager prodManag = new ProductManagmentManager();
        static IList<ProductManagment> prodManagList = null;

        int statusFilter;

        Dictionary<int, User> userList;
        public void ProductManagmentIntoGridView(bool reload)
        {
            if(reload)
            {
                prodManagList = prodManag.GetItem(0, 0, 0);
                ProductManagmentGridView.DataSource = prodManagList.ToList();
            }
        }
        
        private void ProductManagementTab_Enter(object sender, EventArgs e)
        {
            try
            {
                CategoryProdMagTabComboBox.Items.Clear();
                ProductProdManagTabComboBox.Items.Clear();

                //add elems in ProductCategory ComboBox
                foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
                {
                    CategoryProdMagTabComboBox.Items.Add(elem.Value.Name);
                }

                //add elems in Product ComboBox
                foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
                {
                    ProductProdManagTabComboBox.Items.Add(elem.Value.Name);
                }

                UserManager user = new UserManager();
                //userList = user.SelectActiveUser();
                foreach(var elem in userList)
                {
                    UserProdManagTabComboBox.Items.Add(elem.Value.Username);
                }
                ProductManagmentIntoGridView(true);
            }
            catch(Exception ex)
            {

            }

        }


        private void AddProductManagmentButton_Click(object sender, EventArgs e)
        {
            NewItemProdManag newItemForm = new NewItemProdManag(this);
            newItemForm.Show();
        }

        
        private void DeleteProductManagmentButton_Click(object sender, EventArgs e)
        {
            var selectedRows = ProductManagmentGridView.SelectedRows;
            try
            {
                foreach(var elem in selectedRows)
                {
                    prodManag.DeleteItem(Convert.ToInt32(((DataGridViewRow)elem).Cells[0].Value));
                }
                if(statusFilter != 0)
                {
                    prodManagList = prodManag.GetItem(0, 0, statusFilter);
                    ProductManagmentGridView.DataSource = prodManagList.ToList();
                }
                else
                {
                    ProductManagmentIntoGridView(true);
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void UpdateProductManagmentButton_Click(object sender, EventArgs e)
        {
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
            
            UpdateProductManagment updateItemForm = new UpdateProductManagment(id, productId, quantity, actionDate, action, userId, reason, price, supplierId, brand, lastModifyDate, isActive);
            updateItemForm.Show();
        }

        private void CategoryProdMagTabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductProdManagTabComboBox.Items.Clear();
            var categorySelect = CategoryProdMagTabComboBox.SelectedItem.ToString();
            var categoryId = -1;

            foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
            {
                if (categorySelect == elem.Value.Name)
                {
                    categoryId = elem.Key;
                    break;
                }
            }

            foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                if (categoryId == elem.Value.ProductCategoryId)
                {
                    ProductProdManagTabComboBox.Items.Add(elem.Value.Name);
                }
            }
        }
        private void FilterProdManadButton_Click(object sender, EventArgs e)
        {
            var selectedProduct = ProductProdManagTabComboBox.SelectedItem.ToString();
            var productId = -1;
            foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                if (selectedProduct == elem.Value.Name)
                {
                    productId = elem.Key;
                    break;
                }
            }

            try
            {
                prodManagList = prodManag.GetItem(0, 0, productId);
                ProductManagmentGridView.DataSource = prodManagList.ToList();
                statusFilter = productId;

            }catch(Exception ex)
            {

            }
        }


       private void UserProdManagTabComboBox_SelectedIndexChanged(object sender, EventArgs e)
       {
            var selectedUser = UserProdManagTabComboBox.SelectedItem.ToString();
            int userId = -1;
            foreach(var elem in userList)
            {
                if(selectedUser == elem.Value.Username)
                {
                    userId = Convert.ToInt32(elem.Value.Id);
                }
            }
            prodManagList = prodManag.GetItem(0, userId, 0);
            ProductManagmentGridView.DataSource = prodManagList.ToList();
           // MessageBox.Show(userId.ToString());
        }
    }
}
