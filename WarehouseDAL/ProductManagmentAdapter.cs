
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

        public int ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime ActionDate { get => actionDate; set => actionDate = value; }
        public int Action { get => action; set => action = value; }
        public int UserId { get => userId; set => userId = value; }
        public decimal Price { get => price; set => price = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public string Reason { get => reason; set => reason = value; }
        public DateTime LastModifyDate { get => lastModifyDate; set => lastModifyDate = value; }
        public bool IsActive1 { get => IsActive; set => IsActive = value; }
    }
}
