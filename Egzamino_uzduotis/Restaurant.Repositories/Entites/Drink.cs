﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Repositories.Entites
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Drink(string[] item)
        {
            Id = Convert.ToInt32(item[0]);
            Name = item[1];
            Price = Convert.ToDecimal(item[2]);
        }
    }
}
