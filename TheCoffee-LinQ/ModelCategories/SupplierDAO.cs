using Beans;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelCategories;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Linq;

namespace Business
{

    public class SupplierDAO
    {
        //DBLayer db;
        public SupplierDAO()
        {
            ///constructor
            //db = new DBLayer();
        }
      /*  public DataSet getAllNameSupplier()
        {
            ///thực hiện: lấy ID và Tên nhà cung cấp bằng truy vấn
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "select id, sup_name from [dbo].[Supplier]", CommandType.Text, null);
        }*/
        public int getSupplierID(string sup_name)
        {
            int id = 0;
            TheCoffeDataContext coffe = new TheCoffeDataContext();

            var sQuery = (from s in coffe.Suppliers
                          where s.sup_name == sup_name
                          select s).SingleOrDefault();
            if (sQuery != null)
            {
                id = sQuery.id;
                coffe.SubmitChanges();
            }
            return id;
           /* ///sup_name: tên nhà cung cấp
            ///thực hiện: lấy id nhà cung cấp bằng query
            ///trả về: id nhà cung cấp
            DataSet ds = db.ExecuteQueryDataSet(
                "select id from [dbo].[Supplier] " +
                "where sup_name = '" + sup_name + "'", 
                CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
            return id;*/
        }
    }
}
