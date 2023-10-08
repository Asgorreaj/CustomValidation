using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidation.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Provide you name")]
        [StringLength(5, ErrorMessage = "Length <5")]
        public string Username { get; set; }
        public string Password { get; set; }  
    }
}