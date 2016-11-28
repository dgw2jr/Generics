using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Services.Interfaces;

namespace Services
{
    public class ListCustomerCommand : IListCommand<Customer>
    {
        public IEnumerable<Customer> Execute()
        {
            return Enumerable.Range(1, 10).Select(i => new Customer { Id = i, Name = i.ToString() });
        }
    }
}
