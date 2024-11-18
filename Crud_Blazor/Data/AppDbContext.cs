using Crud_Blazor.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Blazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Category> Categories { get; set; } = null;
        public DbSet<Book> Books { get; set; } = null;
    }
}
