using System;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configuration
{
	public class AuthorConfiguration :IEntityTypeConfiguration<Author>
	{
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(m => m.FullName).IsRequired();
            builder.Property(m => m.Email).IsRequired();
            builder.Property(m => m.PhoneNumber).IsRequired();
        }
    }
}

