using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Serialization;
namespace WarehouseWebService.DataContracts
{
    [DataContract]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {

                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                string pass = BitConverter.ToString(checkSum).Replace("-", String.Empty);

                if (id == null || (this.password != pass))
                {
                    password = pass;
                }
                else
                {
                    password = value;
                }
            }
        }
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
