using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(generalnoticedata))]
    public partial class generalnotice
    {
    }

    public class generalnoticedata
    {
        [Display(Name = "Notice ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice ID is required")]
        public int noticeid { get; set; }

        [Display(Name = "Notice subject")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice Subject is required")]
        public string noticesubject { get; set; }

        [Display(Name = "Notice Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Notice Description is required")]
        public string noticedescription { get; set; }

        [Display(Name = "Post date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Post Date is required")]
        public System.DateTime postdate { get; set; }
    }
}