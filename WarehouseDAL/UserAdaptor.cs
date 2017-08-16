using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WarehouseDAL
{
    class UserAdaptor
    {
        public IList<User> SelectActiveUser()
        {
            return GetActiveUsers(null);
        }
        public User SelectActiveUser(int a)
        {
            var user = GetActiveUsers(a);
            if (user.Count > 0)
                return user[0];
            return null;
        }
        private IList<User> GetActiveUsers(int? id)
        {
            IList<User> user = null;
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var comand = new SqlCommand("SelectActiveUsers", connection))
                {
                    var param = new SqlParameter("@UserId", System.Data.SqlDbType.Int);
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
                    User use;
                    user = new List<User>();
                    while (reader.Read())
                    {
                        use = new User();
                        use.Id = (Int32)reader["id"];
                        use.Username = (string)reader["username"];
                        use.Password = (string)reader["password"];
                        use.RoleGroupId = (Int32)reader["roleGroupId"];
                        use.CreationDate = (DateTime)reader["CreationDate"];
                        if ((reader["lastLoginDate"]) == DBNull.Value)
                            use.LastLoginDate = DateTime.MinValue;
                        else use.LastLoginDate = (DateTime)(reader["lastLoginDate"]);
                        use.LastModifireDate = (DateTime)reader["LastModifyDate"];
                        user.Add(use);
                    }
                }
            }
            return user;
        }
      



        bool ManageUser(User user)
        {
            int result = -1;
            bool retVal = false;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(ConnectionParameters.ConnectionString, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    SqlParameter pUserName = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar, 20);
                    pUserName.Value = user.Username;
                    cmd.Parameters.Add(pUserName);

                    SqlParameter pPassword = new SqlParameter("@Password", System.Data.SqlDbType.VarChar, 50);
                    pPassword.Value = user.Password;
                    cmd.Parameters.Add(pPassword);

                    SqlParameter pRoleGroupId = new SqlParameter("@RoleGroupId", System.Data.SqlDbType.Int);
                    pRoleGroupId.Value = user.RoleGroupId;
                    cmd.Parameters.Add(pRoleGroupId);


                   

                    cmd.ExecuteNonQuery();


                    

                    if (result == 0) return true;
                }
                return retVal;
            }
        }

    }
}
