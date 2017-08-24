using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService.DataContracts
{
   public class ProductCategory
    {
        private int? id;
        private int parentId;
        private string name;
        private bool isActive;

        [DataMember]
        public int? Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [DataMember]
        public int ParentId
        {
            get { return this.parentId; }
            set { this.parentId = value; }
        }

        [DataMember]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        
        [DataMember]
        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }
    }
}
