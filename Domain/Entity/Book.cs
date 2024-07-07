using System;
using Domain.Common;

namespace Domain.Entity
{
	public class Book : BaseEntity
	{
		public string Name { get; set; }
		public int PageCount { get; set; }
		public int BookCount { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}

