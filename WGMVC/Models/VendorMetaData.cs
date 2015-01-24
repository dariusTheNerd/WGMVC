using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WGMVC
{
    public class VendorMetaData
    {
       [Required(ErrorMessage="* Required")]
        public string  Name { get; set; }
        [Required(ErrorMessage="* Required")]
        [RegularExpression(@"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?", ErrorMessage = "* Invalid URL")]
        public string Website { get; set; }
        [Required(ErrorMessage="* Required")]
        public string LogoUrl { get; set; }

    }
    [MetadataType(typeof(VendorMetaData))]
    public partial class WGVendor { }
}