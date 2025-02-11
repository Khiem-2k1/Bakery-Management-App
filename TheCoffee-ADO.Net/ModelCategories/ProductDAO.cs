using System;
using System.Data.SqlClient;
using System.Data;
using DBProvider;
using Beans;
namespace Business
{
    public class ProductDAO
    {
        DBLayer db;
        public ProductDAO()
        {
            ///Constructor
            db = new DBLayer();
        }
        public DataSet timKiemSanPhamTheoTen(string name)
        {
            ///name: TÊN SẢN PHẦM cần tìm kiếm
            ///thực hiện: Tìm Kiếm sản phầm bằng thủ tục, trả về 1 data table thông tin sản phẩm
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "sp_TimKiemSanPhamTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@name", name));
        }
        public DataSet getAllProduct()
        {
            ///Thực hiện: lấy tất cả sản phẩm
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "sp_getAllProduct", CommandType.StoredProcedure, null);
        }
        
        public Product getProduct(int id)
        {
            ///id: id của sản phẩm
            ///Thực hiên: Lấy thông tin sản phẩm theo ID
            ///trả về: SẢN PHẨM cần tìm và thông tin về sản phẩm            
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
            double pro_firstprice, double pro_price, string pro_description,
            DateTime pro_nsx, DateTime pro_hsd)
        {
            ///err:
            ///sup_id, pro_name, pro_quantity, pro_firstprice, 
            ///pro_price, pro_description, pro_nsx, pro_hsd:
            ///Thông tin sản phảm cần được thêm
            ///Trả về: 1 nếu thêm thành công; 0 nếu thất bại
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
            ///err:
            ///pro_id: id sản phẩm bị xóa
            ///thực hiện: gọi thủ tục để xóa sản phẩm
            ///trả về: 1 nếu xóa thành công; 0 nếu không thành công
            return db.MyExecuteNonQuery(
                "sp_DeleteProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", pro_id));
        }

        public bool updateProduct(ref string err,
            int pro_id, int sup_id, int cate_id, string pro_name, int pro_quantity,
            double pro_firstprice, double pro_price, string pro_description, 
            DateTime pro_nsx, DateTime pro_hsd)
        {
            ///err:
            ///pro_id, ... : những thông tin của sản phẩm được CẬP NHẬT
            ///thực hiện: gọi thủ tục để CẬP NHẬT sản phẩm
            ///trả về: 1 nếu CẬP NHẬT thành công; 0 nếu không thành công

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

