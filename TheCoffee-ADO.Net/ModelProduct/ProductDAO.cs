using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBProvider;
namespace ModelProduct
{
    public class ProductDAO
    {
        DBLayer db;
        public ProductDAO()
        {
            db = new DBLayer();
        }
        public DataSet timKiemSanPhamTheoTen(string name)
        {
            return db.ExecuteQueryDataSet(
                "sp_TimKiemSanPhamTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@name", name));
        }
        public DataSet getAllProduct()
        {
            return db.ExecuteQueryDataSet(
                "sp_getAllProduct", CommandType.StoredProcedure, null);
        }
        
        public Product getProduct(int id)
        {
            DataSet result =  db.ExecuteQueryDataSet(
                "sp_getProduct", CommandType.StoredProcedure,
                new SqlParameter("@id", id));
            Product product = new Product();
            foreach(DataRow row in result.Tables[0].Rows)
            {
                product.id = id;
                product.categoriesID = (int) row["categoriesID"];
                product.supplierID = (int) row["supplierID"];
                product.name = row["pro_name"].ToString();
                product.quantity = (int)row["pro_quantity"];
                product.firstPrice = (double)row["pro_firstprice"];
                product.price = (double)row["pro_price"];
                product.description = row["pro_description"].ToString();
                product.nsx = (DateTime) row["pro_nsx"];
                product.hsd = (DateTime)row["pro_hsd"];
            }
            return product;
        }
        
        public bool insertProduct(ref string err,
            int sup_id, int cate_id, string pro_name, int pro_quantity,
            double pro_firstprice, double pro_price, string pro_description, DateTime pro_nsx,
            DateTime pro_hsd)
        {
            return db.MyExecuteNonQuery(
                "sp_InsertProduct", CommandType.StoredProcedure, ref err,
                new SqlParameter("@categoriesID", cate_id),
                new SqlParameter("@supplierID", sup_id),
                new SqlParameter("@pro_name", pro_name),
                new SqlParameter("@pro_quantity", pro_quantity),
                new SqlParameter("@pro_firstprice", pro_firstprice),
                new SqlParameter("@pro_price", pro_price),
                new SqlParameter("@pro_nsx", pro_nsx),
                new SqlParameter("@pro_hsd", pro_hsd),
                new SqlParameter("@pro_description", pro_description)
                );
        }
        public bool deleteProduct(ref string err, int pro_id)
        {
            return db.MyExecuteNonQuery(
                "sp_DeleteProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", pro_id));
        }

        public bool updateProduct(ref string err,
            int pro_id, int sup_id, int cate_id, string pro_name, int pro_quantity,
            double pro_firstprice, double pro_price, string pro_description, DateTime pro_nsx,
            DateTime pro_hsd)
        {
            return db.MyExecuteNonQuery(
                "sp_UpdateProduct", CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", pro_id),
                new SqlParameter("@categoriesID", cate_id),
                new SqlParameter("@supplierID", sup_id),
                new SqlParameter("@name", pro_name),
                new SqlParameter("@quantity", pro_quantity),
                new SqlParameter("@firstprice", pro_firstprice),
                new SqlParameter("@price", pro_price),
                new SqlParameter("@nsx", pro_nsx),
                new SqlParameter("@hsd", pro_hsd),
                new SqlParameter("@description", pro_description)
                );
        }
    }
}

