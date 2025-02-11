using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBProvider;

namespace ModelSupplier
{

    public class SupplierDAO
    {
        DBLayer db;
        public SupplierDAO()
        {
            db = new DBLayer();
        }
        public DataSet getAllNameSupplier()
        {
            return db.ExecuteQueryDataSet(
                "select id, sup_name from [dbo].[Supplier]", CommandType.Text, null);
        }
        public int getSupplierID(string sup_name)
        {
            DataSet ds = db.ExecuteQueryDataSet("select id from [dbo].[Supplier] where sup_name = '" + sup_name + "'", CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
            return id;
        }
    }
}
