using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos{ get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
