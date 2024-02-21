using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class History : BaseEntity
    {
        public Status Status { get; set; }
        public string User { get; set; } 
        public string Description { get; set; } 
    }
}
