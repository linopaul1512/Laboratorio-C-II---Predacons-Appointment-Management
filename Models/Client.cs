using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Client
    {
        public Client()
        {
            Appointment = new HashSet<Appointment>();
        }

        public string Idclient { get; set; }
        public string Nameclient { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public DateTime Datebirth { get; set; }
        public string Phonenumber { get; set; }
        public string Statusclient { get; set; }

        public virtual ICollection<Appointment> Appointment { get; set; }
    }
}
