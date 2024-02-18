using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class FinancialInformation : BaseEntity
    {
        public bool Blocked { get; set; } = false;
        public int CreditLimit { get; set; } = 0;
        public int TotalDebt { get; set; } = 0;
    }
}
