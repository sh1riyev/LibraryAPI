using System;
using Domain.Common;

namespace Domain.Entity
{
	public class Author : BaseEntity
	{
		public string FullName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}

