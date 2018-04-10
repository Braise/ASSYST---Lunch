using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExtraByOrderLine
    {
        public int Id { get; set; }

        public Extra Extra { get; set; }
        public OrderLine OrderLine { get; set; }
    }
}
