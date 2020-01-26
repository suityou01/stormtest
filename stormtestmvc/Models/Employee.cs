using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stormtestmvc.Models
{
    public class Employee
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string First_Name {get;set;}
        [Required]
        public string Last_Name{get;set;}
        [Required]
        public string Email {get;set;}
        [Required]
        public string Identifier {get;set;}
        [Required]
        public DateTime CreatedDate {get; set;}
        public bool IsDeleted{get;set;}
        [Required]
        internal Guid Guid{get;set;}
    }
}
