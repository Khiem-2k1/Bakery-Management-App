using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBProvider;

namespace ModelTransactions
{
    public class TransactionDAO
    {
        DBLayer db;

        public TransactionDAO()
        {
            db = new DBLayer();
        }
        
        public bool insertTransaction(ref string err,
            string username, string address, string phone, DateTime createDate, string note)
        {
            return db.MyExecuteNonQuery(
                "sp_InsertTransaction", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone),
                new SqlParameter("@createdate", createDate),
                new SqlParameter("@note", note));
        }

        public int getTransactionID()
        {
            DataSet ds = db.ExecuteQueryDataSet(
                "select top 1 id from [dbo].[Transaction] order by id desc", CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            return id;
        }

        public DataSet getTransactionByUser(string username)
        {
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getTransactionByUser", CommandType.StoredProcedure,
                new SqlParameter("@username", username));
            return ds;
        }
        public DataSet getTransactionByUserForDate(string username, string datefrom, string dateto)
        {
            DataSet ds = db.ExecuteQueryDataSet(
                "sp_getTransactionByUserForDate", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@datefrom", datefrom),
                new SqlParameter("@dateto", dateto));
            return ds;
        }

        public bool deleteTransaction(ref string err, int transactionid)
        {
            bool rs = db.MyExecuteNonQuery(
                "sp_DeleteTransaction", CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", transactionid));
            return rs;
        }
    }
}
