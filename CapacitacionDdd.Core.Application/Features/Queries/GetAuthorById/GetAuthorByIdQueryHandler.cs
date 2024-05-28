using CapacitacionDdd.Core.Application.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Queries.GetAuthorById
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, Author>
    {
        #region Propiedades

        readonly ILibraryUnitOfWork _libraryUnitOfWork;

        #endregion

        #region Constructor

        public GetAuthorByIdQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        #endregion

        #region Métodos Públicos

        public async Task<Author> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            return await _libraryUnitOfWork.AuthorRepository.GetAuthorById(request.Id);
        }

        #endregion
    }
}
