using System.Data.SqlClient;
using System.Data;
using Beans;
using ModelCategories;
using System.Net;
using System.Security.Policy;

namespace Business
{
    public class OrderDAO
    {
        //private DBLayer db;

        public OrderDAO()
        {
            ///constructor
            //db = new DBLayer();
        }
        public bool insertOrder(ref string err, Order1 order)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            Order o = new Order();
            o.us_username = order.username;
            o.transactionID = order.transactionID;
            o.productID = order.productID;
            o.or_quantity = order.quantity;
            coffe.Orders.InsertOnSubmit(o);
            coffe.Orders.Context.SubmitChanges();
            return true;
            ///err:
            ///order: thông tin đơn hàng (các thuộc tính...)
            ///thục hiện: thêm một đơn hàng
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu THẤT BẠI
            /*return db.MyExecuteNonQuery(
                "sp_InsertOrder", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", order.username),
                new SqlParameter("@transactionID", order.transactionID),
                new SqlParameter("@productID", order.productID),
                new SqlParameter("@quantity", order.quantity));*/
        }

        /*public DataSet getOrderDetail(string username, int transactionid)
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
        }*/
    }
}
