using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL;
using WarehouseDAL.DataContracts;

namespace WarehouseBL.UserManagement
{
  public  class UserManager : IUserManager
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
        public IList<User> SelectActiveUser()
        {
            var userAdapter = new UserAdaptor();
            IList<User> reList;
            reList = userAdapter.SelectActiveUser();
            return reList;
        }
        public void AddOrInsertUser(User user) {
            UserAdaptor adaptor = new UserAdaptor();
            adaptor.UpdateOrInsertUser(user);
        }
        public void UpdateUserLoginDate(int id)
        {
            UserAdaptor adaptor = new UserAdaptor();
            adaptor.UpdateUserLoginDate(id);

        }
    }
}
