using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portal_Web.Models;

namespace Portal_Web.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

       public ActionResult index()
       {
            return View();
       }
        //Vista para el perfil
       public ActionResult perfil()
       {
            // Obtener el ID del usuario desde la sesión
            int? userId = Session["UserId"] as int?;
            if (userId == null)
            {
                return RedirectToAction("login", "Auth");
            }

            // Buscar el usuario en la base de datos
            var usuario = db.Usuarios
            .Where(u => u.Pk_id_usuario == userId)
            .Select(u => new Perfil
            {
                Pk_id_usuario = u.Pk_id_usuario,
                nombre_usuario = u.nombre_usuario,
                apellido_usuario = u.apellido_usuario,
                username_usuario = u.username_usuario,
                email_usuario = u.email_usuario,
                ultima_conexion_usuario = u.ultima_conexion_usuario,
                estado_usuario = u.estado_usuario // bool
            })
            .FirstOrDefault();
            if (usuario == null)
            {
                return RedirectToAction("login", "Auth");
            }

            return View(usuario);
       }

        //Vista y logica para la asistencia
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult asistencia(Asistencia asistencia)
        {
            if(ModelState.IsValid)
            {
                db.tbl_asistencias.Add(asistencia);
                db.SaveChanges();
                return RedirectToAction("asistencia");
            }
            //Si existe un error entonces hacer esto
            ViewBag.Empleados = new SelectList(
            db.tbl_empleados.Where(e => e.estado).ToList(),
            "pk_clave",
            "empleados_nombre"
            );
            return View(asistencia);

        }
        [HttpGet]
        public ActionResult asistencia()
        {
            ViewBag.Empleados = new SelectList(
            db.tbl_empleados.Where(e => e.estado).ToList(),
            "pk_clave",
            "empleados_nombre"
        );
            return View();
        }
        //Asignacion de vacaciones
        [HttpGet]
        public ActionResult vacaciones()
        {
            ViewBag.Empleados = new SelectList(db.tbl_empleados.Where(e => e.estado), "pk_clave", "empleados_nombre");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Vacaciones(Asignacion_Vacaciones vacacion)
        {
            if (ModelState.IsValid)
            {
                db.tbl_asignacion_vacaciones.Add(vacacion);
                db.SaveChanges();
                return RedirectToAction("Vacaciones");
            }

            ViewBag.Empleados = new SelectList(db.tbl_empleados.Where(e => e.estado), "pk_clave", "empleados_nombre", vacacion.fk_clave_empleado);
            return View(vacacion);
        }
        //documentos
        public ActionResult documentos()
        {
            return View();
        }
        //Nominas
        public ActionResult nominas()
        {
            int? userId = Session["UserId"] as int?;

            if (userId == null)
            {
                return RedirectToAction("Login"); // O la vista que uses para login
            }

            using (var db = new ApplicationDbContext())
            {
                // Buscar el empleado vinculado al usuario actual
                var usuario = db.Usuarios
                                .Where(u => u.Pk_id_usuario == userId)
                                .FirstOrDefault();

                if (usuario == null || usuario.fk_empleado == null)
                {
                    return View(new Nominas()); // Usuario no tiene empleado vinculado
                }

                int empleadoId = usuario.fk_empleado;

                // Buscar contrato activo del empleado
                var contrato = db.tbl_contratos
                                 .Where(c => c.fk_clave_empleado == empleadoId && c.estado == 1)
                                 .OrderByDescending(c => c.pk_id_contrato)
                                 .FirstOrDefault();

                if (contrato == null)
                {
                    return View(new Nominas()); // No hay contrato
                }

                decimal salarioBase = contrato.contratos_salario;
                decimal bonificacionIncentivo = 250.00m;
                decimal igss = salarioBase * 0.0483m;
                decimal aguinaldoMensual = salarioBase / 12;
                decimal vacacionesMensuales = (salarioBase / 30) * 1.25m;

                decimal deducciones = igss;

                var viewModel = new Nominas
                {
                    SalarioBase = salarioBase,
                    Bonos = bonificacionIncentivo + aguinaldoMensual + vacacionesMensuales,
                    Deducciones = deducciones
                };

                return View(viewModel);
            }
        }


        //Quejas o Reclamos
        public ActionResult quejas_reclamos()
        {
            return View();
        }
    }
}