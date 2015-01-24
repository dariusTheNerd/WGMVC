using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WGMVC
{
    public class CategoryMetaData
    {

        [Required(ErrorMessage="* Required")]
        public string  Name { get; set; }
        [UIHint("MultilineText")]
        public string Description { get; set; }
    }//end class
    [MetadataType(typeof(CategoryMetaData))]
    public partial class WGCategory { }



}
    
    
    
    
