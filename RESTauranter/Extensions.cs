using System;
using System.ComponentModel.DataAnnotations;
namespace RESTauranter.Models
{
public class PastDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime d = Convert.ToDateTime(value);
        return d <= DateTime.Now;

    }
}
    
}