//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Workshop
    {
        public int WorkshopID { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "Workshop Name must be Alphanumeric")]
        [Display(Name = "Workshop Name")]
        [Required(ErrorMessage = "Please enter Workshop Name")]
        public string WorkshopName { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "Workshop Description must be Alphanumeric")]
        [Display(Name = "Workshop Description")]
        [Required(ErrorMessage = "Please enter Workshop Description")]
        public string WorkshopDescription { get; set; }

        //property for the relation (1:M)
        [Display(Name = "Facilitator Last Name")]

        public int? FacilitatorID { get; set; }

        //relationship with Facilitator
        public virtual Facilitator Facilitator { get; set; }

        //property for the relation (1:M)
        [Display(Name = "Participant Last Name")]

        public int? ParticipantID { get; set; }

        //relationship with Participant
        public virtual Participant Participant { get; set; }


        //many side of  relationship with Attendees
        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}
