using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL
{
    class Product
    {
        private int id;
        private int productCategoryId;
        private string name;
        private int munit;
        private bool isActive;
        
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int ProductCategoryId
        {
            get { return this.productCategoryId; }
            set { this.productCategoryId = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Munit
        {
            get { return this.munit; }
            set { this.munit = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }
    }
}
