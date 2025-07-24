using GameOfThrones.Domain;
using Microsoft.EntityFrameworkCore;

namespace GameOfThrones.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        DbSet<House> Houses { get; set; }
        DbSet<Lord> Lords { get; set; }
    }
}
