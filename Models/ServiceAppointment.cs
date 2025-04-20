using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class ServiceAppointment
    {
        public string CodeSa { get; set; }
        public string Codeservice { get; set; }
        public string Codeappointment { get; set; }

        public virtual Appointment CodeappointmentNavigation { get; set; }
        public virtual Service CodeserviceNavigation { get; set; }
    }
}
