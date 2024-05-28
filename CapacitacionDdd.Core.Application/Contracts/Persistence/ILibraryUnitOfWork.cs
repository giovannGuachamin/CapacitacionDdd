namespace CapacitacionDdd.Core.Application.Contracts.Persistence
{
    public interface ILibraryUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
    }
}
