using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataBase.Entities
{

    public class Export
    {
        public int ExportId { get; set; }
        public System.DateTime DateCreate { get; set; }
        public string CustomerId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public  List<ExportDetail> ExportDetails { get; set; }
        public  Customer Customer { get; set; }
        public  User User { get; set; }
    }
}
