using System;
using System.ComponentModel.DataAnnotations;

namespace stormtestmvc.Models
{
    /// <summary>
    /// Login Model
    /// </summary>
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public LoginModel()
        {
          
        }

        public override string ToString(){
            return "Username[" + this.Username + "] Password[" + this.Password + "] AppId[" + "]"; 
        }
    }
}