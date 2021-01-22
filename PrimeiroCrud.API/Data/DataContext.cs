using Microsoft.EntityFrameworkCore;
using PrimeiroCrud.API.Model;

namespace PrimeiroCrud.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
            public DbSet<Banda> Bandas { get; set; }
        
    }
}