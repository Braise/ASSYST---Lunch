﻿using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFExtraRepository : IExtraRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Extra> Extras {
            get { return context.Extras; }
        }
    }
}