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
        public NewProductAddForm()
        {
            InitializeComponent();
        }

        public NewProductAddForm(MainForm mainFrm)
        {
            InitializeComponent();
            this.mainFrm = mainFrm;
        }

        

       

        private void NewProductAddForm_Load(object sender, EventArgs e)
        {
            var munitBL = new MunitManager();

            var munitData = munitBL.GetMunit();

            munitSelectProductComboBox2.DataSource = munitData.Select(m => m.MunitName).ToList();
            munitSelectProductComboBox2.Tag = munitData;

            var productCategoryBL = new ProductCategoryManager();

            var productCategoryData = productCategoryBL.GetAllProductCategories();


            productCategorySelectProductComboBox1.DataSource = productCategoryData.Select(p => p.Name).ToList();
            productCategorySelectProductComboBox1.Tag = productCategoryData;

        }

        private void newProductAddButton_Click(object sender, EventArgs e)
        {
            var munitSelect = ((IList<Munit>)munitSelectProductComboBox2.Tag).Where(m => m.MunitName == munitSelectProductComboBox2.Text).ToList()[0];

            var productCategorySelect = ((IList<ProductCategory>)productCategorySelectProductComboBox1.Tag).Where(p => p.Name == productCategorySelectProductComboBox1.Text).ToList()[0];

            var productName = newProductNameTextBox.Text;

            if (munitSelect != null && productCategorySelect != null && productName != "")
            {
                var productAdaptor = new ProductAdaptor();
                var newProduct = new Product() { Name = productName, Munit = munitSelect.Id, ProductCategoryId = productCategorySelect.Id };

                productAdaptor.CreateOrUpdateProduct(newProduct);

                mainFrm.loadProductsInToGrid(true);
                this.Close();
            }

        }
    }
    
}
