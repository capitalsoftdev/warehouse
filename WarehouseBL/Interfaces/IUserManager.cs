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
        IList<User> SelectActiveUser();
        void ActivateOrDeActivate(int id);
        User SelectActiveUser(int id);
        void UpdateOrInsertUser(User user);
        void UpdateUserLoginDate(int id);
    }
}
