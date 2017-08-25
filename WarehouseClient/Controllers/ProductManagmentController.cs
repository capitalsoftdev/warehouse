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
using WarehouseClient.Constants;
using System.Collections;
using WarehouseClient.WWS;

namespace WarehouseClient
{
    public partial class MainForm
    {
       // WarehouseServiceClient wwsClient = new WarehouseServiceClient(ServiceParametor.Parametor);
        //WWS.IWarehouseService prodManag = new WWS.WarehouseService();
      //  IProductManagmentManager prodManag = new ProductManagmentManager();

        IList<WWS.ProductManagment> prodManagList = null;

        IList<WWS.Product> productListForProdManag;

        int statusFilterProductId;

        Dictionary<int, WWS.User> userList;
        
        public void ProductManagmentIntoGridView(bool reload, int id, int userId, int productId)
        {
            if(reload)
            {
                using (WarehouseServiceClient client = new WarehouseServiceClient("HTTP"))
                {
                    prodManagList = client.GetItem(id, userId, productId);
                    if (prodManagList == null)
                    {
                        //prodManagList = new List<WWS.ProductManagment>();
                    }
                    productListForProdManag = ApplicationData.Products.Select(p => p.Value).ToList();
                    var pMJOinP = prodManagList.Join(
                       productListForProdManag,
                       p => p.ProductId,
                       m => m.Id,
                       (p, m) => new
                       {
                           Id = p.Id.Value,
                           Product = m.Name,
                           Quantity = p.Quantity,
                           ActionDate = p.ActionDate,
                           Action = p.Action,
                           userId = p.UserId,
                           Reason = p.Reason,
                           Price = p.Price,
                           supplierId = p.SupplierId,
                           brand = p.Brand,
                       }
                       );
                    var userList = client.SelectActiveUsers();
                    var pMJoinPJoinUser = pMJOinP.Join(
                   userList,
                   p => p.userId,
                   u => u.Id,
                   (p, u) => new
                   {
                       Id = p.Id,
                       Product = p.Product,
                       Quantity = p.Quantity,
                       ActionDate = p.ActionDate,
                       Action = p.Action,
                       User = u.Username,
                       Reason = p.Reason,
                       Price = p.Price,
                       supplierId = p.supplierId,
                       brand = p.brand,
                   }
                   );
                    ProductManagmentGridView.DataSource = pMJoinPJoinUser.ToList();
                    ProductManagmentGridView.Columns[0].Visible = false;
                }
            }
        }
        
        private void ProductManagementTab_Enter(object sender, EventArgs e)
        {
          //  try
           // {
                //add elems in ProductCategory ComboBox
                if (CategoryProdMagTabComboBox.Items.Count == 0)
                {
                    foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
                    {
                        CategoryProdMagTabComboBox.Items.Add(elem.Value.Name);
                    }
                }



                //add elems in Product ComboBox
                if (ProductProdManagTabComboBox.Items.Count == 0)
                {
                    foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
                    {
                        ProductProdManagTabComboBox.Items.Add(elem.Value.Name);
                    }
                }


            //  UserManager user = new UserManager();
            //userList = user.SelectActiveUser();
            using (WarehouseServiceClient client = new WarehouseServiceClient("HTTP"))
            {
                var userList = client.SelectActiveUsers();
                foreach (var elem in userList)
                {
                    UserProdManagTabComboBox.Items.Add(elem.Username);
                }
                ProductManagmentIntoGridView(true, 0, 0, 0);
            }
           
           // }
            /*catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

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
                using (WarehouseServiceClient client = new WarehouseServiceClient("HTTP"))
                {
                    foreach (var elem in selectedRows)
                    {
                        client.DeleteItem(Convert.ToInt32(((DataGridViewRow)elem).Cells[0].Value));
                    }
                }
                if(statusFilterProductId != 0)
                {
                    ProductManagmentIntoGridView(true, 0, 0, statusFilterProductId);
                }
                else
                {
                    ProductManagmentIntoGridView(true, 0, 0, 0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //last
        private void UpdateProductManagmentButton_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[0].Value);
            var quantity = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[2].Value);
            var reason = Convert.ToString(ProductManagmentGridView.CurrentRow.Cells[6].Value);
            var price = Convert.ToInt32(ProductManagmentGridView.CurrentRow.Cells[7].Value);
            var brand = Convert.ToString(ProductManagmentGridView.CurrentRow.Cells[9].Value);
            UpdateProductManagment updateItemForm = new UpdateProductManagment(id,  quantity, reason, price, brand, this);
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
                ProductManagmentIntoGridView(true, 0, 0, productId);
                statusFilterProductId = productId;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       private void UserProdManagTabComboBox_SelectedIndexChanged(object sender, EventArgs e)
       {
            using (WarehouseServiceClient client = new WarehouseServiceClient("HTTP"))
            {
                var userList = client.SelectActiveUsers();
                var selectedUser = UserProdManagTabComboBox.SelectedItem.ToString();
                int userId = -1;
                foreach (var elem in userList)
                {
                    if (selectedUser == elem.Username)
                    {
                        userId = Convert.ToInt32(elem.Id);
                        break;
                    }
                }
                ProductManagmentIntoGridView(true, 0, userId, 0);
            }
        }

    }
}
