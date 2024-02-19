using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Customer : BaseEntity
    {
        public int Code { get; set; }
        public string CNPJ { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        public Address Address { get; set; } = new Address();
        public Contact Contact { get; set; } = new Contact();
        public Category Category { get; set; } = new Category();
        public List<History> History { get; set; } = new List<History>();
        public FinancialInformation FinancialInformation { get; set; } = new FinancialInformation();
    }
}
