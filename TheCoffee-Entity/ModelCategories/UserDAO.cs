using Beans;
using DBProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
//using Beans;
using User = DBProvider.User;

namespace Business
{
    public class UserDAO
    {
        private DBTheCoffeeEntities dbContext;

        public object Users { get; set; }

        public UserDAO()
        {
            dbContext = new DBTheCoffeeEntities();
        }

        public List<User> GetAllKhachHang()
        {
            return dbContext.Users.Where(u => u.us_role == "Customer").ToList();
        }

        public List<User> GetAllNhanVien()
        {
            return dbContext.Users.Where(u => u.us_role == "Admin" || u.us_role == "Employee").ToList();
        }

        public bool InsertUser(ref string err, string username, 
            string password, string firstname, string lastname, 
            string address, DateTime birthday, string gender, 
            string phone, string email, string role)
        {
            dbContext = new DBTheCoffeeEntities();

            User user = new User();
            user.us_username = username;
            user.us_password = password;
            user.us_firstname = firstname;
            user.us_lastname = lastname;
            user.us_address = address;
            user.us_birthday = birthday;
            user.us_gender = gender;
            user.us_phone = phone;
            user.us_email = email;
            user.us_role = role;

            dbContext.Users.Add(user);
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //dbContext.SaveChanges();
            return true;
        }



        public bool DeleteUser(ref string err, string username)
        {
            dbContext = new DBTheCoffeeEntities();
            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.us_username == username);
                if (user != null)
                {
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    err = "User not found.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool UpdateUser(ref string err,string username,string password, User user)
        {
            try
            {
                dbContext = new DBTheCoffeeEntities();

                var existingUser = dbContext.Users.FirstOrDefault(u => u.us_username == user.us_username);
                if (existingUser != null)
                {
                    existingUser.us_password = user.us_password;
                    existingUser.us_firstname = user.us_firstname;
                    existingUser.us_lastname = user.us_lastname;
                    existingUser.us_address = user.us_address;
                    existingUser.us_birthday = user.us_birthday;
                    existingUser.us_phone = user.us_phone;
                    existingUser.us_email = user.us_email;
                    existingUser.us_role = user.us_role;
                    existingUser.us_gender = user.us_gender;
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    err = "User not found.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public User GetInfoUser(string username)
        {
            return dbContext.Users.FirstOrDefault(u => u.us_username == username);
        }
        public bool CheckLogin(string username, string password)
        {
            return dbContext.Users.Any(u => u.us_username == username && u.us_password == password);
        }
        

        public bool ChangePassword(ref string err, string username, string oldpassword, string newpassword, string confirmpassword)
        {
            dbContext = new DBTheCoffeeEntities();
            try
            {
                var user = dbContext.Users.FirstOrDefault(u => u.us_username == username && u.us_password == oldpassword);
                if (user != null)
                {
                    user.us_password = newpassword;
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    err = "Invalid username or password.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Register(ref string err, string username,string password)
        {
            try
            {
                dbContext = new DBTheCoffeeEntities();
                User user = new User();
                user.us_username = username;
                user.us_password = password;
                user.us_role = "Customer";
                dbContext.Users.Add(user);
                dbContext.SaveChanges();

                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
