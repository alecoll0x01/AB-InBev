using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public CustomerValidator() 
        {
            RuleFor(customer => customer.Name)
                .NotEmpty()
                .MinimumLength(3).WithMessage("Customer name must be at least 3 characters long.")
                .MaximumLength(50).WithMessage("Customer name cannot be longer than 50 characters.");
            RuleFor(customer => customer.Email)
                .NotEmpty()
                .EmailAddress().WithMessage("Invalid email address.");
        }
    }
}
