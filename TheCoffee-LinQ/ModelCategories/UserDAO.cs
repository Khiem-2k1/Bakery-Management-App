using Beans;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelCategories;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Linq;

namespace Business
{
    public class UserDAO
    {
        //DBLayer db;
        public UserDAO()
        {
            ///constructor
            //db = new DBLayer();
        }
      

        /*public DataSet getAllKhachHang()
        {
            ///thực hiện: lấy tất cả thông tin customer bằng SQL
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email " +
                "from [dbo].[User] " +
                "where us_role = 'Customer' ", 
                CommandType.Text, null);
        }*/

       /* public DataSet getAllNhanVien()
        {
            ///thực hiện: lấy tất cả thông tin employee bằng SQL
            ///trả về: 1 data table
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email " +
                "from [dbo].[User] " +
                "where us_role = 'Admin' or us_role ='Employee'", 
                CommandType.Text, null);
        }*/
        public bool insertUser(ref string err,
            string username, string password, string firstname, string lastname,
            string address, DateTime birthday, string gender, string phone,
            string email, string role)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            User nd = new User();
            nd.us_username = username;
            nd.us_password = password;
            nd.us_firstname = firstname;
            nd.us_lastname = lastname;
            nd.us_address = address;
            nd.us_birthday = birthday;
            nd.us_gender = char.Parse(gender);
            nd.us_phone = phone;
            nd.us_email = email;
            nd.us_role = role;
            coffe.Users.InsertOnSubmit(nd);
            coffe.Users.Context.SubmitChanges();
            return true;            
        }
        public bool delelteUser(ref string err, string username)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var ndQuery = from nd in coffe.Users
                          where nd.us_username == username
                          select nd;
            coffe.Users.DeleteAllOnSubmit(ndQuery);
            coffe.SubmitChanges();
            return true;            
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
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var ndQuery = (from nd in coffe.Users
                           where nd.us_username == username
                           select nd).SingleOrDefault();
            if (ndQuery != null)
            {
                ndQuery.us_firstname = firstname;
		        ndQuery.us_lastname = lastname;
                ndQuery.us_address = address;
                ndQuery.us_birthday = birthday;
                ndQuery.us_gender = char.Parse(gender);
                ndQuery.us_phone = phone;
                ndQuery.us_email = email;
                ndQuery.us_role = role;
                coffe.SubmitChanges();
            }
            return true;
                      
        }

        /*public bool updateUser1(ref string err,
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
        }*/
        
        public User1 getInfoUser(string username)
        {
            User1 user = new User1();
            TheCoffeDataContext coffe = new TheCoffeDataContext();

            var ndQuery = (from nd in coffe.Users
                           where nd.us_username == username
                           select nd).SingleOrDefault();
            var spQuery = (from sp in coffe.Products
                           where sp.id == 1
                           select sp).SingleOrDefault();           
            if (ndQuery != null)
            {
                user.username = ndQuery.us_username.ToString();
                user.password = ndQuery.us_password.ToString();
                user.firstName = ndQuery.us_firstname.ToString();
                user.lastName = ndQuery.us_lastname.ToString();
                user.address = ndQuery.us_address.ToString();
                user.birthday = (DateTime)ndQuery.us_birthday;
                user.phone = ndQuery.us_phone.ToString();
                user.email = ndQuery.us_email.ToString();
                user.role = ndQuery.us_role.ToString();
                user.gender = ndQuery.us_gender.ToString();
                coffe.SubmitChanges();
            }
            return user;
        }

     /*   public User getInfoUser1(string username)
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
        }*/

        public bool checkLogin(string UserName, string Password)
        {
            TheCoffeDataContext theCoffe = new TheCoffeDataContext();

            var ndQuery = from nd in theCoffe.Users
                          where nd.us_username == UserName
                          && nd.us_password == Password
                          select nd;

            if (ndQuery.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /* public DataSet checkLogin1(string username, string password)
         {
             ///username:USER NAME cần kiểm tra
             ///password: PASSWORD cần kiểm tra
             ///thực hiện: KIỂM TRA tài khoản và mật khẩu có trong database không bằng thủ tục            
             ///trả về: data table
             return db.ExecuteQueryDataSet(
                 "sp_CheckLogin", CommandType.StoredProcedure,
                 new SqlParameter("@username", username),
                 new SqlParameter("@password", password));
         }*/

        public bool changePassword(ref string err, string username, string oldpassword, string newpassword, string confirmpassword)
        {
            ///err:
            ///username: USER NAME cần đổi pass
            ///oldpassword: PASSWORD trước khi đổi
            ///newpassword: PASSWORD muốn đổi
            ///confirmpassword: xác nhận lại newpassword
            ///thực hiện: Thay đổi password bằng thủ tục
            ///trả về: data table
            TheCoffeDataContext coffe = new TheCoffeDataContext();

            var ndQuery = (from nd in coffe.Users
                           where nd.us_username == username
                           select nd).SingleOrDefault();
            if (ndQuery != null)
            {
                ndQuery.us_password = newpassword;
                coffe.SubmitChanges();
            }
            return true;
        }

       /* public DataSet changePassword1(ref string err, string username, string oldpassword, string newpassword, string confirmpassword)
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
        }*/
        public bool Register(ref string err, string username, string password, string confirmpassword)
        {
            ///err:
            ///username: USER NAME đăng ký
            ///password: password đăng ký
            ///confirmpassword: xác nhận lại password
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            User nd = new User();
            nd.us_username = username;
            nd.us_password = password;           
            nd.us_firstname = "";
            nd.us_lastname = "";
            nd.us_address = "";
            nd.us_birthday = DateTime.Now;
            nd.us_phone = "";
            nd.us_email = "";
            nd.us_gender = 'F';
            nd.us_role = "Customer";
            coffe.Users.InsertOnSubmit(nd);
            coffe.Users.Context.SubmitChanges();
            return true;
        }

        /*public bool Register1(ref string err, string username, string password, string confirmpassword)
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
        }       */
    }
}
