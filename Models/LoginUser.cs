using System.ComponentModel.DataAnnotations;
using System;

namespace BeltExam
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password should be at least 8 characters")]
        [DataType(DataType.Password, ErrorMessage = "Password is invalid")]
        public string Password { get; set; }
    }
}