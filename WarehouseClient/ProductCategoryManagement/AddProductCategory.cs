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
using WarehouseClient.Helpers;
using WarehouseDAL.DataContracts;

namespace WarehouseClient.ProductCategoryManagement
{
    public partial class AddProductCategory : Form
    {
        MainForm mainForm;


        public AddProductCategory(MainForm form)
        {
            mainForm = form;
            mainForm.Enabled = false;
            InitializeComponent();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddProductCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void addProductCategoryButton_Click(object sender, EventArgs e)
        {
            WarehouseDAL.DataContracts.ProductCategory product = new WarehouseDAL.DataContracts.ProductCategory();
            product.Id = -1;
            product.Name = PCTextBox1.Text.ToString();
            var selItem = (ComboBoxKeyValuePair)productCategoryComboBox.SelectedItem;
            if (selItem.m_objKey != null)
            {
                product.ParentId = ((ProductCategory)selItem.m_objKey).Id;
            } 
            
            
            ProductCategoryManager manager = new ProductCategoryManager();
            int result = manager.CreateOrUpdateProductCategory(product);

            if(result==0|| result == 1)
            {
                #region Load Product Categories

                var prodCategoryBL = new WarehouseBL.ProductCategoryManagement.ProductCategoryManager();

                var allCats = prodCategoryBL.GetAllProductCategories();

                Constants.ApplicationData.ProductCategory.Clear();

                foreach (var item in allCats)
                {
                    Constants.ApplicationData.ProductCategory.Add(item.Id, item);
                }

                #endregion
            }

            mainForm.ProductCategoryRefresh();
            mainForm.Enabled = true;
            Close();
        }

        private void AddProductCategory_Load(object sender, EventArgs e)
        {
            var potentialParents = Constants.ApplicationData.ProductCategory.Where(
                p => (p.Value.ParentId == 0 && p.Value.IsActive));
            
            productCategoryComboBox.Items.Add(new ComboBoxKeyValuePair(null, "empty"));
            foreach (var prodCat in potentialParents)
            {
                productCategoryComboBox.Items.Add(new ComboBoxKeyValuePair(prodCat.Value, prodCat.Value.Name));
            }
            productCategoryComboBox.SelectedIndex = 0;

        }
    }
}
