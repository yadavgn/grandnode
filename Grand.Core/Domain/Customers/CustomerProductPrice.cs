﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grand.Core.Domain.Customers
{
    public class CustomerProductPrice: BaseEntity
    {
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public decimal Price { get; set; }
    }
}
