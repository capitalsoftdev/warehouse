using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.ProductCategoryManagement;
using WarehouseClient.Constants;
using WarehouseDAL.DataContracts;
using WarehouseClient.Helpers;
using WarehouseBL.Interfaces;
using WarehouseBL.ProductManagmentManagment;

namespace WarehouseClient.ProdManagForm
{
    public partial class NewItemProdManag : Form
    {
        MainForm sendedForm;
        IProductManagmentManager prodManagManager = null;  
        public NewItemProdManag(MainForm sendedForm)
        {
            this.sendedForm = sendedForm;
            InitializeComponent();
        }


        private void NewItemProdManag_Load(object sender, EventArgs e)
        {

            //add elems in ProductCategory ComboBox
            foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
            {
                CategoryComboBox.Items.Add(elem.Value.Name);
            }

            //add elems in Product ComboBox
            foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                ProductComboBox.Items.Add(elem.Value.Name);
            }

            //var potentialParents = Constants.ApplicationData.ProductCategory.Where(
            //   p => (p.Value.ParentId == 0 && p.Value.IsActive));
            //foreach (var prodCat in potentialParents)
            //{
            //    CategoryComboBox.Items.Add(new ComboBoxKeyValuePair(prodCat.Value, prodCat.Value.Name));
            //}



            ////add elems in ActionComboBox
            //ActionComboBox.Items.Add(ActionProduct.Acceptance);
            //ActionComboBox.Items.Add(ActionProduct.Ouptut);
            //ActionComboBox.Items.Add(ActionProduct.WriteOff);

            //var productCategoryBL = new ProductCategoryManager();
            //var productCategoryData = productCategoryBL.GetAllProductCategories();
            //CategoryComboBox.DataSource = productCategoryData.Select(p => p.Name).ToList();
            //CategoryComboBox.Tag = productCategoryData;
        }

        private void AddItemProductManagment_Click(object sender, EventArgs e)
        {
            //get Id
            //var selItem = CategoryComboBox.SelectedItem;

            var productSelect = ProductComboBox.SelectedItem.ToString();
            var productId = -1;
            foreach(var prodSel in WarehouseClient.Constants.ApplicationData.Products)
            {
                if(productSelect == prodSel.Value.Name)
                {
                    productId = prodSel.Key;
                }
            }


            var quantity = Convert.ToInt32(QuantityTextBox.Text);
            var userId = Convert.ToInt32(this.sendedForm.LoginUser.Id);
            var reason = Convert.ToString(ReasonLabel.Text);
            var price = Convert.ToInt32(PriceTextBox.Text);
            var supplierid = Convert.ToInt32(SupplierIdTextBox.Text);
            var brand = Convert.ToString(BrandTextBox.Text);

            prodManagManager = new ProductManagmentManager();
            WarehouseDAL.DataContracts.ProductManagment prodManag = new WarehouseDAL.DataContracts.ProductManagment();
            prodManag.ProductId = productId;
            prodManag.Quantity = quantity;
            prodManag.ActionDate = DateTime.Now;
            prodManag.Action = Convert.ToInt32(ActionProduct.Acceptance);
            prodManag.UserId = userId;
            prodManag.Reason = reason;
            prodManag.Price = price;
            prodManag.SupplierId = supplierid;
            prodManag.Brand = brand;
            prodManag.LastModifyDate = DateTime.Now;
            prodManag.IsActive = true;
            prodManagManager.CreateOrUpdate(prodManag);
            //MessageBox.Show(productId.ToString());
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductComboBox.Items.Clear();
            var categorySelect = CategoryComboBox.SelectedItem.ToString();
            var categoryId = -1;

            foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
            {
                if (categorySelect == elem.Value.Name)
                {
                    categoryId = elem.Key;
                    break;
                }
            }

            foreach(var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                if(categoryId == elem.Value.ProductCategoryId)
                {
                    ProductComboBox.Items.Add(elem.Value.Name);
                }
            }
        }
    }
}
