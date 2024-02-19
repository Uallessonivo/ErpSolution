using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class History : BaseEntity
    {
        public bool Status { get; set; }
        public string User { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
