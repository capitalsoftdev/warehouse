using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService.DataContracts
{
    [DataContract]
    public class RoleGroup
    {
        private int id = -1;
        private string name;
        bool isActive = true;

        [DataMember]
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        [DataMember]
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        [DataMember]
        public bool IsActive
        {
            set { isActive = value; }
            get { return isActive; }
        }
    }
}
