using Beans;
using DBProvider;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
    public class UserDAO
    {
        DBLayer db;
        public UserDAO()
        {
            ///constructor
            db = new DBLayer();
        }
        public DataSet getAllKhachHang()
        {
            ///thực hiện: lấy tất cả thông tin customer bằng SQL
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email " +
                "from [dbo].[User] " +
                "where us_role = 'Customer' ", 
                CommandType.Text, null);
        }

        public DataSet getAllNhanVien()
        {
            ///thực hiện: lấy tất cả thông tin employee bằng SQL
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email " +
                "from [dbo].[User] " +
                "where us_role = 'Admin' or us_role ='Employee'", 
                CommandType.Text, null);
        }
        public bool insertUser(ref string err,
            string username, string password, string firstname, string lastname,
            string address, DateTime birthday, string gender, string phone,
            string email, string role)
        {
            ///err:
            ///username, ... : thông tin user được THÊM
            ///thực hiên: thêm user bằng thủ tục
            ///trả về: 1 nếu thêm THÀNH CÔNG; 0 nếu KHÔNG THÀNH CÔNG
            return db.MyExecuteNonQuery(
                "sp_InsertUser", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@firstname", firstname),
                new SqlParameter("@lastname", lastname),
                new SqlParameter("@address", address),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@email", email),
                new SqlParameter("@role", role)
                );
        }
        public bool delelteUser(ref string err, string username)
        {
            ///err:
            ///username: USER NAME muốn xóa
            ///thực hiên: XÓA user bằng thủ tục
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu KHÔNG THÀNH CÔNG
            return db.MyExecuteNonQuery(
                "sp_DeleteUser",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username));
        }

        public bool updateUser(ref string err,
           string username, string password, string firstname, string lastname,
           string address, DateTime birthday, string gender, string phone,
           string email, string role)
        {
            ///err:
            ///username, ... : thông tin user được CẬP NHẬT
            ///thực hiên: CẬP NHẬT user bằng thủ tục
            ///trả về: 1 nếu THÀNH CÔNG; 0 nếu KHÔNG THÀNH CÔNG
            return db.MyExecuteNonQuery(
                "sp_UpdateUser", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@firstname", firstname),
                new SqlParameter("@lastname", lastname),
                new SqlParameter("@address", address),
                new SqlParameter("@birthday", birthday),
                new SqlParameter("@gender", gender),
                new SqlParameter("@phone", phone),
                new SqlParameter("@email", email),
                new SqlParameter("@role", role)
                );
        }
        public User getInfoUser(string username)
        {
            ///username: USER NAME cân lấy thông tin
            ///thực hiện: thực thi THỦ TỤC lấy thông tin user
            ///trả về: data table về user đó
            User user = new User();
            DataSet result = db.ExecuteQueryDataSet(
                "sp_InfoUser", CommandType.StoredProcedure,
                 new SqlParameter("@username", username));

            foreach (DataRow row in result.Tables[0].Rows)
            {
                user.username = username;
                user.password = row["us_password"].ToString();
                user.firstName = row["us_firstname"].ToString();
                user.lastName = row["us_lastname"].ToString();
                user.address = row["us_address"].ToString();
                user.birthday = (DateTime)row["us_birthday"];
                user.phone = row["us_phone"].ToString();
                user.email = row["us_email"].ToString();
                user.role = row["us_role"].ToString();
                user.gender = row["us_gender"].ToString();
            }
            return user;
        }


        public DataSet checkLogin(string username, string password)
        {
            ///username:USER NAME cần kiểm tra
            ///password: PASSWORD cần kiểm tra
            ///thực hiện: KIỂM TRA tài khoản và mật khẩu có trong database không bằng thủ tục            
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "sp_CheckLogin", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password));
        }

        public DataSet changePassword(ref string err, string username, string oldpassword, string newpassword, string confirmpassword)
        {
            ///err:
            ///username: USER NAME cần đổi pass
            ///oldpassword: PASSWORD trước khi đổi
            ///newpassword: PASSWORD muốn đổi
            ///confirmpassword: xác nhận lại newpassword
            ///thực hiện: Thay đổi password bằng thủ tục
            ///trả về: data table
            return db.ExecuteQueryDataSet(
                "sp_ChangePassword", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@password_old", oldpassword),
                new SqlParameter("@password_new", newpassword),
                new SqlParameter("@confirmPass", confirmpassword));
        }

        public bool Register(ref string err, string username, string password, string confirmpassword)
        {
            ///err:
            ///username: USER NAME đăng ký
            ///password: password đăng ký
            ///confirmpassword: xác nhận lại password
            ///thực hiện: đăng ký user mới bằng thủ tục
            return db.MyExecuteNonQuery(
                "sp_Register", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@confirmpassword", confirmpassword));
        }
    }
}
