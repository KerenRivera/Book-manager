using Book_manager.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Book_manager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
            
        }
        public DbSet <Book> Books { get; set; }
    }
}
