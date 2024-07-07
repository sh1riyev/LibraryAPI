using System;
using System.Linq.Expressions;
using Domain.Entity;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class AuthorService: IAuthorService
	{
        private readonly IAuthorRepository _authorRepo;
		public AuthorService(IAuthorRepository authorRepo)
		{
            _authorRepo = authorRepo;
		}

        public Task Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Author entiy)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> GetAll(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetBy(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExist(Expression<Func<Author, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}

