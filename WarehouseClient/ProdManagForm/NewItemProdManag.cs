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
using WarehouseDAL.DataContracts;

namespace WarehouseClient.ProdManagForm
{
    public partial class NewItemProdManag : Form
    {
        public NewItemProdManag()
        {
            InitializeComponent();
        }

        private void NewItemProdManag_Load(object sender, EventArgs e)
        {
            // var productCategorySelect = ((IList<ProductCategory>)CategoryComboBox.Tag).Where(p => p.Name == CategoryComboBox.Text).ToList()[0];
            var productCategoryBL = new ProductCategoryManager();
            var productCategoryData = productCategoryBL.GetAllProductCategories();
            CategoryComboBox.DataSource = productCategoryData.Select(p => p.Name).ToList();
            CategoryComboBox.Tag = productCategoryData;
        }
    }
}
