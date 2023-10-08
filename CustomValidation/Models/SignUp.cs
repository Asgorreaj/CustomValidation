using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidation.Models
{
    public class SignUp
    {



        
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Lenght minimum 4 and maximum 50")]
        [Display(Name = "Name")]
        [Required(ErrorMessage = " Provide Your Name")]
        [RegularExpression(@"^[a-zA-Z\ \.\-_]{4,50}$", ErrorMessage = "Number and Special character are not allowed")]
        public string Name { get; set; }

        
        [StringLength(12, MinimumLength = 4, ErrorMessage = "Lenght minimum 4 and maximum 12")]
        [Required(ErrorMessage = " Provide Your UserID")]
        [RegularExpression(@"^[0-9\-_]{4,12}$", ErrorMessage = "Dot and Special character are not allowed Only Number Allowed")]
        public string UserID { get; set; }
         
        
        [Required(ErrorMessage = " Provide Your Password")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
            ErrorMessage = "password must be eight characters including one uppercase letter, one special character and alphanumeric characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = " Provide Your ID")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$",
            ErrorMessage = "Must Use This Pattern ( **-*****-* )")]
        public string ID { get; set; }

        [Required(ErrorMessage = " Provide Your Email")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}@student\.aiub\.edu$",
            ErrorMessage = "Must Use This Pattern ( **-*****-*@student.aiub.edu )")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Provide Your DateOffBirth")]
        [RegularExpression(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]\d{4}$",
            ErrorMessage = "Follow This Pattern dd/mm/yyyy")]
        public string DateOfBirth { get; set; }



    }
}