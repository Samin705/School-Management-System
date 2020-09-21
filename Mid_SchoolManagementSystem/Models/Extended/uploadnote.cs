using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(uploadnotedata))]
    public partial class uploadnote
    {
    }

    public class uploadnotedata
    {
        public int uploadid { get; set; }

        // [Display(Name = "Directory Path")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Not a valid directory")]

        public string directory { get; set; }

        [Display(Name = "Upload File")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select One file")]
        public string filename { get; set; }

        //[Display(Name = "Upload Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Not a valid Date")]
        public System.DateTime datetime { get; set; }
        public int sectionid { get; set; }
        public int subjectid { get; set; }
    }
}