using CapacitacionDdd.Core.Application.Contracts.Persistence;
using CapacitacionDdd.Core.Infraestructure.Content;
using CapacitacionDdd.Core.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CapacitacionDdd.Core.Infraestructure
{
    public class InfraestructureServiceContainer
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryContext>(options=> options.UseInMemoryDatabase("Library"));
            using(var context = services.BuildServiceProvider().GetService<LibraryContext>())
            {
                context!.Authors.Add(new Domain.Entities.Author { Id = 1, Code = "A1", Name = "Jorde Icaza", Country = "Ecuador" });
                context!.Authors.Add(new Domain.Entities.Author { Id = 2, Code = "A2", Name = "Juan Montalvo", Country = "Ecuador" });
                context.SaveChanges();
            }
            services.AddScoped<ILibraryUnitOfWork, LibraryUnitOfWorkRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }
    }
}
