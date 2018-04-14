using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.Guid))
            {
                product.Guid = Guid.NewGuid().ToString();
                context.Products.Add(product);
            }
            else
            {
                Product dbEntry = context.Products.Find(product.Guid);

                if(dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.IsActive = product.IsActive;
                    dbEntry.Shop = product.Shop;
                }
            }
            context.SaveChanges();
        }
    }
}
