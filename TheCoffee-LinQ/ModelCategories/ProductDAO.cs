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
using System.Net;
using System.Security.Policy;

namespace Business
{
    public class ProductDAO
    {
        //DBLayer db;
        public ProductDAO()
        {
            ///Constructor
            //db = new DBLayer();
        }
        /*public DataSet timKiemSanPhamTheoTen(string name)
        {
            ///name: TÊN SẢN PHẦM cần tìm kiếm
            ///thực hiện: Tìm Kiếm sản phầm bằng thủ tục, trả về 1 data table thông tin sản phẩm
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "sp_TimKiemSanPhamTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@name", name));
        }*/
        
        /*public DataSet getAllProduct()
        {            
            ///Thực hiện: lấy tất cả sản phẩm
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "sp_getAllProduct", CommandType.StoredProcedure, null);
        }*/
        
        public Product1 getProduct(int id)
        {
            Product1 product = new Product1();
            TheCoffeDataContext coffe = new TheCoffeDataContext();

            var spQuery = (from sp in coffe.Products
                           where sp.id == id
                           select sp).SingleOrDefault();

            if (spQuery != null)
            {
                product.id = spQuery.id;
                product.categoriesID = spQuery.categoriesID;
                product.supplierID = spQuery.supplierID;
                product.name = spQuery.pro_name;
                product.quantity = spQuery.pro_quantity;
                product.firstPrice = (double)spQuery.pro_firstprice;
                product.price = (double)spQuery.pro_price;
                product.description = spQuery.pro_description;
                product.nsx = spQuery.pro_nsx;
                product.hsd = spQuery.pro_hsd;
                coffe.SubmitChanges();
            }
            return product;
            ///id: id của sản phẩm
            ///Thực hiên: Lấy thông tin sản phẩm theo ID
            ///trả về: SẢN PHẨM cần tìm và thông tin về sản phẩm            
          /*  DataSet result =  db.ExecuteQueryDataSet(
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
            return product;*/
        }
        
        public bool insertProduct(ref string err,
            int sup_id, int cate_id, string pro_name, int pro_quantity,
            double pro_firstprice, double pro_price, string pro_description,
            DateTime pro_nsx, DateTime pro_hsd)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            Product sp = new Product();
            sp.categoriesID = cate_id;
            sp.supplierID = sup_id;
            sp.pro_name = pro_name;
            sp.pro_quantity = pro_quantity;
            sp.pro_firstprice = pro_firstprice;
            sp.pro_price = pro_price;
            sp.pro_nsx = pro_nsx;
            sp.pro_hsd = pro_hsd;
            sp.pro_description = pro_description;
            coffe.Products.InsertOnSubmit(sp);
            coffe.Products.Context.SubmitChanges();
            return true;
            ///err:
            ///sup_id, pro_name, pro_quantity, pro_firstprice, 
            ///pro_price, pro_description, pro_nsx, pro_hsd:
            ///Thông tin sản phảm cần được thêm
            ///Trả về: 1 nếu thêm thành công; 0 nếu thất bại
            /*return db.MyExecuteNonQuery(
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
                );*/
        }
        public bool deleteProduct(ref string err, int pro_id)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var spQuery = from sp in coffe.Products
                          where sp.id == pro_id
                          select sp;
            coffe.Products.DeleteAllOnSubmit(spQuery);
            coffe.SubmitChanges();
            return true;
           /* ///err:
            ///pro_id: id sản phẩm bị xóa
            ///thực hiện: gọi thủ tục để xóa sản phẩm
            ///trả về: 1 nếu xóa thành công; 0 nếu không thành công
            return db.MyExecuteNonQuery(
                "sp_DeleteProduct",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@id", pro_id));*/
        }

        public bool updateProduct(ref string err,
            int pro_id, int sup_id, int cate_id, string pro_name, int pro_quantity,
            double pro_firstprice, double pro_price, string pro_description, 
            DateTime pro_nsx, DateTime pro_hsd)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var spQuery = (from sp in coffe.Products
                          where sp.id == pro_id
                          select sp).SingleOrDefault();
            if (spQuery != null)
            {
                spQuery.categoriesID = cate_id;
                spQuery.supplierID = sup_id;
                spQuery.pro_name = pro_name;
                spQuery.pro_quantity = pro_quantity;
                spQuery.pro_firstprice = pro_firstprice;
                spQuery.pro_price = pro_price;
                spQuery.pro_nsx = pro_nsx;
                spQuery.pro_hsd = pro_hsd;
                spQuery.pro_description= pro_description;
                coffe.SubmitChanges();
            }
            return true;
            ///err:
            ///pro_id, ... : những thông tin của sản phẩm được CẬP NHẬT
            ///thực hiện: gọi thủ tục để CẬP NHẬT sản phẩm
            ///trả về: 1 nếu CẬP NHẬT thành công; 0 nếu không thành công

          /*  return db.MyExecuteNonQuery(
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
                );*/
        }
    }
}

