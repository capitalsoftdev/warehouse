using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using WarehouseDAL;
namespace WarehouseClient
{
    public partial class ProductManagmentForm : Form
    {
        private string _getItem = "GetItemFromProductManagment";
        public ProductManagmentForm()
        {
            InitializeComponent();
        }


        private void ProductManagmentForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

