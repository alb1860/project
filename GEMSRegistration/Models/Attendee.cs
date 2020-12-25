//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; }
        [RegularExpression("^[0-9]{1}$", ErrorMessage = "Please enter numbers only.")]
        public int Quantity { get; set; }
        public int? WorkshopID { get; set; }

        //relationship with Workshop
        public virtual Workshop Workshop { get; set; }

        public int? LocationID { get; set; }
        //relationship with Building
        public virtual Location Location { get; set; }

        
    }
}
