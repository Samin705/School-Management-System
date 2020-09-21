using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{

    [MetadataType(typeof(homeworkdata))]
    public partial class homework
    {
    }

    public class homeworkdata
    {
        public int homeworkid { get; set; }

        [Display(Name = "File Name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select One file")]
        public string filename { get; set; }

        [Display(Name = "Directory Path")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Not a valid directory")]
        public string directory { get; set; }

        [Display(Name = "Upload Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Not a valid Date")]
        public System.DateTime postdate { get; set; }

        [Display(Name = "Due Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Not a valid Date")]
        public System.DateTime duedate { get; set; }
        public int subjectid { get; set; }
        public int sectionid { get; set; }
    }
}