using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseClient.ProductCategoryManagement;
using WarehouseClient.WWS;


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
            using (WarehouseServiceClient wwsClient = new WarehouseServiceClient(ServiceParametor.Parametor))
            {
                IList<ProductCategory> prodCatList = wwsClient.GetAllProductCategories().ToList();
                productCategoryDataGridView.DataSource = prodCatList.ToList();
            }
          
        }
        private void addProductCategoryButton_Click(object sender, EventArgs e)
        {
            
            AddProductCategory add = new AddProductCategory(this);
            add.Show();
        }
    }
}
