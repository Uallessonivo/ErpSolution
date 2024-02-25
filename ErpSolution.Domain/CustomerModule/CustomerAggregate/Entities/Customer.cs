using ErpSolution.Domain.SalesModule.SellerAggregate.Entities;
using ErpSolution.Domain.Shared.Common;
using ErpSolution.Domain.Shared.Entities;

namespace ErpSolution.Domain.CustomerModule.CustomerAggregate.Entities
{
    public class Customer : BaseEntity
    {
        public string Cnpj { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Name { get; private set; }
        public Status CustomerStatus { get; private set; } = Status.Active;
        public Address Address { get; private set; }
        public Contact Contact { get; private set; }
        public Category Category { get; private set; }
        public IReadOnlyList<Seller> Sellers { get; private set; }
        public IReadOnlyList<History> History { get; private set; }
        public FinancialInformation FinancialInformation { get; private set; }

        public Customer(string cnpj, string cpf, string email, string name, Address address, Contact contact,
            Category category, int creditLimit, int totalDebt)
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
            FinancialInformation = new FinancialInformation(creditLimit, totalDebt);
        }

        public void SetAddSeller(Seller seller)
        {
            Sellers = Sellers.Concat(new[] { seller }).ToList().AsReadOnly();
        }

        public void SetRemoveSeller(Seller seller)
        {
            var sellersList = Sellers.ToList();
            sellersList.Remove(seller);
            Sellers = sellersList.AsReadOnly();
        }

        public void SetAddHistory(History history)
        {
            History = History.Concat(new[] { history }).ToList().AsReadOnly();
        }

        public void SetFinancialInformation(FinancialInformation financialInformation)
        {
            FinancialInformation = financialInformation;
        }

        public void SetCategory(Category category)
        {
            Category = category;
        }

        public void SetContact(Contact contact)
        {
            Contact = contact;
        }

        public void SetAddress(Address address)
        {
            Address = address;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetStatus(Status status)
        {
            CustomerStatus = status;
        }
    }
}