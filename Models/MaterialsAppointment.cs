using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class MaterialsAppointment
    {
        public string CodeMa { get; set; }
        public string Codematerials { get; set; }
        public string Codeappointment { get; set; }
        public int Quantityma { get; set; }

        public virtual Appointment CodeappointmentNavigation { get; set; }
        public virtual Materials CodematerialsNavigation { get; set; }
    }
}
