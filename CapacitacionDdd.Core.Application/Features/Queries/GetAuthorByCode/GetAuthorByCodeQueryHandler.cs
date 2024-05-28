using CapacitacionDdd.Core.Application.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Queries.GetAuthorByCode
{
    public class GetAuthorByCodeQueryHandler : IRequestHandler<GetAuthorByCodeQuery, Author>
    {
        #region Propiedades

        readonly ILibraryUnitOfWork _libraryUnitOfWork;

        #endregion

        #region Constructor

        public GetAuthorByCodeQueryHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        #endregion

        #region Métodos Públicos

        public async Task<Author> Handle(GetAuthorByCodeQuery request, CancellationToken cancellationToken)
        {
            return await _libraryUnitOfWork.AuthorRepository.GetAuthorByCode(request.Code);
        }

        #endregion
    }
}
