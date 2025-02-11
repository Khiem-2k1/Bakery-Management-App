using System.Data;
using System.Linq;
using DBProvider;
using System;

namespace Business
{
    public class OrderDAO
    {
        private DBTheCoffeeEntities dbContext;

        public OrderDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public bool InsertOrder(ref string err, Order order)
        {
            try
            {
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public DataTable GetOrderDetail(string username, int transactionid)
        {
            var ds = new DataTable();

            var query = from od in dbContext.Orders
                        where od.us_username == username && od.transactionID == transactionid
                        select new { od.productID, od.or_quantity, od.or_price };

            var results = query.ToList();
            ds.Columns.Add("Sản Phẩm");
            ds.Columns.Add("Số lượng");
            ds.Columns.Add("Giá");

            foreach (var result in results)
            {
                // Truy vấn tên sản phẩm dựa trên productID
                var productName = (from p in dbContext.Products
                                   where p.id == result.productID
                                   select p.pro_name).FirstOrDefault();

                // Thêm dữ liệu vào DataTable
                ds.Rows.Add(productName, result.or_quantity, result.or_price);
            }

            return ds;
        }
    }
}
