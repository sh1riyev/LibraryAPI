using System;
using AutoMapper;
using Domain.Entity;
using Service.DTOs.Account;
using Service.DTOs.Author;

namespace Service.Helpers
{
	public class MappingProfile :Profile
	{
		public MappingProfile()
		{
			CreateMap<RegisterDto, AppUser>();
			CreateMap<AppUser, UserDto>();
			CreateMap<LoginDto, AppUser>();
			CreateMap<AuthorCreateDto, Author>();
			CreateMap<Author, AuthorDto>();
        }
	}
}

