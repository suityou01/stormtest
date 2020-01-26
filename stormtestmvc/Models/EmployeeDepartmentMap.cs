using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stormtestmvc.Models
{
    public class EmployeeDepartmentMap
    {
        [Key]
        public int id {get;set;}
        [Required]
        public Department department {get; set;}
        [Required]
        public Employee employee {get;set;}
    }
}
