
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
    public class ProductManagmentAdapter
    {
        private string _createOrUpdate = "CreateOrUpdateProductManagment";

        private string _deleteItem = "DeleteItemFromProductManagment";

        private string _getItem = "GetItemFromProductManagment";
        public IList<ProductManagment> GetItem(int id, int userId, int productId)
        {
            IList<ProductManagment> list = null;
            if (id > 0 && userId > 0)
            {
                throw new Exception("invaild argument");
            }
            else if (id > 0 && productId > 0)
            {
                throw new Exception("invaild argument");
            }
            else if (userId > 0 && productId > 0)
            {
                throw new Exception("invaild argument");
            }
            else
            {
                using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(_getItem, conn))
                    {
                        SqlParameter pId = new SqlParameter("@id", System.Data.SqlDbType.Int);
                        if (id > 0)
                        {
                            pId.Value = id;
                        }
                        else
                        {
                            pId.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(pId);

                        SqlParameter pUserId = new SqlParameter("@userId", System.Data.SqlDbType.Int);
                        if (userId > 0)
                        {
                            pId.Value = userId;
                        }
                        else
                        {
                            pUserId.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(pUserId);

                        SqlParameter pProductId = new SqlParameter("@productId", System.Data.SqlDbType.Int);
                        if (productId > 0)
                        {
                            pProductId.Value = productId;
                        }
                        else
                        {
                            pProductId.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(pProductId);


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            list = new List<ProductManagment>();
                            while (reader.Read())
                            {
                                ProductManagment newPrMn = new ProductManagment();
                                newPrMn.Id = Convert.ToInt32(reader["id"]);
                                newPrMn.ProductId = Convert.ToInt32(reader["productId"]);
                                newPrMn.Quantity = Convert.ToDecimal(reader["quantity"]);
                                newPrMn.ActionDate = Convert.ToDateTime(reader["actionDate"]);
                                newPrMn.Action = Convert.ToInt32(reader["action"]);
                                newPrMn.UserId = Convert.ToInt32(reader["userId"]);
                                newPrMn.Reason = Convert.ToString(reader["reason"]);
                                newPrMn.Price = Convert.ToDecimal(reader["price"]);
                                newPrMn.SupplierId = Convert.ToInt32(reader["supplierId"]);
                                newPrMn.Brand = Convert.ToString(reader["brand"]);
                                newPrMn.LastModifyDate = Convert.ToDateTime(reader["lastModifyDate"]);
                                newPrMn.IsActive = Convert.ToBoolean(reader["isActive"]);
                                list.Add(newPrMn);
                            }

                        }
                    }
                }

                return list;
            }


        }
        public int DeleteItem(int id)
        {
            int res = 0;
            using (var conn = new SqlConnection(ConnectionParameters.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(_deleteItem, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", System.Data.SqlDbType.Int);
                    pId.Value = id;
                    cmd.Parameters.Add(pId);

                    SqlParameter pResult = new SqlParameter("result", System.Data.SqlDbType.Int);
                    pResult.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(pResult);

                    cmd.ExecuteNonQuery();

                    res = Convert.ToInt32(pResult.Value);

                }
            }
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

                    SqlParameter pQuantity = new SqlParameter("@quantity", SqlDbType.Decimal);
                    pQuantity.Value = prMn.Quantity;
                    cmd.Parameters.Add(pQuantity);

                    SqlParameter pActionDate = new SqlParameter("@actionDate", SqlDbType.DateTime); //Date or Datatime
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

                    SqlParameter pBrand = new SqlParameter("@brand", SqlDbType.VarChar);
                    pBrand.Value = prMn.Brand;
                    cmd.Parameters.Add(pBrand);


                    SqlParameter pLastModifyDate = new SqlParameter("@lastModifyDate", SqlDbType.DateTime);
                    pLastModifyDate.Value = prMn.LastModifyDate;
                    cmd.Parameters.Add(pLastModifyDate);


                    SqlParameter pIsActive = new SqlParameter("@isActive", SqlDbType.Bit);
                    pIsActive.Value = prMn.IsActive;
                    cmd.Parameters.Add(pIsActive);

                    SqlParameter pResult = new SqlParameter("@res", System.Data.SqlDbType.Int);
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