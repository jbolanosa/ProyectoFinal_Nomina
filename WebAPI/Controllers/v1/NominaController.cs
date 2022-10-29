using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Context;
using WebAPI.Models;

namespace WebAPI.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class NominaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NominaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Nomina
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNomina()
        {
            return await _context.Nomina.ToListAsync();
        }

        // GET: api/Nomina/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nomina>> GetNomina(int id)
        {
            var nomina = await _context.Nomina.FindAsync(id);

            if (nomina == null)
            {
                return NotFound();
            }

            return nomina;
        }

        [HttpGet("Periodo")]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNominaFiltrado([FromQuery]MesAnio mesAnio)
        {
            return await _context.Nomina.Where(x => x.Mes == mesAnio.Mes).Where(x => x.Anio == mesAnio.Anio).ToListAsync();

        }


        // PUT: api/Nomina/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNomina(int id, Nomina nomina)
        {
            if (id != nomina.NominaId)
            {
                return BadRequest();
            }

            _context.Entry(nomina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NominaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Nomina
        [HttpPost]
        public async Task<ActionResult<Nomina>> PostNomina(Nomina nomina)
        {
            _context.Nomina.Add(nomina);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNomina", new { id = nomina.NominaId }, nomina);
        }

        // DELETE: api/Nomina/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomina(int id)
        {
            var nomina = await _context.Nomina.FindAsync(id);
            if (nomina == null)
            {
                return NotFound();
            }

            _context.Nomina.Remove(nomina);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NominaExists(int id)
        {
            return _context.Nomina.Any(e => e.NominaId == id);
        }
    }
}
