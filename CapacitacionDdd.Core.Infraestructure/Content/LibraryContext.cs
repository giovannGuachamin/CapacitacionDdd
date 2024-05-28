using CapacitacionDdd.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CapacitacionDdd.Core.Infraestructure.Content
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> Authors { get; set;}

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    }
}
