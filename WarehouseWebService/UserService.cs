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
            var serviseUserManager = new UserManager();

            var retUser = serviseUserManager.Login(userName, password);

            if (retUser.Id > 0)
            {
                return serviseUserManager.SelectActiveUser(retUser.Id.Value).ToServiceUser();
            }

            return null;
        }
        public IList<User> SelectActiveUser()
        {
            var serviseUserManager = new UserManager();
            return serviseUserManager.SelectActiveUser().Select(p => p.ToServiceUser()).ToList();
        }
        public User SelectActiveUser(int id)
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
