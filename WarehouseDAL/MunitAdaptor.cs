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
    public class MunitAdaptor
    {
        private string getMunit = "[dbo].[GetMunit]";

        public IList<Munit> GetMunit()
        {
            return GetMunits(-1);
        }

        private IList<Munit> GetMunits(int id)
        {
            IList<Munit> munitList = null;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(getMunit, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var cmdParamId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    cmdParamId.Value = id;
                    cmd.Parameters.Add(cmdParamId);

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        munitList = new List<Munit>();
                        while (reader.Read())
                        {
                            Munit newMunit = new Munit();
                            newMunit.Id = (int)reader["id"];
                            newMunit.MunitName = (string)reader["name"];
                            newMunit.IsActive = (bool)reader["IsActive"];
                            munitList.Add(newMunit);
                        }
                    }

                }

            }
            return munitList;
        }

        public Munit GetMunit(int id)
        {
            var munit = GetMunits(id);

            if (munit.Count > 0)
                return munit[0];
            return null;
        }
    }
}
