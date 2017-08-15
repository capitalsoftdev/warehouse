
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.DataContracts;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseDAL
{
    class ProductManagmentAdapter
    {
        private string _createOrUpdate = "CreateOrUpdateProcuctManagment";
        public IList<ProductManagment> GetItem(int id , int userId , int productId )
        {

            return null;
        }

        public int DeleteItem(int id)
        {
            return 0;
        }

        public int CreateOrUpdate(ProductManagment prMn)
        {
            int result = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();

                using (var cmd = new SqlCommand(_createOrUpdate, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", System.Data.SqlDbType.Int);
                    pId.Value = prMn.Id;
                    cmd.Parameters.Add(pId);

                    SqlParameter pProductId = new SqlParameter("@productId", SqlDbType.Int);
                    pProductId.Value = prMn.ProductId;
                    cmd.Parameters.Add(pProductId);

                    SqlParameter pQuantity = new SqlParameter("@quantity", SqlDbType.Int);
                    pQuantity.Value = prMn.Quantity;
                    cmd.Parameters.Add(pQuantity);

                    SqlParameter pActionDate = new SqlParameter("@actionDate", SqlDbType.Date); //Date or Datatime
                    pActionDate.Value = prMn.ActionDate;
                    cmd.Parameters.Add(pActionDate);

                    SqlParameter pAction = new SqlParameter("@action", SqlDbType.Int);
                    pAction.Value = prMn.Action;
                    cmd.Parameters.Add(pAction);

                    SqlParameter pUserId = new SqlParameter("@userId", SqlDbType.Int);
                    pUserId.Value = prMn.Action;
                    cmd.Parameters.Add(pUserId);


                    SqlParameter pReason = new SqlParameter("@reason", SqlDbType.NVarChar);
                    pReason.Value = prMn.Reason;
                    cmd.Parameters.Add(pReason);


                    SqlParameter pPrice = new SqlParameter("@price", SqlDbType.Int);
                    pPrice.Value = prMn.Price;
                    cmd.Parameters.Add(pPrice);

                    SqlParameter pSupplierId = new SqlParameter("@supplierId", SqlDbType.Int);
                    pSupplierId.Value = prMn.SupplierId;
                    cmd.Parameters.Add(pSupplierId);

                    SqlParameter pLastModifyDate = new SqlParameter("@lastModifyDate", SqlDbType.Date);
                    pLastModifyDate.Value = prMn.LastModifyDate;
                    cmd.Parameters.Add(pLastModifyDate);


                    SqlParameter pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    pIsActive.Value = prMn.IsActive1;

                    SqlParameter pResult = new SqlParameter("result", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(pResult.Value);
                

                }
                return result;
            }
        }

    }

   
}
