using System;
using System.Data;
using System.Data.Entity;

namespace DBProvider
{
    public class DBLayer : DbContext
    {
        public DBLayer(string connectionString) : base(connectionString)
        {
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return Set<T>();
        }

        public DataTable ExecuteQueryDataSet(string sql, params object[] parameters)
        {
            var dataTable = new DataTable();
            using (var connection = this.Database.Connection)
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string sql, params object[] parameters)
        {
            return this.Database.ExecuteSqlCommand(sql, parameters);
        }
    }
}
