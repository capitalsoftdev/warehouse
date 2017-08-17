using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.UserManagement
{
    class UserManager : IUserManager
    {
        public User Login(string userName, string password)
        {
            var userAdapter = new UserAdaptor();

            var loginResult = userAdapter.Autorisation(userName,password);

            if (loginResult > 0)
            {
                return userAdapter.SelectActiveUser(loginResult);
            }

            return null;
        }
    }
}
