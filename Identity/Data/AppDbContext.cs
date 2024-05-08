using Identity.Models;
using Microsoft.EntityFrameworkCore;
namespace Identity.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<product> products { get; set; }
    }

}

