using FluentValidation;
using InvoiceManagementSystem.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Service.Validation
{
    public class UserValidator : AbstractValidator<UserDTO>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail cannot be empty")
            .Must(BeValidEmail).WithMessage("Enter a valid e-mail address");
        }
        private bool BeValidEmail(string email)
        {
            return email.EndsWith("@hotmail.com") || email.EndsWith("@gmail.com");
        }
    }
}
