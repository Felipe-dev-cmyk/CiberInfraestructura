using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Data;

namespace WebService.Controllers
{
    [Route("api/catAlumno")]
    [ApiController]
    public class catAlumnoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public catAlumnoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<catAlumno>>> GetcatAlumnos()
        {
            return await _context.Alumnos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<catAlumno>> GetcatAlumno(int id)
        {
            var catAlumno = await _context.Alumnos.FindAsync(id);

            if (catAlumno == null)
            {
                return NotFound();
            }

            return catAlumno;
        }

        [HttpPost]
        public async Task<ActionResult<catAlumno>> PostcatAlumno(catAlumno catAlumno)
        {
            _context.Alumnos.Add(catAlumno);

            // Agrega registros de diagnóstico
            Console.WriteLine($"Estado del objeto catAlumno: {catAlumno}");

            try
            {
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetcatAlumno", new { id = catAlumno.id }, catAlumno);
            }
            catch (Exception ex)
            {
                // Registra cualquier excepción
                Console.WriteLine($"Excepción al guardar en la base de datos: {ex}");
                throw;
            }
        }

        // Otros métodos de CRUD...
    }
}