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

        public void loadProductsInToGrid(bool reLoad)
        {
            if (ApplicationData.Products == null || reLoad)
            {
                ApplicationData.Products = productManager.GetActiveProduct();
            }

            productDataGridView.DataSource = ApplicationData.Products.Select(p => p.Value).ToList();
            productDataGridView.Columns[0].Visible = false;
            productDataGridView.Columns[4].Visible = false;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            loadProductsInToGrid(true);
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            ProductManagement.NewProductAddForm newProductAddForm = new ProductManagement.NewProductAddForm(this);
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

    }
}
