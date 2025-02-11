using System;
using System.Data;
using System.Linq;
using DBProvider;


namespace Business
{
    public class ProductDAO
    {
        private DBTheCoffeeEntities dbContext;

        public ProductDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public DataTable timKiemSanPhamTheoTen(string name)
        {
            var query = from product in dbContext.Products
                        where product.pro_name.Contains(name)
                        select new
                        {
                            product.id,
                            product.categoriesID,
                            product.supplierID,
                            product.pro_name,
                            product.pro_quantity,
                            product.pro_price,
                            product.pro_description,
                            product.pro_nsx,
                            product.pro_hsd
                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã sản phẩm");
            dataTable.Columns.Add("Tên sản phẩm");
            dataTable.Columns.Add("Số lượng");
            dataTable.Columns.Add("Giá");
            dataTable.Columns.Add("Nhà phân phối");
            dataTable.Columns.Add("Danh mục");
            dataTable.Columns.Add("Ngày sản xuất");
            dataTable.Columns.Add("Hạn sử dụng");
            dataTable.Columns.Add("Mô tả");

            foreach (var result in query)
            {
                dataTable.Rows.Add(
                    result.id,
                    result.pro_name,
                    result.pro_quantity,
                    result.pro_price,
                    result.supplierID,
                    result.categoriesID,
                    result.pro_nsx,
                    result.pro_hsd,
                    result.pro_description
                    );
            }

            return dataTable;
        }

        public DataTable getAllProduct()
        {
            var query = from product in dbContext.Products
                        select new
                        {
                            product.id,
                            product.categoriesID,
                            product.supplierID,
                            product.pro_name,
                            product.pro_quantity,
                            product.pro_firstprice,
                            product.pro_price,
                            product.pro_description,
                            product.pro_nsx,
                            product.pro_hsd
                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Danh mục", typeof(string));
            dataTable.Columns.Add("Nhà phân phối", typeof(string));
            dataTable.Columns.Add("Tên sản phẩm", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Giá nhập", typeof(double));
            dataTable.Columns.Add("Giá bán", typeof(double));
            dataTable.Columns.Add("Mô tả", typeof(string));
            dataTable.Columns.Add("Ngày sản xuất", typeof(DateTime));
            dataTable.Columns.Add("Hạn sử dụng", typeof(DateTime));

            foreach (var result in query)
            {
                var catename = (from p in dbContext.Categories
                                   where p.id == result.categoriesID
                                   select p.cate_name).FirstOrDefault();
                var suppliername = (from p in dbContext.Suppliers
                                where p.id == result.supplierID
                                select p.sup_name).FirstOrDefault();
                dataTable.Rows.Add(
                    result.id,
                    catename,
                    suppliername,
                    result.pro_name,
                    result.pro_quantity,
                    result.pro_firstprice,
                    result.pro_price,
                    result.pro_description,
                    result.pro_nsx,
                    result.pro_hsd
                    );
            }

            return dataTable;
        }

        public Product getProduct(int id)
        {
            var query = from product in dbContext.Products
                        where product.id == id
                        select product;

            return query.FirstOrDefault();
        }

        public bool insertProduct(ref string err, int sup_id, int cate_id, string pro_name, int pro_quantity, double pro_firstprice, double pro_price, string pro_description, DateTime pro_nsx, DateTime pro_hsd)
        {
            try
            {
                Product product = new Product
                {
                    categoriesID = cate_id,
                    supplierID = sup_id,
                    pro_name = pro_name,
                    pro_quantity = pro_quantity,
                    pro_firstprice = pro_firstprice,
                    pro_price = pro_price,
                    pro_description = pro_description,
                    pro_nsx = pro_nsx,
                    pro_hsd = pro_hsd,
                };

                dbContext.Products.Add(product);
                dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool deleteProduct(ref string err, int pro_id)
        {
            try
            {
                Product product = dbContext.Products.Find(pro_id);
                if (product != null)
                {
                    dbContext.Products.Remove(product);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    err = "Product not found.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool updateProduct(ref string err, int pro_id, int sup_id, int cate_id, string pro_name, int pro_quantity, double pro_firstprice, double pro_price, string pro_description, DateTime pro_nsx, DateTime pro_hsd)
        {
            try
            {
                Product product = dbContext.Products.Find(pro_id);
                if (product != null)
                {
                    product.categoriesID = cate_id;
                    product.supplierID = sup_id;
                    product.pro_name = pro_name;
                    product.pro_quantity = pro_quantity;
                    product.pro_firstprice = pro_firstprice;
                    product.pro_price = pro_price;
                    product.pro_description = pro_description;
                    product.pro_nsx = pro_nsx;
                    product.pro_hsd = pro_hsd;

                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    err = "Product not found.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
