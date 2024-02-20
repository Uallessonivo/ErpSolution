using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class History : BaseEntity
    {
        public bool Status { get; set; }
        public string User { get; set; } 
        public string Description { get; set; } 
    }
}
