using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; } 
        public int Number { get; set; } 
        public string Neighborhood { get; set; } 
        public string City { get; set; } 
        public string State { get; set; } 
        public string ZipCode { get; set; } 
        public string Reference { get; set; } 
    }
}
