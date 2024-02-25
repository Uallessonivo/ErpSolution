using ErpSolution.Domain.SalesModule.SellerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Validations;

public class SellerValidations : AbstractValidator<Seller>
{
    public SellerValidations()
    {
        RuleFor(c => c.Code)
            .NotEmpty().WithMessage("Code is required")
            .GreaterThanOrEqualTo(100).WithMessage("Code must be greater than or equal to 100");
        
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required");
        
        RuleFor(c => c.Email)
            .EmailAddress().WithMessage("Invalid email address");
        
        RuleFor(c => c.SellerStatus)
            .NotNull().WithMessage("Status is required");
        
        RuleFor(c => c.Supervisor)
            .NotNull().WithMessage("Supervisor is required");
    }
}