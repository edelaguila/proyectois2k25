using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NominaAPI.Data;
using NominaAPI.Models;

namespace NominaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominasController : ControllerBase
    {
        private readonly NominaContext _context;

        public NominasController(NominaContext context)
        {
            _context = context;
        }

        // GET: api/Nominas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNominas()
        {
            return await _context.Nominas.ToListAsync();
        }

        // GET: api/Nominas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nomina>> GetNomina(int id)
        {
            var nomina = await _context.Nominas.FindAsync(id);

            if (nomina == null)
            {
                return NotFound();
            }

            return nomina;
        }

        // GET: api/Nominas/empleado/{empleadoId}
        [HttpGet("empleado/{empleadoId}")]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNominasByEmpleado(string empleadoId)
        {
            return await _context.Nominas
                .Where(n => n.EmpleadoId == empleadoId)
                .ToListAsync();
        }

        // GET: api/Nominas/departamento/{departamento}
        [HttpGet("departamento/{departamento}")]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNominasByDepartamento(string departamento)
        {
            return await _context.Nominas
                .Where(n => n.Departamento == departamento)
                .ToListAsync();
        }
    }
} 