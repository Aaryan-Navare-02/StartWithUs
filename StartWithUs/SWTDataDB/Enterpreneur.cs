using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class Enterpreneur
    {
        public Enterpreneur()
        {
            Company = new HashSet<Company>();
            Report = new HashSet<Report>();
        }

        public string EnterpreneurId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Pan { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
