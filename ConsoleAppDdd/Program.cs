// See https://aka.ms/new-console-template for more information
using CapacitacionDdd.Core.Application.Features.Command.AddAuthor;
using CapacitacionDdd.Core.Application.Features.Command.UpdateAuthor;
using CapacitacionDdd.Core.Application.Features.Queries.GetAuthorByCode;
using CapacitacionDdd.Core.Application.Features.Queries.GetAuthorById;
using CapacitacionDdd.Core.Infraestructure;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();
var configuration = new ConfigurationBuilder().Build();
InfraestructureServiceContainer.ConfigureServices(services, configuration);
services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
var serviceProvider = services.BuildServiceProvider();
var mediator = serviceProvider.GetRequiredService<IMediator>();

#region Obtener Autor por Id

GetAuthorByIdQuery getAuthorByIdQuery = new(1);
var result = await mediator.Send(getAuthorByIdQuery);
Console.WriteLine("El Autor encontrado por Id es: " + result.Name);

#endregion

#region Crear Autor

AddAuthorCommand addAuthorCommand = new()
{
    Id = 3,
    Code = "A3",
    Name = "Juan Leon Mera",    
    Country = "Ecuador"
};

int resultId = await mediator.Send(addAuthorCommand);
Console.WriteLine("El Id del Autor creado es: " + resultId);

#endregion

#region Actualizar Autor

UpdateAuthorCommand updateAuthorCommand = new()
{
    Id = 2,
    Code = "A2",
    Name = "Eugenio Espejo",    
    Country = "Ecuador"
};

await mediator.Send(updateAuthorCommand);
GetAuthorByIdQuery getAuthorByIdQueryUpdate = new(2);
var resultAuthorUpdateQuery = await mediator.Send(getAuthorByIdQueryUpdate); 
Console.WriteLine("El Autor actualizado es: " + resultAuthorUpdateQuery.Name);

#endregion

#region Obtener Autor por Codigo

GetAuthorByCodeQuery getAuthorByCodeQuery = new("A2");
var resultAuthorByCodeQuery = await mediator.Send(getAuthorByCodeQuery);
Console.WriteLine("El Autor encontrado por código es: " + resultAuthorByCodeQuery.Name);

#endregion
