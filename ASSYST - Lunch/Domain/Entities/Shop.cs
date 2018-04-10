using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string OrderBefore { get; set; }
        public bool IsActive { get; set; }
    }
}
