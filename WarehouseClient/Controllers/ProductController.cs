using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.ProductManagement;
using WarehouseClient.Constants;
using WarehouseDAL.DataContracts;


namespace WarehouseClient
{
    public partial class MainForm
    {
        ProductManager productManager = new ProductManager();
        IList<Product> productList;
        IEnumerable<ProductMunitProductCategoryJoin> result;

        public void loadProductsInToGrid(bool reLoad)
        {
            var munitBL = new MunitManager();
            var munitData = munitBL.GetMunit();

            if (reLoad)
            {
                ApplicationData.Products = productManager.GetActiveProduct();
            }
            productList = ApplicationData.Products.Select(p => p.Value).ToList();

            result = from productJoin in productList
                         join productCategoryJoin in ApplicationData.ProductCategory
                         on productJoin.ProductCategoryId equals productCategoryJoin.Value.Id
                         join munitJoin in munitData
                         on productJoin.Munit equals munitJoin.Id
                         select new ProductMunitProductCategoryJoin()
                         {
                             Id = productJoin.Id,
                             IsActive = productJoin.IsActive,
                             Name = productJoin.Name,
                             Category = productCategoryJoin.Value.Name,
                             Munit = munitJoin.MunitName
                         };

            productDataGridView.DataSource = result.ToList();
            productDataGridView.Columns[0].Visible = false;
            productDataGridView.Columns[2].Visible = false;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            loadProductsInToGrid(true);
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this, false, null);
            newProductAddForm.Show();
        }

        private void disableProductButton_Click(object sender, EventArgs e)
        {
            var selectedRowsList = productDataGridView.SelectedRows;

            if (selectedRowsList.Count == 0)
            {
                MessageBox.Show("Select row");
            }
            else
            {
                var productManager = new ProductManager();
                foreach (var product in selectedRowsList)
                {
                    var a = (DataGridViewRow)product;
                    productManager.DisableProduct((int)a.Cells[0].Value);
                }
                loadProductsInToGrid(true);
            }
        }

        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var productSelect = productList.Where(p => p.Id ==  result.ToList()[e.RowIndex].Id).First();
            ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this, true, productSelect);
            newProductAddForm.Show();
        }


        class ProductMunitProductCategoryJoin
        {
            int? id;
            Boolean isActive;
            string name;
            string category;
            string munit;

            public int? Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public bool IsActive
            {
                get
                {
                    return isActive;
                }

                set
                {
                    isActive = value;
                }
            }

            public string Category
            {
                get
                {
                    return category;
                }

                set
                {
                    category = value;
                }
            }

            public string Munit
            {
                get
                {
                    return munit;
                }

                set
                {
                    munit = value;
                }
            }
        }

    }

    
}
