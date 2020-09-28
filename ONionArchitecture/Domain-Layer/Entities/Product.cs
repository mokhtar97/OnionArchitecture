using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Entities
{
   public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public int Category_ID { get; set; }
        [NotMapped]
        public virtual Category Category { get; set; }
    }
}
