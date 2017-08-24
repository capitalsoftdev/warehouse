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
        IList<Munit> munitList;
        IList<ProductCategory> productCategoryList;
        IEnumerable<ProductMunitProductCategoryJoin> result;

        public void loadProductsInToGrid(bool reLoad)
        {

            if (reLoad)
            {
                ApplicationData.Products = new Dictionary<int, Product>();

                var allProduct = productManager.GetActiveProduct();

                foreach (var item in allProduct)
                {
                    ApplicationData.Products.Add(item.Id.Value, item);
                }
            }
            productList = ApplicationData.Products.Select(p => p.Value).ToList();
            productCategoryList = ApplicationData.ProductCategory.Select(pc => pc.Value).ToList();
            munitList = ApplicationData.Munits.Select(m => m.Value).ToList();

            var result1 = productList.Join
                (
                    munitList,
                    p => p.Munit,
                    m => m.Id,
                    (p, m) => new
                    {
                        Id = p.Id.Value,
                        Name = p.Name,
                        ProductCategoryId = p.ProductCategoryId,
                        Munit = m.MunitName
                    }
                );

            var result2 = result1.Join
                (
                    productCategoryList,
                    p => p.ProductCategoryId,
                    pc => pc.Id,
                    (p, pc) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Munit = p.Munit,
                        Category = pc.Name
                    }
                );

            //result = from productJoin in productList
            //             join productCategoryJoin in productCategoryList
            //             on productJoin.ProductCategoryId equals productCategoryJoin.Id
            //             join munitJoin in munitList
            //             on productJoin.Munit equals munitJoin.Id
            //         select new ProductMunitProductCategoryJoin()
            //         {
            //                 Id = productJoin.Id.Value,
            //                 Name = productJoin.Name,
            //                 Category = productCategoryJoin.Name,
            //                 Munit = munitJoin.MunitName
            //         };

            productDataGridView.DataSource = result2.ToList();
            productDataGridView.Columns[0].Visible = false;
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
            ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this, true, productList[e.RowIndex]);
            newProductAddForm.Show();
                
        }


        class ProductMunitProductCategoryJoin
        {
            int id;
            string name;
            string category;
            string munit;

            public int Id
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
