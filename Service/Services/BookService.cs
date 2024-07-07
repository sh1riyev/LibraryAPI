using System;
using System.Linq.Expressions;
using Domain.Entity;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class BookService : IBookService
	{
        private readonly IBookRepository _bookRepo;
		public BookService(IBookRepository bookRepo)
		{
            _bookRepo = bookRepo;
		}

        public Task Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Book entiy)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAll(Expression<Func<Book, bool>> predicate = null, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBy(Expression<Func<Book, bool>> predicate = null, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExist(Expression<Func<Book, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}

