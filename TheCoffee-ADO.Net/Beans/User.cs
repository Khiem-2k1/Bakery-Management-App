using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Beans
{
    public class User
    {
        /// <summary>
        /// Class Order
        /// được tạo ra để lưu thông tin của NGƯỜI DÙNG (các thuộc tính bến dưới)
        /// các thuộc tính bên dưới tương ứng với thuộc tính trong database
        /// </summary>
        public string username { set; get; }
        public string password { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public string address { set; get; }
        public DateTime birthday { set; get; }
        public string gender { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public string role { set; get; }
        public List<Order> listOrder { set; get; }
        public DataTable orderTable { set; get; }

    }
}
