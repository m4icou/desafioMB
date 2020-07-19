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
    public class IngressoesController : ControllerBase
    {
        private readonly appContext _context;

        public IngressoesController(appContext context)
        {
            _context = context;
        }

        // GET: api/Ingressoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingresso>>> GetIngresso()
        {
            return await _context.Ingresso.ToListAsync();
        }

        // GET: api/Ingressoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingresso>> GetIngresso(int id)
        {
            var ingresso = await _context.Ingresso.FindAsync(id);

            if (ingresso == null)
            {
                return NotFound();
            }

            return ingresso;
        }

        // PUT: api/Ingressoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngresso(int id, Ingresso ingresso)
        {
            if (id != ingresso.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingresso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngressoExists(id))
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

        // POST: api/Ingressoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ingresso>> PostIngresso(Ingresso ingresso)
        {
            _context.Ingresso.Add(ingresso);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetIngresso), new { id = ingresso.Id }, ingresso);
        }

        // DELETE: api/Ingressoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ingresso>> DeleteIngresso(int id)
        {
            var ingresso = await _context.Ingresso.FindAsync(id);
            if (ingresso == null)
            {
                return NotFound();
            }

            _context.Ingresso.Remove(ingresso);
            await _context.SaveChangesAsync();

            return ingresso;
        }

        private bool IngressoExists(int id)
        {
            return _context.Ingresso.Any(e => e.Id == id);
        }
    }
}
