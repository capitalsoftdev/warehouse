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
        private string createOrUpdateProduct = "[dbo].[CreateOrUpdateProduct]";
        private string getProduct = "[dbo].[GetProduct]";
        private string dicebleProduct = "[dbo].[DisableProduct]";
        private string getActiveProduct = "[dbo].[GetActiveProduct]";

        public int CreateOrUpdateProduct(Product product)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(createOrUpdateProduct, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var cmdParamId = new SqlParameter("@id", System.Data.SqlDbType.Int);
                    if (product.Id.HasValue)
                        cmdParamId.Value = product.Id.Value;
                    else
                        cmdParamId.Value = DBNull.Value;

                    cmd.Parameters.Add(cmdParamId);


                    SqlParameter pProductCategoryId = new SqlParameter("@productCategoryId", System.Data.SqlDbType.Int);
                    pProductCategoryId.Value = product.ProductCategoryId;
                    cmd.Parameters.Add(pProductCategoryId);

                    SqlParameter pName = new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 100);
                    pName.Value = product.Name;
                    cmd.Parameters.Add(pName);

                    SqlParameter pMunit = new SqlParameter("@munit", System.Data.SqlDbType.Int);
                    pMunit.Value = product.Munit;
                    cmd.Parameters.Add(pMunit);

                    SqlParameter pResult = new SqlParameter("@status", System.Data.SqlDbType.Int);
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
            return GetProducts(null);
        }

        private IList<Product> GetProducts(int? id)
        {
            IList<Product> productList = null;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(getProduct, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var cmdParamId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    if (id.HasValue)
                        cmdParamId.Value = id.Value;
                    else
                        cmdParamId.Value = DBNull.Value;

                    cmd.Parameters.Add(cmdParamId);

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        productList = new List<Product>();
                        while (reader.Read())
                        {
                            Product newProduct = new Product();
                            newProduct.Id = (int)reader["id"];
                            newProduct.Name = (string)reader["name"];
                            newProduct.ProductCategoryId = (int)reader["productCategoryId"];
                            newProduct.Munit = (int)reader["munit"];
                            newProduct.IsActive = (bool)reader["IsActive"];
                            productList.Add(newProduct);
                        }
                    }

                }

            }
            return productList;
        }

        public Product GetProduct(int id)
        {
            var product = GetProducts(id);
          
            if (product.Count > 0)
                return product[0];
            return null;
        }

        public int DisableProduct(int id)
        {
            int res = -10;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(dicebleProduct, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    pId.Value = id;
                    cmd.Parameters.Add(pId);


                    SqlParameter pResult = new SqlParameter("status", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                   
                    cmd.ExecuteNonQuery();


                    res = Convert.ToInt32(pResult.Value);

                }
                return res;
            }
        }

        public Dictionary<int, Product> GetActiveProduct()
        {
            Dictionary<int, Product> productList = null;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(getActiveProduct, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        productList = new Dictionary<int, Product>();
                        while (reader.Read())
                        {
                            Product newProduct = new Product();
                            newProduct.Id = (int)reader["id"];
                            newProduct.Name = (string)reader["name"];
                            newProduct.ProductCategoryId = (int)reader["productCategoryId"];
                            newProduct.Munit = (int)reader["munit"];
                            newProduct.IsActive = (bool)reader["IsActive"];
                            if (newProduct.Id.HasValue)
                                productList.Add(newProduct.Id.Value, newProduct);
                        }
                    }

                }

            }
            return productList;
        }




    }
}
