using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WarehouseDAL.DataContracts;
using System.Configuration;

namespace WarehouseDAL
{
   public class RoleGroupMapAdapter
    {
        public IList<RoleGroupMap> GetItemFromProductManagment(int roleGroupId, int roleid) {


            return null;
        }

        private string insertRoleGroupMap = "[dbo].[InsertRoleGroupMap]";

        public int CreateRoleGroupMap(RoleGroupMap role)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(insertRoleGroupMap, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter roleGroupId = new SqlParameter("roleGroupId", System.Data.SqlDbType.Int);
                    roleGroupId.Value = role.RoleGroupId;
                    cmd.Parameters.Add(roleGroupId);


                    SqlParameter roleId = new SqlParameter("roleId", System.Data.SqlDbType.Int);
                    roleId.Value = role.RoleId;
                    cmd.Parameters.Add(roleId);

                    

                    SqlParameter pResult = new SqlParameter("status", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                    cmd.ExecuteNonQuery();


                    res = Convert.ToInt32(pResult.Value);


                }
                return res;
            }
        }



    }
}
