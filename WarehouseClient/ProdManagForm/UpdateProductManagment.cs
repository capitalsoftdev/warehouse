using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.Interfaces;
using WarehouseBL.ProductManagmentManagment;
using WarehouseClient.Constants;
using WarehouseDAL.DataContracts;

namespace WarehouseClient.ProdManagForm
{
    public partial class UpdateProductManagment : Form
    {
        IProductManagmentManager prodManagManager = new ProductManagmentManager();
        ProductManagment that = null;

        MainForm sendedForm;

        public UpdateProductManagment()
        {
            InitializeComponent();
        }

        public UpdateProductManagment(int id,  int quantity,  string reason, int price, string brand, MainForm sendedFrom)
        {
            InitializeComponent();
            that = new ProductManagment();
            that.Id = id;
            that.Quantity = quantity;
            that.Reason = reason;
            that.Price = price;
            that.Brand = brand;
            this.sendedForm = sendedFrom;
        }

        private void UpdateProductManagment_Load(object sender, EventArgs e)
        {
            if (CategoryUpdateComboBox.Items.Count == 0)
            {
                foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
                {
                    CategoryUpdateComboBox.Items.Add(elem.Value.Name);
                }
            }

            //add elems in Product ComboBox
            if (ProductUpdateComboBox.Items.Count == 0)
            {
                foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
                {
                    ProductUpdateComboBox.Items.Add(elem.Value.Name);
                }
            }
            QuantityUpdateTextBox.Text = that.Quantity.ToString();
            ReasonUpdateTextBox.Text = that.Reason.ToString();
            PriceUpdateTextBox.Text = that.Price.ToString();
            BrandUpdateTextBox.Text = that.Brand.ToString();

            ActionUpdateComboBox.Items.Add(ActionProduct.Acceptance);
            ActionUpdateComboBox.Items.Add(ActionProduct.Ouptut);
            ActionUpdateComboBox.Items.Add(ActionProduct.WriteOff);
        }

        private void CategoryUpdateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categorySelect = CategoryUpdateComboBox.SelectedItem.ToString();
            var categoryId = -1;
          

            foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
            {
                if (categorySelect == elem.Value.Name)
                {
                    categoryId = elem.Key;
                    break;
                }
            }
            ProductUpdateComboBox.Items.Clear();
            foreach (var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                if (categoryId == elem.Value.ProductCategoryId)
                {
                    ProductUpdateComboBox.Items.Add(elem.Value.Name);
                }
            }
        }
        private void SaveUpdateButton_Click(object sender, EventArgs e)
        {
            var selItem = CategoryUpdateComboBox.SelectedItem;
            var productSelect = ProductUpdateComboBox.SelectedItem.ToString();
            var productId = -1;
            foreach (var prodSel in WarehouseClient.Constants.ApplicationData.Products)
            {
                if (productSelect == prodSel.Value.Name)
                {
                    productId = prodSel.Key;
                }
            }

            prodManagManager = new ProductManagmentManager();

            ProductManagment prodManag = new ProductManagment();
            prodManag.Id = that.Id;
            prodManag.ProductId = productId;
            prodManag.ActionDate = DateTime.Now;
            prodManag.Quantity = Convert.ToDecimal(QuantityUpdateTextBox.Text.Trim());
            prodManag.Reason = ReasonUpdateTextBox.Text.Trim();
            prodManag.UserId = Convert.ToInt32(this.sendedForm.LoginUser.Id);
            prodManag.Brand = BrandUpdateTextBox.Text.Trim();
            prodManag.Price = Convert.ToInt32(PriceUpdateTextBox.Text.Trim());
            prodManag.Action = Convert.ToInt32(ActionUpdateComboBox.SelectedItem);
            prodManag.SupplierId = Convert.ToInt32(SupplierIdTextBox.Text.Trim());
            prodManag.LastModifyDate = DateTime.Now;
            prodManag.IsActive = true;
            prodManagManager.CreateOrUpdate(prodManag);

            //poxel 
            sendedForm.ProductManagmentIntoGridView(true, 0, 0,0);
            this.Close();

        }


    }
}
