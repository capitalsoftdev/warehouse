using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService.DataContracts
{
    [DataContract]
    public class Product
    {
        private int? id;
        private int productCategoryId;
        private string name;
        private int munit;
        private Boolean isActive;

        [DataMember]
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public int ProductCategoryId
        {
            get { return this.productCategoryId; }
            set { this.productCategoryId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        [DataMember]
        public int Munit
        {
            get { return this.munit; }
            set { this.munit = value; }
        }

        [DataMember]
        public Boolean IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }
    }
}
