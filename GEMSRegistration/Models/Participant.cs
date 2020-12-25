//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Participant : Person

    {
        [Display(Name = "Contact First Name")]
        [MaxLength(15, ErrorMessage = "Contact's First name cannot be longer than 15 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Contact First Name must be letters only")]
        [Required(ErrorMessage = "Please enter Contact's First Name")]

        public string ContactFName { get; set; }


        [Display(Name = "Contact Last Name")]
        [MaxLength(15, ErrorMessage = "Contact's Last name cannot be longer than 15 characters.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Contact Last Name must be letters only")]
        [Required(ErrorMessage = "Please enter Contact's Last Name")]
        public string ContactLName { get; set; }


        [RegularExpression("^[0-9]{2}$", ErrorMessage = "Please enter numbers only.")]
        public int Age { get; set; }

        [Display(Name = "Registration Date")]
        [DisplayFormat(DataFormatString ="{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        //many side of  relationship with Workshop
        public virtual ICollection<Workshop> Workshops{ get; set; }

    }
}
