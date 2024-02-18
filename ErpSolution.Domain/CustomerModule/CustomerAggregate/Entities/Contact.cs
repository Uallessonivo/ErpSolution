using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Contact : BaseEntity
    {
        public int DDD { get; set; }
        public int Phone { get; set; }
    }
}
