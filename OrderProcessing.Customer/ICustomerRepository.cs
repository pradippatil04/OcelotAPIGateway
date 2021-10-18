using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Customer
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomers();
    }
}
