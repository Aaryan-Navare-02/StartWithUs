using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartWithUs.Models
{
    public class InvestorSignUp
    {
        public int InvestorId { get; set; }

        public string Name { get; set; }

        public string PANNumber { get; set; }

        public string EmailId { get; set; }

        public string MobileNo { get; set; }

        public string DOB { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }


    }
}