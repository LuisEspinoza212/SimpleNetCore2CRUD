using Microsoft.EntityFrameworkCore;

namespace SimpleNetCoreCRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base (options){}

        public DbSet<Videogame> Videogames { get; set; }
    }
}
