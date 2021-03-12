using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcApplication.Models
{
    public class CourseReview
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Course Name")]
        public string CourseName { get; set; }

        [Required]
        [Display(Name ="Review Comments")]
        public string ReviewComments { get; set; }
        
        [Display(Name ="Do you recommend this course?")]
        public bool IsRecommended { get; set; }
    }
}