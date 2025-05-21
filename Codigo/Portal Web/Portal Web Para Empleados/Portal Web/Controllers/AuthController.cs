using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Portal_Web.Models;
using System.Security.Cryptography;
using System.Text;


namespace Portal_Web.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult login()
        {
            return View();
        }
        public ActionResult registro()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarUsuario(Usuarios user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Verificar si el usuario ya existe
                    if (db.Usuarios.Any(u => u.email_usuario == user.email_usuario || u.username_usuario == user.username_usuario))
                    {
                        ModelState.AddModelError("", "El correo o nombre de usuario ya está registrado.");
                        return View(user);
                    }

                    // Hashear la contraseña
                    user.password_usuario = HashPassword(user.password_usuario);
                    user.estado_usuario = true; // Usuario activo por defecto
                    user.ultima_conexion_usuario = null; // Primera vez que se registra

                    db.Usuarios.Add(user);
                    db.SaveChanges();
                    TempData["Exito"] = "Registro realizado con exito";
                    return RedirectToAction("login");
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = "Ocurrio un error al realizar el registro del usuario: " + e.Message;
            }
            return View(user);
        }
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(string username_usuario, string password_usuario)
        {
            var user = db.Usuarios.SingleOrDefault(u => u.username_usuario == username_usuario);
            if (ModelState.IsValid)
            {
                string passwordHash = HashPassword(password_usuario);
                var usuario = db.Usuarios.FirstOrDefault(u =>
                    u.username_usuario == username_usuario &&
                    u.password_usuario == passwordHash &&
                    u.estado_usuario == true);
                if (usuario != null)
                {
                    // Autenticación exitosa
                    Session["UserId"] = usuario.Pk_id_usuario;
                    Session["Username"] = usuario.nombre_usuario;
                    usuario.ultima_conexion_usuario = DateTime.Now;
                    db.SaveChanges();
                    return RedirectToAction("index", "Home");
                }

                // Si no se encontró un usuario válido
                ViewBag.Error = "Usuario o contraseña incorrectos, o usuario inactivo.";
            }
            return View();
        }
        public ActionResult Logout() {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("login", "Auth");
        }//Cerramos sesión
    }
}