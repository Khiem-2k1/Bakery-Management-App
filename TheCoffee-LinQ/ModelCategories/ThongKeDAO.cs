using System.Data;

namespace Business
{
    public class ThongKeDAO
    {
        //DBLayer db;
        public ThongKeDAO()
        {
            ///constructor
            //db = new DBLayer();
        }
       /* public DataSet getAllBaoCaoDoanhThu()
        {
            ///thực hiện: lấy VIEW đã tạo trong database
            ///trả về: view báo cáo doanh thu
            DataSet tmp = db.ExecuteQueryDataSet(
                "select * from View_BaoCaoDoanhThu", CommandType.Text, null);
            return tmp;
        }*/

        /*public DataSet getBaoCaoDoanhThuDate(string from, string to)
        {
            ///from: NGÀY từ xx
            ///to: đến NGÀY xx
            ///thực hiện: lấy VIEW báo cáo doanh thu theo ngày
            ///trả về: view báo cáo doanht hu theo ngày
            DataSet tmp = db.ExecuteQueryDataSet(
                "select * from View_BaoCaoDoanhThu " +
                "where createdate >='" + from + "' and " + "createdate <='" + to + "'",
                CommandType.Text, null);
            return tmp;
        }*/
    }
}
