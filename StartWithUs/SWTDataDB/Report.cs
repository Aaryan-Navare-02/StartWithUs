using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class Report
    {
        public string ReportId { get; set; }
        public string CompanyId { get; set; }
        public string EnterpreneurId { get; set; }
        public string InvestorId { get; set; }
        public string PaymentId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Enterpreneur Enterpreneur { get; set; }
        public virtual Investor Investor { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
