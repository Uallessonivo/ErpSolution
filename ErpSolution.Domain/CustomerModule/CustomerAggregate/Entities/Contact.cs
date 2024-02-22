using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Contact : BaseEntity
    {
        public int Ddd { get; set; }
        public int Phone { get; set; }
    }
}
