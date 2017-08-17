using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WarehouseDAL.DataContracts
{
   public class User
    {
        private int? id;
        private string username;
        private string password;
        private int roleGroupId;
        private DateTime creationDate;
        private DateTime lastLoginDate;
        private DateTime lastModifireDate;
        private bool isActive;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
         private   get
            {
                return password;
            }

            set
            {

                if (id == null)
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                    string pass = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                    password = pass;
                }
                else
                {
                    password = value;
                }
            }
        }

        public int RoleGroupId
        {
            get
            {
                return roleGroupId;
            }

            set
            {
                roleGroupId = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }

        public DateTime LastLoginDate
        {
            get
            {
                return lastLoginDate;
            }

            set
            {
                lastLoginDate = value;
            }
        }

        public DateTime LastModifireDate
        {
            get
            {
                return lastModifireDate;
            }

            set
            {
                lastModifireDate = value;
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
    }
}
