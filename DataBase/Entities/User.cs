using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase.Entities
{

    public class User : IdentityUser<Guid>
    {

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public System.DateTime DayOfBirth { get; set; }
        public double Salary { get; set; }
        public string Password { get; set; }

        // 1 nv có nhiều phiếu nhập 
        public  List<Export> Exports { get; set; }
        public  List<Import> Imports { get; set; }

    }
}
