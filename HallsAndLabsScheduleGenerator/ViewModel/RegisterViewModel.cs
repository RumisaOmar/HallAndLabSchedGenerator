using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HallsAndLabsScheduleGenerator.ViewModel
{
    public class RegisterViewModel
    {

        public string Id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        //[Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


       //  [Required]
         [Display(Name = "Email")] 
          public string Email { get; set; }
          
          [Required]
          [DataType(DataType.Password)]
          [Display(Name = "Confirm Password")]
          public string Password { get; set; }

          [DataType(DataType.Password)]
          [Display(Name = "Confirm Password")]
          [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
          public string ConfirmPassword { get; set; }

    }
}
