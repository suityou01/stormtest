using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stormtestmvc.Models
{
    public class Department
    {
        
        [Key]
        public int Id {get;set;}
        [Required]
        public string Code {get; set;}
        [Required]
        public string Description {get;set;}
        [Required]
        public DateTime CreatedDate{get;set;}
        [Required]
        public bool IsDeleted{get;set;}
    }
}
