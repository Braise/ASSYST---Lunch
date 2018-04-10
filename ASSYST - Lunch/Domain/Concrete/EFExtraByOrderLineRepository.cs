﻿using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFExtraByOrderLineRepository : IExtraByOrderLineRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<ExtraByOrderLine> ExtraByOrderLines {
            get { return context.ExtraByOrderLines; }
        }
    }
}
