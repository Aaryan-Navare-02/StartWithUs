using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StartWithUs.Models
{
    public class CompanyDetailsModel
    {
        public string CompanyName { get; set; }
        public string CompanyId { get; set; }
        public string About { get; set; }
        public string Tagline { get; set; }

        [Required(ErrorMessage ="Image is required")]
        public byte[] CompanyImage { get; set; }
        public byte[] CompanyGraph { get; set; }
        public byte[] CompanyVideo { get; set; }




    }
}