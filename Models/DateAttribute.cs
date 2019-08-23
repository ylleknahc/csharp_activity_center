using System;
using System.ComponentModel.DataAnnotations;

public class DateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        Console.WriteLine("#######################");
        Console.WriteLine("HI I MADE IT TO THIS FUNCTION");
        Console.WriteLine(value);
        DateTime dateValue = Convert.ToDateTime(value);
        Console.WriteLine(dateValue);
        Console.WriteLine(DateTime.Now.Date);
        // does not allow user to select current date OR future date
        if (dateValue.Date < DateTime.Now.Date || dateValue.Date == DateTime.Now.Date)
        {
            return new ValidationResult("Activity Date should be set in the future");
        }

        return ValidationResult.Success;
    }
}