using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Portal_Web.Models;
using System.Security.Cryptography;
using System.Text;

namespace Portal_Web.Controllers
{
    public class AuthController : Controller
    {
        private MyDbContext db = new MyDbContext();
        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Roles = db.Roles.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users model)
        {
            if (ModelState.IsValid)
            {
                // Verificar si el usuario ya existe
                if (db.Usuarios.Any(u => u.Email == model.Email))
                {
                    ModelState.AddModelError("", "El correo ya está registrado.");
                    ViewBag.Roles = db.Roles.ToList();
                    return View(model);
                }

                // Hashear la contraseña
                model.PasswordHash = HashPassword(model.PasswordHash);
                db.Usuarios.Add(model);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            ViewBag.Roles = db.Roles.ToList();
            return View(model);
        }

        // 🔹 MÉTODO PARA LOGIN
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var hashedPassword = HashPassword(password);
            var user = db.Usuarios.FirstOrDefault(u => u.Email == email && u.PasswordHash == hashedPassword);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["UserId"] = user.UserId;
                Session["UserName"] = user.UserName;
                Session["Role"] = user.Rol.RoleName;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }
        public ActionResult Recover_Password()
        {
            return View();
        }


        // 🔹 MÉTODO PARA CERRAR SESIÓN
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }

        // 🔹 MÉTODO PARA HASH DE CONTRASEÑA
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}