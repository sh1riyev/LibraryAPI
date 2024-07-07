using System;
using Domain.Common;
using Domain.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Author> Authors { get; set; }
		public DbSet<BookAuthor> BookAuthors { get; set; }
		public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
			builder.ApplyConfigurationsFromAssembly(typeof(BaseEntity).Assembly);

            base.OnModelCreating(builder);
        }
    }
}

