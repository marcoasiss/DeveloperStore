using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(customer => customer.Email).SetValidator(new EmailValidator());

        RuleFor(customer => customer.Customername)
            .NotEmpty()
            .MinimumLength(3).WithMessage("Customer name must be at least 3 characters long.")
            .MaximumLength(50).WithMessage("Customer name cannot be longer than 50 characters.");
        
        RuleFor(customer => customer.Password).SetValidator(new PasswordValidator());
        
        RuleFor(customer => customer.Phone)
            .Matches(@"^\+[1-9]\d{10,14}$")
            .WithMessage("Phone number must start with '+' followed by 11-15 digits.");
        
        RuleFor(customer => customer.Status)
            .NotEqual(CustomerStatus.Unknown)
            .WithMessage("Customer status cannot be Unknown.");
        

    }
}
