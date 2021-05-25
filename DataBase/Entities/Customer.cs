using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{
    public class Customer
    {
 
        public string CustomerId { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
    
        public string AccountNumber { get; set; }

        public string Phone { get; set; }

        // 1-n
        public  List<Export> Exports { get; set; }
    }
}
