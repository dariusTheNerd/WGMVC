using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WGMVC //must remove the .Models to make sure  the partial class 
//for WGProducts  is in the same namespace as the EF WGProduct class
{
    public class ProductMetaData
    {
        //properties go here for data annotations

        //properties  must match the ef Properties exactly
      [Required(ErrorMessage="* Required")]
        public string name { get; set; }
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "*Requied")]
        public decimal Price { get; set; }
       
        [Display(Name="Product Image")]//only affects create and edit views by default
                                                                        //value for .labelfor()
        public string ImageUrl { get; set; }


        //for the foreign key dd, the label value is hard coded on the create and edit views.
        //we must  remove that hard coded value  from those view before 
        //the display name value from here will take effect
        //

        public int? CategoryID { get; set; }
         [Required(ErrorMessage = "* Required")]
       [Display(Name="Vendor")]
        public int? VendorID { get; set; }
         [Required(ErrorMessage = "* Required")]
    [Display(Name="Status")]
        public int? StatusID { get; set; }

    }
    //partial class to link to the EF WGProducst class. Must be names exactly the same as the EF Class
    [MetadataType(typeof(ProductMetaData))]
    public partial class WgProduct { }
}