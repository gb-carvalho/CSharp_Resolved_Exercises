﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate {get; set;}

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price:F2} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
