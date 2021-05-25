using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{
    public class Supplier
    {
        public string SupplierId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
         public  List<Import> Imports { get; set; }
    }
}
