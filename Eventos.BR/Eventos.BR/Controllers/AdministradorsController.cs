using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eventos.BR.Data;
using Eventos.BR.Models;

namespace Eventos.BR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorsController : ControllerBase
    {
        private readonly appContext _context;

        public AdministradorsController(appContext context)
        {
            _context = context;
        }

        // GET: api/Administradors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrador>>> GetAdmistradores()
        {
            return await _context.Admistradores.ToListAsync();
        }

        // GET: api/Administradors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrador>> GetAdministrador(int id)
        {
            var administrador = await _context.Admistradores.FindAsync(id);

            if (administrador == null)
            {
                return NotFound();
            }

            return administrador;
        }

        // PUT: api/Administradors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdministrador(int id, Administrador administrador)
        {
            if (id != administrador.Id)
            {
                return BadRequest();
            }

            _context.Entry(administrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdministradorExists(id))
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

        // POST: api/Administradors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Administrador>> PostAdministrador(Administrador administrador)
        {
            _context.Admistradores.Add(administrador);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetAdministrador), new { id = administrador.Id }, administrador);
        }

        // DELETE: api/Administradors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Administrador>> DeleteAdministrador(int id)
        {
            var administrador = await _context.Admistradores.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }

            _context.Admistradores.Remove(administrador);
            await _context.SaveChangesAsync();

            return administrador;
        }

        private bool AdministradorExists(int id)
        {
            return _context.Admistradores.Any(e => e.Id == id);
        }
    }
}
