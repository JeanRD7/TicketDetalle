using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketDetalle.Server.DAL;

[Route("api/[controller]")]
[ApiController]
public class TicketDetalleController : ControllerBase
{
    private readonly Context _context;

    public TicketDetalleController(Context context)
    {
        _context = context;
    }

    // GET: api/TicketDetalles
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TicketDetalles>>> GetPrioridades()
    {
        if (_context.TicketDetalles == null)
        {
            return NotFound();
        }
        return await _context.TicketDetalles.ToListAsync();
    }

    // GET: api/TicketDetalles/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TicketDetalles>> GetTicketDetalles(int id)
    {
        if (_context.TicketDetalles == null)
        {
            return NotFound();
        }
        var ticketDetalles = await _context.TicketDetalles.FindAsync(id);

        if (ticketDetalles == null)
        {
            return NotFound();
        }

        return ticketDetalles;
    }

    // POST: api/TicketDetalles
    [HttpPost]
    public async Task<ActionResult<TicketDetalles>> PostPrioridades(TicketDetalles ticketDetalles)
    {
        if (!TicketDetallesExists(ticketDetalles.TicketDetalleId))
            _context.TicketDetalles.Add(ticketDetalles);
        else
            _context.TicketDetalles.Update(ticketDetalles);

        await _context.SaveChangesAsync();
        return Ok(ticketDetalles);
    }

    // DELETE: api/TicketDetalles/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTicketDetalles(int id)
    {
        if (_context.TicketDetalles == null)
        {
            return NotFound();
        }
        var ticketDetalles = await _context.TicketDetalles.FindAsync(id);
        if (ticketDetalles == null)
        {
            return NotFound();
        }

        _context.TicketDetalles.Remove(ticketDetalles);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TicketDetallesExists(int id)
    {
        return (_context.TicketDetalles?.Any(e => e.TicketDetalleId == id)).GetValueOrDefault();
    }
}
