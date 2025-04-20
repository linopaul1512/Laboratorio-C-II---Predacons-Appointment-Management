using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Role
    {
        public Role()
        {
            Userx = new HashSet<Userx>();
        }

        public string Coderole { get; set; }
        public string Descriptionrole { get; set; }
        public string Statusrole { get; set; }

        public virtual ICollection<Userx> Userx { get; set; }
    }
}
