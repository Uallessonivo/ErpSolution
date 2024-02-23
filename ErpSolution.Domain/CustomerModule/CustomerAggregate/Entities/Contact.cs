using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Contact : BaseEntity
    {
        public int Ddd { get; private set; }
        public int Phone { get; private set; }
        
        public Contact(int ddd, int phone)
        {
            Ddd = ddd;
            Phone = phone;
        }
        
        public void SetDdd(int ddd) => Ddd = ddd;
        public void SetPhone(int phone) => Phone = phone;
    }
}
