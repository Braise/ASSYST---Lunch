using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExtraByShop
    {
        public int Id { get; set; }
        public double Price { get; set; }

        public Shop Shop { get; set; }
        public Extra Extra { get; set; }
    }
}
