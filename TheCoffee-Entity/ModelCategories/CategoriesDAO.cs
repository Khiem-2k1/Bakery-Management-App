using System;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using DBProvider;

namespace Business
{
    public class CategoriesDAO
    {
        private DBTheCoffeeEntities dbContext;

        public CategoriesDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public DataTable getAllNameCategories()
        {
            var query = from category in dbContext.Categories
                        select new { category.id, category.cate_name };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Tên danh mục", typeof(string));

            foreach (var result in query)
            {
                dataTable.Rows.Add(result.id, result.cate_name);
            }

            return dataTable;
        }

        public int getCategoriesID(string cate_name)
        {
            var query = from category in dbContext.Categories
                        where category.cate_name == cate_name
                        select category.id;

            return query.FirstOrDefault();
        }
    }
}
