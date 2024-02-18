using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Customer : BaseEntity
    {
        public string CNPJ { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        public Address Address { get; set; } = new Address();
        public Contact Contact { get; set; } = new Contact();
        public FinancialInformation FinancialInformation { get; set; } = new FinancialInformation();
    }
}
