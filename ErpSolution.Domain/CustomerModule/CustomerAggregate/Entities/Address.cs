using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; private set; } 
        public int Number { get; private set; } 
        public string Neighborhood { get; private set; } 
        public string City { get; private set; } 
        public string State { get; private set; } 
        public string ZipCode { get; private set; } 
        public string Reference { get; private set; }
        
        public Address(string street, int number, string neighborhood, string city, string state, string zipCode, string reference)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            ZipCode = zipCode;
            Reference = reference;
        }
        
        public void SetStreet(string street) => Street = street;
        public void SetNumber(int number) => Number = number;
        public void SetNeighborhood(string neighborhood) => Neighborhood = neighborhood;
        public void SetCity(string city) => City = city;
        public void SetState(string state) => State = state;
        public void SetZipCode(string zipCode) => ZipCode = zipCode;
        public void SetReference(string reference) => Reference = reference;
    }
}
