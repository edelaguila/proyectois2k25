using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NominaAPI.Data;
using NominaAPI.Models;

namespace NominaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanillaController : ControllerBase
    {
        private readonly NominaContext _context;

        public PlanillaController(NominaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanillaDetalle>>> GetPlanillas()
        {
            return await _context.PlanillaDetalles.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlanillaDetalle>> GetPlanilla(int id)
        {
            var planilla = await _context.PlanillaDetalles.FindAsync(id);

            if (planilla == null)
            {
                return NotFound();
            }

            return planilla;
        }

        [HttpGet("empleado/{empleadoId}")]
        public async Task<ActionResult<IEnumerable<PlanillaDetalle>>> GetPlanillaByEmpleado(int empleadoId)
        {
            return await _context.PlanillaDetalles
                .Where(p => p.EmpleadoId == empleadoId)
                .ToListAsync();
        }
    }
} 