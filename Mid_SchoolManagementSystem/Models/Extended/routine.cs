using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(routinedata))]
    public partial class routine
    {
    }

    public class routinedata
    {
        [Display(Name = "Routine Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Routine Id is required")]
        public int routineid { get; set; }

        [Display(Name = "Section Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section ID is required")]
        public int sectionid { get; set; }
    }
}