using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace BeltExam
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name should be at least 2 characters")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        // [Required(ErrorMessage = "Last Name is required")]
        // [MinLength(2, ErrorMessage = "Last Name should be at least 2 characters")]
        // [Display(Name = "Last Name")]
        // public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password should be at least 8 characters")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "Password must contain at least one letter, one number, and a special character")]
        [DataType(DataType.Password, ErrorMessage = "Password is invalid")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password, ErrorMessage = "Confirm Passowrd is invalid")]
        [Compare(nameof(Password), ErrorMessage = "Password and Confirm Password do not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public List<Hangout> HangoutsCreated { get; set; }
        public List<HangoutParticipants> HangoutsAsParticipants { get; set; }
    }
}