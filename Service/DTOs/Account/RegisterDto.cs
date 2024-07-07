using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Service.DTOs.Account
{
	public class RegisterDto
	{
		[Required]
		public string Username { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string FullName { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}


	public class RegisterDtoValidator : AbstractValidator<RegisterDto>
	{
		public RegisterDtoValidator()
		{
			RuleFor(m => m.Username).NotEmpty().WithMessage("Name is required");
			RuleFor(m => m.Email).EmailAddress().NotEmpty().WithMessage("Email is required");
			RuleFor(m => m.Password).NotEmpty().WithMessage("Password is required");
			RuleFor(m => m.FullName).NotEmpty().WithMessage("FullName is required");
        }
	}
}

