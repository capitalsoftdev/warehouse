using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using WarehouseDAL.DataContracts;
using System.Security.Cryptography;

namespace WarehouseDAL
{
  public  class UserAdaptor
    {
        public  IList<User> SelectActiveUser()
        {
            return GetActiveUsers(null);
        }
        public  User SelectActiveUser(int id)
        {
            IList<User> user = GetActiveUsers(id);
            if (user.Count != 0)
                return user[0];
            return null;
        }
        private IList<User> GetActiveUsers(int? id)
        {
            IList<User> user = new List<User>();
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var comand = new SqlCommand("SelectActiveUsers", connection))
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;

                    var param = new SqlParameter("UserId", System.Data.SqlDbType.Int);

                    if (id.HasValue)
                    {
                        param.Value = id.Value;
                    }
                    else
                    {
                        param.Value = DBNull.Value;
                    }
                    comand.Parameters.Add(param);

                    SqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        User use = null;
                        while (reader.Read())
                        {
                            use = new User();
                            use.Id = (int)reader["id"];
                            use.Username = (string)reader["username"];
                            use.Password = (string)reader["password"];
                            use.RoleGroupId = (int)reader["roleGroupId"];
                            use.CreationDate = (DateTime)reader["CreationDate"];
                            if ((reader["lastLoginDate"]) == DBNull.Value)
                                use.LastLoginDate = DateTime.MinValue;
                            else
                                use.LastLoginDate = (DateTime)reader["lastLoginDate"];
                            use.LastModifireDate = (DateTime)reader["LastModifyDate"];
                            use.IsActive = (bool)reader["IsActive"];
                            user.Add(use);
                        }
                    }
                    reader.Close();
                }
            }
            return user;
        }




        public void UpdateOrInsertUser(User user)
        {
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();

                using (var comand = new SqlCommand("AddOrUpdateUser", connection))
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;

                    var parId = new SqlParameter("@UserId", System.Data.SqlDbType.Int);
                    if (user.Id.HasValue)
                    {
                        parId.Value = user.Id.Value;
                    }
                    else
                    {
                        parId.Value = DBNull.Value;
                    }

                    comand.Parameters.Add(parId);

                    var parUserName = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar, 20);
                    parUserName.Value = user.Username;
                    comand.Parameters.Add(parUserName);

                    var parPassword = new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50);
                    parPassword.Value = user.Password;
                    comand.Parameters.Add(parPassword);

                    var parRoleGroupId = new SqlParameter("@RoleGroupId", System.Data.SqlDbType.Int);
                    parRoleGroupId.Value = user.RoleGroupId;
                    comand.Parameters.Add(parRoleGroupId);

                    comand.ExecuteNonQuery();
                }
            }
        }
        public void ActiveOrDeactive(int id)
        {
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("ChangeIsActive", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    var param = new SqlParameter("@UserId", System.Data.SqlDbType.Int);
                    param.Value = id;
                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();
                }
            }
        }
        public int Autorisation(string username, string password)
        {
            int result ;
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var comand = new SqlCommand("Autorisation", connection))
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;

                    var parUserName = new SqlParameter("@username", System.Data.SqlDbType.VarChar, 20);
                    parUserName.Value = username;
                    comand.Parameters.Add(parUserName);


                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                    string pass = BitConverter.ToString(checkSum).Replace("-", String.Empty);

                    var parPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar, 50);
                    parPassword.Value = pass;
                    comand.Parameters.Add(parPassword);


                    var parOutput = new SqlParameter("@output", System.Data.SqlDbType.Int);
                    parOutput.Direction = System.Data.ParameterDirection.Output;
                    comand.Parameters.Add(parOutput);

                    comand.ExecuteNonQuery();
                    result = (int)parOutput.Value;
                }
            }
            return result;
        }
        public void UpdateUserLoginDate(int id)
        {
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();

                using (var comand = new SqlCommand("setLoginDate", connection))
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;

                    var parId = new SqlParameter("@UserId", System.Data.SqlDbType.Int);
                    parId.Value = id;
                    comand.Parameters.Add(parId);

                    comand.ExecuteNonQuery();
                }
            }
        }





    }



}

