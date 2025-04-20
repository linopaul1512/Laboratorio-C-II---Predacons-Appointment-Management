using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Invoice
    {
        public string Codeinvoice { get; set; }
        public string Codeappointment { get; set; }
        public DateTime Dateinvoice { get; set; }
        public double Iva { get; set; }
        public double Saleprice { get; set; }
        public string Statusinvoice { get; set; }

        public virtual Appointment CodeappointmentNavigation { get; set; }
    }
}
