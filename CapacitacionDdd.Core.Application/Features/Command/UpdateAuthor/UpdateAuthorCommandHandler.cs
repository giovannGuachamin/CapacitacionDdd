using CapacitacionDdd.Core.Application.Contracts.Persistence;
using MediatR;

namespace CapacitacionDdd.Core.Application.Features.Command.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, int>
    {
        #region Propiedades

        readonly ILibraryUnitOfWork _libraryUnitOfWork;

        #endregion

        #region Constructor

        public UpdateAuthorCommandHandler(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        #endregion

        #region Métodos Públicos

        public async Task<int> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            return await _libraryUnitOfWork.AuthorRepository.UpdateAuthor(request);
        }

        #endregion
    }
}
