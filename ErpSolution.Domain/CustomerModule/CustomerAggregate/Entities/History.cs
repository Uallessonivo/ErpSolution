using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class History : BaseEntity
    {
        public Status Status { get; private set; }
        public string User { get; private set; } 
        public string Description { get; private set; } 
        
        public History(Status status, string user, string description)
        {
            Status = status;
            User = user;
            Description = description;
        }
        
        public void SetStatus(Status status) => Status = status;
        public void SetUser(string user) => User = user;
        public void SetDescription(string description) => Description = description;
    }
}
