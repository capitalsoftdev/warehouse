using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseBL.ProductManagement;
using WarehouseDAL.DataContracts;

namespace WarehouseClient
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            dataGridView1.DataSource = productManager.GetProduct();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("click");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
