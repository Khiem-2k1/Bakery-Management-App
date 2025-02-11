using System;
using System.Data;
using System.Linq;
using DBProvider;

namespace Business
{
    public class StatisticDAO
    {
        private DBTheCoffeeEntities dbContext;

        public StatisticDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public DataTable getAllBaoCaoDoanhThu()
        {
            var query = from report in dbContext.View_BaoCaoDoanhThu
                        select report;

            return ToDataTable(query);
        }

        public DataTable getBaoCaoDoanhThuDate(string fromD, string toD)
        {
            var query = from report in dbContext.View_BaoCaoDoanhThu
                        where report.createdate >= DateTime.Parse(fromD) && report.createdate <= DateTime.Parse(toD)
                        select report;

            return ToDataTable(query);
        }

        private DataTable ToDataTable<T>(IQueryable<T> query)
        {
            DataTable dataTable = new DataTable();

            foreach (var property in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }

            foreach (var result in query)
            {
                DataRow row = dataTable.NewRow();

                foreach (var property in typeof(T).GetProperties())
                {
                    row[property.Name] = property.GetValue(result);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
