using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Portal_Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if (ValidateUser(username, password))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToLocal(returnUrl);
            }

            ModelState.AddModelError("", "Usuario o contraseña incorrectos.");
            return View();
        }

        [HttpGet]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login");
        }

        private bool ValidateUser(string username, string password)
        {
            string connectionString = "Server=localhost;Database=portalEmpleados;Uid=root;Pwd=12345;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE UserName = @Username AND PasswordHash = @PasswordHash";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", password); // En producción, usar hash

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en ValidateUser: {ex.Message}");
                return false;
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
} 