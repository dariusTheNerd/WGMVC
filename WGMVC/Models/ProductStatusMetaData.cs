using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WGMVC
{
    public class ProductStatusMetaData
    {
        [Required(ErrorMessage="* Required")]
        public string  Name { get; set; }

    }
    [MetadataType(typeof(ProductStatusMetaData))]
    public partial class WGStatu { }
}