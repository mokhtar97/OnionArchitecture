﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.DTOs
{
   public class ProductDTO
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public int Category_ID { get; set; }
    }
}
