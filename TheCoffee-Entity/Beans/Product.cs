using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beans
{
    public class Product
    {
        /// <summary>
        /// Class Product
        /// được tạo ra để lưu thông tin của SẢN PHẨM (các thuộc tính bến dưới)
        /// các thuộc tính bên dưới tương ứng với thuộc tính trong database
        /// </summary>
        public int id { set; get; }
        public int categoriesID { set; get; }
        public int supplierID { set; get; }
        public string name { set; get; }
        public int quantity { set; get; }
        public double firstPrice { set; get; }
        public double price { set; get; }
        public string description { set; get; }
        public DateTime nsx { set; get; }
        public DateTime hsd { set; get; }
    }
}
