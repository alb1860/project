//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        [Display(Name = "Location Name")]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "Location Name must be Alphanumeric")]
        [Required(ErrorMessage = "Please enter Location Name")]
        public string LocationName { get; set; }

        //many side of  relationship with Attendees
        public virtual ICollection<Attendee> Attendees { get; set; }
    }

}
