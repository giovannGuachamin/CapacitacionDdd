using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Command.AddAuthor
{
    public class AddAuthorCommand : Author, IRequest<int>
    {
    }
}
