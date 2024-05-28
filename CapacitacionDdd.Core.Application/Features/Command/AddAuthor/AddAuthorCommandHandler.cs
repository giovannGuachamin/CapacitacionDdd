using CapacitacionDdd.Core.Application.Contracts.Persistence;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Command.AddAuthor
{
    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
    {
        #region Propiedades

        readonly ILibraryUnitOfWork _libraryUnitOfWork;

        #endregion

        #region Constructor

        public AddAuthorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;    
        }

        #endregion

        #region Métodos Públicos

        public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            return await _libraryUnitOfWork.AuthorRepository.AddAuthor(request);
        }

        #endregion
    }
}
