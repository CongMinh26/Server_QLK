using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        public  List<ImportDetail> ImportDetails { get; set; }
        public  List<ExportDetail> ExportDetails { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
