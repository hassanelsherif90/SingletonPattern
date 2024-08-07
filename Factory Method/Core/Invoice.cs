﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class Invoice
    {

        public Customer Customer { get; set; }  
        public IEnumerable<InvoiceLines>   Lines { get; set; }
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);
        public double DiscountPersentag { get; set; }
        public double Taxes {  get; set; }  
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPersentag);

    }
}
