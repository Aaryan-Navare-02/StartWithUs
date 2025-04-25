using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class Payment
    {
        public Payment()
        {
            Report = new HashSet<Report>();
        }

        public string PaymentId { get; set; }
        public string InvestorId { get; set; }
        public DateTime Date { get; set; }
        public long Amount { get; set; }

        public virtual Investor Investor { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
