using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.ProductCategoryManagement;
using WarehouseClient.ProductCategoryManagement;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class MainForm
    {
        private void ProductCategoryTab_Enter(object sender, EventArgs e)
        {
        
            ProductCategoryRefresh();
        }

        public void ProductCategoryRefresh()
        {
            ProductCategoryManager productCategoryManager = new ProductCategoryManager();
            IList<ProductCategory> productCategoryList = productCategoryManager.GetAllProductCategories();
            productCategoryDataGridView.DataSource = productCategoryList.ToList();
        }
        private void addProductCategoryButton_Click(object sender, EventArgs e)
        {
            AddProductCategory add = new AddProductCategory(this);
            add.Show();
        }
    }
}
