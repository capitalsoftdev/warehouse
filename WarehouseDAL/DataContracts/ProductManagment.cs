using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
    public class ProductManagment
    {
        private int id;

        private int productId;

        private int quantity;

        private DateTime actionDate;

        private int action;

        private int userId;

        private string reason;

        private decimal price;

        private int supplierId;
        
        private DateTime lastModifyDate;

        private bool isActive;

        public int Id { get { return this.id; } set { this.id = value; } }
        public int ProductId { get { return this.productId; } set { this.productId = value; } }
        public int Quantity { get { return this.quantity; } set { quantity = value; } }
        public DateTime ActionDate { get { return this.actionDate; } set { actionDate = value; } }
        public int Action { get { return this.action; } set { this.action = value; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public int SupplierId { get { return this.supplierId; } set { this.supplierId = value; } }
        public string Reason { get { return this.reason; } set { this.reason = value; } }
        public DateTime LastModifyDate { get { return this.lastModifyDate; } set { this.lastModifyDate = value; } }
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }
    }
}
