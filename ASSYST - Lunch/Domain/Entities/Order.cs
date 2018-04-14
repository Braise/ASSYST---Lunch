using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        [Key]
        public string Guid { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
    }
}
