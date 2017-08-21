using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService.DataContracts
{
    [DataContract]
    public class ProductManagment
    {
        private int? id;

        private int productId;

        private decimal quantity;

        private DateTime actionDate;

        private int action;

        private int userId;

        private string reason;

        private decimal price;

        private int supplierId;

        private string brand;

        private DateTime lastModifyDate;

        private bool isActive;

        [DataMember]
        public int? Id { get { return this.id; } set { this.id = value; } }

        [DataMember]
        public int ProductId { get { return this.productId; } set { this.productId = value; } }

        [DataMember]
        public decimal Quantity { get { return this.quantity; } set { quantity = value; } }

        [DataMember]
        public DateTime ActionDate { get { return this.actionDate; } set { actionDate = value; } }

        [DataMember]
        public int Action { get { return this.action; } set { this.action = value; } }

        [DataMember]
        public int UserId { get { return this.userId; } set { this.userId = value; } }

        [DataMember]
        public decimal Price { get { return this.price; } set { this.price = value; } }

        [DataMember]
        public int SupplierId { get { return this.supplierId; } set { this.supplierId = value; } }

        [DataMember]
        public string Reason { get { return this.reason; } set { this.reason = value; } }

        [DataMember]
        public string Brand { get { return this.brand; } set { this.brand = value; } }

        [DataMember]
        public DateTime LastModifyDate { get { return this.lastModifyDate; } set { this.lastModifyDate = value; } }

        [DataMember]
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }

    }
}
