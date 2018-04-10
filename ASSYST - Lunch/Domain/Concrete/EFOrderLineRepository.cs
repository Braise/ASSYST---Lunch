using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFOrderLineRepository : IOrderLineRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<OrderLine> OrderLines {
            get { return context.OrderLines; }
        }
    }
}
