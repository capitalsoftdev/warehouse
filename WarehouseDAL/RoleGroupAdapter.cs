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
        private string _getRole = "GetRoleGroup";
        private string _disableRole = "DisableRoleGroup";
        private string _createOrUpdateRole = "CreateOrUpdateRoleGroup";
        public int CreateOrUpdateRole(RoleGroup roleGroup)
        {
            int res;
            using (var _connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                _connection.Open();
                using (var _command = new SqlCommand(_createOrUpdateRole, _connection))
                {
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlParameter _pId = new SqlParameter("@id", SqlDbType.Int);
                    _pId.Value = roleGroup.Id;
                    _command.Parameters.Add(_pId);

                    SqlParameter _pName = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    _pName.Value = roleGroup.Name;
                    _command.Parameters.Add(_pName);

                    SqlParameter _pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    _pIsActive.Value = roleGroup.IsActive;
                    _command.Parameters.Add(_pIsActive);

                    SqlParameter _pResult = new SqlParameter("@result", SqlDbType.Int);
                    _pResult.Direction = ParameterDirection.Output;
                    _command.Parameters.Add(_pResult);

                    _command.ExecuteNonQuery();

                    res = Convert.ToInt32(_pResult.Value);
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
            using (var _connnection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                _connnection.Open();
                using (var _command = new SqlCommand(_disableRole, _connnection))
                {
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlParameter _pId = new SqlParameter("@Id", SqlDbType.Int);
                    _pId.Value = id;
                    _command.Parameters.Add(_pId);

                    SqlParameter _pResult = new SqlParameter("@result", SqlDbType.Int);
                    _pResult.Direction = ParameterDirection.Output;
                    _command.Parameters.Add(_pResult);

                    _command.ExecuteNonQuery();
                    res = Convert.ToInt32(_pResult.Value);
                }
            }
            return res;
        }

        private List<RoleGroup> _GetRoleGroup(int id = -1)
        {
            List<RoleGroup> roleGroupList = new List<RoleGroup>();
            using (var _connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                _connection.Open();
                using (var _command = new SqlCommand(_getRole, _connection))
                {
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlParameter _pId = new SqlParameter("@id", SqlDbType.Int);
                    _pId.Value = id;
                    _command.Parameters.Add(_pId);

                    SqlDataReader reader = _command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int rGId = (int)reader.GetValue(0);
                            string rGName = (string)reader.GetValue(1);
                            bool rGIsActive = (bool)reader.GetValue(2);
                            roleGroupList.Add(new RoleGroup(rGId, rGName, rGIsActive));
                        }
                    }

                }

            }
            return roleGroupList;
        }
    }
}
