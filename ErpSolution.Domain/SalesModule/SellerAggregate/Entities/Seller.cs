using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Entities
{
    public class Seller : BaseEntity
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Status SellerStatus { get; private set; } = Status.Active;
        public Supervisor Supervisor { get; private set; }
        
        public Seller(int code, string name, string email, Supervisor supervisor)
        {
            Code = code;
            Name = name;
            Email = email;
            Supervisor = supervisor;
        }
        
        public void SetStatus(Status status)
        {
            SellerStatus = status;
        }
        
        public void SetSupervisor(Supervisor supervisor)
        {
            Supervisor = supervisor;
        }
        
        public void SetName(string name)
        {
            Name = name;
        }
        
        public void SetEmail(string email)
        {
            Email = email;
        }
        
        public void SetCode(int code)
        {
            Code = code;
        }
    }
}
