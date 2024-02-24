using ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities;
using FluentValidation;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Validations;

public class AddressValidations : AbstractValidator<Address>
{
    public AddressValidations()
    {
        RuleFor(x => x.Street)
            .NotEmpty().WithMessage("Street is required");
        
        RuleFor(x => x.Number)
            .NotEmpty().WithMessage("Number is required");
        
        RuleFor(x => x.Neighborhood)
            .NotEmpty().WithMessage("Neighborhood is required");
        
        RuleFor(x => x.City)
            .NotEmpty().WithMessage("City is required");
        
        RuleFor(x => x.State)
            .NotEmpty().WithMessage("State is required");
        
        RuleFor(x => x.ZipCode)
            .NotEmpty().WithMessage("ZipCode is required");
    }
}