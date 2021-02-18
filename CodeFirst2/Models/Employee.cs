using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst2.Models {
    public class Employee {
        [Key]
        public int EmpId { get; set; }
        public string EName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int DeptId { get; set; }

        public virtual Department Department { get; set; }
    }
}