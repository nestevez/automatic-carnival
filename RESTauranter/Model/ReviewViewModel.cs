using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class ReviewViewModel: BaseEntity
    {
        [Required]
        [Display(Name="Reviewer Name")]
        public string reviewer {get;set;}
        [Required]
        [Display(Name="Restaurant Name")]
        public string restaurant {get;set;}
        [Required]
        [Display(Name="Stars")]
        public int stars {get;set;}
        [Required]
        [Display(Name="Review")]
        [MinLength(10)]
        public string reviewtext {get;set;}
        [Required]
        [Display(Name="Date of visit")]
        [PastDate(ErrorMessage="Date must be in the past.")]
        public DateTime visitdate {get;set;}
    }
}