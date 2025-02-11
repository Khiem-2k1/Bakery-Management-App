using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ModelCategories;
using Beans;

namespace Business
{
    public class TransactionDAO
    {
        //DBLayer db;

        public TransactionDAO()
        {
            ///constructor
            //db = new DBLayer();
        }
        
        public bool insertTransaction(ref string err,
            string username, string address, string phone, DateTime createDate, string note)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            Transaction t = new Transaction();
            t.us_username = username;
            t.addressTo = address;
            t.phoneTo = phone;
            t.createdate = createDate;
            t.note= note;
            coffe.Transactions.InsertOnSubmit(t);
            coffe.Transactions.Context.SubmitChanges();
            return true;
/*
            ///err:
            ///username, ...: thông tin của GIAO DỊCH cần THÊM
            ///thực hiện: THÊM GIAO DỊCH bằng THỦ TỤC
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu THẤT BẠI
            return db.MyExecuteNonQuery(
                "sp_InsertTransaction", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone),
                new SqlParameter("@createdate", createDate),
                new SqlParameter("@note", note));*/
        }

        public int getTransactionID()
        {
            int id=0;
            TheCoffeDataContext coffe = new TheCoffeDataContext();

            var tQuery = (from t in coffe.Transactions
                           orderby t.id descending
                           select t).FirstOrDefault();
            if (tQuery != null)
            {
                id = tQuery.id;
                coffe.SubmitChanges();
            }
            ///thực hiện: lấy ID GIAO DỊCH đầu tiên sau khi sắp xếp giảm dần
            ///trả về: id GIAO DỊCH
           /* DataSet ds = db.ExecuteQueryDataSet(
                "SELECT TOP 1 id " +
                "FROM [dbo].[Transaction] " +
                "ORDER BY id DESC", CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);*/
            return id;
        }

        /*public DataSet getTransactionByUser(string username)
        {
            ///username:
            ///thực hiện: lấy thông tin giao dịch theo người dùng bằng thủ tục
            ///trả về: data table giao dịch theo người dùng
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getTransactionByUser", CommandType.StoredProcedure,
                new SqlParameter("@username", username));
            return ds;
        }*/
        /*public DataSet getTransactionByUserForDate(string username, string datefrom, string dateto)
        {
            ///username: USER NAME
            ///datefrom: giao dịch từ NGÀY xx
            ///dateto: giao dịch đến NGÀY xx
            ///thực hiện: lấy thông tin giao dịch  theo ngày và user
            ///trả về: data table
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getTransactionByUserForDate", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@datefrom", datefrom),
                new SqlParameter("@dateto", dateto));
            return ds;
        }*/

        public bool deleteTransaction(ref string err, int transactionid)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var tQuery = from t in coffe.Transactions
                          where t.id == transactionid
                          select t;
            coffe.Transactions.DeleteAllOnSubmit(tQuery);

            var oQuery = from o in coffe.Orders
                         where o.id == transactionid
                         select o;
            coffe.Orders.DeleteAllOnSubmit(oQuery);

            coffe.SubmitChanges();
            return true;
            /*///err:
            ///transactionid: ID GIAO DỊCH
            ///thực hiện: XÓA giao dịch theo ID GIAO DỊCH bằng thủ tục
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu THẤT BẠI
            bool rs = db.MyExecuteNonQuery(
                "sp_DeleteTransaction", CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", transactionid));
            return rs;*/
        }
    }
}
