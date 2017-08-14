using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WarehouseDAL
{
    class ProductAdaptor
    {
        private string createOrUpdateProduct = "";

        public int CreateOrUpdateProduct(Product product)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(createOrUpdateProduct, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pProductCategoryId = new SqlParameter("productCategoryId", System.Data.SqlDbType.Int);
                    pProductCategoryId.Value = product.ProductCategoryId;
                    cmd.Parameters.Add(pProductCategoryId);

                    SqlParameter pResult = new SqlParameter("result", System.Data.SqlDbType.Int);
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
