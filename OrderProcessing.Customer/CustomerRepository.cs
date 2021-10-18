using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessing.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();

        public CustomerRepository()
        {
            _customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = "Pradip",
                LastName = "Patil",
                EmailAddress = "pradip@test.com"
            });
            _customers.Add(new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Satter",
                EmailAddress = "john@test.com"
            });
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            return Task.FromResult(_customers);
        }
    }
}
