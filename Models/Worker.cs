using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Worker
    {
        public Worker()
        {
            Appointment = new HashSet<Appointment>();
        }

        public string Idworker { get; set; }
        public string Nameworker { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public DateTime Datebirth { get; set; }
        public string Adress { get; set; }
        public string Sex { get; set; }
        public string Statusworker { get; set; }

        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}
