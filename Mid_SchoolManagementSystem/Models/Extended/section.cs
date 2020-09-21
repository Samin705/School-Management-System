using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(sectiondata))]
    public partial class section
    {
    }

    public class sectiondata
    {
        [Display(Name = "Section ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section ID is required")]
        public int sectionid { get; set; }

        [Display(Name = "Section Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section Name is required")]
        public string sectionname { get; set; }

        [Display(Name = "Class ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Class ID is required")]
        public int classid { get; set; }
    }
}