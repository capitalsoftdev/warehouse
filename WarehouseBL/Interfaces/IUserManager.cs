using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseBL
{
    interface IUserManager
    {
        User Login(string userName, string password);
        Dictionary<int, User> SelectActiveUser();
        void ActivateOrDeActivate(int id);
    }
}
