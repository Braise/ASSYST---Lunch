using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class EditProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
    }
}