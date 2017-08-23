using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseDAL.DataContracts;

namespace WarehouseClient.ProdManagForm
{
    public partial class UpdateProductManagment : Form
    {
        WarehouseDAL.DataContracts.ProductManagment that = null;
        public UpdateProductManagment()
        {
            InitializeComponent();
        }

        public UpdateProductManagment(int id, int productId, int quantity, DateTime actionDate, int action, int userId, string reason, int price, int supplierId, string brand, DateTime lastModifyDate, bool isActive)
        {
            InitializeComponent();
            that = new ProductManagment();
            that.Id = id;
            that.ProductId = productId;
            that.Quantity = quantity;
            that.ActionDate = actionDate;
            that.Action = action;
            that.UserId = userId;
            that.Reason = reason;
            that.Price = price;
            that.SupplierId = supplierId;
            that.Brand = brand;
            that.LastModifyDate = lastModifyDate;
            that.IsActive = isActive;
        }

        private void UpdateProductManagment_Load(object sender, EventArgs e)
        {
            textBox1.Text = that.Id.ToString();

        }
    }
}
