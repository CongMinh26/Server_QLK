using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

   public class ImportDetail
    {
       
        public int ImportId { get; set; }      
        public int ProductId { get; set; }    
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public  Import Import { get; set; }
        public  Product Product { get; set; }
    }
}
