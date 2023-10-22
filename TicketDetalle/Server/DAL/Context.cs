using Microsoft.EntityFrameworkCore;

namespace TicketDetalle.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Opcions) : base(Opcions) { }
        public DbSet<TicketDetalles> TicketDetalles { get; set; }
    }
}
