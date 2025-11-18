using Microsoft.EntityFrameworkCore;
using DemoMVC167.Models;

namespace DemoMVC167.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}