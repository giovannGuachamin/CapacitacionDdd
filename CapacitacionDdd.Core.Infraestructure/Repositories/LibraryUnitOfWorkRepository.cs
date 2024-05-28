using CapacitacionDdd.Core.Application.Contracts.Persistence;
using CapacitacionDdd.Core.Infraestructure.Content;

namespace CapacitacionDdd.Core.Infraestructure.Repositories
{
    public class LibraryUnitOfWorkRepository : ILibraryUnitOfWork
    {
        #region Propiedades

        public readonly LibraryContext _context;

        #endregion

        #region Constructor

        public LibraryUnitOfWorkRepository(LibraryContext context)
        {
            _context = context;
        }

        #endregion

        IAuthorRepository _authorRepository {  get; set; }

        public IAuthorRepository AuthorRepository => _authorRepository ??= new AuthorRepository(_context);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
