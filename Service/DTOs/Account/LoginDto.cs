using System;
using FluentValidation;

namespace Service.DTOs.Account
{
	public class LoginDto
	{
		public string EmailOrUsername { get; set; }
		public string Password { get; set; }
	}

	public class LoginDtoValidator : AbstractValidator<LoginDto>
	{
		public LoginDtoValidator()
		{
			RuleFor(m => m.EmailOrUsername).NotEmpty().WithMessage("Email or Username is required");
			RuleFor(m => m.Password).NotEmpty().WithMessage("Password is required");
		}
	}

}