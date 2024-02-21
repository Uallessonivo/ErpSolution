using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Entities
{
    public class Supervisor : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Seller> sellers { get; set; }
    }
}
