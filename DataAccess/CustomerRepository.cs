using Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class CustomerRepository: RepositoryBase<Customers>
    { 
        /*
        public override Customers GetBy(string id)
        {
            return context.Customers
                .SingleOrDefault(p => p.CustomerId == id);
        }*/

        public override IEnumerable<Customers> GetAll()
        {
            return context.Customers;
        }
    }
}
