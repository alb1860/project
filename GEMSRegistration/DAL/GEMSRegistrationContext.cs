//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //add namespace for Entity Framework
using GEMSRegistration.Models; //adds access to the classes


namespace GEMSRegistration.DAL 
{
    public class GEMSRegistrationContext : DbContext
    {
        //creating a custom constructor for this class with base options
        public GEMSRegistrationContext(DbContextOptions<GEMSRegistrationContext>options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Facilitator> Facilitators { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
