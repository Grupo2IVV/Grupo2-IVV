using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerParcialProgra.Data;     // <- ahora sí encuentra AppDbContext
using PrimerParcialProgra.Models;   // <- ahora sí encuentra SupportTicket

namespace PrimerParcialProgra.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupportTicketsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SupportTicketsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportTicket>>> GetTickets()
        {
            return await _context.SupportTickets.ToListAsync();
        }

        // GET: api/SupportTickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportTicket>> GetTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // POST: api/SupportTickets
        [HttpPost]
        public async Task<ActionResult<SupportTicket>> PostTicket(SupportTicket ticket)
        {
            _context.SupportTickets.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTicket), new { id = ticket.Id }, ticket);
        }

        // PUT: api/SupportTickets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, SupportTicket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.SupportTickets.Any(e => e.Id == id))
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

        // DELETE: api/SupportTickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.SupportTickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
