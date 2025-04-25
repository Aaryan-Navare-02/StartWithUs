using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StartWithUs.SWTDataDB
{
    public partial class Company
    {
        public Company()
        {
            Report = new HashSet<Report>();
        }

        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public byte[] CompanyVideo { get; set; }
        public byte[] CompanyGraph { get; set; }
        public string EnterpreneurId { get; set; }
        public string About { get; set; }
        public string Tagline { get; set; }
        public byte[] CompanyImage { get; set; }

        public virtual Enterpreneur Enterpreneur { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
