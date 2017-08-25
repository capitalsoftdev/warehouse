using System.Collections.Generic;
using System.Linq;
using WarehouseBL.RoleManagement;
using WarehouseWebService.DataContracts;
using WarehouseBL.UserManagement;

namespace WarehouseWebService
{
    public partial class WarehouseService
    {
        public User Login(string userName, string password)
        {
            UserManager serviseUserManager = new UserManager();
            User retUser = null;
            if (serviseUserManager.Login(userName, password) == null)
            {
                return retUser;
            }
            else
            {
                retUser = serviseUserManager.Login(userName, password).ToServiceUser();
                return retUser;
            }
        }
        public IList<User> SelectActiveUsers()
        {
            var serviseUserManager = new UserManager();
            return serviseUserManager.SelectActiveUser().Select(p => p.ToServiceUser()).ToList();
        }
        public User SelectActiveUserById(int id)
        {
            var serviseUserManager = new UserManager();
            return serviseUserManager.SelectActiveUser(id).ToServiceUser();
        }
        public void UpdateOrInsertUser(User user)
        {
            var serviseUserManager = new UserManager();
            serviseUserManager.UpdateOrInsertUser(user.ToDALUser());
        }
        public void ActivateOrDeActivate(int id)
        {
            var serviseUserManager = new UserManager();
            serviseUserManager.ActivateOrDeActivate(id);
        }
        public void UpdateUserLoginDate(int id)
        {
            var serviseUserManager = new UserManager();
            serviseUserManager.UpdateUserLoginDate(id);

        }
    }
}
