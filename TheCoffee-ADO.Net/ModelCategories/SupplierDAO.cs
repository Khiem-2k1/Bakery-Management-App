using System;
using System.Data;
using DBProvider;

namespace Business
{

    public class SupplierDAO
    {
        DBLayer db;
        public SupplierDAO()
        {
            ///constructor
            db = new DBLayer();
        }
        public DataSet getAllNameSupplier()
        {
            ///thực hiện: lấy ID và Tên nhà cung cấp bằng truy vấn
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "select id, sup_name from [dbo].[Supplier]", CommandType.Text, null);
        }
        public int getSupplierID(string sup_name)
        {
            ///sup_name: tên nhà cung cấp
            ///thực hiện: lấy id nhà cung cấp bằng query
            ///trả về: id nhà cung cấp
            DataSet ds = db.ExecuteQueryDataSet(
                "select id from [dbo].[Supplier] " +
                "where sup_name = '" + sup_name + "'", 
                CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
            return id;
        }
    }
}
