using System;
using System.Windows.Forms;

namespace TheCoffee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///
            /// Phân quy?n admin và customer
            ///
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool check = true;
            while (check)
            {
                check = false;
                SignInForm loginForm = new SignInForm();
                Application.Run(loginForm);

                if (loginForm.IsLogin == true && loginForm.User.us_role != "Customer")
                {
                    MainForm mainForm = new MainForm(loginForm.User);
                    Application.Run(mainForm);
                    if (mainForm.IsLogout == true)
                    {
                        check = true;
                    }
                }
                else if (loginForm.IsLogin == true && loginForm.User.us_role == "Customer")
                {
                    MainFormCustomer mainFormCustomer = new MainFormCustomer(loginForm.User);
                    Application.Run(mainFormCustomer);
                    if (mainFormCustomer.IsLogout == true)
                    {
                        check = true;
                    }
                }

                if (loginForm.IsRegister == true)
                {
                    SignUpForm registerForm = new SignUpForm();
                    Application.Run(registerForm);
                    if (registerForm.IsLogin == true)
                    {
                        check = true;
                    }
                }
            }
        }
    }
}
