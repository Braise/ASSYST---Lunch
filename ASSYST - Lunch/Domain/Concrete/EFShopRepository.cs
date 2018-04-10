using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFShopRepository : IShopRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Shop> Shops {
            get { return context.Shops; }
        }
    }
}
