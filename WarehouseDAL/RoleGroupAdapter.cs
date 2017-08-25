using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;

namespace WarehouseDAL
{
    public class RoleGroupAdapter
    {
        private string getRole = "GetRoleGroup";
        private string disableRole = "DisableRoleGroup";
        private string createOrUpdateRole = "CreateOrUpdateRoleGroup";
        public int CreateOrUpdateRole(RoleGroup roleGroup)
        {
            int res;
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(createOrUpdateRole, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                    pId.Value = roleGroup.Id;
                    command.Parameters.Add(pId);

                    SqlParameter pName = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    pName.Value = roleGroup.Name;
                    command.Parameters.Add(pName);

                    SqlParameter pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    pIsActive.Value = roleGroup.IsActive;
                    command.Parameters.Add(pIsActive);

                    SqlParameter pResult = new SqlParameter("@result", SqlDbType.Int);
                    pResult.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pResult);

                    command.ExecuteNonQuery();

                    res = Convert.ToInt32(pResult.Value);
                }
            }
            return res;
        }

        public RoleGroup GetRoleGroup(int id)
        {
            return _GetRoleGroup(id)[0];
        }

        public List<RoleGroup> GetRoleGroup()
        {
            return _GetRoleGroup();
        }



        public int Disable(int id)
        {
            int res;
            using (var connnection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connnection.Open();
                using (var command = new SqlCommand(disableRole, connnection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                    pId.Value = id;
                    command.Parameters.Add(pId);

                    SqlParameter pResult = new SqlParameter("@result", SqlDbType.Int);
                    pResult.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pResult);

                    command.ExecuteNonQuery();
                    res = Convert.ToInt32(pResult.Value);
                }
            }
            return res;
        }

        private List<RoleGroup> _GetRoleGroup(int id = -1)
        {
            List<RoleGroup> roleGroupList = new List<RoleGroup>();
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(getRole, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                    pId.Value = id;
                    command.Parameters.Add(pId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int rGId = (int)reader.GetValue(0);
                            string rGName = (string)reader.GetValue(1);
                            bool rGIsActive = (bool)reader.GetValue(2);
                            roleGroupList.Add(new RoleGroup() { Id = rGId, Name = rGName, IsActive = rGIsActive });
                        }
                    }

                }

            }
            return roleGroupList;
        }
    }
}
