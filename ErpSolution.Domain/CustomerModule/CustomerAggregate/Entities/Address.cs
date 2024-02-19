using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; } = string.Empty;
        public int Number { get; set; } 
        public string Neighborhood { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Reference { get; set; } = string.Empty;
    }
}
