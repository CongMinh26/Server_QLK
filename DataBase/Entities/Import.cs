using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{

    public class Import
    {

        public int ImportId { get; set; }
        public System.DateTime DateCreate { get; set; }
        public int UserId { get; set; }
        public string SupplierId { get; set; }
        public bool Status { get; set; }
        public  List<ImportDetail> ImportDetails { get; set; }
        public  Supplier Supplier { get; set; }
        public  User User { get; set; }
    }
}
