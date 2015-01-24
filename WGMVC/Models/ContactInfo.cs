using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WGMVC.Models
{
    public class ContactInfo
    {
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "* Required")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "* Please enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "* Required")]
       [UIHint("MultilineText")]
        public string Comments { get; set; }

    }
}