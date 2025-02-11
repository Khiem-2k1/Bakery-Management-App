using System;
using System.Data;
using DBProvider;
namespace Business
{
    public class CategoriesDAO
    {
        DBLayer db;
        public CategoriesDAO()
        {
            ///constructor
            db = new DBLayer();
        }
        public DataSet getAllNameCategories()
        {
            ///thực hiện: lấy tất cả tên DANH MỤC và ID bằng query
            ///trả về: data table (ID, tên danh mục)
            return db.ExecuteQueryDataSet(
                "select id, cate_name from [dbo].[Categories]", 
                CommandType.Text, null);
        }

        public int getCategoriesID(string cate_name)
        {
            ///cate_name: tên danh mục
            ///thực hiện: lấy ID danh mục dựa trên tên danh mục, bằng query
            ///trả về: id danh mục
            DataSet ds = db.ExecuteQueryDataSet("select id from [dbo].[Categories] where cate_name = '" + cate_name + "'", CommandType.Text, null);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
            return id;
        }
    }
}
