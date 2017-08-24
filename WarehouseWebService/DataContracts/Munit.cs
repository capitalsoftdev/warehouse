using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseWebService.DataContracts
{
    [DataContract]
    public class Munit
    {
        private int id;
        private string munitName;
        private Boolean isActive;

        [DataMember]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMember]
        public string MunitName
        {
            get
            {
                return munitName;
            }

            set
            {
                munitName = value;
            }
        }

        [DataMember]
        public bool IsActive
        {
            get
            {
                return isActive;
            }

            set
            {
                isActive = value;
            }
        }
    
    }
}
