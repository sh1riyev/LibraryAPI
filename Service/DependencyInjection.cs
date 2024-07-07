using System;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Service.DTOs.Account;
using Service.Helpers;
using Service.Services;
using Service.Services.Interfaces;

namespace Service
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddServiceLayer(this IServiceCollection service)
		{
			service.AddAutoMapper(typeof(MappingProfile).Assembly);

			service.AddFluentValidationAutoValidation(config =>
			{
				config.DisableDataAnnotationsValidation = true;
			});

			service.AddScoped<IValidator<RegisterDto>, RegisterDtoValidator>();
			service.AddScoped<IAccountService, AccountService>();

			return service;
		}
	}
}

