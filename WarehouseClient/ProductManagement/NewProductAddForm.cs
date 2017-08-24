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
using WarehouseBL.ProductManagement;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseClient.ProductManagement
{
    public partial class NewProductAddForm : Form
    {
        MainForm mainFrm;
        bool flag;
        Product product;
        public NewProductAddForm()
        {
            InitializeComponent();
        }

        public NewProductAddForm(MainForm mainFrm, bool flag, Product product)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
            this.flag = flag;
            this.product = product;
        }
        
        private void NewProductAddForm_Load(object sender, EventArgs e)
        {
            var munitData = Constants.ApplicationData.Munits.Select(m => m.Value).ToList();

            munitSelectProductComboBox2.DataSource = munitData.Select(m => m.MunitName).ToList();
            munitSelectProductComboBox2.Tag = munitData;
            

            var productCategoryData = Constants.ApplicationData.ProductCategory.Select(p => p.Value).ToList();

            productCategorySelectProductComboBox1.DataSource = productCategoryData.Select(p => p.Name).ToList();
            productCategorySelectProductComboBox1.Tag = productCategoryData;

            //if add product flag -> false else if update product flag -> true
            if(flag)
            {
                addNewProductLabel1.Text = "Update product";
                newProductAddAndUpdateButton.Text = "Update";
                productCategorySelectProductComboBox1.SelectedItem = Constants.ApplicationData.ProductCategory[product.ProductCategoryId].Name;
                munitSelectProductComboBox2.SelectedItem = Constants.ApplicationData.Munits[product.Munit].MunitName;
                newProductNameTextBox.Text = product.Name;
            }

        }

        private void newProductAddAndUpdateButton_Click(object sender, EventArgs e)
        {
            var productCategorySelect = ((IList<ProductCategory>)productCategorySelectProductComboBox1.Tag).Where(p => p.Name == productCategorySelectProductComboBox1.Text).ToList()[0];

            var munitSelect = ((IList<Munit>)munitSelectProductComboBox2.Tag).Where(m => m.MunitName == munitSelectProductComboBox2.Text).ToList()[0];

            
            var productName = newProductNameTextBox.Text;

            if (munitSelect != null && productCategorySelect != null && productName != "")
            {
                var productAdaptor = new ProductAdaptor();
                if (product == null)
                {  
                    product = new Product() { Name = productName, Munit = munitSelect.Id, ProductCategoryId = productCategorySelect.Id };
                }
                else
                {
                    product.Name = productName;
                    product.Munit = munitSelect.Id;
                    product.ProductCategoryId = productCategorySelect.Id;
                }
                productAdaptor.CreateOrUpdateProduct(product);

                mainFrm.loadProductsInToGrid(true);
                this.Close();
            }
        }
    }
    
}
