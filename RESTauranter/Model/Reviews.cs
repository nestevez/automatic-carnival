using System;

namespace RESTauranter.Models
{
    public class Reviews: BaseEntity
    {
        public int reviewsId {get;set;}
        public string reviewer {get;set;}
        public string restaurant {get;set;}
        public int stars {get;set;}
        public string reviewtext {get;set;}
        public DateTime visitdate {get;set;}
    }
}