using System;
using System.Data;
using System.Linq;
using DBProvider;

namespace Business
{
    public class SupplierDAO : DBContext
    {
        private DBTheCoffeeEntities dbContext;

        public SupplierDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public DataTable GetAllNameSupplier()
        {
            var query = from Supplier in dbContext.Suppliers
                        select new
                        {
                            Supplier.id,
                            Supplier.sup_name
                        };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            foreach (var result in query)
            {
                dataTable.Rows.Add(result.id, result.sup_name);
            }

            return dataTable;
        }

        public int GetSupplierID(string sup_name)
        {
            var query = from Supplier in dbContext.Suppliers
                        where Supplier.sup_name == sup_name
                        select Supplier.id;

            return query.FirstOrDefault();
        }

    }
}
