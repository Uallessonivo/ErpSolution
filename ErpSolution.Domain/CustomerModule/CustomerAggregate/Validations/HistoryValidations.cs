using ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Validations;

public class HistoryValidations : AbstractValidator<History>
{
    public HistoryValidations()
    {
        RuleFor(c => c.Status)
            .NotEmpty().WithMessage("Status is required");
        
        RuleFor(c => c.User)
            .NotEmpty().WithMessage("User is required");
        
        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Description is required");
    }
}