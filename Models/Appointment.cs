using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            Invoice = new HashSet<Invoice>();
            MaterialsAppointment = new HashSet<MaterialsAppointment>();
            ServiceAppointment = new HashSet<ServiceAppointment>();
        }

        public string Codeappointment { get; set; }
        public string Idclient { get; set; }
        public string Idworker { get; set; }
        public DateTime Instalationdate { get; set; }
        public DateTime Possibledate { get; set; }
        public string Statusappoinment { get; set; }

        public virtual Client IdclientNavigation { get; set; }
        public virtual Worker IdworkerNavigation { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<MaterialsAppointment> MaterialsAppointment { get; set; }
        public virtual ICollection<ServiceAppointment> ServiceAppointment { get; set; }
    }
}
