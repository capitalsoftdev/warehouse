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
namespace WarehouseClient
{
    public partial class MainForm
    {
        WWS.IWarehouseService prodManag = null;

        IList<WWS.ProductManagment> prodManagList = null;

        IList<Product> productListForProdManag;

        int statusFilterProductId;

        Dictionary<int, User> userList;
        
        public void ProductManagmentIntoGridView(bool reload, int id, int userId, int productId)
        {
            if(reload)
            {
                prodManagList = prodManag.GetItem(id, userId, productId);
                if(prodManagList == null)
                {
                    prodManagList = new List<WWS.ProductManagment>();
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

                UserManager user = new UserManager();
                userList = user.SelectActiveUser();
                var pMJoinPJoinUser = pMJOinP.Join(
                    userList,
                    p => p.userId,
                    u => u.Value.Id,
                    (p, u) => new
                    {
                        Id = p.Id,
                        Product = p.Product,
                        Quantity = p.Quantity,
                        ActionDate = p.ActionDate,
                        Action = p.Action,
                        User = u.Value.Username,
                        Reason = p.Reason,
                        Price = p.Price,
                        supplierId = p.supplierId,
                        brand = p.brand,
                    }
                    );
               //var enumList = Enum.GetValues(typeof(ActionProduct)).Cast<ActionProduct>().ToList();
               //.Select(x => x.ToString()).ToList();

                ProductManagmentGridView.DataSource = pMJoinPJoinUser.ToList();
                ProductManagmentGridView.Columns[0].Visible = false;
            }
        }
        
        private void ProductManagementTab_Enter(object sender, EventArgs e)
        {
            try
            {
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
            

                UserManager user = new UserManager();
                userList = user.SelectActiveUser();
                foreach(var elem in userList)
                {
                    UserProdManagTabComboBox.Items.Add(elem.Value.Username);
                }
                ProductManagmentIntoGridView(true, 0, 0, 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if(statusFilterProductId != 0)
                {
                    ProductManagmentIntoGridView(true, 0, 0, statusFilterProductId);
                    //prodManagList = prodManag.GetItem(0, 0, statusFilter);
                    //if(prodManagList == null)
                    //{
                    //    prodManagList = new List<ProductManagment>();
                    //}
                    //ProductManagmentGridView.DataSource = prodManagList.ToList();
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
             var selectedUser = UserProdManagTabComboBox.SelectedItem.ToString();
            int userId = -1;
            foreach(var elem in userList)
            {
                if(selectedUser == elem.Value.Username)
                {
                    userId = Convert.ToInt32(elem.Value.Id);
                    break;
                }
            }
            prodManagList = prodManag.GetItem(0, userId, 0);
            ProductManagmentGridView.DataSource = prodManagList.ToList();
           
        }

    }
}
