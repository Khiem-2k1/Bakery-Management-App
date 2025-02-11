using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public class Order
    {
        /// <summary>
        /// Class Order
        /// được tạo ra để lưu thông tin của ĐƠN HÀNG (các thuộc tính bến dưới)
        /// các thuộc tính bên dưới tương ứng với thuộc tính trong database
        /// </summary>
        public int id { set; get; }
        public string username { set; get; }
        public int transactionID {set;get;}
        public int productID { set; get; }
        public string productName { set; get; }
        public int quantity { set; get; }
        public double price { set; get; }
    }
}
