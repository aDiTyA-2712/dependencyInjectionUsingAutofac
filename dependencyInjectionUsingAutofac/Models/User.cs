using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dependencyInjectionUsingAutofac.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; } 
        public string About { get; set; }
        public bool RememberMe { get; set; }    
        public string Gender { get; set; }
    }
}