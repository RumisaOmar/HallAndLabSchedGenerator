using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HallsAndLabsScheduleGenerator.ViewModel
{
    public class RegisterViewModel
    {
          [Required]
          [EmailAddress]
         // [Display(Name = "Confirm Password")] 
        public string Email { get; set; }
          
          [Required]
          [DataType(DataType.Password)]
         // [Display(Name = "Confirm Password")]
          public string Password { get; set; }

          [DataType(DataType.Password)]
          [Display(Name = "Confirm Password")]
          [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
          public string ConfirmPassword { get; set; }

    }
}
