using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PredaconsAppointmentManagement.Models
{
    public partial class Userx
    {
        public string Codeuser { get; set; }
        public string Coderole { get; set; }
        public string Personalname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public string Statususer { get; set; }

        public virtual Role CoderoleNavigation { get; set; }
    }
}
