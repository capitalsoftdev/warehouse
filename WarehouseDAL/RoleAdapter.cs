using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WarehouseDAL.DataContracts;

namespace WarehouseDAL
{
    public class RoleAdapter
    {
        private string getRole = "GetRole";
        private string disableRole = "DisableRole";
        private string createOrUpdateRole = "CreateOrUpdateRole";
        public int CreateOrUpdateRole(Role role)
        {
            int res;
            using (var connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(createOrUpdateRole, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                    pId.Value = role.Id;
                    command.Parameters.Add(pId);

                    SqlParameter pName = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    pName.Value = role.Name;
                    command.Parameters.Add(pName);

                    SqlParameter pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    pIsActive.Value = role.IsActive;
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

        public Role GetRoleById(int id)
        {
            return _GetRole(id)[0];
        }

        public List<Role> GetRoles()
        {
            return _GetRole();
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

        private List<Role> _GetRole(int id = -1)
        {
            List<Role> roleList = new List<Role>();
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
                            int rId = (int)reader.GetValue(0);
                            string rName = (string)reader.GetValue(1);
                            bool rIsActive = (bool)reader.GetValue(2);
                            roleList.Add(new Role() { Id = rId, Name = rName, IsActive = rIsActive});
                        }
                    }

                }

            }
            return roleList;
        }
    }
}
