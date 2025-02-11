using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DBProvider;

namespace modelUser
{
    public class UserDAO
    {
        DBLayer db;
        public UserDAO()
        {
            db = new DBLayer();
        }
        public DataSet getAllKhachHang()
        {
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email from [dbo].[User] where us_role = 'Customer' ", CommandType.Text, null);
        }

        public DataSet getAllNhanVien()
        {
            return db.ExecuteQueryDataSet(
                "select us_username, us_firstname, us_lastname, us_address, us_birthday, us_gender, us_phone, us_email from [dbo].[User] where us_role = 'Admin' or us_role ='Employee'", CommandType.Text, null);
        }
        public bool insertUser(ref string err,
            string username, string password, string firstname, string lastname,
            string address, DateTime birthday, string gender, string phone,
            string email, string role)
        {
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
            return db.MyExecuteNonQuery(
                "sp_DeleteUser",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username));
        }

        public bool updateUser(ref string err,
           string username, string firstname, string lastname,
           string address, DateTime birthday, string gender, string phone,
           string email, string role)
        {
            return db.MyExecuteNonQuery(
                "sp_UpdateUser", CommandType.StoredProcedure, ref err,
                new SqlParameter("@username", username),
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
            User user = new User();
           DataSet result =  db.ExecuteQueryDataSet("sp_InfoUser", CommandType.StoredProcedure,
                new SqlParameter("@username", username));

            foreach(DataRow row in result.Tables[0].Rows)
            {
                user.username = username;
                user.password = row["us_password"].ToString();
                user.firstName = row["us_firstname"].ToString();
                user.lastName = row["us_lastname"].ToString();
                user.address = row["us_address"].ToString();
                user.birthday = (DateTime) row["us_birthday"];
                user.phone = row["us_phone"].ToString();
                user.email= row["us_email"].ToString();
                user.role = row["us_role"].ToString();
            }
            return user;
        }


        public DataSet checkLogin(string username, string password)
        {
            return db.ExecuteQueryDataSet(
                "sp_CheckLogin", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
                );
        }

        public DataSet changePassword(ref string err, string username, string oldpassword, string newpassword, string confirmpassword)
        {
            return db.ExecuteQueryDataSet(
                "sp_ChangePassword", CommandType.StoredProcedure,
                new SqlParameter("@username", username),
                new SqlParameter("@password_old", oldpassword),
                new SqlParameter("@password_new", newpassword),
                new SqlParameter("@confirmPass", confirmpassword)
                );
        }
    }
}
