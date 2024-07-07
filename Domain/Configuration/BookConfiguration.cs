using System;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
	public class BookConfiguration : IEntityTypeConfiguration<Book>
	{

        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(m => m.Name).IsRequired();
        }
    }
}

