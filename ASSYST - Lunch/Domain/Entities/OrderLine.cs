using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderLine
    {
        [Key]
        public string Guid { get; set; }
        public string Note { get; set; }
        public bool IsPaid { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
