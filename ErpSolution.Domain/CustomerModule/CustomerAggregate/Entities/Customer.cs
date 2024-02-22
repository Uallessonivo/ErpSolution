using ErpSolution.Domain.SalesModule.SellerAggregate.Entities;
using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Customer : BaseEntity
    {
        private string Cnpj { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private string Name { get; set; }
        private Status CustomerStatus { get; set; } = Status.Active;
        private Address Address { get; set; }
        private Contact Contact { get; set; }
        private Category Category { get; set; }
        private IReadOnlyList<Seller> Sellers { get; set; }
        private IReadOnlyList<History> History { get; set; }
        private FinancialInformation FinancialInformation { get; set; }

        public Customer(string cnpj, string cpf, string email, string name, Address address, Contact contact,
            Category category)
        {
            Cnpj = cnpj;
            Cpf = cpf;
            Email = email;
            Name = name;
            Address = address;
            Contact = contact;
            Category = category;
            Sellers = new List<Seller>().AsReadOnly();
            History = new List<History>().AsReadOnly();
            FinancialInformation = new FinancialInformation();
        }

        public Customer AddSeller(Seller seller)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, Category)
            {
                Sellers = Sellers.Concat(new[] { seller }).ToList().AsReadOnly()
            };
        }

        public Customer RemoveSeller(Seller seller)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, Category)
            {
                Sellers = Sellers.Where(x => x.Id != seller.Id).ToList().AsReadOnly()
            };
        }

        public Customer AddHistory(History history)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, Category)
            {
                History = History.Concat(new[] { history }).ToList().AsReadOnly()
            };
        }

        public Customer UpdateFinancialInformation(FinancialInformation financialInformation)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, Category)
            {
                FinancialInformation = financialInformation
            };
        }

        public Customer UpdateCategory(Category category)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, category);
        }

        public Customer UpdateContact(Contact contact)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, contact, Category);
        }

        public Customer UpdateAddress(Address address)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, address, Contact, Category);
        }

        public Customer UpdateName(string name)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, name, Address, Contact, Category);
        }

        public Customer UpdateStatus(Status status)
        {
            // Use validation
            return new Customer(Cnpj, Cpf, Email, Name, Address, Contact, Category)
            {
                CustomerStatus = status
            };
        }
    }
}