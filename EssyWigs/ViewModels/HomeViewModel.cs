﻿using EssyWigs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EssyWigs.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductWDiscount { get; set; }
        public IEnumerable<Product> AllProducts { get; set; }
    }
}