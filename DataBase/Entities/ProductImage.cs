using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string Cation { get; set; }
        public string PathImage { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public Product Product { get; set; }
    }
}
