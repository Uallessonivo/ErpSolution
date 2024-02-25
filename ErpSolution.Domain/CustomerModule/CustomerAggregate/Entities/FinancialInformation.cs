using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class FinancialInformation : BaseEntity
    {
        public Status Status { get; private set; } = Status.Active;
        public int CreditLimit { get; private set; }
        public int TotalDebt { get; private set; } 
        
        public FinancialInformation(int creditLimit, int totalDebt)
        {
            CreditLimit = creditLimit;
            TotalDebt = totalDebt;
        }
        
        public void SetStatus(Status status) => Status = status;
        public void SetCreditLimit(int creditLimit) => CreditLimit = creditLimit;
        public void SetTotalDebt(int totalDebt) => TotalDebt = totalDebt;
    }
}
