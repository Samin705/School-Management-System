using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(tpedata))]
    public partial class tpe
    {

    }

    public class tpedata
    {
        public int tpeid { get; set; }
        public string teacherid { get; set; }

        public string studentid { get; set; }

        [Display(Name = "Question 1:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select one!")]
        public int q1 { get; set; }

        [Display(Name = "Question 2:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select one!")]
        public int q2 { get; set; }

        [Display(Name = "Question 3:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select one!")]
        public int q3 { get; set; }

        [Display(Name = "Question 4:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must select one!")]
        public int q4 { get; set; }

        [Display(Name = "Please leave your comment.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must put your comment!")]
        public string comment { get; set; }
    }
}
