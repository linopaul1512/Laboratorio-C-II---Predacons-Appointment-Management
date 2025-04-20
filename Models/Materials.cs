using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Materials
    {
        public Materials()
        {
            MaterialsAppointment = new HashSet<MaterialsAppointment>();
        }

        public string Codematerials { get; set; }
        public string Description { get; set; }
        public double Puccharseprice { get; set; }
        public double Saleprice { get; set; }
        public int Quantityavailable { get; set; }
        public string Statusmaterials { get; set; }

        public virtual ICollection<MaterialsAppointment> MaterialsAppointment { get; set; }
    }
}
