//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GEMSRegistration.Models
{
    public class Facilitator : Person
    {
        [Display(Name = "Organization Affiliation")]
        public string Affiliation { get; set; }

        //many side of  relationship with Workshop
        public virtual ICollection<Workshop> Workshops { get; set; }
    }
}
