using Microsoft.EntityFrameworkCore;
using Tarea5TicketDetalle.Shared;

namespace Tarea5TicketDetalle.Server.DAL
{
    public class TicketContext : DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }
    }
}
