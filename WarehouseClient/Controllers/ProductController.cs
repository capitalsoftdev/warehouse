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

        WWS.WarehouseServiceClient productManager = new WWS.WarehouseServiceClient(ServiceParametor.Parametor);    
        IList<WWS.Product> productList;
        IList<WWS.Munit> munitList;
        IList<ProductCategory> productCategoryList;

        public void loadProductsInToGrid(bool reLoad)
        {
            try
            {
                if (reLoad)
                {
                    ApplicationData.Products = new Dictionary<int, WWS.Product>();

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


                productDataGridView.DataSource = result2.ToList();
                productDataGridView.Columns[0].Visible = false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            loadProductsInToGrid(true);
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this, false, null);
                newProductAddForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disableProductButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void productDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this, true, productList[e.RowIndex]);
                newProductAddForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

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
