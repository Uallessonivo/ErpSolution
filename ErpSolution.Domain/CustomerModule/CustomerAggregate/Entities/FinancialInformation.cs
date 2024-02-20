using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class FinancialInformation : BaseEntity
    {
        public Status Status { get; set; } = Status.Active;
        public int CreditLimit { get; set; } 
        public int TotalDebt { get; set; }
    }
}
