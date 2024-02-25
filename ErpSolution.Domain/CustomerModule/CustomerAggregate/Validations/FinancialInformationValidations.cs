using ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Validations;

public class FinancialInformationValidations : AbstractValidator<FinancialInformation>
{
    public FinancialInformationValidations()
    {
        RuleFor(c => c.Status)
            .NotNull().WithMessage("Status is required");
        
        RuleFor(c => c.CreditLimit)
            .GreaterThanOrEqualTo(0).WithMessage("Credit limit must be greater than 0");
        
        RuleFor(c => c.TotalDebt)
            .GreaterThanOrEqualTo(0).WithMessage("Total debt must be greater than 0");
    }
}