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

        public void SaveShop(Shop shop)
        {
            if (string.IsNullOrEmpty(shop.Guid))
            {
                shop.Guid = Guid.NewGuid().ToString();
                context.Shops.Add(shop);
            }
            else
            {
                Shop dbEntry = context.Shops.Find(shop.Guid);

                if(dbEntry != null)
                {
                    dbEntry.Name = shop.Name;
                    dbEntry.City = shop.City;
                    dbEntry.ZipCode = shop.ZipCode;
                    dbEntry.Street = shop.Street;
                    dbEntry.Number = shop.Number;
                    dbEntry.Phone = shop.Phone;
                    dbEntry.Mail = shop.Mail;
                    dbEntry.OrderBefore = shop.OrderBefore;
                    dbEntry.IsActive = shop.IsActive;
                }
            }
            context.SaveChanges();
        }
    }
}
