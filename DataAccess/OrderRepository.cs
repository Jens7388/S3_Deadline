using Entities;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ProductRepository: RepositoryBase<Orders>
    {
        protected const string orderDetails = "OrderDetails";

        public override Orders GetBy(int id)
        {
            return context.Orders
                .Include(orderDetails)
                .SingleOrDefault(p => p.OrderId == id);
        }

        public override IEnumerable<Orders> GetAll()
        {
            return context.Orders.Include(orderDetails);
        }
    }
}
