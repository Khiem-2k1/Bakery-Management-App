using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DBProvider;

namespace Business
{
    public class TransactionDAO
    {
        private DBTheCoffeeEntities dbContext;

        public TransactionDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public bool InsertTransaction(ref string err, string username, string address, string phone, DateTime createDate, string note)
        {
            try
            {
                var transaction = new Transaction
                {
                    us_username = username,
                    addressTo = address,
                    phoneTo = phone,
                    createdate = createDate,
                    note = note
                };

                dbContext.Transactions.Add(transaction);
                dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public int GetTransactionID()
        {
            var query = dbContext.Transactions
                .OrderByDescending(t => t.id)
                .Select(t => t.id)
                .FirstOrDefault();

            return query;
        }

        public DataTable GetTransactionByUser(string username)
        {
            var ds = new DataTable();
            
                var query = from t in dbContext.Transactions
                            where t.us_username == username
                            select t;

                ds.Columns.Add("ID");
                ds.Columns.Add("Username");
                ds.Columns.Add("Address");
                ds.Columns.Add("Phone");
                ds.Columns.Add("Total Price");
                ds.Columns.Add("CreateDate");
                ds.Columns.Add("Note");

                foreach (var transaction in query)
                {
                    ds.Rows.Add(transaction.id, transaction.us_username, transaction.addressTo, transaction.phoneTo,transaction.totalprice, transaction.createdate, transaction.note);
                }
            

            return ds;
        }

        public DataTable GetTransactionByUserForDate(string username, string datefrom, string dateto)
        {
            var ds = new DataTable();
            
                var fromDate = DateTime.Parse(datefrom);
                var toDate = DateTime.Parse(dateto).AddDays(1).AddMilliseconds(-1);

                var query = from t in dbContext.Transactions
                            where t.us_username == username && t.createdate >= fromDate && t.createdate <= toDate
                            select t;

                ds.Columns.Add("ID");
                ds.Columns.Add("Username");
                ds.Columns.Add("Address");
                ds.Columns.Add("Phone");
                ds.Columns.Add("CreateDate");
                ds.Columns.Add("Note");

                foreach (var transaction in query)
                {
                    ds.Rows.Add(transaction.id, transaction.us_username, transaction.addressTo, transaction.phoneTo, transaction.createdate, transaction.note);
                }
            

            return ds;
        }

        public bool DeleteTransaction(ref string err, int transactionid)
        {
            try
            {
                using (var context = new DBTheCoffeeEntities())
                {
                    var transaction = context.Transactions.FirstOrDefault(t => t.id == transactionid);
                    if (transaction != null)
                    {
                        context.Transactions.Remove(transaction);
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
