using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class Investor
    {
        public Investor()
        {
            Payment = new HashSet<Payment>();
            Report = new HashSet<Report>();
        }

        public string InvestorId { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Pannumber { get; set; }
        public string EmailId { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
