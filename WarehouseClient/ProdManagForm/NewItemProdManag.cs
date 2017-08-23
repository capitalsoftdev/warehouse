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
using WarehouseClient.Constants;
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

            //add elems in ProductCategory  ComboBox
            foreach (var elem in WarehouseClient.Constants.ApplicationData.ProductCategory)
            {
                CategoryComboBox.Items.Add(elem.Value.Name);
            }
           
            //add elems in Product ComboBox
            foreach(var elem in WarehouseClient.Constants.ApplicationData.Products)
            {
                ProductComboBox.Items.Add(elem.Value.Name);
            }
           


            //add elems in ActionComboBox
            ActionComboBox.Items.Add(ActionProduct.Acceptance);
            ActionComboBox.Items.Add(ActionProduct.Ouptut);
            ActionComboBox.Items.Add(ActionProduct.WriteOff);

            var productCategoryBL = new ProductCategoryManager();
            var productCategoryData = productCategoryBL.GetAllProductCategories();
            CategoryComboBox.DataSource = productCategoryData.Select(p => p.Name).ToList();
            CategoryComboBox.Tag = productCategoryData;
        }

        private void AddItemProductManagment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CategoryComboBox.SelectedItem.ToString());
        }
    }
}
