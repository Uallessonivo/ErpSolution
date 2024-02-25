using ErpSolution.Domain.SalesModule.SellerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Validations;

public class SupervisorValidations : AbstractValidator<Supervisor>
{
    public SupervisorValidations()
    {
        RuleFor(c => c.Code)
            .NotEmpty().WithMessage("Code is required")
            .GreaterThanOrEqualTo(10).WithMessage("Code must be greater than or equal to 10");

        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required")
            .MinimumLength(4).WithMessage("Name must be at least 4 characters");
        
        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email");
        
        RuleFor(c => c.sellers)
            .NotEmpty().WithMessage("Supervisor must have at least one seller");
    }
}