using ErpSolution.Domain.SalesModule.SellerAggregate.Entities;
using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Customer : BaseEntity
    {
        public int Code { get; set; }
        public string CNPJ { get; set; } 
        public string CPF { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; }
        public Status Status { get; set; } = Status.Active;
        public Address Address { get; set; }
        public Contact Contact { get; set; } 
        public Category Category { get; set; } 
        public List<Seller> Sellers { get; set; }
        public List<History> History { get; set; } 
        public FinancialInformation FinancialInformation { get; set; } 
    }
}
