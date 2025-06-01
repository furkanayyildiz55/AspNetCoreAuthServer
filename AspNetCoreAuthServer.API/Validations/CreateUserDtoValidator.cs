using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAuthServer.Core.DTOs;

namespace UdemyAuthServer.API.Validations
{
    public class CreateUserDtoValidator : AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email  gerekli").EmailAddress().WithMessage("Email yanlış");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password gerekli");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName gerekli");
        }
    }
}