using System.Data.SqlClient;
using System.Data;
using DBProvider;
using Beans;

namespace Business
{
    public class OrderDAO
    {
        private DBLayer db;

        public OrderDAO()
        {
            ///constructor
            db = new DBLayer();
        }
        public bool insertOrder(ref string err, Order order)
        {
            ///err:
            ///order: thông tin đơn hàng (các thuộc tính...)
            ///thục hiện: thêm một đơn hàng
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu THẤT BẠI
            return db.MyExecuteNonQuery(
                "sp_InsertOrder", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", order.username),
                new SqlParameter("@transactionID", order.transactionID),
                new SqlParameter("@productID", order.productID),
                new SqlParameter("@quantity", order.quantity));
        }

        public DataSet getOrderDetail(string username, int transactionid)
        {
            ///username: USER NAME người dùng
            ///transactionid: ID giao dịch
            ///thực hiện: lấy thông tin chi tiết về đơn hàng bằng thủ tục
            ///trả về: data table về đơn hàng
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getOrderDetail", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@transactionID", transactionid));
            return ds;
        }
    }
  

}
