using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Part6_Angular.Models
{
    public class StudentVM
    {
        [Required(ErrorMessage = "Please enter the first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the Password")]
        public string Password { get; set; }
    }
}