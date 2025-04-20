using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Service
    {
        public Service()
        {
            ServiceAppointment = new HashSet<ServiceAppointment>();
        }

        public string Codeservice { get; set; }
        public string Descriptionservice { get; set; }
        public double Price { get; set; }
        public string Statuservice { get; set; }

        public virtual ICollection<ServiceAppointment> ServiceAppointment { get; set; }
    }
}
