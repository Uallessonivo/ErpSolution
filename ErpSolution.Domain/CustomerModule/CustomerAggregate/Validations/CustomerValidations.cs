using ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities;
using ErpSolution.Domain.SalesModule.SellerAggregate.Validations;
using FluentValidation;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Validations;

public class CustomerValidations : AbstractValidator<Customer>
{
    public CustomerValidations()
    {
        RuleFor(c => c.Cnpj)
            .Length(14).WithMessage("CNPJ must have 14 characters")
            .Matches(@"^\d{14}$").WithMessage("CNPJ must have only numbers");
        
        RuleFor(c => c.Cpf)
            .Length(11).WithMessage("CPF must have 11 characters")
            .Matches(@"^\d{11}$").WithMessage("CPF must have only numbers");
        
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required")
            .MaximumLength(100).WithMessage("Name must have a maximum of 100 characters");
        
        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Email is invalid");
        
        RuleFor(c => c.Address)
            .NotNull().WithMessage("Address is required")
            .SetValidator(new AddressValidations());
        
        RuleFor(c => c.Contact)
            .NotNull().WithMessage("Contact is required")
            .SetValidator(new ContactValidations());

        RuleFor(c => c.Category)
            .IsInEnum().WithMessage("Category is invalid");
        
        RuleForEach(c => c.Sellers)
            .NotNull().WithMessage("Sellers is required")
            .SetValidator(new SellerValidations());

        RuleFor(c => c.FinancialInformation)
            .NotNull().WithMessage("Financial Information is required")
            .SetValidator(new FinancialInformationValidations());
    }
}