using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portal_Web.Models;
using MySql.Data.MySqlClient;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;

namespace Portal_Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult TestConexion()
        {
            string connectionString = "Server=localhost;Database=portalEmpleados;Uid=root;Pwd=12345;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    return Content("Conexión exitosa a MySQL");
                }
            }
            catch (Exception ex)
            {
                return Content("Error: " + ex.Message);
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Attendance()
        {
            return View();
        }
        public ActionResult Vacations()
        {
            return View();
        }
        public ActionResult Documents()
        {
            return View();
        }
        public ActionResult Payroll()
        {
            return View();
        }
        public ActionResult Overtime()
        {
            return View();
        }
        public ActionResult Complaints()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public JsonResult GetCurrentUser()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT u.UserId, u.UserName, u.Email, u.RoleId, r.RoleName
                        FROM Users u
                        JOIN Roles r ON u.RoleId = r.RoleId
                        WHERE u.UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", User.Identity.Name);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new
                                {
                                    userId = reader.GetInt32(0),
                                    userName = reader.GetString(1),
                                    email = reader.GetString(2),
                                    roleId = reader.GetInt32(3),
                                    roleName = reader.GetString(4),
                                    department = "Desarrollo", // Estos campos deberían venir de la base de datos
                                    position = "Desarrollador",
                                    joinDate = DateTime.Now.ToString("dd 'de' MMMM, yyyy")
                                };

                                return Json(user, JsonRequestBehavior.AllowGet);
                            }
                        }
                    }
                }
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                // Log del error
                System.Diagnostics.Debug.WriteLine($"Error en GetCurrentUser: {ex.Message}");
                return Json(new { error = "Error al obtener la información del usuario" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Auth");
        }

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