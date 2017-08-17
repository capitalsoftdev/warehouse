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
    class ProductCategoryAdaptor
    {

        private string createOrUpdateProductCategory = "[dbo].[CreateOrUpdateProductCategory]";

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
                    pId.Value = product.Id;
                    cmd.Parameters.Add(pId);


                    SqlParameter pparentId = new SqlParameter("parentId", System.Data.SqlDbType.Int);
                    pparentId.Value = product.ParentId;
                    cmd.Parameters.Add(pparentId);

                    SqlParameter pName = new SqlParameter("name", System.Data.SqlDbType.NVarChar, 100);
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



        public ProductCategory getProductCategoryById(int id)
        {

            return new ProductCategory();
        }


        public IList<ProductCategory> getAllProductCategories()
        {
            return new List<ProductCategory>();
        }


    }

    public class ProductCategory
    {
        private int id;
        private string name;
        private int parentId;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int ParentId
        {
            get
            {
                return parentId;
            }
            set
            {
                parentId = value;
            }
        }
    }
}
