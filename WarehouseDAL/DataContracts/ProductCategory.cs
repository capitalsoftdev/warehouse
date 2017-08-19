using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDAL.DataContracts
{
     public class ProductCategory
    {
        private int id;
        private string name;
        private int parentId;
        private bool isActive;
        private int action;

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

        public int Action
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int ParentId
        {
            get
            {
                return parentId;
            }
            set
            {
                parentId = value;
            }
        }

        public override string ToString()
        {
            return String.Format("id -> {0}: ParentId -> {1}: name -> {2}: IsActive -> {3}", Id, ParentId, Name, IsActive);
        }
    }
}

