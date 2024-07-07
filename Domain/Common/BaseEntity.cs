﻿using System;
namespace Domain.Common
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public bool IsDeleted { get; set; } = false;
		public DateTime CreateDate { get; set; } = DateTime.Now;
		public DateTime UpdateDate { get; set; }
	}
}

