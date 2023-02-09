using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HallsAndLabsScheduleGenerator.ViewModel
{
    public class EditUserViewModel
    {

        public string Id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }


        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }



        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
