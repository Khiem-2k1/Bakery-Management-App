using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBProvider;

namespace ModelOrder
{
    public class OrderDAO
    {
        private DBLayer db;

        public OrderDAO()
        {
            db = new DBLayer();
        }
        public bool insertOrder(ref string err, Order order)
        {
            return db.MyExecuteNonQuery(
                "sp_InsertOrder", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", order.username),
                new SqlParameter("@transactionID", order.transactionID),
                new SqlParameter("@productID", order.productID),
                new SqlParameter("@quantity", order.quantity)
                );
        }

        public DataSet getOrderDetail(string username, int transactionid)
        {
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getOrderDetail", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@transactionID", transactionid));
            return ds;
        }
    }
  

}
