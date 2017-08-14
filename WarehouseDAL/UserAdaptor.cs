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
        
        private string _createUpdateUserSpName = "";
        bool LoginUser(string login, string password) {
            return false;
        }

        bool ManageUser(User user)
        {
            bool retVal = false;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(_createUpdateUserSpName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    SqlParameter pUserName = new SqlParameter("userName", System.Data.SqlDbType.VarChar, 20);
                    pUserName.Value = user.Username;
                    cmd.Parameters.Add(pUserName);

                    SqlParameter pResult = new SqlParameter("result", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                    cmd.ExecuteNonQuery();


                    int result = Convert.ToInt32(pResult.Value);

                    if (result == 1) return true;






                }
                return retVal;
            }
        }

    }
}
