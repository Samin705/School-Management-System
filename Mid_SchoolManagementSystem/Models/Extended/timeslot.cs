using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Mid_SchoolManagementSystem.Models.DataAccess
{
    [MetadataType(typeof(timeslotdata))]
    public partial class timeslot
    {

    }
    public class timeslotdata
    {
        //timeslotid
        [Display(Name = "Timeslot Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Timeslot id required")]
        public int timeslotid { get; set; }

        //time
        [Display(Name = "Time")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Time required")]
        //[DataType(DataType.Time)]
        public string time { get; set; }

        //day
        [Display(Name = "Day")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Day required")]
        //[DataType(DataType.Date)]
        public string day { get; set; }

        //subjectid
        [Display(Name = "Subject Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Subject ID required")]
        public int subjectid { get; set; }

        //Section Id
        [Display(Name = "Section Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section ID required")]
        public int sectionid { get; set; }

        //Routine Id
        [Display(Name = "Routine Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Routine ID required")]
        public int routineid { get; set; }
    }
}