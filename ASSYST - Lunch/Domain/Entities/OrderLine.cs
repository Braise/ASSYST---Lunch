using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderLine
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public bool IsPaid { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
