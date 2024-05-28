using CapacitacionDdd.Core.Application.Contracts.Persistence;
using CapacitacionDdd.Core.Domain.Entities;
using CapacitacionDdd.Core.Infraestructure.Content;
using Microsoft.EntityFrameworkCore;

namespace CapacitacionDdd.Core.Infraestructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        #region Propiedades

        public readonly LibraryContext _context;

        #endregion

        #region Constructor

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        #endregion

        #region Métodos Get

        public async Task<Author> GetAuthorById(int id)
        {
            return await _context.Authors.FindAsync(id);
        }

        public async Task<Author> GetAuthorByCode(string code)
        {
            return await _context.Authors.Where(au => au.Code.Equals(code, StringComparison.CurrentCulture)).FirstAsync();
        }

        #endregion

        #region Métodos CRUD

        public async Task<int> AddAuthor(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return author.Id;
        }

        public async Task<int> UpdateAuthor(Author author)
        {
            var existsAuthor = await _context.Authors.FindAsync(author.Id);
            if(existsAuthor != null)
            {
                existsAuthor.Code = author.Code;
                existsAuthor.Name = author.Name;
                existsAuthor.Country = author.Country;

                _context.Authors.Update(existsAuthor);
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAuthor(Author author)
        {
            //_context.Database.BeginTransaction();
            var existsAuthor = await _context.Authors.FindAsync(author.Id);
            if (existsAuthor != null)
            {
                existsAuthor.Code = author.Code;
                existsAuthor.Name = author.Name;
                existsAuthor.Country = author.Country;

                _context.Authors.Remove(existsAuthor);
            }

            return await _context.SaveChangesAsync();
        }

        #endregion
    }
}
