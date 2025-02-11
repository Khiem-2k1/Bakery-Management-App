using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBProvider;

namespace ModelTransaction
{
    public class TransactionDBBusiness
    {
        DBLayer db;
        public TransactionDBBusiness()
        {
            db = new DBLayer();
        }
        
        

    }
}
