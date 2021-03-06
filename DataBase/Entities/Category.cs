using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Entities
{
   public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
