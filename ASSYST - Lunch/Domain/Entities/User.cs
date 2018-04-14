using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public string Guid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
