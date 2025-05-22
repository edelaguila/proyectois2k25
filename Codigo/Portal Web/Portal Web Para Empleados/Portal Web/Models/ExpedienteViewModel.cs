using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Portal_Web.Models
{
    public class ExpedienteViewModel
    {
        [Required]
        public int Fk_id_postulante { get; set; }

        [Required(ErrorMessage = "Debe adjuntar el archivo PDF del currículum.")]
        public HttpPostedFileBase Curriculum { get; set; }
    }
}