using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseDAL
{
    public class RoleAdapter
    {
        private string _getRole = "GetRole";
        private string _disableRole = "DisableRole";
        private string _createOrUpdateRole = "CreateOrUpdateRole";
        public int CreateOrUpdateRole(Role role)
        {
            int res;
            using (var _connection = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                _connection.Open();
                using (var _command = new SqlCommand(_createOrUpdateRole, _connection))
                {
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlParameter _pId = new SqlParameter("@id", SqlDbType.Int);
                    _pId.Value = role.Id;
                    _command.Parameters.Add(_pId);

                    SqlParameter _pName = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    _pName.Value = role.Name;
                    _command.Parameters.Add(_pName);

                    SqlParameter _pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    _pIsActive.Value = role.IsActive;
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

        public Role GetRole(int id)
        {
            return _GetRole(id)[0];
        }

        public List<Role> GetRole()
        {
            return _GetRole();
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

        private List<Role> _GetRole(int id = -1)
        {
            List<Role> roleList = new List<Role>();
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
                            int rId = (int)reader.GetValue(0);
                            string rName = (string)reader.GetValue(1);
                            bool rIsActive = (bool)reader.GetValue(2);
                            roleList.Add(new Role(rId, rName, rIsActive));
                        }
                    }

                }

            }
            return roleList;
        }
    }
}
