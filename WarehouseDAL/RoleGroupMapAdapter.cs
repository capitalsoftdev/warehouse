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
        private string createRoleGroupMap = "[dbo].[CreateRoleGroupMap]";
        private string getRoleGroupMap    = "[dbo].[GetRoleGroupMap]";

        public int CreateRoleGroupMap(RoleGroupMap role)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(createRoleGroupMap, conn))
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

        public IList<RoleGroupMap> GetRoleGroupI()
        {
            return GetRoleGroupMap();
        }
        private IList<RoleGroupMap> GetRoleGroupMap()
        {
            IList<RoleGroupMap> roleGroupMapList = null;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(getRoleGroupMap, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var cmdParamId = new SqlParameter("roleId", System.Data.SqlDbType.Int);
                    

                    SqlDataReader reader = cmd.ExecuteReader();

                            roleGroupMapList = new List<RoleGroupMap>();
                        while (reader.Read())
                        {
                            RoleGroupMap newRoleGroupMap = new RoleGroupMap();
                            newRoleGroupMap.RoleGroupId = (int)reader["roleGroupId"];
                            newRoleGroupMap.RoleId = (int)reader["roleId"];
                            roleGroupMapList.Add(newRoleGroupMap);
                        }
                    }

                }
                    return roleGroupMapList;
            }
            
        }


    }

