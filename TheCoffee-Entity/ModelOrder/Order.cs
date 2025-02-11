using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelOrder
{
    public class Order
    {
        public int id { set; get; }
        public string username { set; get; }
        public int transactionID {set;get;}
        public int productID { set; get; }
        public string productName { set; get; }
        public int quantity { set; get; }
        public double price { set; get; }
    }
}
