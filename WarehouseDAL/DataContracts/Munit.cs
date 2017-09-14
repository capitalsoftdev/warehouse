using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
    public class Munit
    {
        private int? id;
        private string munitName;
        private Boolean isActive;

        public int? Id
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
