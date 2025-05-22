using System;
using System.IO;
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
            // LUEGO: fuera del LINQ, usa File.Exists para calcular la ruta de la imagen
            string rutaFotoRelativa = $"~/Uploads/Fotos/usuario_{usuario.Pk_id_usuario}.jpg";
            string rutaFotoFisica = Server.MapPath(rutaFotoRelativa);
            if (System.IO.File.Exists(rutaFotoFisica))
            {
                // Añade cache-busting para evitar problemas de caché
                usuario.ruta_foto = Url.Content(rutaFotoRelativa + "?" + Guid.NewGuid());
            }
            return View(usuario);
        }
        //Vista y logica para la asistencia
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult asistencia(Asistencia asistencia)
        {
            if (ModelState.IsValid)
            {
                db.tbl_asistencias.Add(asistencia);
                db.SaveChanges();
                return RedirectToAction("Gracias");
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
                return RedirectToAction("Gracias");
            }

            ViewBag.Empleados = new SelectList(db.tbl_empleados.Where(e => e.estado), "pk_clave", "empleados_nombre", vacacion.fk_clave_empleado);
            return View(vacacion);
        }
        [HttpGet]
        public ActionResult documentos()
        {
            ViewBag.Fk_id_postulante = new SelectList(db.Tbl_postulante.ToList(), "Pk_id_postulante", "nombre_postulante");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult documentos(ExpedienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.Curriculum != null && model.Curriculum.ContentLength > 0)
                {
                    var ext = Path.GetExtension(model.Curriculum.FileName).ToLower();
                    if(ext != ".pdf")
                    {
                        ModelState.AddModelError("Curriculum", "Solo se permiten archivos PDF.");
                    }
                    else
                    {
                        byte[] fileData;
                        var rutaFisica = @"C:\Users\oscar\OneDrive\Escritorio\Ing. De Software\proyectois2k25\Archivos de Reclutamiento";
                        var nombreArchivo = Path.GetFileName(model.Curriculum.FileName);

                        if (!Directory.Exists(rutaFisica))
                        {
                            Directory.CreateDirectory(rutaFisica);
                        }
                        var rutaCompleta = Path.Combine(rutaFisica, nombreArchivo);
                        model.Curriculum.SaveAs(rutaCompleta);
                        
                        using (var binaryReader = new BinaryReader(model.Curriculum.InputStream))
                        {
                            fileData = binaryReader.ReadBytes(model.Curriculum.ContentLength);
                        }
                        var expediente = new Expediente
                        {
                            Fk_id_postulante = model.Fk_id_postulante,
                            curriculum = fileData,
                            estado = true
                        };
                        db.Tbl_expedientes.Add(expediente);
                        db.SaveChanges();
                        TempData["Mensaje"] = $"Expediente guardado con ID #{expediente.Pk_id_expediente}";
                        return RedirectToAction("Gracias");
                    }
                }
                else
                {
                    ModelState.AddModelError("Curriculum", "Debe seleccionar un archivo PDF.");
                }
            }
            ViewBag.Fk_id_postulante = new SelectList(db.Tbl_postulante.ToList(), "Pk_id_postulante", "nombre_postulante", model.Fk_id_postulante);
            return View(model);
        }
        //Convertir Bytes
        private byte[] ConvertToBytes(HttpPostedFileBase file)
        {
            using (var binaryReader = new BinaryReader(file.InputStream))
            {
                return binaryReader.ReadBytes(file.ContentLength);
            }
        }
        //Nominas
        public ActionResult nominas()
        {
            {
                int? userId = Session["UserId"] as int?;

                if (userId == null)
                {
                    return RedirectToAction("Login");
                }

                using (var db = new ApplicationDbContext())
                {
                    // Buscar el empleado vinculado al usuario actual
                    var usuario = db.Usuarios
                                    .FirstOrDefault(u => u.Pk_id_usuario == userId);

                    if (usuario == null || usuario.fk_empleado == null)
                    {
                        return View(new Nominas()); // Usuario sin vínculo
                    }

                    int empleadoId = usuario.fk_empleado;

                    // Buscar contrato activo del empleado
                    var contrato = db.tbl_contratos
                                     .Where(c => c.fk_clave_empleado == empleadoId && c.estado == 1)
                                     .OrderByDescending(c => c.pk_id_contrato)
                                     .FirstOrDefault();

                    if (contrato == null)
                    {
                        return View(new Nominas()); // Sin contrato activo
                    }

                    // Obtener el salario base desde el contrato
                    decimal salarioBase = contrato.contratos_salario;

                    // Buscar el último registro de planilla para este empleado y contrato
                    var planillaDetalle = db.tbl_planilla_Detalle
                                            .Where(p => p.fk_clave_empleado == empleadoId
                                                     && p.fk_id_contrato == contrato.pk_id_contrato
                                                     && p.estado == 1)
                                            .OrderByDescending(p => p.pk_registro_planilla_Detalle)
                                            .FirstOrDefault();

                    // Si no hay planilla aún, se devuelven 0s
                    decimal percepciones = 0;
                    decimal deducciones = 0;

                    if (planillaDetalle != null)
                    {
                        percepciones = planillaDetalle.detalle_total_Percepciones;
                        deducciones = planillaDetalle.detalle_total_Deducciones;
                    }

                    var viewModel = new Nominas
                    {
                        SalarioBase = salarioBase,
                        Percepciones = percepciones,
                        Deducciones = deducciones
                    };

                    return View(viewModel);
                }
            }
        }
        //Generar recibo de nominas
       
        //Quejas o Reclamos
        public ActionResult quejas_reclamos()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult quejas_reclamos(QuejasReclamos model)
        {
            if (ModelState.IsValid)
            {
                db.tbl_quejas_reclamos.Add(model);
                db.SaveChanges();
                return RedirectToAction("Gracias");
            }

            return View(model);
        }

        public ActionResult Gracias()
        {
            return View();
        }
        public ActionResult CurriculumVitae()
        {
            ViewBag.Puestos = new SelectList(db.tbl_puestos_trabajo, "Pk_id_puestos", "puestos_nombre_puesto");
            ViewBag.Nivel_Educativo = new SelectList(db.Tbl_nivel_educativo, "Pk_id_nivel", "nivel");
            ViewBag.Disponibilidad = new SelectList(db.Tbl_disponibilidad, "Pk_id_disponibilidad", "disponibilidad");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CurriculumVitae(Postulante postulante)
        {
            if (ModelState.IsValid)
            {
                postulante.fecha_postulacion = DateTime.Now;
                postulante.estado = true;

                db.Tbl_postulante.Add(postulante);
                db.SaveChanges();
                return RedirectToAction("Gracias");
            }

            // Si hay error, volver a llenar ViewBags
            ViewBag.Puestos = new SelectList(db.tbl_puestos_trabajo, "Pk_id_puestos", "puestos_nombre_puesto");
            ViewBag.Nivel_Educativo = new SelectList(db.Tbl_nivel_educativo, "Pk_id_nivel", "nivel");
            ViewBag.Disponibilidad = new SelectList(db.Tbl_disponibilidad, "Pk_id_disponibilidad", "disponibilidad");

            return View(postulante);
        }
        [HttpPost]
        public ActionResult SubirFoto(HttpPostedFileBase foto)
        {
            int userId = (int)Session["UserId"];
            if (foto != null && foto.ContentLength > 0)
            {
                var extension = Path.GetExtension(foto.FileName);
                var fileName = $"usuario_{userId}{extension}";
                var folderPath = Server.MapPath("~/Uploads/Fotos/");
                var filePath = Path.Combine(folderPath, fileName);

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                foto.SaveAs(filePath);
                Session["FotoPerfil"] = fileName;
            }

            return RedirectToAction("Perfil"); // Esta acción también debe estar en HomeController
        }

    }
}