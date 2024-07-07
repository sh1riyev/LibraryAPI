using System;
using AutoMapper;
using Domain.Entity;
using Service.DTOs.Account;

namespace Service.Helpers
{
	public class MappingProfile :Profile
	{
		public MappingProfile()
		{
			CreateMap<RegisterDto, AppUser>();
			CreateMap<AppUser, UserDto>();
        }
	}
}

