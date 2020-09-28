using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.Entities
{
  public class Category
    {
        public int ID { get; set; }
        public string CatName { get; set; }
        [NotMapped]
        public virtual ICollection<Product> Products { get; set; }
    }
}
