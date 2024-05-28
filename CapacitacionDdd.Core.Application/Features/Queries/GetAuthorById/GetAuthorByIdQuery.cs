using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Queries.GetAuthorById
{
    public class GetAuthorByIdQuery : IRequest<Author>
    {
        #region Propiedades

        public int Id { get; set; }

        #endregion

        #region Constructor

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }

        #endregion
    }
}
