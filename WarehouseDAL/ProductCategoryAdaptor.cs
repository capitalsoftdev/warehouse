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
   public class ProductCategoryAdaptor
    {

        private string createOrUpdateProductCategory = "[dbo].[CreateOrUpdateProductCategory]";
        private string getProductCategory = "[dbo].[GetProductCategory]";
        private string manageProductCategory = "[dbo].[ManageProductCategory]";


        public int CreateOrUpdateProductCategory(ProductCategory product)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LOCAL"].ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(createOrUpdateProductCategory, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    if (product.Id >= 0)
                        pId.Value = product.Id;
                    else
                        pId.Value = DBNull.Value;
                    cmd.Parameters.Add(pId);


                    SqlParameter pparentId = new SqlParameter("parentId", System.Data.SqlDbType.Int);
                    pparentId.Value = product.ParentId;
                    cmd.Parameters.Add(pparentId);

                    SqlParameter pName = new SqlParameter("name", System.Data.SqlDbType.NVarChar, 50);
                    pName.Value = product.Name;
                    cmd.Parameters.Add(pName);

                    SqlParameter pResult = new SqlParameter("status", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);



                    // cmd.Connection = conn;


                    cmd.ExecuteNonQuery();


                    res = Convert.ToInt32(pResult.Value);


                }
                
                return res;
            }
        }

        public IList<ProductCategory> GetAllProductCategories()
        {
            IList<ProductCategory> productCategoryList = new List<ProductCategory>();
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(getProductCategory, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    pId.Value = null;
                    cmd.Parameters.Add(pId);


                    SqlDataReader reader = cmd.ExecuteReader();


                    if (reader.HasRows)
                    {
                        //productCategoryList = new List<ProductCategory>();
                        while (reader.Read())
                        {
                            ProductCategory newProductCategory = new ProductCategory();
                            newProductCategory.Id = (int)reader.GetValue(0);//["id"];
                            newProductCategory.Name = (string)reader.GetValue(1);//["name"];
                            newProductCategory.ParentId = (int)reader.GetValue(2);//["parentId"];
                            newProductCategory.IsActive = (bool)reader.GetValue(3);//["isActive"];
                            productCategoryList.Add(newProductCategory);
                        }
                    }

                }

            }
            return productCategoryList;
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            ProductCategory productCategory = null;

            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(getProductCategory, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    pId.Value = id;
                    cmd.Parameters.Add(pId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    productCategory = new ProductCategory();
                    if (reader.Read())
                    {
                        productCategory.Id = (int)reader["id"];
                        productCategory.Name = (string)reader["name"];
                        productCategory.ParentId = (int)reader["parentId"];
                        productCategory.IsActive = (bool)reader["isActive"];

                    }

                }
            }
            return productCategory;
        }

        public int ManageProductCategory(int id, int action)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(manageProductCategory, conn))
                {

                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("id", System.Data.SqlDbType.Int);
                    pId.Value = id;
                    cmd.Parameters.Add(pId);

                    SqlParameter pAction = new SqlParameter("action", System.Data.SqlDbType.Int);
                    pAction.Value = action;
                    cmd.Parameters.Add(pAction);

                    SqlParameter pResult = new SqlParameter("status", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);


                    cmd.ExecuteNonQuery();


                    res = Convert.ToInt32(pResult.Value);

                }
                return res;
            }
        }


        public ProductCategory getProductCategoryById(int id)
        {

            return new ProductCategory();
        }


        public IList<ProductCategory> getAllProductCategories()
        {
            return  new List<ProductCategory>();
        }



    }

   
}
