using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class ReviewViewModel: BaseEntity
    {
        [Required]
        public string reviewer {get;set;}
        [Required]
        public string restaurant {get;set;}
        [Required]
        public int stars {get;set;}
        [Required]
        [MinLength(10)]
        public string reviewtext {get;set;}
        [Required]
        [PastDate(ErrorMessage="Date must be in the past.")]
        public DateTime visitdate {get;set;}
    }
}