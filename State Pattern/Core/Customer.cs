﻿

namespace StrategyPattern.Core
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CustomerCategory Category { get; set; }
    }
}
