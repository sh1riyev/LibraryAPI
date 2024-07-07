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

        public async Task Create(Author entity)
        {
            if (await _authorRepo.IsExist(m => m.Email == entity.Email)) throw new FormatException();
            await _authorRepo.Create(entity);

        }

        public async Task Delete(Author entiy)
        {
            await _authorRepo.Delete(entiy);
        }

        public async Task<List<Author>> GetAll(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            return await _authorRepo.GetAll(predicate, includes);
        }

        public async Task<Author> GetBy(Expression<Func<Author, bool>> predicate = null, params string[] includes)
        {
            return await _authorRepo.GetEntity(predicate, includes);
        }

        public async Task<bool> IsExist(Expression<Func<Author, bool>> predicate = null)
        {
            return await _authorRepo.IsExist(predicate);
        }

        public async  Task Update(Author entity)
        {
            if (await _authorRepo.IsExist(m => m.Id != entity.Id && m.Email == entity.Email)) throw new FormatException();
            entity.UpdateDate = DateTime.Now;
            await _authorRepo.Update(entity);
        }
    }
}

