using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Invoice_website.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class Invoice_Table
    {

    }

    // Requires title 
    public class UserMetadata
    {
        [Display(Name ="Title")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="Title Required")]
        public string title { get; set; }

        
    }
}