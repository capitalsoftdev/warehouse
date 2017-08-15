
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    class ProductManagmentAdapter
    {
        public IList<ProductManagment> GetItemFromProductManagment(int id , int userId , int productId )
        {

            return null;
        }

        public int DeleteItemFromProductManagment(int id)
        {
            return 0;
        }

        public int CreateOrUpdateProcuctManagment(int id)
        {
            return 0;
        }

    }

    class ProductManagment
    {
        private int productId;
        private int quantity;
        private DateTime	actionDate;
        private int action;
        private int userId;
        private decimal price;
        private int supplierId;
        private string reason;
        private DateTime	lastModifyDate;
        private bool IsActive;

        public int ProductId { get { return this.productId; } set { this.productId = value; } }
        public int Quantity { get { return this.quantity; } set { quantity = value; } }
        public DateTime ActionDate { get { return this.actionDate; } set { actionDate = value; } }
        public int Action { get { return this.action; } set { this.action = value; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public int SupplierId { get { return this.supplierId; } set { this.supplierId = value; } }
        public string Reason { get { return this.reason; } set { this.reason = value; } }
        public DateTime LastModifyDate { get { return this.lastModifyDate; } set { this.lastModifyDate = value; } }
        public bool IsActive1 { get { return this.IsActive; } set { this.IsActive = value; } }
    }
}
