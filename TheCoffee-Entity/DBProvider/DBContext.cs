using System;
using System.Data;
using System.Data.Entity;

namespace DBProvider
{
    public class DBContext : DbContext
    {
        static DBContext()
        {
            Database.SetInitializer<DBContext>(null);
        }

        public DBContext() : base(@"Data Source=.\THSQLSERVER;Initial Catalog=DIEPFAMILY;Integrated Security=True")
        {
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return Set<T>();
        }


        public void ExecuteNonQuery(string sql, params object[] parameters)
        {
            Database.ExecuteSqlCommand(sql, parameters);
        }

        public DataTable ExecuteQuery(string sql, params object[] parameters)
        {
            var dataTable = new DataTable();
            using (var command = Database.Connection.CreateCommand())
            {
                command.CommandText = sql;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }
                Database.Connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                Database.Connection.Close();
            }
            return dataTable;
        }

        public object ChangePassword(string username, string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}
