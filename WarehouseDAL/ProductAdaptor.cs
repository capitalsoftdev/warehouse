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
    public class ProductAdaptor
    {
        private string createOrUpdateProduct = "";

        public int CreateOrUpdateProduct(Product product)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(createOrUpdateProduct, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pProductCategoryId = new SqlParameter("productCategoryId", System.Data.SqlDbType.Int);
                    pProductCategoryId.Value = product.ProductCategoryId;
                    cmd.Parameters.Add(pProductCategoryId);

                    SqlParameter pName = new SqlParameter("name", System.Data.SqlDbType.NVarChar, 100);
                    pName.Value = product.Name;
                    cmd.Parameters.Add(pName);

                    SqlParameter pMunit = new SqlParameter("munit", System.Data.SqlDbType.Int);
                    pMunit.Value = product.Munit;
                    cmd.Parameters.Add(pMunit);

                    SqlParameter pResult = new SqlParameter("status", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                    cmd.ExecuteNonQuery();


                     res = Convert.ToInt32(pResult.Value);


                }
                return res;
            }
        }
           
        

        public IList<Product> GetProduct()
        {
            return new List<Product>();
        }

        public Product GetProduct(int id)
        {
            return new Product();
        }


    }
}
