using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.SalesModule.SellerAggregate.Entities
{
    public class Supervisor : BaseEntity
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<Seller> sellers { get; private set; }
        
        public Supervisor(int code, string name, string email)
        {
            Code = code;
            Name = name;
            Email = email;
        }
        
        public void SetAddSeller(Seller seller)
        {
            sellers.Add(seller);
        }
        
        public void SetRemoveSeller(Seller seller)
        {
            sellers.Remove(seller);
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
