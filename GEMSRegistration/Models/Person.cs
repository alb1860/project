//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Person
    {
        public int ID { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "First Name must be letters only")]
        [Display(Name = "First Name")]
        [MaxLength(15, ErrorMessage = "First name cannot be longer than 15 characters.")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FName { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Last Name must be letters only")]
        [Display(Name = "Last Name")]
        [MaxLength(20, ErrorMessage = "Last name cannot be longer than 20 characters.")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LName { get; set; }


        [MaxLength(11, ErrorMessage = "Phone number cannot be longer than 11 characters.")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        public string Email { get; set; }
    }
}
